namespace Lab6_KazanovAlexandr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var firstUser = new Authorization("Vasiliy", "12345", "12345");
                //var secondUser = new Authorization("Ihor Myasnikov", "1543", "1543");
                var thirdUser = new Authorization("Pavel", "3214", "53215");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}