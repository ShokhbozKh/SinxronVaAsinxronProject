using System.Diagnostics;

namespace ConsoleApp10
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // quymoq pishirmoq
            //1.
            //..
            //9..
            //Task.Delay(1000). Wait(); - bu oqimni tuxtatib quyadi va natijani kutadi
            // await Task.Delay(1000); - uqimni tuxtatmasdan natijani kutadi
            #region 1
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //TuxumniOlmoq();
            //TuxumniSindirmoqAsync();
            //TuxumgaTuzSepmoqAsync();
            //TovaniIsitmoqAsync();
            //YogniIsitmoqAsync();
            //TuxumiPishirmoqAsync();
            //TuxumniAgdarmoqAsync();
            //TuxumniYeyishgaYubormoqAsync();
            //TuxumniYimoqAsync();

            //stopwatch.Stop();
            //Console.WriteLine($"Ketgan umumiy vaqt {stopwatch.ElapsedTicks}");
            #endregion 1

            #region 2
            #region 1
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            await TuxumniOlmoqAsync();
            await TuxumniSindirmoqAsync();
            await TuxumgaTuzSepmoqAsync();
            await TovaniIsitmoqAsync();
            await YogniIsitmoqAsync();
            await TuxumiPishirmoqAsync();
            await TuxumniAgdarmoqAsync();
            await TuxumniYeyishgaYubormoqAsync();
            await TuxumniYimoqAsync();

            stopwatch.Stop();
            Console.WriteLine($"Ketgan umumiy vaqt {stopwatch.ElapsedTicks}");
            #endregion 1

            #endregion 2


        }
        #region 1.1sinxron
        //static void TuxumniOlmoq()
        //{
        //    Task.Delay(500).Wait();
        //    Console.WriteLine("Tuxumlarni olmoq...1");
        //}
        //static void TuxumniSindirmoqAsync()
        //{
        //    Task.Delay(750).Wait();
        //    Console.WriteLine("Tuxumni sindirmoq..2");
        //}
        //static void TuxumgaTuzSepmoqAsync()
        //{
        //    Task.Delay(200).Wait();
        //    Console.WriteLine("Tuxumga tuz sepmoq..3");
        //}
        //static void TovaniIsitmoqAsync()
        //{
        //    Task.Delay(1000).Wait();
        //    Console.WriteLine("Tovani isitmoq...4");
        //}
        //static void YogniIsitmoqAsync()
        //{
        //    Task.Delay(750).Wait();
        //    Console.WriteLine("Yogni isitmoq...5");
        //}
        //static void TuxumiPishirmoqAsync()
        //{
        //    Task.Delay(2000).Wait();
        //    Console.WriteLine("Tuxumni pishirmoq...6");
        //}
        //static void TuxumniAgdarmoqAsync()
        //{
        //    Task.Delay(1000).Wait();
        //    Console.WriteLine("Tuxumni bosqa tamonini pishirish..7");
        //}
        //static void TuxumniYeyishgaYubormoqAsync()
        //{
        //    Task.Delay(750).Wait();
        //    Console.WriteLine("Tuxumni yeyishga yubormoq...8");
        //}
        //static void TuxumniYimoqAsync()
        //{
        //    Task.Delay(2500).Wait();
        //    Console.WriteLine("Tuxumni yimoq...9");
        //}
        #endregion 1.1 

        #region 2.1 asinxron
        static async Task TuxumniOlmoqAsync()
        {
            await Task.Delay(500);
            Console.WriteLine("Tuxumlarni olmoq...1");
        }
        static async Task TuxumniSindirmoqAsync()
        {
            await Task.Delay(750);
            Console.WriteLine("Tuxumni sindirmoq..2");
        }
        static async Task TuxumgaTuzSepmoqAsync()
        {
            await Task.Delay(200);
            Console.WriteLine("Tuxumga tuz sepmoq..3");
        }
        static async Task TovaniIsitmoqAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Tovani isitmoq...4");
        }
        static async Task YogniIsitmoqAsync()
        {
            await Task.Delay(750);
            Console.WriteLine("Yogni isitmoq...5");
        }
        static async Task TuxumiPishirmoqAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("Tuxumni pishirmoq...6");
        }
        static async Task TuxumniAgdarmoqAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("Tuxumni bosqa tamonini pishirish..7");
        }
        static async Task TuxumniYeyishgaYubormoqAsync()
        {
            await Task.Delay(750);
            Console.WriteLine("Tuxumni yeyishga yubormoq...8");
        }
        static async Task TuxumniYimoqAsync()
        {
            await Task.Delay(2500);
            Console.WriteLine("Tuxumni yimoq...9");
        }

        #endregion 2.1


    }
}