using System.Net.Mail;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = "Mosh";
            name = 10;

            dynamic a = 10;
            dynamic b = 5;
            // since a and b are dynamic, c is also dynamic
            var c = a + b;
           
            //implicit conversion
            int i = 5;
            dynamic d = i;
            long l = d;

            dynamic excelObject = "Natalia";
            excelObject.Optimize();


        }
    }
}