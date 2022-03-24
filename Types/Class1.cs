namespace Types
{
    //TODD 2
    public class MyString
    {
        public string Value { get; set; } 

        public MyString(string x)
        {
            this.Value = x;
        }
        public MyString(string x, string y)
        {
            this.Value = x + y;
        }
        public MyString(string x, char y)
        {
            this.Value=x + y;
        }
        public MyString(char x, char y)
        {
            this.Value = (x + y).ToString();
        }
        public MyString()
        {
        }

        public string Revers(string x)
        {
            char[] arr = x.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);

        }
    }
    //TODD 5
    public class Transport
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nAge: {Age.ToString()}");
            
        }
    }
    public class Car : Transport
    {
        public string Type { get; set; }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Type: {Type}");
        }
    }
    public class Boat : Transport
    {
        public decimal Lenght { get; set; }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Lenght: {Lenght}");
        }

    }
    static class Data
    {
        public static string Print(this DateTime dateTime)
        {
            
        }
    }
}