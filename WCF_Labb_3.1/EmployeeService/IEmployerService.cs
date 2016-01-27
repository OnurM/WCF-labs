using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmployerService" in both code and config file together.
    [ServiceContract]
    public interface IEmployerService
    {
        [OperationContract]
        MyEmployee GetEmployeeInfoByEmployeeId(int employeeId);

        [OperationContract]
        string UpdateEmployeeInfo(MyEmployee employee);
    }

    [DataContract]
    public class MyEmployee
    {
        [DataMember]
        public int EmployeeId { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string TitleOfCourtesy { get; set; }
        [DataMember]
        public DateTime? BirthDate { get; set; }
        [DataMember]
        public DateTime? HireDate { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Region { get; set; }
        [DataMember]
        public string PostalCode { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string HomePhone { get; set; }
        [DataMember]
        public string Extension { get; set; }
        [DataMember]
        public string Notes { get; set; }
        [DataMember]
        public int? ReportsTo { get; set; }
    }
}

