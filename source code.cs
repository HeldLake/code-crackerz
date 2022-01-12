using System;
using System.Threading;
					
public class Program
{
	public static void Main()
	{
		codecrackerzheadline();
		//Random rand = new Random();
		//int randomNumber = rand.Next(1, 10);
		
	Console.WriteLine("");
		Thread.Sleep(1);
	}
	
	static void codecrackerzheadline()
	{
		Console.WriteLine("                                                                                                                                                    ");
		Console.WriteLine("                                  88                                                                  88                                            ");
		Console.WriteLine("                                  88                                                                  88                                            ");
		Console.WriteLine("                                  88                                                                  88                                            ");
		Console.WriteLine(" ,adPPYba,   ,adPPYba,    ,adPPYb,88   ,adPPYba,       ,adPPYba,  8b,dPPYba,  ,adPPYYba,   ,adPPYba,  88   ,d8    ,adPPYba,  8b,dPPYba,  888888888  ");
		Console.WriteLine("a8          a8       8a  a8     `Y88  a8P_____88      a8          88P     Y8        `Y8   a8          88 ,a8     a8P_____88  88P`   Y8       a8P`   ");
		Console.WriteLine("8b          8b       d8  8b       88  8PP=======      8b          88          ,adPPPPP88  8b          8888[      8PP======   88            ,d8P`    ");
		Console.WriteLine(" 8a,   ,aa   8a,   ,a8    8a,   ,d88   8b,   ,aa       8a,   ,aa  88          88,    ,88   8a,   ,aa  88` Yba,    8b,   ,aa  88          ,d8`       ");
		Console.WriteLine("  `Ybbd8     `YbbdP01     `8bbdP Y8    `Ybbd801        `Ybbd801  88           `8bbdP1Y8    `Ybbd801  88   `Y8a    `Ybbd801  88          888888888   ");
		Console.WriteLine("                                                                                                                                                    ");
		codecrackerzstartmenu();
	}
	static void codecrackerzstartmenu()
	{
		string difficulty_easy ="e";
		string difficulty_medium ="m";
		string difficulty_hard ="h";
		string difficulty_custom ="c";
		
		Console.WriteLine("Select difficulty (e=easy, m=medium, h=hard, c=custom)");
		string input = Console.ReadLine();
		if(input == difficulty_easy){
			Console.Clear();
			codegame_easy();
		}
		else if(input == difficulty_medium){
			Console.Clear();
			codegame_medium();
		}
		else if(input == difficulty_hard){
			Console.Clear();
			codegame_hard();
		}
		else if(input == difficulty_custom){
		Console.Clear();
			codegame_custom();
		}
		else{
			Console.Clear();
			Main();
		}
	}
	static void codegame_easy()
	{
		string yes ="y";
	string no ="n";
	string yess ="Y";
	string noo ="N";
		bool Correct = false;
		Random conum = new Random();
		int randomNumber = conum.Next(1, 10);
		
		Console.Write("guess the number between 1 and 10: ");
		
		while(!Correct)
		{
		int input = Convert.ToInt32(Console.ReadLine());
			if(input == randomNumber){
			Correct = true;
			Console.WriteLine("succes!!! (" + randomNumber + ")" );
		}
			else if(input != randomNumber){
			Console.WriteLine("wrong");
			}
		}
		Console.WriteLine("play again y/n");
		string input2 = Console.ReadLine();
	if(input2 == yes){
	codecrackerzstartmenu();
	}
	else if(input2 == yess){
	codecrackerzstartmenu();
	}
	else if(input2 == no){
	//Terminal();
	}
	else if(input2 == noo){
	//Terminal();
	}
		
	}
	static void codegame_medium()
	{
		string yes ="y";
	string no ="n";
	string yess ="Y";
	string noo ="N";
		bool Correct = false;
		Random conum = new Random();
		int randomNumber = conum.Next(1, 25);
		
		Console.Write("guess the number between 1 and 25: ");
		
		while(!Correct)
		{
		int input = Convert.ToInt32(Console.ReadLine());
			if(input == randomNumber){
		Console.WriteLine("succes!!! (" + randomNumber + ")" );
			Correct = true;
		}
			else if(input != randomNumber){
			Console.WriteLine("wrong");
			}
		}
		Console.WriteLine("play again y/n");
		string input2 = Console.ReadLine();
	if(input2 == yes){
	codecrackerzstartmenu();
	}
	else if(input2 == yess){
	codecrackerzstartmenu();
	}
	else if(input2 == no){
	//Terminal();
	}
	else if(input2 == noo){
	//Terminal();
	}
		
	}
		static void codegame_hard()
	{
		string yes ="y";
	string no ="n";
	string yess ="Y";
	string noo ="N";
		bool Correct = false;
		Random conum = new Random();
		int randomNumber = conum.Next(1, 50);
		
		Console.Write("guess the number between 1 and 50: ");
		
		while(!Correct)
		{
		int input = Convert.ToInt32(Console.ReadLine());
			if(input == randomNumber){
		Console.WriteLine("succes!!! (" + randomNumber + ")" );
			Correct = true;
		}
			else if(input != randomNumber){
			Console.WriteLine("wrong");
			}
		}
		Console.WriteLine("play again y/n");
		string input2 = Console.ReadLine();
	if(input2 == yes){
	codecrackerzstartmenu();
	}
	else if(input2 == yess){
	codecrackerzstartmenu();
	}
	else if(input2 == no){
	//Terminal();
	}
	else if(input2 == noo){
	//Terminal();
	}
		
	}
			static void codegame_custom()
	{
		string yes ="y";
	string no ="n";
	string yess ="Y";
	string noo ="N";
		
		Console.Write("enter the first number it should start from (don't use decimals): ");
				int numinput1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("enter the second number it should start from (don't use decimals): ");
				int numinput2 = Convert.ToInt32(Console.ReadLine());
		Console.Clear();
				
		bool Correct = false;
		Random conum = new Random();
		int randomNumber = conum.Next(numinput1, numinput2);
		
		Console.WriteLine("guess the number between " + numinput1 + " and " + numinput2);
		
		while(!Correct)
		{
		int input = Convert.ToInt32(Console.ReadLine());
			if(input == randomNumber){
		Console.WriteLine("succes!!! (" + randomNumber + ")" );
			Correct = true;
		}
			else if(input != randomNumber){
			Console.WriteLine("wrong");
			}
		}
		Console.WriteLine("play again y/n");
		string input2 = Console.ReadLine();
	if(input2 == yes){
	codecrackerzstartmenu();
	}
	else if(input2 == yess){
	codecrackerzstartmenu();
	}
	else if(input2 == no){
	//Terminal();
	}
	else if(input2 == noo){
	//Terminal();
	}
		
	}
}
