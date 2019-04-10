using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BusinessLib.Common;
using BusinessLib.Data;

namespace BusinessLib.Business
{
    public class ClientValidation
    {
        private static List<string> errorList;

        public static string ErrorMessage
        {
            get
            {
                string message = "";

                foreach (string msg in errorList)
                {
                    message += msg + "\r\n";
                }

                return message;
            }
        }

        // static constructor to operate on static member
        static ClientValidation()
        {
            errorList = new List<string>();
        }

        public static ClientCollection GetClients()
        {
            return ClientRepository.GetClients();
        }

        public static int AddClient(Client client)
        {
            if (validate(client))
            {
                return ClientRepository.AddClient(client);
            }
            else
            {
                return -1;
            }
        }

        public static int UpdateClient(Client client)
        {
            if (validate(client))
            {
                return ClientRepository.UpdateClient(client);
            }
            else
            {
                return -1;
            }
        }

        public static int DeleteClient(Client client)
        {
            return ClientRepository.DeleteClient(client);
        }

        public static List<string> GetProvinceList()
        {
            return ClientRepository.GetProvinceList();
        }

        private static bool validate(Client client)
        {
            bool result = true;
            errorList.Clear();

            if (string.IsNullOrWhiteSpace(client.ClientCode))
            {
                errorList.Add("ClientCode cannot be empty");
                result = false;
            }

            if (!Regex.IsMatch(client?.ClientCode ?? "", @"^[A-Z]{5}$"))
            {
                errorList.Add("ClientCode must be in the form AAAAA");
                result = false;
            }

            if (string.IsNullOrWhiteSpace(client.CompanyName))
            {
                errorList.Add("CompanyName cannot be empty");
                result = false;
            }

            if (string.IsNullOrWhiteSpace(client.Address1))
            {
                errorList.Add("Address1 cannot be empty");
                result = false;
            }

            if (string.IsNullOrWhiteSpace(client.Province))
            {
                errorList.Add("Province cannot be empty");
                result = false;
            }

            if (!Regex.IsMatch(client?.Province ?? "", @"^[A-Z]{2}$"))
            {
                errorList.Add("Province must be in the form AA");
                result = false;
            }

            if (!Regex.IsMatch(client?.PostalCode ?? "", @"^[A-Z]\d[A-Z]\s\d[A-Z]\d$"))
            {
                errorList.Add("PostalCode must be in the form A9A 9A9");
                result = false;
            }

            if (client.YTDSales < 0m)
            {
                errorList.Add("YTDSales cannot be negative");
                result = false;
            }

            return result;
        }
    }
}
