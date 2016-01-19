using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.WorstMaleActorWinnerService;

namespace Client.Pages
{
    public partial class GetWorstMaleActor : System.Web.UI.Page
    {
        private WorstMaleActorWinnerSoapClient _host;

        public GetWorstMaleActor()
        {
            _host = new WorstMaleActorWinnerSoapClient();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = _host.GetActorByYear(TextBox1.Text);
        }
    }
}