using System;
using System.Collections.Generic;
using System.Text;
using MetotSampleBankDemo.Entity;

namespace MetotSampleBankDemo.Manager
{
    class CostumerManager
    {
        public Costumer Add(Costumer costumer)
        {
            Console.WriteLine(costumer.Name +" "+ costumer.Surname + " is added");
            return costumer;
        }
        public Costumer Delete(Costumer costumer)
        {
            Console.WriteLine(costumer.Name +" "+costumer.Surname + " is deleted");
            return costumer;
        }
        public Costumer Update(Costumer costumer)
        {
            Console.WriteLine(costumer.Name + costumer.Surname + " is updated");
            return costumer;
        }
        public bool GetCostumer(int id)
        {
            Console.WriteLine("Your sended costumer id is"+ id);
            return true;
        }

        public Costumer[] ListOfCostumer()
        {
            return new Costumer[]
            {
                new Costumer{Id=1,Name="Costumer1",Surname="Surname1",Birthday=DateTime.Now},
                new Costumer{Id=2,Name="Costumer2",Surname="Surname2",Birthday=DateTime.Now},
                new Costumer{Id=3,Name="Costumer3",Surname="Surname3",Birthday=DateTime.Now},
            };
        }
    }
}
