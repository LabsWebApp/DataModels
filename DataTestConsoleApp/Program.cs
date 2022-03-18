using Models;
using Models.DataProviders.DataTest;
using static System.Console;

namespace DataTestConsoleApp;

class Programm
{
    private static DataManager data = new DataManager(new TestMainRepository());
    public static void Main()
    {
        var main = data.MainEntityRepository;
        //1.1 Read all
        for (int i = 0; i < main.Items?.Length; i++)
        {
            WriteLine(main.Items[i]);
        }
        //1.2 Read one
        var one = main.Items![1]!.Id;
        WriteLine(main.GetItemById(one) == main.Items[1]);

        //2.1 Update create
        //2.2 Update update

        //3 Delete
    }
}