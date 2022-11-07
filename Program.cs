internal class Program
{
    private static void Main(string[] args)
    {
        //sort
        int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };


        Console.WriteLine("****Sırasız Dizi****");
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        Console.WriteLine("****Sıralı Dizi****");
        Array.Sort(sayiDizisi);

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);


        //Clear
        Console.WriteLine("****Array Clear****");
        Array.Clear(sayiDizisi, 2, 2);

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);




        //Reverse
        Console.WriteLine("****Array Reverse****");
        Array.Reverse(sayiDizisi);

        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);




        //IndexOf
        Console.WriteLine("****Array IndexOf****");
        Console.WriteLine(Array.IndexOf(sayiDizisi, 23));//23 itemının dizideki indexini getirir?



        //Resize
        Console.WriteLine("****Array Resize****");
        Array.Resize<int>(ref sayiDizisi, 9);
        sayiDizisi[8] = 99;
        Array.Sort(sayiDizisi);


        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);


        for (int i = 0; i < sayiDizisi.Length; i++)
        {
            Console.Write("Dizinin {0}. elemanı:  ",i+1);
            Console.WriteLine(Array.IndexOf(sayiDizisi, sayiDizisi[i]));

            

        }

        //ConvertAll
        Console.WriteLine("****Array ConvertAll****");
        string[] sayiDizisi1 = Array.ConvertAll(sayiDizisi, element => element.ToString());
        Console.WriteLine("sayiDizisi arrayinin tipi:"+sayiDizisi.GetType());
        Console.WriteLine("sayiDizisi1 arrayinin tipi:"+sayiDizisi1.GetType());

        //FindAll
        Console.WriteLine("****Array FindAll****");
       int[] matchedItems = Array.FindAll(sayiDizisi, x => x >= 12 && x <= 86);
        foreach (var sayi in matchedItems)
            Console.WriteLine(sayi);
      



    }
}