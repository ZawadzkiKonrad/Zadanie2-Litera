
    String imie, nazwisko, plik, path;
    int licznika = 0;
    plik = System.IO.File.ReadAllText(@"C:\test\lorem.txt");

    Console.Write("Wpisz swoje imię i naciśnij ENTER: ");
    imie = Console.ReadLine();
    Console.Write("Podaj swoje nazwisko i naciśnij ENTER: ");
    nazwisko = Console.ReadLine();

    path = @"C:/test/test_" + imie + "_" + nazwisko + ".txt";
    var checkPath = "test_" + imie + "_" + nazwisko;
    if (checkPath.Length > 15)
    {
        String newimie = imie.Substring(0, 3);
        String newnazwisko = nazwisko.Substring(0, 3);
        path = @"C:/test/test_" + newimie + "_" + newnazwisko + ".txt";

    }

    File.WriteAllText(path, plik);
    for (int i = 0; i < plik.Length; i++)
    {

        if (plik[i] == 'a')
        {
            licznika++;
        }
    }
    Console.Write("Liczba liter a: " + licznika);
    Console.Write("Liczba wszystkich znaków: " + plik.Length);

