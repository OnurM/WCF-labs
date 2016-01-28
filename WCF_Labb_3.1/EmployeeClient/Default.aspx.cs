using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeClient.EmpService;

namespace EmployeeClient
{
    public partial class Default : System.Web.UI.Page
    {
        private EmployerServiceClient _host;

        public Default()
        {
            _host = new EmployerServiceClient();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                lblInfoText.Text = string.Empty;
                using (_host)
                {
                    int x;
                    var employee = _host.GetEmployeeInfoByEmployeeId(int.TryParse(tbxGetEmpId.Text, out x)
                        ? int.Parse(tbxGetEmpId.Text)
                        : x);


                    tbxEmployeeID.Text = employee.EmployeeId.ToString();
                    tbxFirstName.Text = employee.FirstName;
                    tbxLastName.Text = employee.LastName;
                    tbxAddress.Text = employee.Address;
                    tbxCity.Text = employee.City;
                    tbxPostalCode.Text = employee.PostalCode;
                    tbxRegion.Text = employee.Region;
                    tbxCountry.Text = employee.Country;
                    tbxTitle.Text = employee.Title;
                    tbxTitleOfCourtesy.Text = employee.TitleOfCourtesy;
                    tbxBirthDate.Text = employee.BirthDate.ToString();
                    tbxHireDate.Text = employee.HireDate.ToString();
                    tbxExtension.Text = employee.Extension;
                    tbxNotes.Text = employee.Notes;
                    tbxReportsTo.Text = employee.ReportsTo.ToString();
                }
            }
            catch (FaultException exc)
            {
                lblInfoText.Text = exc.Message;
            }
            catch (Exception exc)
            {
                lblInfoText.Text = "Something went wrong while trying to get the employee. Try again later.";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                lblInfoText.Text = string.Empty;
                int x;
                DateTime z;

                if (!DateTime.TryParse(tbxBirthDate.Text, out z))
                {
                    lblBirthDateError.Text = "Birthdate is not in a correct format, please try again (yyyy-mm-dd)";
                    return;
                }
                if (!int.TryParse(tbxReportsTo.Text, out x))
                {
                    lblNotesError.Text = "Reports To is not in a correct format, please try again (digits)";
                    return;
                }
                if (!DateTime.TryParse(tbxHireDate.Text, out z))
                {
                    lblHireDateError.Text = "Hiredate is not in a correct format, please try again (yyyy-mm-dd)";
                    return;
                }

                using (_host)
                {
                    var employee =
                        new MyEmployee()
                        {
                            EmployeeId = int.TryParse(tbxGetEmpId.Text, out x) ? int.Parse(tbxGetEmpId.Text) : x,
                            FirstName = tbxFirstName.Text,
                            LastName = tbxLastName.Text,
                            TitleOfCourtesy = tbxTitleOfCourtesy.Text,
                            Extension = tbxExtension.Text,
                            BirthDate = DateTime.Parse(tbxBirthDate.Text),
                            Title = tbxTitle.Text,
                            Address = tbxAddress.Text,
                            HomePhone = tbxHomePhone.Text,
                            PostalCode = tbxPostalCode.Text,
                            Region = tbxRegion.Text,
                            Notes = tbxNotes.Text,
                            ReportsTo = int.Parse(tbxReportsTo.Text),
                            Country = tbxCountry.Text,
                            City = tbxCity.Text,
                            HireDate = DateTime.Parse(tbxHireDate.Text)
                        };

                    lblInfoText.Text = _host.UpdateEmployeeInfo(employee);
                }
            }
            catch (FaultException exc)
            {
                lblInfoText.Text = exc.Message;
            }
            catch (Exception)
            {
                lblInfoText.Text = "Something went wrong while trying to save the employee. Try again later.";
            }
        }
    }
}