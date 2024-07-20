using System.ComponentModel;

Console.Write("Rüya manavında fiyatlar çok uygun!\r\n\r\nElma = 2 TL\r\n\r\nArmut = 3 TL\r\n\r\nÇilek = 2 TL\r\n\r\nMuz = 3 TL\r\n\r\nDiğer bütün meyveler = 4 TL\n\n");

float elma = 2;
float armut = 3;
float cilek = 2;
float muz = 3;
float diger = 4;

Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer):");
string meyve=Console.ReadLine().ToLower();

switch (meyve)
{
    case "elma":
        Console.Write($"Seçtiğiniz meyvenin fiyatı: {elma} TL");
        break;

    case "armut":
        Console.Write($"Seçtiğiniz meyvenin fiyatı: {armut} TL");
        break;

    case "çilek":
        Console.Write($"Seçtiğiniz meyvenin fiyatı: {cilek} TL");
        break;

    case "muz":
        Console.Write($"Seçtiğiniz meyvenin fiyatı: {muz} TL");
        break;
    default:
        Console.Write($"Seçtiğiniz meyvenin fiyatı: {diger} TL");
        break;

}


