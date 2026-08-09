using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment02
{
    internal class StandardShipment : Shipment
    {
        public StandardShipment(string trackingCode, string description, double weight,decimal deliveryFee, DeliveryAddress destination)
        : base (trackingCode,description,weight,deliveryFee,destination)
        {
        }

        public override void  PrintShipment()
        {
            Console.WriteLine($"\nStanderd Shipment\n\n" +
                              $"Tracking Code     : {TrackingCode}.\n" +
                              $"Description       : {Description}.\n" +
                              $"Weight            : {Weight}.\n" +
                              $"Delivery Fee      : {DeliveryFee}.\n" +
                              $"Destination       : {Destination.GetFullAddress()}.\n" +
                              $"Estimated Cost    : {EstimatedCost} EGP.\n"+
                              "-----------------------------------------");

        }
    }
}
