using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksamensOpgave {
	internal class Program {
		static void Main(string[] args)
		{
			//0.1 Lav variabler
			//1 switch
			//2 festivalplads
			//2.1 if else med telefon
			//2.2 lav map med noget placering over mappet
			//2.3 lav en retrun knap
			//3 webshop
			//3.1 while loop
			//3.2 liste menu switch
			//3.3 enkel visning af product med hvor mange man ville købe
			//3.4 vis total pris med hvor meget man har købt

			string anwser;
			string phone;
			double price=0;
			int amount;
			double sPrice = 0;

					//Definerer linjer på mappet
					string ylinje = "\x2502";
					string xlinje = "\x2500";
					string tvhjørne = "\x250C";
					string thhjørne = "\x2510";
					string bvhjørne = "\x2514";
					string bhhjørne = "\x2518";
			//Do while loop så den starter forfra
			do { 
			Console.WriteLine("velkommen til festivalen");
			Console.WriteLine("Tast ind hvad du vil se");
			Console.WriteLine("Tast 1. for Festivalpladsen - hvor skal man slå lejr?");
			Console.WriteLine("Tast 2. for Webshopen som sælger camping udstyr");
				Console.WriteLine("Tast 0 for at gå ud");
			anwser = Console.ReadLine();
			switch(anwser)
			{
				case "1":
					//festivalplads
					Console.Clear();

					Console.WriteLine("Skriv dit telefon nummer");
					phone = Console.ReadLine();
						//Tager kun det første tal
					string shortphone = phone.Substring(0, 1);
					Console.Clear();


					Console.Write(tvhjørne);

					for(int i = 0; i < 100; i++) //top - laver øverste linje
					{
						Console.Write(xlinje);
					}

					Console.Write(thhjørne);

					for(int i = 0; i < 17; i++) //sider - laver siderne
					{
						Console.SetCursorPosition(0, 1 + i);
						Console.WriteLine(ylinje);
						Console.SetCursorPosition(101, 1 + i);
						Console.WriteLine(ylinje);
					}

					Console.SetCursorPosition(0, 18);
					Console.Write(bvhjørne);

					for(int i = 0; i < 100; i++) //bund - laver nederste linje
					{
						Console.Write(xlinje);
					}

					Console.Write(bhhjørne);

					//--- kryds ---

					Console.SetCursorPosition(1, 9); //vandret linje til kryds

					for(int i = 0; i < 100; i++)
					{
						Console.Write(xlinje);
					}

					for(int i = 0; i < 17; i++) //lodret linje til kryds
					{

						Console.SetCursorPosition(50, 1 + i);
						Console.WriteLine(ylinje);

					}

					Console.SetCursorPosition(20, 5);
					Console.WriteLine("Plads 1");
					Console.SetCursorPosition(72, 5);
					Console.WriteLine("Plads 2");
					Console.SetCursorPosition(20, 14);
					Console.WriteLine("Plads 3");
					Console.SetCursorPosition(68, 14);
					Console.WriteLine("Vareudlevering");
					//End of map 
					//Hvor folk skal være via telefon nummer
					if(shortphone == "1" || shortphone == "2" || shortphone == "3")
					{
						Console.SetCursorPosition(15, 5);
						Console.BackgroundColor = ConsoleColor.Red;
						Console.WriteLine("Du skal være her!");
						Console.ResetColor();
					}else if(shortphone == "4" || shortphone == "5" || shortphone == "6")
					{
						Console.SetCursorPosition(67, 5);
						Console.BackgroundColor = ConsoleColor.Red;
						Console.WriteLine("Du skal være her!");
						Console.ResetColor();
					}else if(shortphone == "7" || shortphone == "8" || shortphone == "9")
						{
						Console.SetCursorPosition(15, 14);
						Console.BackgroundColor = ConsoleColor.Red;
						Console.WriteLine("Du skal være her!");
						Console.ResetColor();
						}
					else
					{
						Console.SetCursorPosition(0, 19);
						Console.WriteLine("Vi kan ikke finde dit telefon nummer");
					}

					Console.SetCursorPosition(0, 20);

					Console.WriteLine("Tryk på en tast for at gå videre");
					Console.ReadKey();
						Console.Clear();


				break;


					//----------------------------------------------------

				case "2":
					//webshop
					do{
						Console.Clear();
						Console.WriteLine("Tast 1 for Telt, 2 for Luftmadras, 3 for Sovepose, 8. kort, 9 din total pris");
						Console.WriteLine("1. Telt - pris 350,75 DKK");
						Console.WriteLine("2. Luftmadras - pris 255,00 DKK");
						Console.WriteLine("3. Sovepose - pris 150,50 DKK");
						Console.WriteLine("8. Hvor skal jeg hente mine ting");
						Console.WriteLine("9. Hvor meget har jeg købt for?");
						Console.WriteLine("0. tilbage");
						anwser = Console.ReadLine();
						switch(anwser) { 
						case "1":
								Console.Clear();
								Console.WriteLine("Hvor mange Telte vil du købe?");
								amount=Convert.ToInt32(Console.ReadLine());
								sPrice = 350.75 * amount;
								price = price + sPrice;
								Console.WriteLine("Du har købt " + amount + " telte for " + sPrice + " DKK");
								Console.ReadKey();
								Console.Clear();
								break;
						case "2":
								Console.Clear();
								Console.WriteLine("Hvor mange Luftmadraser vil du købe?");
								amount = Convert.ToInt32(Console.ReadLine());
								sPrice = 255.00 * amount;
								price = price + sPrice;
								Console.WriteLine("Du har købt " + amount + " Luftmadraser for " + sPrice + " DKK");
								Console.ReadKey();
								Console.Clear();
								break;
						case "3":
								Console.Clear();
								Console.WriteLine("Hvor mange Soveposer vil du købe?");
								amount = Convert.ToInt32(Console.ReadLine());
								sPrice = 150.50 * amount;
								price = price + sPrice;
								Console.WriteLine("Du har købt " + amount + " Soveposer for " + sPrice + " DKK");
								Console.ReadKey();
								Console.Clear();
								break;
							case "8":
								Console.Clear();
								Console.Write(tvhjørne);

								for(int i = 0; i < 100; i++) //top - laver øverste linje
								{
									Console.Write(xlinje);
								}

								Console.Write(thhjørne);

								for(int i = 0; i < 17; i++) //sider - laver siderne
								{
									Console.SetCursorPosition(0, 1 + i);
									Console.WriteLine(ylinje);
									Console.SetCursorPosition(101, 1 + i);
									Console.WriteLine(ylinje);
								}

								Console.SetCursorPosition(0, 18);
								Console.Write(bvhjørne);

								for(int i = 0; i < 100; i++) //bund - laver nederste linje
								{
									Console.Write(xlinje);
								}

								Console.Write(bhhjørne);

								//--- kryds ---


								Console.SetCursorPosition(1, 9); //vandret linje til kryds

								for(int i = 0; i < 100; i++)
								{
									Console.Write(xlinje);
								}

								for(int i = 0; i < 17; i++) //lodret linje til kryds
								{

									Console.SetCursorPosition(50, 1 + i);
									Console.WriteLine(ylinje);

								}

								Console.SetCursorPosition(20, 5);
								Console.WriteLine("Plads 1");
								Console.SetCursorPosition(72, 5);
								Console.WriteLine("Plads 2");
								Console.SetCursorPosition(20, 14);
								Console.WriteLine("Plads 3");
								Console.BackgroundColor = ConsoleColor.Red;
								Console.ForegroundColor = ConsoleColor.Black;
								Console.SetCursorPosition(68, 14);
								Console.WriteLine(" Vareudlevering ");
								Console.ResetColor();

								Console.ReadKey();
								//End of map 
								break;
							case "9":
								Console.Clear();
								Console.WriteLine("Du har brugt for " + price + " DKK");
								Console.ReadKey();
								Console.Clear();
								break;
							case "0":
								
								Console.Clear();
								break;
								default:
								Console.Clear();
								Console.WriteLine("Du har intasted en ugyldig intastning");
								Console.ReadKey();
								Console.Clear();
								break;
						}
					} while(anwser != "0");	
				break;
					case "0":
						Console.Clear();
						Console.BackgroundColor= ConsoleColor.Green;
						Console.Clear();
						Console.ForegroundColor= ConsoleColor.Black;
						Console.WriteLine("God fornøjelse med festivalen");
						Console.ReadKey();
						Console.ResetColor();
						Console.Clear();
						price = 0;
						break;
						default :
						Console.WriteLine("Du har intasted noget ugyldigt");
						Console.ReadKey();
						break;
			}
			} while(true);
		}
	}
}

