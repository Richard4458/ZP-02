using System.Security.Cryptography.X509Certificates;

namespace ZP_02
{
    internal class Program
    {
        static void Main(string[] args)
  
        {
            Console.WriteLine("Pacient 1");
           
            // 1.meno 
            Console.Write("Zadajte meno: ");

            string meno = Console.ReadLine();

            // 2.priezvysko
            Console.Write("Zadajte priezvysko: ");

            string priezvysko = Console.ReadLine();
            
            // 3.vek
            Console.Write("Zadajte vek: ");
            
            int vek = int.Parse(Console.ReadLine());
            
            // 4.váha
            Console.Write("Zadajte váhu: ");
            
            double váha = double.Parse(Console.ReadLine());
            
            // 5.výška
            Console.Write("Zadajte výšku: ");
            
            double výška = double.Parse(Console.ReadLine());



            // 6.vyhodnotenie vety
            Console.WriteLine( (meno + " " + priezvysko) + " je starý/á " + vek + " rokov. Váži " + váha + " kilogramov a je " + výška + " centimetrov vysoký/á.");

            // 7.BMI
            double BMI = (double)(váha / ((výška / 100)* (výška / 100)));

            Console.WriteLine("Vaše BMI je: " + BMI);
             

            // DRUHÝ PACIENT    

            Console.WriteLine("Pacient 2");

            // 1.meno 
            Console.Write("Zadajte meno: ");

            string meno2 = Console.ReadLine();

            // 2.priezvysko
            Console.Write("Zadajte priezvysko: ");

            string priezvysko2 = Console.ReadLine();

            // 3.vek
            Console.Write("Zadajte vek: ");

            int vek2 = int.Parse(Console.ReadLine());

            // 4.váha
            Console.Write("Zadajte váhu: ");

            double váha2 = double.Parse(Console.ReadLine());

            // 5.výška
            Console.Write("Zadajte výšku: ");

            double výška2 = double.Parse(Console.ReadLine());



            // 6.vyhodnotenie vety
            Console.WriteLine((meno2 + " " + priezvysko2) + " je starý/á " + vek2 + " rokov. Váži " + váha2 + " kilogramov a je " + výška2 + " centimetrov vysoký/á.");

            // 7.BMI
            double BMI2 = (double)(váha2 / ((výška2 / 100) * (výška2 / 100)));

            Console.WriteLine("Vaše BMI je: " + BMI2);





        }
       
    }
}

























































































































