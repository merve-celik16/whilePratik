


//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız



int i = 0;
while (i <= 10) 
{
    i++;
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}


//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
Console.WriteLine("---------------------------");
Console.WriteLine("1 ile 20 arasındaki sayılar : ");

int a = 1;
while (a <= 20) 
{
    a++;
    Console.WriteLine(a);
}


//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
Console.WriteLine("---------------------------");


int b = 1;
while (b <= 20) 
{
    b++;

    if (b %2==0) 
    {
        Console.WriteLine(b);
    }

}


//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
Console.WriteLine("---------------------------");
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı :");
int toplam = 0;
int c = 50;
while (c <= 150) 
{
   
    toplam=toplam+c;
    c++;
}
Console.WriteLine(" Toplam = " +toplam);


//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
Console.WriteLine("---------------------------");
Console.WriteLine(" 1 ile 120 arasındaki tek ve çift sayıların toplamı : ");

int tekToplam = 0; //tek sayıların toplamını tutan değişken
int ciftToplam = 0; // çift sayıların toplamını tutan değişken
int k = 1;
while (k <= 120) 
{
    if ((k % 2) == 0) // sayıların çift olanlarını bulur.
    {
        ciftToplam = ciftToplam + k; //çift sayıları toplamına ekler

        k++;
    }
    else
    {
        tekToplam = tekToplam + k; // aksi halde tek sayıları toplamına ekler

        k++;
    }

    
}

Console.WriteLine(" Çift sayıların toplamı = " + ciftToplam);
Console.WriteLine(" Tek sayıların toplamı = " + tekToplam);