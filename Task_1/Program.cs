using lab_1;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address yulias = new Address();


            Console.WriteLine("Index: " + yulias.index);
            Console.WriteLine("Country: " + yulias.country);
            Console.WriteLine("City: " + yulias.sity);
            Console.WriteLine("Street: " + yulias.street);
            Console.WriteLine("House: " + yulias.house);
            Console.WriteLine("Apartment: " + yulias.apartament);

        }

    }

}