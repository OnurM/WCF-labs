using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.GetNamesDayDateService;

namespace Client.Pages
{
    public partial class GetNamesDayDate : System.Web.UI.Page
    {
        private GetNamesDayDateServiceSoapClient _host;
        public GetNamesDayDate()
        {
            _host = new GetNamesDayDateServiceSoapClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = _host.GetNamesDayDateByName(TextBox1.Text);
        }
    }
}