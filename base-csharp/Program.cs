// Boucle while infinie pour garder la console ouverte
while (true)
{
    // Déclaration d'une variable de type string?, le ? pour indiquer que la valeur peut-être 'null' et qui récupère ce que l'utilisateur tape dans la console
    string? line = Console.ReadLine();

    // Appelle notre fonction 'CountVowels' avec notre variable line
    CountVowels(line);
}


/* Écrivez une fonction qui compte le nombre de voyelles d'une ligne de texte */
void CountVowels(string line)
{
    // Condition if, si notre variable line (ligne de texte entré par l'utilisateur dans la console) est null ou vide
    if (string.IsNullOrEmpty(line))
    {
        // Message l'indiquant de taper du texte dans la console en premier
        Console.WriteLine("type something first to count all the vowels in it ...");
        // Instruction return pour ignorer le code après notre condition
        return;
    }

    // Déclaration d'une variable de type Array contenant nos voyelles
    char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
    // Déclaration d'une variable de type int, utilisation de Linq Count pour compter chaque char character contenu dans notre string line et présent dans notre Array vowels
    int vowelsCount = line.Count(character => vowels.Contains(char.ToLower(character)));

    // Affiche notre nombre de voyelles trouvées
    Console.WriteLine($"vowels count in {line} are : {vowelsCount}");
}

/* Écrivez une fonction qui compte le nombre de voyelles d'une ligne de texte avec l'aide dune boucle for */
void CountVowelsForLoop(string line)
{
    // Condition if, si notre variable line (ligne de texte entré par l'utilisateur dans la console) est null ou vide
    if (string.IsNullOrEmpty(line))
    {
        // Message l'indiquant de taper du texte dans la console en premier
        Console.WriteLine("type something first to count all the vowels in it ...");
        // Instruction return pour ignorer le code après notre condition
        return;
    }

    // Déclaration d'une variable de type int qui s'incrémente à chaque fois qu'une voyelle est trouvée
    int vowelsCount = 0;

    // Déclaration d'une variable de type Array contenant nos voyelles
    char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };

    // Boucle for qui itère jusqu'à la fin de notre string line
    for (int i = 0; i < line.Length; i++)
    {
        // Condition if, si notre variable vowels contient le char à l'index i 'line[i]' alors il s'agit d'une voyelle
        // char.ToLower pour passer notre char en minuscule et éviter les problèmes de comparaisons
        if (vowels.Contains(char.ToLower(line[i])))
        {
            // Incrémente notre variable pour garder le nombre de voyelles trouvées
            vowelsCount++;
        }
    }

    // Affiche notre nombre de voyelles trouvées
    Console.WriteLine($"vowels count in {line} are : {vowelsCount}");
}

/* Écrivez une fonction qui retourne les nombres pairs de 2 à 20 à l'aide dune boucle for */
void EvenNumber()
{
    // Première solution
    // Boucle for, qui commence à l'index 2 'i = 2', qui itère tant que l'index i est inférieur ou égale à 20
    for (int i = 2; i <= 20; i++)
    {
        // Condition if, si index i modulo 2 est égale à zero alors le nombre est pair
        if (i % 2 == 0)
        {
            Console.WriteLine($"solution #1 {i} is even ...");
        }
    }

    // Deuxième solution
    // Boucle for, qui commence à l'index 2 'i = 2', qui itère tant que l'index i est inférieur ou égale à 20 et qui s'incrémante de 2 en 2
    for (int i = 2; i <= 20; i += 2)
    {
        Console.WriteLine($"solution #2 {i} is even ...");
    }
}

/* Écrivez une fonction qui demande à l'utilisateur d'entrer un nombre entier positif 
et qui calcule et affiche la somme des carrés des nombres de 1 à ce nombre à l'aide d'une boucle while. 
*/
void SquareSum(string line)
{
    // Condition if, si notre variable line (ligne de texte entré par l'utilisateur dans la console) est null ou vide
    if (string.IsNullOrEmpty(line))
    {
        // Message l'indiquant de taper du texte dans la console en premier
        Console.WriteLine("type in a number to get the sum total of the squares of each number from 1 to the number you entered ...");
        // Instruction return pour ignorer le code après notre condition
        return;
    }

    // Condition if, si notre variable string line ne contient PAS un integer valide on sort de la fonction et retourne un résultat NULL
    if (!int.TryParse(line, out int endNumber))
    {
        Console.WriteLine($"{line} is not a valid int number ...");
        // Instruction return pour ignorer le code après notre condition
        return;
    }

    // Condition if, si le nombre entré dans notre line est inférieur à 0 (négatif, -1, -2 ...) on sort de la fonction et retourne un résultat NULL
    if (endNumber < 0)
    {
        Console.WriteLine("type in a positive number ...");
        return;
    }

    // Déclaration d'une variable sumSquare de type int qui servira à ajouter la somme des carré issus de notre boucle while
    int sumSquare = 0;

    // Déclaration d'une variable de type int qui servira de point de départ pour notre boucle while
    int startNumber = 1;
    // Boucle while qui itère tant que le nombre de départ startNumber est inférieur ou égal à notre nombre de fin endNumber
    while (startNumber <= endNumber)
    {
        // Ajoute le résultat du calcule du carré du nombre startNumber (startNumber * startNumber) à la variable sumSquare
        sumSquare += startNumber * startNumber;
        // Ajoute + 1 à notre nombre de départ
        startNumber++;
    }

    // Affiche le résultat de la somme de nos carrés contenus dans notre variable sumSquare
    Console.WriteLine($"the sum of the squares for the numbers from 1 to {endNumber} are : {sumSquare}");
}

/* Écrivez une fonction qui demande à l'utilisateur d'entrer une ligne de texte, et qui retourne toutes les voyelles de celle-ci */
void FindVowels(string line)
{
    // Condition if, si notre variable line (ligne de texte entré par l'utilisateur dans la console) est null ou vide
    if (string.IsNullOrEmpty(line))
    {
        // Message l'indiquant de taper du texte dans la console en premier
        Console.WriteLine("type something first to find all the vowels in it ...");
        // Instruction return pour ignorer le code après notre condition
        return;
    }

    // Déclaration d'une variable result de type List, contenant des char (a, b, c ...)
    List<char> result = new List<char>();

    // Déclaration d'une variable vowels de type Array contenant nos voyelles
    char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };

    // Boucle foreach qui itère chaque char character dans notre string line
    foreach (char character in line)
    {
        // Condition if, si notre variable vowels contient le char character alors il s'agit d'une voyelle
        // char.ToLower pour passer notre character en miniscule, même si l'utilisateur tape en majuscule A, E la condition fonctionnera
        if (vowels.Contains(char.ToLower(character)))
        {
            // On ajoute le char character à la List result
            result.Add(character);
        }
    }

    // Condition if, si notre liste est vide (contient 0 élément)
    if (result.Count == 0)
    {
        Console.WriteLine($"no vowels found in {line}");
        // Instruction return pour ignorer le code après notre condition
        return;
    }

    // Affiche le résultat utilisation de string.Join pour joindre notre List de char result est séparer chaque char avec ', '
    Console.WriteLine($"vowels found in {line} are : {string.Join(", ", result)}");
}