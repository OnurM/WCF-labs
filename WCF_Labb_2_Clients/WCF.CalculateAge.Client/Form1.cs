using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF.CalculateAge.Client.CalculateAgeService;

namespace WCF.CalculateAge.Client
{
    public partial class Form1 : Form
    {
        private CalculateAgeServiceSoapClient _host;
        public Form1()
        {
            InitializeComponent();
            _host = new CalculateAgeServiceSoapClient();
        }

        private void btnCalculateAge_Click(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            lblResult.Text =
                _host.CalculateAge(DateTime.TryParse(tbxDate.Text, out now) ? DateTime.Parse(tbxDate.Text) : now)
                    .ToString();
        }
    }
}
