using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClassHW
{
    internal class AddressProcess
    {
        public static void GetStreetAddress(AddressModel address)
        {
            Console.WriteLine("Hello, What is your street address? ");
            address.StreetAddress = Console.ReadLine();
        }

        public static void GetCity(AddressModel address)
        {
            Console.WriteLine("What city do you live in? ");
            address.City = Console.ReadLine();
        }

        public static void GetZipCode(AddressModel address)
        {
            Console.WriteLine("What is your Zip Code? ");
            string zipCodeText = Console.ReadLine();

            if(!int.TryParse(zipCodeText, out int zipCode))
            {
                Console.WriteLine("Sorry Please enter whole numbers only");
                GetZipCode(address);
            }
            address.ZipCode = zipCode;
        }

        public static void ConfirmAddress(AddressModel address)
        {
            Console.WriteLine($"We have your address as {address.StreetAddress}, in {address.City}, zip: {address.ZipCode}");
        }

        public static void AddNewAddress(AddressModel address)
        {
            GetStreetAddress(address);
            GetCity(address);
            GetZipCode(address);
            ConfirmAddress(address);
        }
    }
}
