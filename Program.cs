namespace G_ASP_NET_99_C_Basics_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            book b = new book();
            b.tittle = "cukur";
            b.page_number = 310;

            object aras = b;
            Console.WriteLine(aras);
            #endregion
        }
    }
}
