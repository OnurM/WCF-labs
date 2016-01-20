using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCF.BMI.Client.CalculateBMIService;

namespace WCF.BMI.Client
{
    public partial class Form1 : Form
    {
        private CalculateBMIServiceSoapClient _host;
        public Form1()
        {
            InitializeComponent();
            _host = new CalculateBMIServiceSoapClient();
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            var x = 0.0;
            lblResult.Text =
                _host.CalculateMyBMI(
                    double.TryParse(tbxLength.Text.Replace(".", ","), out x)
                        ? double.Parse(tbxLength.Text.Replace(".", ","))
                        : 0.0,
                    double.TryParse(tbxWeight.Text.Replace(".", ","), out x)
                        ? double.Parse(tbxWeight.Text.Replace(".", ","))
                        : 0.0).ToString();
        }
    }
}
