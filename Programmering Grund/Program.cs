using System;
using System.Collections.Generic;

namespace UppgiftMiniräknare.AdamBillekvist
{
    //Adam Billekvists MiniRäknare

    class Program
    {
        static void Main(string[] args)
        {
            //Välkomnande av användaren och namnet på konsolen
            Console.Title = "Super Miniräknaren 6000";
            Console.WriteLine("Välkommen till en fantastisk miniräknare!");
            Console.Write("\n~~~~~~~~~~~~~~~~~~~\n");

            //Här sparas listan för historik
            List<string> ResultatHistoria = new List<string>();

            while (true)
            {
                string Operator = "";
                string total = "";
                string Inmatning1 = "";
                string Inmatning2 = "";
                double Resultat = 0;
                double FörstaTalet = 0;
                double AndraTalet = 0;

                //Här nedan är inmatningen för Tal 1, där jag även la in en Tjena funktion för MARCUS utan att programmet avslutas
                //Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet
                Console.WriteLine("Ange det första talet");
                Inmatning1 = Console.ReadLine();
                while (!double.TryParse(Inmatning1, out FörstaTalet))
                {
                    if (Inmatning1 == "MARCUS")
                    {
                        Console.WriteLine("Tjena!\nSkriv in ett tal:");
                        Inmatning1 = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Ogiltig inmatning! Var vänlig och ange ett tal:");
                        Inmatning1 = Console.ReadLine();
                    }
                }

                //Här måste användaren mata in en operator annars kommer programmet fortsätta loopa utan möjlighet att kunna gå vidare
                //Om Användaren matar in MARCUS istället för en operator kommer programmet att avslutas och stängas

                Console.WriteLine("Ange en operator ( -, +, *, / )");
                Operator = Console.ReadLine();

                while (true)
                {

                    if (Operator == "*" || Operator == "+" || Operator == "-" || Operator == "/")
                    {
                        break;
                    }
                    else if (Operator == "MARCUS")
                    {

                        Console.WriteLine("Hej");
                        Environment.Exit(10);

                    }
                    else
                    {
                        Console.WriteLine("Ogiltig inmatning! Var vänlig och ange en operator");
                        Operator = Console.ReadLine();
                    }

                }

                //Här nedan är inmatningen för Tal 2 med samma funktion som Tal 1
                //Användaren måsta mata in ett tal för att kunna ta sig vidare i programmet
                Console.WriteLine("Ange det andra talet");
                Inmatning2 = Console.ReadLine();
                while (!double.TryParse(Inmatning2, out AndraTalet))
                {
                    if (Inmatning2 == "MARCUS")
                    {
                        Console.WriteLine("Tjena!\nSkriv in ett tal::");
                        Inmatning2 = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Ogiltig inmatning! Var vänlig och ange en operator:");
                        Inmatning2 = Console.ReadLine();
                    }
                }

                //Här använder jag mig av switch cases, då det är flera olika fall och mer passande då alla inmatningar har olika funktioner
                switch (Operator)
                {
                    case "/":
                        Resultat = FörstaTalet / AndraTalet;
                        break;
                    case "*":
                        Resultat = FörstaTalet * AndraTalet;
                        break;
                    case "-":
                        Resultat = FörstaTalet - AndraTalet;
                        break;
                    case "+":
                        Resultat = FörstaTalet + AndraTalet;
                        break;

                }

                //Här presenteras uträkningen av dom olika inmatningarna av användaren
                if (Operator == "-")
                {
                    total = FörstaTalet + " - " + AndraTalet + " = " + Resultat.ToString();
                    Console.WriteLine(total);
                }
                else if (Operator == "+")
                {
                    total = FörstaTalet + " + " + AndraTalet + " = " + Resultat.ToString();
                    Console.WriteLine(total);
                }
                else if (Operator == "*")
                {
                    total = FörstaTalet + " * " + AndraTalet + " = " + Resultat.ToString();
                    Console.WriteLine(total);
                }
                else if (Operator == "/")
                {
                    //Ifall användaren skulle dela 0 med 0
                    if (AndraTalet == 0)
                    {
                        Console.WriteLine("\n Ogiltig beräkning, vänligen ange en ny beräkning.");
                    }

                    else
                    {
                        total = FörstaTalet + " / " + AndraTalet + " = " + Resultat.ToString();
                        Console.WriteLine(total);
                    }
                }
                //Lägger till resultat till listan
                ResultatHistoria.Add(total);

                //Här frågas användaren om den vill se historik av beräkningar eller fortsätta
                Console.Write("\n~~~~~~~~~~~~~~~~~~~\n" +
                    "För att se tidigare resultat klicka på ( y ) eller på ( ENTER ) för att fortsätta: ");
                if (Console.ReadLine() == "y")
                {
                    foreach (string y in ResultatHistoria)
                    {
                        Console.WriteLine("\n" + y);
                    }
                }

                //Här frågas användaren om den vill avsluta eller fortsätta
                Console.Write("För att avsluta programmet klicka på ( t ) eller på ( ENTER ) för en ny beräkning: ");
                if (Console.ReadLine() == "t")
                {
                    break;
                }
                Console.Write("\n~~~~~~~~~~~~~~~~~~~\n");
            }


        }
    }
}