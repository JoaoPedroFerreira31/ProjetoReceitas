using PRE.Model.Model;
using PRE.Model.Model.Util;
using PRE.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class InsertAdminForm : Form
    {
        private UserService _service;

        public InsertAdminForm()
        {
            InitializeComponent();
            _service = new UserService();
        }

        private void allForms_TextChanged(object sender, EventArgs e)
        {
            string firstName = firstNameTxt.Text;
            string lastName = lastNameTxt.Text;
            string email = emailTxt.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string passwordRepeat = passwordRepeatTxt.Text;

            if (firstName == "" && lastName == "" && email == "" && username == "" && password == "" && passwordRepeat == "")
            {
                button1.Enabled = false;
                warningTxt.Text = "Campos por preencher";
            }
            else
            {
                if (password.Length > 3 && passwordRepeat.Length > 3)
                {
                    if (password == passwordRepeat)
                    {
                        warningTxt.Text = "";
                        button1.Enabled = true;
                    }
                }
                else
                {
                    warningTxt.Text = "Passwords don't match";
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTxt.Text;
            string lastName = lastNameTxt.Text;
            DateTime birthDate = dateTimePicker1.Value.Date;
            Gender gender = (Gender)comboBox1.SelectedIndex;
            string email = emailTxt.Text;
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            bool admin;
            if(comboBox2.SelectedIndex == 0)
            {
                admin = false;
            }
            else
            {
                admin = true;
            }


            User user = new User();

            user.FirstName = firstName;
            user.LastName = lastName;
            user.BirthDate = birthDate;
            user.Gender = gender;
            user.Email = email;
            user.IsAdmin = admin;
            

            Account account = new Account();
            account.Username = username;
            account.Password = password;

            user.Account = account;

            if (comboBox2.SelectedIndex == 0) 
            {
                _service.InsertAdmin(user);
            }
            else
            {
                _service.Insert(user);
            }
            
            
        }
    }
}
