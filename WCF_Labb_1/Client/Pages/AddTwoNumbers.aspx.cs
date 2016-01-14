using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.AddTwoNumbersService;

namespace Client.Pages
{
    public partial class AddTwoNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddTwoNumbers_Click(object sender, EventArgs e)
        {
            var service = new AddTwoNumbersSoapClient();
            var number = 0;
            lblAddTwoNumbersResult.Text = service.Add(int.TryParse(tbxFirstNumber.Text, out number) ? int.Parse(tbxFirstNumber.Text) : number, int.TryParse(tbxSecondNumber.Text, out number) ? int.Parse(tbxSecondNumber.Text) : number).ToString();
        }
    }
}