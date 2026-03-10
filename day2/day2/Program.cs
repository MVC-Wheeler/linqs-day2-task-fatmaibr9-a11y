namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book( 1,  "C# Basics", 200,  1 ),
                new Book( 2,  "Advanced C#",  300,  1 ),
                new Book( 3,  "LINQ Guide", 150, 2 ),
                new Book(  4,  "ASP.NET Core",  400,  2 ),
                new Book( 5,  "Database Design",  250,  3 ),
                new Book( 6, "OOP Concepts", 180,  3 ),
                new Book( 7,  "Design Patterns", 220,  4 ),
                new Book(8, "Software Architecture", 350,  4 )
            };

            List<Aouther> aouthers = new List<Aouther>()
            {
                  new Aouther( "Eng.Ahmed" ,1),
                new Aouther(  "Eng.Sara" ,2 ),
                new Aouther( "Eng.Mona" ,3),
                new Aouther( "Eng.Khaled" ,4 )

            };
            
        }
    }
}
