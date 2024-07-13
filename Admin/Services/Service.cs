using ClassLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Admin.Services
{
    public class Service//запросы к сервису
    {

        public Admin_Cafe_bll RegistrationAdmin(Admin_Cafe_bll admin)
        {
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect("127.0.0.1", 8888);
                NetworkStream stream = tcpClient.GetStream();
                byte[] admin_write = TransportServices.Packer(admin);
                Courier courier = new Courier()
                {
                    Header = com.CommandAdminRegistration,
                    Entity = admin_write
                };
                TransportServices.PackerAndSender(stream, courier);
                courier = TransportServices.ReciverAndUnpacker(stream);
                admin = TransportServices.Unpacker<Admin_Cafe_bll>(courier.Entity);
                tcpClient.Close();
                if (courier.Header == com.AnswerAdminRegistrationOK)
                {
                    return admin;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public Admin_Cafe_bll AuthorizationAdmin(Admin_Cafe_bll admin)
        {
            try
            {
                TcpClient tcpClient = new TcpClient();
                tcpClient.Connect("127.0.0.1", 8888);
                NetworkStream stream = tcpClient.GetStream();
                byte[] admin_write = TransportServices.Packer(admin);
                Courier courier = new Courier()
                {
                    Header = com.CommandAdminAuthorization,
                    Entity = admin_write
                };
                TransportServices.PackerAndSender(stream, courier);
                courier = TransportServices.ReciverAndUnpacker(stream);
                admin = TransportServices.Unpacker<Admin_Cafe_bll>(courier.Entity);
                tcpClient.Close();
                if (courier.Header == com.AnswerAdminAuthorizationOK)
                {
                    return admin;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
