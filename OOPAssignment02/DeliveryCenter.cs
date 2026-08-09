using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment02
{
    internal class DeliveryCenter
    {
        private Shipment[] shipments;
        public string CenterName { get; set; }


        public DeliveryCenter(int size,string centerName)
        {
            shipments = new Shipment[size];
            CenterName = centerName;
        }
        public Shipment this[int index]
        {
            get
            {
                if (index < shipments.Length)
                {
                    return shipments[index];
                }
                return default;

            }
            set
            {
                if (index < shipments.Length)
                    shipments[index] = value;
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (trackingCode == shipments[i].TrackingCode)
                    {
                        return shipments[i];
                    }

                }
                return default;
            }
        }
        public bool AddShipment(Shipment newShipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i]==null)
                {
                    shipments[i] = newShipment;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for(int i = 0;i < shipments.Length; i++)
            {
                if (shipments[i] != null)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        shipments[i] = default;
                        return true;
                    }
                }
                else
                    return false;
            }
            return false;

        }
        public void PrintAllShipments()
        {
            for(int i = 0; i < shipments.Length; i++)
            {
                if(shipments[i]!=null)
                    shipments[i].PrintShipment();
            }
        }
    }
}
