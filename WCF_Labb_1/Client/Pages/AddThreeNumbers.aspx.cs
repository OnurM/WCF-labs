using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.AddThreeNumbersService;

namespace Client.Pages
{
    public partial class AddThreeNumbers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddThreeNumbers_Click(object sender, EventArgs e)
        {
            var service = new AddThreeNumbersSoapClient();
            var number = 0;
            lblAddThreeNumbers.Text = service.Add(int.TryParse(tbxA.Text, out number) ? int.Parse(tbxA.Text) : number, int.TryParse(tbxB.Text, out number) ? int.Parse(tbxB.Text) : number, int.TryParse(tbxC.Text, out number) ? int.Parse(tbxC.Text) : number).ToString();
        }
    }
}