using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication1
{
    public partial class Get_Ip_Address : Form
    {
        public Get_Ip_Address()
        {

        }

        private void Get_Ip_Address_Load(object sender, EventArgs e)
        {

            IPHostEntry iph;
            string myip = "";
            iph = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in iph.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    myip = ip.ToString();
                }
            }
            Label.text = myip.ToString();
        }
    }
}
