// See https://aka.ms/new-console-template for more information
#region Ekrandan Girilen Gunun Hangı Gun Oldugunu Gerıye Donen Method

Console.WriteLine("1-7 arasi bir sayi giriniz: ");
int gun = int.Parse(Console.ReadLine());

var sonuc = GunuBil(gun);
Console.WriteLine(sonuc);
Console.ReadLine();

 

static string GunuBil(int gun)
    {
        switch (gun)
        {
            case (1):
                return "Pazartesi";
                break;
            case (2):
                return "Sali";
                break;
            case (3):
                return "Carsamba";
                break;
            case (4):
                return "Persembe";
                break;
            case (5):
                return "Cuma";
                break;
            case (6):
                return "Cumartesi";
                break;
            case (7):
                return "Pazar";
                break;
            default:
                return"Yanlıs giris yaptınız. 1-7 arası seçim yapiniz.";
                break;
        }

    }

#endregion
