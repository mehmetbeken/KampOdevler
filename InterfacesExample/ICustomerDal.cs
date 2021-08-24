using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesExample
{
    interface ICustomerDal
    {
        void Add();
        void Delete();
        void Update();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Delete");
        }

        public void Update()
        {
            Console.WriteLine("Sql Update");

        }
    }
        class OracleCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine("Oracle Added");
            }

            public void Delete()
            {
                Console.WriteLine("Oracle Delete");
            }

            public void Update()
            {
                Console.WriteLine("Oracle Update");
            }
        }
    
        class CustomManager
        {
            public void Delete(ICustomerDal customerDal)
            {
                customerDal.Delete();
            }

        
    }
}
