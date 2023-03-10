using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    interface IMobile
    {
        IAndroid GetAndroidPhone();
        IiOS GetiOSPhone();
    }

    class Samsung : IMobile
    {
        public IAndroid GetAndroidPhone()
        {
            return new SamsungGalaxy();
        }
        public IiOS GetiOSPhone()
        {
            return new SamsungGuru();
        }
    }
    interface IAndroid
    {
        string GetModelDetails();
    }
    interface IiOS
    {
        string GetModelDetails();
    }
    class SamsungGalaxy : IAndroid
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Galaxy - RAM: 2GB - Camera: 13MP";
        }
    }
    class SamsungGuru : IiOS
    {
        public string GetModelDetails()
        {
            return "Model: Samsung Guru - RAM: N/A - Camera: N/A";
        }

    }
    class MobileClient
    {
        IAndroid androidPhone;
        IiOS iOSPhone;

        public MobileClient(IMobile factory)
        {
            androidPhone = factory.GetAndroidPhone();
            iOSPhone = factory.GetiOSPhone();
        }
        public string GetAndroidPhoneDetails()
        {
            return androidPhone.GetModelDetails();
        }
        public string GetiOSPhoneDetails()
        {
            return iOSPhone.GetModelDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IMobile samsungMobilePhone = new Samsung();
            MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            Debug.WriteLine(samsungClient.GetAndroidPhoneDetails());
            Debug.WriteLine(samsungClient.GetiOSPhoneDetails());
        }
    }
}
