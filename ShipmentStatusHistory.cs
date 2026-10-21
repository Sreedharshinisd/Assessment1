using System;
using System.Collections.Generic;
using System.Text;

namespace ASSESSMENT1.Models
{
    public class ShipmentStatusHistory
    {
        public int shipmentID { get; set; }
        public int status { get; set; }
        public int UpdatedAt { get; set; }
        public string Location { get; set; } = "";
        public string optionalNotes { get; set; } = "";
        public ShipmentStatusHistory() { }
        
             public ShipmentStatusHistory(int shipmentID, int status, int UpdatedAt, string Location, string optionalNotes)
        {
            this.shipmentID = shipmentID;
            this.status = status;
            this.UpdatedAt = UpdatedAt;
            this.Location = Location;
            this.optionalNotes = optionalNotes;
        }
       
    }
    
}
