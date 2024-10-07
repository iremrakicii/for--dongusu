
for (int i = 0; i < 10; i++)// Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

for (int i = 1; i <= 20; i++)//1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
{
    Console.WriteLine($"i değeri {i}");
}


for (int i = 2; i <= 20; i += 2) //  1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
{
    Console.WriteLine($"i değeri {i}");
}

int toplam = 0;// 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
for (int i = 50; i <= 150; i++)
{
    toplam += i;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

int teksayi = 0;// 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
for (int i = 1; i <= 120; i += 2)
{
    teksayi += i;
}
Console.WriteLine("1 ile 120 arasında bulunan tek sayıların toplamı:" + teksayi);

int çiftsayi = 0;// 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
for (int i = 2; i <= 120; i += 2)
{
    çiftsayi += i;
}
Console.WriteLine("1 ile 120 arasında bulunan çift sayıların toplamı:" + çiftsayi);
