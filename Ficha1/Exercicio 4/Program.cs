namespace Ex4
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var company = new Company();
            var textUi = new TextUi(company);
            textUi.Start();
        }
    }
}