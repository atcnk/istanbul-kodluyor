Print();
FindOrderedProductByProductNumber();
Print();
FindTotalPriceOfShopping();
Print();
WhileAndDoWhile();
Print();
NumberGuessingGame();
Print();
CheckPerfectNumber();
Print();
StringMethods();
Print();
FindAverageGrade();

void Print()
{
    Console.Write("-------------------------------------------\n");
}

void FindOrderedProductByProductNumber()
{
    Console.WriteLine("HANGI URUNUN SIPARIS EDILDIGINI BULAN PROGRAM");
    Print();

    Console.Write("Siparis numarasini (1-5) giriniz: ");
    var orderNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Siparis edilen urun ");

    switch (orderNumber)
    {
        case 1:
            Console.Write(": Bilgisayar.");
            break;
        case 2:
            Console.Write(": Telefon.");
            break;
        case 3:
            Console.Write(": Tablet.");
            break;
        case 4:
            Console.Write(": Televizyon.");
            break;
        case 5:
            Console.Write(": Kulaklik.");
            break;
        default:
            Console.Write(" bulunamamaktadir. Lutfen dogru siparis numarasi girdiginizden emin olun.");
            break;
    }

    Console.WriteLine();
}

void FindTotalPriceOfShopping()
{
    Console.WriteLine("TOPLAM ALISVERIS TUTARINI HESAPLAYAN PROGRAM");
    Print();

    Console.Write("Satin aldiginiz toplam urun sayisini giriniz: ");
    var purchasedProductCount = Convert.ToInt32(Console.ReadLine());
    var totalPrice = 0;

    for (int i = 0; i < purchasedProductCount; i++)
    {
        Console.Write("{0}. satin aldiginz urunun fiyatini giriniz: ", i + 1);
        totalPrice += Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Toplam alisveris tutariniz: {0}", totalPrice);
}

void WhileAndDoWhile()
{
    Console.WriteLine("DO-WHILE VE WHILE DONGULERI");
    Print();

    Console.WriteLine("While, kosul saglandigi surece icerisindeki kod blogunu calistiran bir dongu yapisidir.");
    Console.WriteLine("Do-While'in da calisma mantigi While ile benzer olup tek farki kod blogu 1 kez calistirildiktan sonra kosulu saglayip saglamadigina bakmasidir.");

    var number = 1;

    Console.WriteLine($"Elimizde {number} sayisi var. {number} sayisi 0 sayisina esitse kosuluyla While ve Do While dongulerine girmeye calisalim. ");

    while (number == 0)
    {
        Console.WriteLine("While dongusu icerisine girdik.");
    }

    do
    {
        Console.WriteLine("Do While dongusu icerisine girdik.");
    }
    while (number == 0);
}

void NumberGuessingGame()
{
    Console.WriteLine("SAYI TAHMIN OYUNU");
    Print();

    var random = new Random();
    int number = random.Next(1, 10);

    Console.Write("Sayi tahmin etme oyununa hosgeldiniz!\nLutfen 1 ile 10 arasinda bir sayi giriniz: ");
    var userGuess = Convert.ToInt32(Console.ReadLine());
    var userGuessCount = 1;

    while (userGuess != number)
    {
        Console.Write("Tahmininiz yanlis, lutfen tekrar 1 ile 10 arasinda bir sayi giriniz: ");
        userGuess = Convert.ToInt32(Console.ReadLine());
        userGuessCount++;
    }

    Console.WriteLine("Tebrikler! {0}. tahmininizde dogru sayiyi buldunuz.", userGuessCount);
}

void CheckPerfectNumber()
{
    Console.WriteLine("SAYININ MUKEMMEL OLUP OLMADIGINI KONTROL EDEN PROGRAM");
    Print();

    Console.Write("Lutfen sayiyi giriniz: ");
    var number = Convert.ToInt32(Console.ReadLine());
    var sumOfDivisors = 1;

    for (int i = 2; i < number; i++)
    {
        if (number % i != 0) continue;

        sumOfDivisors += i;
    }
    
    if (number == sumOfDivisors)
    {
        Console.WriteLine("Girdiginiz {0} sayisi mukemmel bir sayidir.", number);
    }
    else
    {
        Console.WriteLine("Girdiginiz {0} sayisi mukemmel bir sayi degildir.", number);
    }
}

void StringMethods()
{
    Console.WriteLine("STRING METOT ORNEKLERI");
    Print();

    var str = "Istanbul Kodluyor";
    var strLength = str.Length;
    var strToUpper = str.ToUpper();
    var strToLower = str.ToLower();
    var str1 = "Istanbul";
    var str2 = "Kodluyor";
    var str3 = string.Concat(str1, str2);
    var firstChar = str[0];
    var indexOfA = str.IndexOf('a');

    Console.WriteLine($"\"{str}\" stringinin uzunlugu: {strLength}");
    Console.WriteLine($"\"{str}\" stringinin buyuk harfli hali: \"{strToUpper}\" ");
    Console.WriteLine($"\"{str}\" stringinin kucuk harfli hali: \"{strToLower}\" ");
    Console.WriteLine($"\"{str1}\" stringiyle ve \"{str2}\" stringini birlestirilmis hali: \"{str3}\"");
    Console.WriteLine($"\"{str}\" stringinin 0. indeksindeki char yani ilk harfi: {firstChar}");
    Console.WriteLine($"\"{str}\" stringindeki \'a\' harfinin indeksi: {indexOfA}");
}

void FindAverageGrade()
{
    Console.WriteLine("NOT ORTALAMASINI HESAPLAYAN PROGRAM");
    Print();

    Console.Write("Toplam ogrenci sayisini giriniz: ");
    var studentCountInput = Console.ReadLine();
    int studentCount;

    while (!(Int32.TryParse(studentCountInput, out studentCount) && studentCount > 0))
    {
        Console.Write("Gecerli bir sayi girmediniz, lutfen tekrar giriniz: ");
        studentCountInput = Console.ReadLine();
    }

    for (int i = 0; i < studentCount; i++)
    {
        Console.Write($"{i + 1}. ogrencinin adini giriniz: ");
        var firstName = Console.ReadLine();

        Console.Write($"{i + 1}. ogrencinin soyadini giriniz: ");
        var lastName = Console.ReadLine();

        var totalExamGrade = 0;

        for (int j = 0; j < 3; j++)
        {
            Console.Write($"{i + 1}. ogrencinin {j + 1}. sinav notunu (0-100) giriniz: ");
            var examGradeInput = Console.ReadLine();
            int examGrade;

            while (!(Int32.TryParse(examGradeInput, out examGrade) && examGrade >= 0 && examGrade <= 100))
            {
                Console.Write("Gecerli bir sayi girmediniz, lutfen tekrar bir sayi (0-100) giriniz: ");
                examGradeInput = Console.ReadLine();
            }

            totalExamGrade += examGrade;
        }

        double averageGrade = Math.Round((double) totalExamGrade / 3, 2);

        Console.WriteLine($"{firstName} {lastName} adli ogrencinin not ortalamasi: {averageGrade}");
    }
}