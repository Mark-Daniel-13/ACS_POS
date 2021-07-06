using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace NTT_POS.Business.Helpers
{
    public  class NetworkConnection
    {
        public static List<NetworkInterface> GetAllNetworkInterface()
        {
            return NetworkInterface.GetAllNetworkInterfaces().ToList();
        }

        public static NetworkInterface GetConnectedNetwork(List<NetworkInterface> allNetworks)
        {
            NetworkInterface onlineNetwork = null;
            allNetworks.ForEach(network =>
            {
                if (onlineNetwork == null)
                {
                    if (network.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                    {
                        if (network.OperationalStatus == OperationalStatus.Up)
                        {
                            onlineNetwork = network;
                        }
                    }
                }
                else
                {
                    return;
                }
            });
            return onlineNetwork;
        }

        public static bool isOnline(List<NetworkInterface> networks)
        {
            foreach (NetworkInterface network in networks)
            {
                if (network.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    if (network.OperationalStatus == OperationalStatus.Up)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static string GetLANMACAddress()
        {
            string physicalAddress = null;
            List<NetworkInterface> networks = GetAllNetworkInterface();
            if (networks.Count > 1) {
                //Get mac address of LAN / Ethernet
                networks.ForEach(network =>
                {
                    if (physicalAddress == null)
                    {
                        if (network.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                        {
                            physicalAddress = network.GetPhysicalAddress().ToString();
                        }
                    }
                    else {
                        return; //used as break when there's value retrieved already;
                    }
                });
            }
            return physicalAddress;
        }

        public static string GetWifiMACAddress() {
            string physicalAddress = null;
            List<NetworkInterface> networks = GetAllNetworkInterface();
            if (networks.Count > 1)
            {
                //Get mac address of LAN / Ethernet
                networks.ForEach(network =>
                {
                    if (physicalAddress == null)
                    {
                        if (network.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                        {
                            physicalAddress = network.GetPhysicalAddress().ToString();
                        }
                    }
                    else
                    {
                        return; //used as break when there's value retrieved already;
                    }
                });
            }
            return physicalAddress;
        }
    }
}
