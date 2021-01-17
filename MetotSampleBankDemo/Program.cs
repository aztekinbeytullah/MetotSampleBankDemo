using MetotSampleBankDemo.Entity;
using MetotSampleBankDemo.Manager;
using System;

namespace MetotSampleBankDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Seçiminizi Yapınız");
            Console.WriteLine("1- Ekle");
            Console.WriteLine("2- Sil");
            Console.WriteLine("3- Güncelle");
            Console.WriteLine("4- Listele");
            Console.WriteLine("5- Müşteri Getir");
            string ch=Console.ReadLine();
            CostumerManager costumerManager = new CostumerManager();

            Costumer costumer = new Costumer()
            {
                Id = 5,
                Birthday = DateTime.Now,
                Name = "Hacı Süleyman Efendizade",
                Surname = "Malkoçoğlularımızdanmısınız"

            };

            switch (ch)
            {
                case "1":
                    costumerManager.Add(costumer);
                    break;

                case "2":
                    costumerManager.Delete(costumer);
                    break;

                case "3":
                    costumerManager.Update(costumer);
                    break;

                case "4":
                    foreach (Costumer c in costumerManager.ListOfCostumer())
                    {
                        Console.WriteLine(c.Name + " " + c.Surname);
                    }
                    break;
                case "5":
                    costumerManager.GetCostumer(1);
                    break;
                default:
                    break;
            }

        }
    }
}
