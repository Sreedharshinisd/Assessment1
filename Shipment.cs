
namespace CourierTrackingSystem.Models;

public class Shipment
{
    public string TrackingNumber { get; set; } = "";
    public int SenderCustomerId { get; set; }
    public string ReceiverName { get; set; } = "";
    public string ReceiverPhone { get; set; } = "";
    public string DestinationAddress { get; set; } = "";

    public DateTime CreatedDate { get; set; }
    public decimal Weight { get; set; }
    public decimal ShippingFee { get; set; }

    public string CurrentStatus { get; set; } = "";
}
