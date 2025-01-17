using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamolo
{
	internal class Program
	{
		static float elsoszam = 0;
		static float masodikszam = 0;
		static string jelek = "";

		static void Main(string[] args)
		{
			Indit();
		}
			


		static void Indit()
		{
				Console.WriteLine("add meg az első számot");
				elsoszam = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("add meg a második számot");
				masodikszam = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("add meg a műveleti jelet");
				jelek = Console.ReadLine();

				switch (jelek)
				{
					case "+":
						Osszeadas();
						break;
				case "-":
					Kivonas();
					break;
				case "/":
					Osztas();
					break;
				case "*":
					Szorzas();
					break;
				case "%":
					Szazalek();
					break;
			}
		}

		static void Osszeadas()
		{
			float osszeadva = elsoszam + masodikszam;
			Console.WriteLine("A két szám össszege:" + osszeadva);
		}

		static void Kivonas()
		{
			float kivonva = elsoszam - masodikszam;
			Console.WriteLine("A két szám különbsége:" + kivonva);
		}

		static void Osztas()
		{
			float osztva = elsoszam / masodikszam;
			Console.WriteLine("A két szám osztva egymással:" + osztva);
		}

		static void Szorzas()
		{
			float szorozva = elsoszam * masodikszam;
			Console.WriteLine("A két szám szorozva egymással:" + szorozva);
		}

		static void Szazalek()
		{
			float szazalek = (elsoszam / masodikszam) * 100;
			Console.WriteLine("Ennyi százaléka az első szam a másodiknak:" + szazalek);
		}
	}
}
