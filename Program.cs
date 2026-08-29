using System.Runtime.InteropServices;

namespace G_ASP_NET_99_C_Basics_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st_anwer
            //    #region
            book b = new book();
            //    b.tittle = "cukur";
            //    b.page_number = 310;

            //    object aras = b;
            //    Console.WriteLine(aras);
            //    #endregion
            #region
            //2nd_answer
            //Console.WriteLine(b.ToString());
            //Console.WriteLine(b.GetHashCode());
            //Console.WriteLine(b.Equals(b));
            //Console.WriteLine(b.GetType());
            #endregion

            #region
            ////int page_number = "301";  //it's compiler-time run
            //string input = "301";
            //int.TryParse(input , out int page_number);
            //Console.WriteLine(page_number);

            #endregion


        }
    }
}
