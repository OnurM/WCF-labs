﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShipperService" in both code and config file together.
    [ServiceContract]
    public interface IShipperService
    {
        [OperationContract]
        MyShipper GetShipperByShipperId(int id);
        [OperationContract]
        string SaveShipper(MyShipper shipper);

    }

    [DataContract]
    public class MyShipper
    {
        [DataMember]
        public int ShipperID { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public string Phone { get; set; }
    } 
}
