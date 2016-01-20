using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF.CalculateThousandthDay.Client.CalculateThousandthDayService;

namespace WCF.CalculateThousandthDay.Client
{
    public partial class Form1 : Form
    {
        private CalculateThousandthDayServiceSoapClient _host;
        public Form1()
        {
            InitializeComponent();
            _host = new CalculateThousandthDayServiceSoapClient();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            lblResult.Text =
                _host.CalculateThousandthDayOfLife(DateTime.TryParse(tbxDate.Text, out now)
                    ? DateTime.Parse(tbxDate.Text)
                    : now).ToShortDateString();
        }
    }
}
