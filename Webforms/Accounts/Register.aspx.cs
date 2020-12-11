using PRE.Model.Model;
using PRE.Model.Model.Util;
using PRE.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webforms
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        private UserService userService = new UserService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            //int convertYear = int.Parse(YearTxt.Text);
            //int convertMonth = int.Parse(MonthTxt.Text);
            //int convertDay = int.Parse(DayTxt.Text);
            //Gender gender = (Gender)int.Parse(UserGender.SelectedValue);

            //User user = new User(FirstNameTxt.Text, LastNameTxt.Text, new DateTime(convertYear, convertMonth, convertDay), gender , EmailTxt.Text);            
            //userService.Insert(user);

        }

        protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
        {
            int convertYear = int.Parse(YearTxt.Text);
            int convertMonth = int.Parse(MonthTxt.Text);
            int convertDay = int.Parse(DayTxt.Text);
            Gender gender = (Gender)int.Parse(UserGender.SelectedValue);

            User user = new User();

            user.FirstName = FirstNameTxt.Text;
            user.LastName = LastNameTxt.Text;
            user.BirthDate = new DateTime(convertYear, convertMonth, convertDay); 
            user.Gender = gender;
            user.Email = EmailTxt.Text;

            user.MembershipUsername = CreateUserWizard1.UserName;

            userService.InsertUserWithMembership(user, CreateUserWizard1.UserName);

        }
    }
}