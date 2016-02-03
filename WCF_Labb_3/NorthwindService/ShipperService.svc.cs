using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.Ajax.Utilities;

namespace NorthwindService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShipperService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ShipperService.svc or ShipperService.svc.cs at the Solution Explorer and start debugging.
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ShipperService : IShipperService
    {

        public MyShipper GetShipperByShipperId(int id)
        {

            try
            {
                using (var db = new theDB())
                {
                    var shipper = (from s in db.Shippers
                                   where s.ShipperID == id
                                   select new MyShipper()
                                   {
                                       ShipperID = s.ShipperID,
                                       CompanyName = s.CompanyName,
                                       Phone = s.Phone
                                   }).FirstOrDefault();

                    if (shipper == null)
                        throw new FaultException("Could not find a Shipper with given ID");

                    return shipper;
                }
            }
            catch (Exception exc)
            {
                throw new FaultException(exc.Message);
            }

        }

        public string SaveShipper(MyShipper shipper)
        {

            try
            {
                using (var db = new theDB())
                {
                    var theShipper = (from s in db.Shippers
                                      where s.ShipperID == shipper.ShipperID
                                      select s).FirstOrDefault();

                    if (theShipper == null)
                        throw new FaultException("Shipper was not saved because there is no Shipepr with given ID");

                    theShipper.CompanyName = shipper.CompanyName;
                    theShipper.Phone = shipper.Phone;
                    db.SaveChanges();

                    return "Shipper was edited successfully";
                }
            }
            catch (Exception exc)
            {
                throw new FaultException(exc.Message);
            }
        }
    }
}
