using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Demo
{
    class Program
    {
        public CustomerBusinessLogic _customerBL;

        public Program()
        {
            _customerBL = new CustomerBusinessLogic(new CustomerDataAccess());
            Console.WriteLine(_customerBL.ProcessCustomerData(1));
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program prg = new Program();
            
        }
    }

    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {

        }
        public string GetCustomerName(int id)
        {
            return "Testing Dependency Injection";
        }
    }

    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _dataAccess;

        public CustomerBusinessLogic(ICustomerDataAccess custDataAccess)
        {
            _dataAccess = custDataAccess;
        }

        public CustomerBusinessLogic()
        {
            _dataAccess = new CustomerDataAccess();
        }

        public string ProcessCustomerData(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }
}
