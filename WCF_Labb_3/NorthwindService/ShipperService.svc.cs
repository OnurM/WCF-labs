using System;
using System.Collections.Generic;
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
    public class ShipperService : IShipperService
    {

        public MyShipper GetShipperByShipperId(int id)
        {

            using (var db = new theDB())
            {
                return (from s in db.Shippers
                        where s.ShipperID == id
                        select new MyShipper()
                        {
                            ShipperID = s.ShipperID,
                            CompanyName = s.CompanyName,
                            Phone = s.Phone
                        }).FirstOrDefault();
            }

        }

        public void SaveShipper(MyShipper shipper)
        {
            using (var db = new theDB())
            {
                db.Shippers.Add(new Shipper()
                {
                    ShipperID = shipper.ShipperID,
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone,
                });

                db.SaveChanges();
            }
        }
    }
}
