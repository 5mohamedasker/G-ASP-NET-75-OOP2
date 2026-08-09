using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment02
{
    internal class Shipment
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                    return;
                trackingCode = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                    return;
                description = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }
        public decimal DeliveryFee
        {
            get
            {
                return deliveryFee;
            }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }
        public virtual double EstimatedCost
        {
            get { return (double)deliveryFee + (weight * 5); }
        }
        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1, 50, default) { }
        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            DeliveryFee = newFee;
        }
        public virtual void PrintShipment()
        {
            Console.WriteLine($"\nShipment\n\n" +
                             $"Tracking Code     : {TrackingCode}.\n" +
                             $"Description       : {Description}.\n" +
                             $"Weight            : {Weight}.\n" +
                             $"Delivery Fee      : {DeliveryFee}.\n" +
                             $"Destination       : {Destination.GetFullAddress()}.\n" +
                             $"Estimated Cost    : {EstimatedCost} EGP.\n" +
                              "-----------------------------------------");
        }                      
    }
}