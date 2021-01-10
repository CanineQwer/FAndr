using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cust
{
    private string FId, FName, FAddres, FChief;
    private int FRoom;

    public string Id
    {
        get { return FId; }
        set { FId = value; }
    }

    public string Name
    {
        get { return FName; }
        set { FName = value; }
    }

    public string Addres
    {
        get { return FAddres; }
        set { FAddres = value; }
    }

    public string Chief
    {
        get { return FChief; }
        set { FChief = value; }
    }

    public int Room
    {
        get { return FRoom; }
        set { FRoom = value; }
    }

    public Cust(string bId, string bName, string bAddres, string bChief, int bRoom)
    {
        FId = bId;
        FName = bName;
        FAddres = bAddres;
        FChief = bChief;
        FRoom = bRoom;
    }
    public Cust()
    {
    }
    public Cust(Cust bCust)
    {
        FId = bCust.Id;
        FName = bCust.Name;
        FAddres = bCust.Addres;
        FChief = bCust.Chief;
        FRoom = bCust.Room;
    }
    public int GetFloor()
    {
        return FRoom / 10;
    }
    public static bool operator >(Cust a, Cust b)
    {
        return a.FRoom > b.FRoom;
    }
    public static bool operator <(Cust a, Cust b)
    {
        return a.FRoom < b.FRoom;
    }
    public static bool operator ==(Cust a, Cust b)
    {
        return a.FId == b.FId & a.FName == b.FName & a.FAddres == b.FAddres & a.FChief == b.FChief & a.FRoom == b.FRoom;
    }

    public static bool operator !=(Cust a, Cust b)
    {
        return a.FId != b.FId & a.FName != b.FName & a.FAddres != b.FAddres & a.FChief != b.FChief & a.FRoom != b.FRoom;
    }

}

enum UCT
{
    Bad, Good, WW
}

class UrCust : Cust
{
    private string FOGRN;
    private UCT FType;

    public string OGRN
    {
        get { return FOGRN; }
        set { FOGRN = value; }
    }

    public UCT Type
    {
        get { return FType; }
        set { FType = value; }
    }

    public UrCust(string bId, string bName, string bAddres, string bChief, int bRoom, string bOGRN, UCT bType) : base(bId, bName, bAddres, bChief, bRoom)
    {
        FOGRN = bOGRN;
        FType = bType;
    }

    public UrCust(UrCust bCust) : base (bCust)
    {
        FOGRN = bCust.OGRN;
        FType = bCust.Type;
    }

}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cust a, b;
            a = new Cust("1", "ООО Рога и Копыта", "Москва, Ленина 7", "Алексеев А.В.", 14);
            b = new UrCust("2", "ООО Мираторг", "Краснодар, Пушкина 9", "Рюрикович М.С.", 21, "234567", UCT.Bad);
            Console.WriteLine("По улице " + a.Addres + " этаж: " + Convert.ToString(a.GetFloor()));
            Console.WriteLine("По улице " + b.Addres + " этаж: " + Convert.ToString(b.GetFloor()));
            Console.WriteLine("Провека a > b даёт " + Convert.ToString(a > b) + ", так как сравнение по этажу");
            Console.WriteLine("Вывод с явным преобразованием:" + ((UrCust)b).OGRN);
            UrCust c = new UrCust((UrCust)b); //использование конструктора копий вместе с янвным преобразованием
            Console.WriteLine("Вывод от копии: " + c.Name +' '+ c.OGRN);
            Console.ReadLine();
        }
    }
}
