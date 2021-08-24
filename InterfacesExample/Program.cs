using System;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomManager customManager = new CustomManager();
            customManager.Delete(new OracleCustomerDal());
        }
    }
}
