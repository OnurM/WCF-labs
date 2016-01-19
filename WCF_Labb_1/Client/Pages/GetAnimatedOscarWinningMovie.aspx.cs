using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Client.AnimatedOscarWinnersService;

namespace Client.Pages
{
    public partial class GetAnimatedOscarWinningMovie : System.Web.UI.Page
    {
        private AnimatedOscarWinningMovieSoapClient _host;
        protected void Page_Load(object sender, EventArgs e)
        {
            _host = new AnimatedOscarWinningMovieSoapClient();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = _host.GetMovieByYear(TextBox1.Text);
        }
    }
}