using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.SubtractTwoNumbersService;

namespace Client.Pages
{
    public partial class SubtractTwoNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            var service = new SubtractTwoNumbersSoapClient();
            var number = 0;
            lblSubtractResult.Text = service.Subtract(int.TryParse(tbxA.Text, out number) ? int.Parse(tbxA.Text) : number, int.TryParse(tbxB.Text, out number) ? int.Parse(tbxB.Text) : number).ToString();
        }
    }
}