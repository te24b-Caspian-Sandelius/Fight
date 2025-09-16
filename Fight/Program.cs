
    
        Random rng = new Random();


        // --- Initiera slagskämparna ---
        Console.Write("Namn på P1: ");
        string namnA = Console.ReadLine();
        int hpA = rng.Next(50, 101); 
        Console.WriteLine($"{namnA} startar med {hpA} HP!");

        Console.Write("Namn på P2: ");
        string namnB = Console.ReadLine();
        int hpB = rng.Next(50, 101); // slumpa mellan 50 och 100 HP
        Console.WriteLine($"{namnB} startar med {hpB} HP!");


        Console.Clear();
        Console.WriteLine("Slaget mellan " + namnA + " och " + namnB + " börjar!\n");


        // fight

        int runda = 1;
        while (hpA > 0 & hpB > 0)
        {
            Console.WriteLine($"--- Runda {runda} ---");

            // spelare P1 slår P2
            int skadaA = rng.Next(5, 16); // slumpmässig skada 5–15
            hpB -= skadaA;
            Console.WriteLine($"{namnA} slår {namnB} för {skadaA} skada. {namnB} har {Math.Max(hpB, 0)} hp kvar.");

            // spelare P2 slår P1 (om han lever)
            int skadaB = rng.Next(5, 16);
            hpA -= skadaB;
            Console.WriteLine($"{namnB} slår {namnA} för {skadaB} skada. {namnA} har {Math.Max(hpA, 0)} hp kvar.\n");

            runda++;
            System.Threading.Thread.Sleep(800); // paus
        }

        // --- Resultat ---

        Console.WriteLine("Slaget är över!");
        if (hpA <= 0 && hpB <= 0)
        {
            Console.WriteLine("Det blev oavgjort! Båda föll samtidigt.");
        }
        else if (hpA <= 0)
        {
            Console.WriteLine($"{namnB} vann!");
        }
        else
        {
            Console.WriteLine($"{namnA} vann!");
        }

        Console.ReadLine();
    