using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment02
{
    internal class InternationalShipment : Shipment
    {
        private string destinationCountry;
        private decimal customsFee;


        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value == " ")
                    return;
                destinationCountry=value;
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                if (value < 0)
                    return;
                customsFee = value;
            }
        }
        public override double EstimatedCost
        {
            get
            {
                return (double)DeliveryFee + (Weight * 5) + (double)CustomsFee;
            }
        }

        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee)
        : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        public override void PrintShipment()
        {
            Console.WriteLine($"\nInternational Shipment\n\n" +
                              $"Tracking Code      : {TrackingCode}.\n" +
                              $"Description        : {Description}.\n" +
                              $"Weight             : {Weight}.\n" +
                              $"Delivery Fee       : {DeliveryFee}.\n" +
                              $"Destination        : {Destination.GetFullAddress()}.\n" +
                              $"Destination Country: {destinationCountry}.\n" +
                              $"Customs Fee        : {customsFee}.\n" +
                              $"Estimated Cost     : {EstimatedCost} EGP.\n"+
                              "-----------------------------------------");

        }
    }
}