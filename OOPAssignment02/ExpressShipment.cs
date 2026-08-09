using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment02
{
    internal class ExpressShipment : Shipment
    {
        private decimal extraFee;
        public decimal ExtraFee
        {
            get => extraFee;
            set
            {
                if (value < 0)
                    return;
                extraFee = value;
            }
        }
        public override double EstimatedCost
        {
            get 
            {
                return (double)DeliveryFee + (Weight * 5) +(double) ExtraFee;
            }
        }
        public ExpressShipment (string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination,decimal extraFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"\nExpress Shipment\n\n" +
                              $"Tracking Code     : {TrackingCode}.\n" +
                              $"Description       : {Description}.\n" +
                              $"Weight            : {Weight}.\n" +
                              $"Delivery Fee      : {DeliveryFee}.\n" +
                              $"Destination       : {Destination.GetFullAddress()}.\n" +
                              $"Extra Fee         : {ExtraFee}.\n"+
                              $"Estimated Cost    : {EstimatedCost} EGP.\n"+
                              "-----------------------------------------");

        }

    }
}
 