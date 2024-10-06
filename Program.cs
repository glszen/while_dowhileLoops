using System.ComponentModel.Design;

int sayac = 0;
int limit = 0;

Console.WriteLine("Bir sayı giriniz:");

 limit = Convert.ToInt32(Console.ReadLine());

while (sayac <= limit) //While ile
{
    sayac++;
    Console.WriteLine("Ben bir Patika'lıyım");
}


do //Do-While ile
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}
while (sayac <= limit);

//While ve Do-While arasındaki fark; while ile yanlış (örneğin negatif) bir değer girildiğinde sonuç vermezken do while ile sonuç veriyor çünkü do-while döngüsü bir kez çalışmayı garanti ediyor..
//While ile koşul en başta koyulurken do-while ile en sonda koyuluyor.