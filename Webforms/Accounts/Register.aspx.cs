using PRE.Model.Model;
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
            User user = new User(FirstNameTxt.Text,LastNameTxt.Text, Calendar1.SelectedDate, PRE.Model.Model.Util.Gender.Male, "Exemplo@exemplo.com");
            userService.Insert(user);

        }
    }
}