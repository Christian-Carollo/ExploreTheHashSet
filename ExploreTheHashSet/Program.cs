internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<string> setA = new HashSet<string>() { "Marco", "Franco" };
        HashSet<string> setB = new HashSet<string>() { "Marta", "franco" };

        setA.UnionWith(setB); // Nel caso delle stringhe l'HashSet sarà sensibile ai caratteri Maiuscoli e Minuscoli, consinderandole univoche.


        Console.WriteLine("Elemnti del set dopo l'aggiunta di valori univoci:");

        Visualizza(setA);

        setA.Add("Marta");

        Console.WriteLine("Elemnti del set dopo l'aggiunta di valori già prensenti:");

        Visualizza(setA);




        void Visualizza(HashSet<string> setA)
        {
            foreach (var item in setA)
            {
                Console.WriteLine(item + "\n");
            }
        }

    }
    
}