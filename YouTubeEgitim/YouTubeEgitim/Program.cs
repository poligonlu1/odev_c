using System;

namespace YouTubeEgitim
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
            customerManager.GiveCredit();
        }
    }

    class CreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("hesaplandı");
        }

        public void Save()
        {
            Console.WriteLine("Kredi verildi");
        }
    }

    interface ICreditManager
    {
        void Calculate();
        void Save();
    }

    abstract class BaseCreditManager : ICreditManager
    {
        public abstract void Calculate();
        
        public void Save()
        {
            Console.WriteLine("Kaydedildi ");
        }
    }

    class TeacherCreditManager : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Öğretmen Kredisi hesaplandı");
        }


    }

    class MilitarycreditManagr : BaseCreditManager, ICreditManager
    {
        public override void Calculate()
        {
            Console.WriteLine("Asker Kredisi hesaplandı");
        }
    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("müşteri nesnesi başlatıldı");
        }
        public int Id { get; set; }

        public string City { get; set; }
    }

    class Person : Customer
    {
        public string NationalIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Company : Customer
   {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }

    class CustomerManager
    {
        private Customer _customer;
        private ICreditManager _creditManager;

        public CustomerManager(Customer customer, ICreditManager creditManager)
        {
            _customer = customer;
            _creditManager = creditManager;
        }
        public void Save()
        {
            Console.WriteLine("müşteri kaydedildi : ");
        }

        public void Delete()
        {
            Console.WriteLine("müşteri silindi : ");
        }

        public void GiveCredit()
        {
            _creditManager.Calculate();
            Console.WriteLine("Kredi verildi");
        }
    }

}
