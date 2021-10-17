namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            TextUi textUi = new TextUi(company);
            textUi.Start();
        }
    }
}