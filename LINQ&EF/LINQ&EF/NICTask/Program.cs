using System;

namespace NICTask
{
    public enum NICType
    {
        Ethernet,
        TokenRing
    }

    public class NIC
    {
        private static NIC instance = null;

        public string Manufacturer { get; }
        public string MACAddress { get; }
        public NICType Type { get; }

        private NIC(string manufacturer, string macAddress, NICType type)
        {
            Manufacturer = manufacturer;
            MACAddress = macAddress;
            Type = type;
        }

        public static NIC GetInstance(string manufacturer, string macAddress, NICType type)
        {
            if (instance == null)
            {
                instance = new NIC(manufacturer, macAddress, type);
            }
            return instance;
        }
    }

    class Program
    {
        static void Main()
        {
            
        }
    }
}
