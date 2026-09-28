namespace CommandlineDatabehandler;

class Program
{
    static void Main(string[] args)
    {
        FileHandler fileHandler = new FileHandler();
        fileHandler.ReadFileContent("datasett.json");
    }
}
