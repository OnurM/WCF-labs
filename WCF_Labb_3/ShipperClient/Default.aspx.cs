using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            try
            {
                lblError.Text = string.Empty;
                int x;
                var shipper =
                    _service.GetShipperByShipperId(int.TryParse(tbxShipperCode.Text, out x)
                        ? int.Parse(tbxShipperCode.Text)
                        : x);



                tbxShipperId.Text = shipper.ShipperID.ToString();
                tbxCompanyName.Text = shipper.CompanyName;
                tbxPhone.Text = shipper.Phone;
            }
            catch (FaultException exc)
            {
                lblError.Text = exc.Message;
            }
            catch (Exception)
            {
                lblError.Text = "Ooopps! Something went wrong";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = string.Empty;
                int x;

                var shipper = new MyShipper { ShipperID = int.TryParse(tbxShipperId.Text, out x) ? int.Parse(tbxShipperId.Text) : x, CompanyName = tbxCompanyName.Text, Phone = tbxPhone.Text };

                lblError.Text = _service.SaveShipper(shipper);
            }
            catch (FaultException exc)
            {
                lblError.Text = exc.Message;
            }
            catch (Exception)
            {
                lblError.Text = "Ooopps! Something went wrong";
            }

        }
    }
}