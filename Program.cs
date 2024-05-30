Dictionary<string, int> boissons = new()
{
   {"soda", 0 },
   {"eau", 0 },
   {"jus", 1 },
   {"bière", 0 },
};

int totalStock = 0;
string choix;

foreach (int values in boissons.Values)
{
   totalStock += values;
}

foreach (KeyValuePair<string, int> pair in boissons)
{
   Console.WriteLine(pair.Key);
   Console.WriteLine(pair.Value);
}

do
{
   Console.WriteLine("Quelle boisson choisissez-vous? Soda - Eau - Jus - Bière");
   choix = Console.ReadLine().ToLower();

   if (boissons.ContainsKey(choix))
   {
       if (boissons[choix] > 0)
       {
           Console.WriteLine("Santé !!");
           boissons[choix]--;
       }
       else
       {
           Console.WriteLine("Sold out...");
       }

   }
   else
   {
       Console.WriteLine("cette boisson n'existe pas... ");
   }
   foreach (KeyValuePair<string, int> pair in boissons)
   {
       Console.WriteLine(pair.Key);
       Console.WriteLine(pair.Value);
   }

   Console.WriteLine("Apuyer sur Escape pour arrêter ou sur une autre touche pour continuer");

} while (Console.ReadKey(true).Key != ConsoleKey.Escape || totalStock > 0);

if (totalStock > 0)
{
   Console.WriteLine("Il n'y a plus de boissons dans la machine...");
}