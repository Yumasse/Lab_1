namespace Task_3
{
    public class Program
    {
        static void Main(string[] args)
        {


            string lastName = "Чеканюк";
            string firstName = "Юлія";
            string position = "Програміст";
            int experience = 4;  // Рік стажу

            Employee employee = new Employee(lastName, firstName);
            employee.DisplayInfo(position, experience);

        }
    }
}   
