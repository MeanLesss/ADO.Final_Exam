using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStore_ADO_Final.Database;
using BookStore_ADO_Final.Model;

namespace BookStore_ADO_Final
{
    public partial class SignUpUC : System.Windows.Forms.UserControl
    {
        private static string PHOTODIR = @"..\..\UserImage\";
        private static string PHOTODEFAULT = @"..\..\UserImage\default.png";
        private Form _form;
        private Panel _panel;
        private FileInfo fileInfo = null;

        private string _role = null;
        private User _user = null;
        private bool _update = false;

        public SignUpUC()
        {
            InitializeComponent();
        }
        public SignUpUC(string Role)
        {
            InitializeComponent();
            _role = Role;
            if (_panel is null)
            {
                iconButtonCancel.Visible = false;
            }
        } 
        public SignUpUC(User seller,string Role,bool update)
        {
            InitializeComponent();
            _role = Role;
            _user = seller;
            _update = update;

            textBoxUsername.Text = _user.Username;
            textBoxPass.Text = _user.Password;
            textBoxEmail.Text = _user.Email;
            textBoxPhone.Text = _user.Phone;
            iconPictureBoxUser.Image = Image.FromFile(_user.PhotoDir);
            iconButtonSignUp.Text = "Update";
            if (_panel is null)
            {
                iconButtonCancel.Visible = false;
            }

        }
        public SignUpUC(Form form,Panel panel)
        {
            InitializeComponent();
            _form = form;
            _panel = panel;
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            if (!(_panel is null))
            {
                _panel.Controls.Clear();
                _panel.Controls.Add(new LogInUC(_form, _panel));
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                iconButtonSignUp.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void iconPictureBoxUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Graphics File|*.bmp;*.gif;*.png;*jpg";
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iconPictureBoxUser.Image = Image.FromFile(openFileDialog.FileName);
                fileInfo = new FileInfo(openFileDialog.FileName);
            }
        }

        private void iconButtonSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxConfirm.Text.Equals(textBoxPass.Text))
            {
                using (DataContext db = new DataContext())
                {
                    if (_update is false)
                    {
                        User user = new User();
                        user.Username = textBoxUsername.Text;
                        user.Password = textBoxPass.Text;
                        user.Phone = textBoxPhone.Text;
                        user.Email = textBoxEmail.Text;
                        if (!(_role is null))
                        {
                            user.Role = _role;
                        }
                        else
                        {
                            user.Role = "Admin";
                        }

                        if (fileInfo is null)
                        {
                            fileInfo = new FileInfo(PHOTODIR + "default.png");
                            user.PhotoDir = PHOTODIR + fileInfo.Name;
                            db.Users.Add(user);
                            db.SaveChanges();
                            MessageBox.Show("User Created!");
                            if (!(_panel is null))
                            {
                                _panel.Controls.Clear();
                                _panel.Controls.Add(new LogInUC(_form, _panel));
                            }

                            return;
                        }
                        else
                        {
                            var name = fileInfo.Name;
                            if (Directory.Exists(PHOTODIR + name))
                            {
                                user.PhotoDir = PHOTODIR + fileInfo.Name;
                            }
                            else
                            {
                                File.Copy(fileInfo.FullName, PHOTODIR + fileInfo.Name, true);
                                user.PhotoDir = PHOTODIR + fileInfo.Name;
                            }

                            db.Users.Add(user);
                            db.SaveChanges();
                            MessageBox.Show("user Created!");
                            if (!(_panel is null))
                            {
                                _panel.Controls.Clear();
                                _panel.Controls.Add(new LogInUC(_form, _panel));
                            }
                        }
                    }
                    else
                    {
                        User user = db.Users.FirstOrDefault(u => u.ID.Equals(_user.ID));
                        user.Username = textBoxUsername.Text;
                        user.Password = textBoxPass.Text;
                        user.Phone = textBoxPhone.Text;
                        user.Email = textBoxEmail.Text;
                        if (!(_role is null))
                        {
                            user.Role = _role;
                        }
                        else
                        {
                            user.Role = "Admin";
                        }

                        if (fileInfo is null)
                        {
                            fileInfo = new FileInfo(PHOTODIR + "default.png");
                            user.PhotoDir = PHOTODIR + fileInfo.Name;
                            db.Users.AddOrUpdate(user);
                            db.SaveChanges();
                            MessageBox.Show("User Created!");
                            return;
                        }
                        else
                        {
                            var name = fileInfo.Name;
                            if (Directory.Exists(PHOTODIR + name))
                            {
                                user.PhotoDir = PHOTODIR + fileInfo.Name;
                            }
                            else
                            {
                                File.Copy(fileInfo.FullName, PHOTODIR + fileInfo.Name, true);
                                user.PhotoDir = PHOTODIR + fileInfo.Name;
                            }

                            db.Users.AddOrUpdate(user);
                            db.SaveChanges();
                            MessageBox.Show("user Created!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Password doesn't match!");
            }

        }

        private void SignUpUC_Load(object sender, EventArgs e)
        {
        }

        private void SignUpUC_Leave(object sender, EventArgs e)
        {
            iconButtonCancel.Visible = true;
            iconButtonSignUp.Text = "Sign up";
        }
    }
}
