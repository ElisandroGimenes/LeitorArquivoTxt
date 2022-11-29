class program
{
    static void Main()
    {
        //Código para leitura por linha

        const string filePath = "c:\\code\\txt.txt";

        using var file = new StreamReader(filePath);
        string? line;

        while ((line = file.ReadLine()) != null)
            Console.WriteLine(line);



        //Código para leitura texto 
        
        /*
        const string filePath = "c:\\code\\txt.txt";

        var data = File.ReadAllText(filePath);

        Console.WriteLine(data);
        */
    }
}
