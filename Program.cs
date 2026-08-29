using System.Runtime.InteropServices;

namespace G_ASP_NET_99_C_Basics_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st_anwer
            //    #region
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
            #region
            //try
            //{
            //    int a = 10;
            //    int b = 0;
            //    int result = a / b;
            //    Console.WriteLine("result");
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("invalid you can't divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("done");
            //}
            #endregion
            #region
            //int page_number = 300;
            //double pages_double = page_number;
            //Console.WriteLine($"page_number os : {pages_double} ");
            #endregion
            #region
            //double price = 49.99;
            //int NewPrice =(int)price;    //explicit 
            //Console.WriteLine(NewPrice);
            #endregion
            #region
            //string pages_text = "301";
            //int pages = Convert.ToInt32(pages_text);
            //Console.WriteLine($"pages_text is : {pages_text}");
            #endregion


        }
    }
}
