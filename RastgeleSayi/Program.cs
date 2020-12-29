using System;

namespace RastgeleSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolay Seviyede Oynamak İçin '1' Tuşuna basınız.");
            Console.WriteLine("Orta Seviyede Oynamak İçin '2' Tuşuna basınız.");
            Console.WriteLine("Zor Seviyede Oynamak İçin '3' Tuşuna basınız.");
            int seviyebelirleme = int.Parse(Console.ReadLine());

            switch (seviyebelirleme)
            {
                case 1:
                    #region Seviye1
                    for (int i = 5; i >= 0; i--)
                    {
                        Console.WriteLine("Sayınızı giriniz.");
                        int deger = int.Parse(Console.ReadLine());
                        Random rndm = new Random();
                        int rndm1 = rndm.Next(1, 10);
                        if (deger == rndm1)
                        {
                            Console.WriteLine("Tebrikler, sayıyı buldunuz.");
                        }
                        else
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("Hakkınız kalmamıştır. " + "Bulmanız gereken sayı:" + rndm1.ToString());
                                break;
                            }
                            Console.WriteLine("Hatalı, " + i.ToString() + " Hakkınız kaldı");
                        }
                    }
                    break;
                #endregion
                case 2:
                    #region Seviye2
                    for (int i = 3; i >= 0; i--)
                    {
                        Console.WriteLine("Sayınızı giriniz.");
                        int deger = int.Parse(Console.ReadLine());
                        Random rndm = new Random();
                        int rndm1 = rndm.Next(1, 25);
                        if (deger == rndm1)
                        {
                            Console.WriteLine("Tebrikler, sayıyı buldunuz.");
                        }
                        else
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("Hakkınız kalmamıştır. " + "Bulmanız gereken sayı:" + rndm1.ToString());
                                break;
                            }
                            Console.WriteLine("Hatalı " + i.ToString() + " Hakkınız kaldı");
                        }
                    }
                    break;
                #endregion
                case 3:
                    #region Seviye3
                    for (int i = 1; i >= 0; i--)
                    {
                        Console.WriteLine("Sayınızı giriniz.");
                        int deger = int.Parse(Console.ReadLine());
                        Random rndm = new Random();
                        int rndm1 = rndm.Next(1, 50);
                        if (deger == rndm1)
                        {
                            Console.WriteLine("Tebrikler, sayıyı buldunuz.");
                        }
                        else
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("Hakkınız kalmamıştır. " + "Bulmanız gereken sayı:" + rndm1.ToString());
                                break;
                            }
                            Console.WriteLine("Hatalı " + i.ToString() + " Hakkınız kaldı");
                        }
                    }
                    break;
                    #endregion
            }


            Console.ReadKey();
        }
    }
}
