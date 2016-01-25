using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShipperClient.TheShipperService;

namespace ShipperClient
{
    public partial class Default : System.Web.UI.Page
    {
        private  ShipperServiceClient _service;

        public Default()
        {
            _service = new ShipperServiceClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetShipper_Click(object sender, EventArgs e)
        {
            int x;
            var shipper = _service.GetShipperByShipperId(int.TryParse(tbxShipperCode.Text, out x) ? int.Parse(tbxShipperCode.Text) : x) ?? new MyShipper() {Phone = string.Empty, CompanyName = string.Empty};

            

            tbxShipperId.Text = shipper.ShipperID != 0 ? shipper.ShipperID.ToString() : "Det finns ingen shipper med detta id";
            tbxCompanyName.Text = shipper.CompanyName ?? string.Empty;
            tbxPhone.Text = shipper.Phone ?? string.Empty;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int x;

            var shipper = new MyShipper {ShipperID = int.TryParse(tbxShipperId.Text, out x) ? int.Parse(tbxShipperId.Text) : x, CompanyName = tbxCompanyName.Text, Phone = tbxPhone.Text};

            if (tbxShipperId.Text == "0" || tbxShipperId.Text == string.Empty || tbxCompanyName.Text == string.Empty || tbxPhone.Text == string.Empty)
            {
                lblError.Text = "Kan inte lägga till tomma shippers";
                return;
            }


            _service.SaveShipper(shipper);

        }
    }
}