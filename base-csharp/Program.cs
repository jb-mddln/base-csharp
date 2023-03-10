ShowMinAndMaxGradesStudents();

// Boucle while infinie pour garder la console ouverte
while (true)
{
    // Déclaration d'une variable de type string?, le ? pour indiquer que la valeur peut-être 'null' et qui récupère ce que l'utilisateur tape dans la console
    string? line = Console.ReadLine();
}

/* Écrire une fonction qui utilise un dictionnaire pour stocker les notes des étudiants et qui donne la note max et min de chaque étudiant. */
void ShowMinAndMaxGradesStudents()
{
    Dictionary<string, double[]> notes = new Dictionary<string, double[]>();
    notes.Add("Abdoulaye", new double[] { 6.5, 11, 13, 15.5 });
    notes.Add("Alexandre", new double[] { 17, 12, 11, 16.5 });
    notes.Add("Aurore", new double[] { 18.5, 7.5, 14, 9.5 });

    foreach (KeyValuePair<string, double[]> note in notes)
    {
        Console.WriteLine($"{note.Key} minimal grade is : {note.Value.Min()} and his max is : {note.Value.Max()}");
    }
}


/* Écrire un fonction qui utilise un dictionnaire pour stocker les notes des étudiants et qui calcule la moyenne de chaque étudiant. */
void ShowAvegareGradesStudents()
{
    Dictionary<string, double[]> notes = new Dictionary<string, double[]>();
    notes.Add("Abdoulaye", new double[] { 6.5, 11, 13, 15.5 });
    notes.Add("Alexandre", new double[] { 17, 12, 11, 16.5 });
    notes.Add("Aurore", new double[] { 18.5, 7.5, 14, 9.5 });

    foreach (KeyValuePair<string, double[]> note in notes)
    {
        Console.WriteLine($"The average grades of {note.Key} is : {Math.Round(note.Value.Average(), 2)}");
    }
}

/* https://leetcode.com/problems/palindrome-number/description/ */
bool IsPalindrome(int integer)
{
    // 123 = '123' avec ToString puis avec Reverse ='3', '2' , '1' en char et pour finir string.Concat = '321'
    string reverseString = string.Concat(integer.ToString().Reverse());

    // Condition if, si mon string reverseString n'est pas égale à integer en string alors ce n'est pas un palindrome
    if (!string.Equals(reverseString, integer.ToString()))
        return false;

    // Si reverse string == integer alors il s'agit d'un palindrome
    return true;
}

/* https://leetcode.com/problems/valid-parentheses/ */
bool CheckParentheses(string line)
{
    Stack<char> stack = new Stack<char>();
    Dictionary<char, char> mappings = new Dictionary<char, char>() 
    {
        { ')', '(' },
        { '}', '{' },
        { ']', '[' }
    };
    foreach (char character in line)
    {
        if (mappings.ContainsKey(character))
        {
            if (stack.Count == 0)
                return false;

            if (stack.Pop() != mappings[character])
                return false;
        }
        else
        {
            stack.Push(character);
        }
    }
    return stack.Count == 0;
}

/* Écrivez une fonction qui utilise un dictionnaire pour stocker les fréquences des mots dans une phrase */
/* exemple : "ma box internet blabla box" box = 2 fois dans la phrase */

void CountSameWords(string line)
{
    // Déclaration d'une variable de type Dictionary contenant nos mots string et leur nombre de répétitions int
    Dictionary<string, int> results = new Dictionary<string, int>();

    // Déclaration d'une variable de type Array string, utilisation de split pour découper notre ligne et séparer chaque mot
    string[] splitted = line.ToLower().Split(" ");

    // Boucle foreach, chaque mot dans notre Array string splitted
    foreach (string word in splitted)
    {
        // Condtion if, si notre mot est contenu dans notre dictionnaire results alors on incrémente le nombre de répétitions
        if (results.ContainsKey(word))
        {
            results[word]++;
        }
        else // else, sinon il n'est pas dans notre dictionnaire alors on l'ajoute
        {
            results.Add(word, 1);
        }
    }

    // Déclaration d'une variable pour mettre dans l'ordre croissant nos mots et le nombre de répétitions
    IOrderedEnumerable<KeyValuePair<string, int>> sortedByCount = results.OrderBy(result => result.Value);

    // Boucle foreach, itère chaque mot et son nombre de répétition 
    foreach (KeyValuePair<string, int> result in sortedByCount)
    {
        // Affiche le mot et le nombre de répétition
        Console.WriteLine($"word {result.Key} count : {result.Value}");
    }
}

/* https://leetcode.com/problems/roman-to-integer */
int RomanToInteger(string line)
{
    Dictionary<char, int> romans = new()
    {
        { 'I', 1 }, 
        { 'V', 5 }, 
        { 'X', 10 },
        { 'L', 50 }, 
        { 'C', 100 }, 
        { 'D', 500 }, 
        { 'M', 1000 }
    };

    int sum = 0;
    for (int i = 0; i < line.Length; i++)
    {
        int current = romans[line[i]];
        int next = 0;

        if (i < line.Length - 1)
        {
            next = romans[line[i + 1]];
        }

        if (current < next)
        {
            sum -= current;
        }
        else
        {
            sum += current;
        }
    }

    return sum;
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
    // Déclaration d'une variable de type List int qui servira pour afficher nos nombres pairs sur une ligne dans la console
    List<int> evenNumbers = new List<int>();

    // Première solution
    // Boucle for, qui commence à l'index 2 'i = 2', qui itère tant que l'index i est inférieur ou égale à 20
    for (int i = 2; i <= 20; i++)
    {
        // Condition if, si index i modulo 2 est égale à zero alors le nombre est pair
        if (i % 2 == 0)
        {
            // Ajoute i à notre List
            evenNumbers.Add(i);
        }
    }

    Console.WriteLine($"solution #1 even numbers from 2 to 20 are : {string.Join(", ", evenNumbers)}");

    // Vide notre liste
    evenNumbers.Clear();

    // Deuxième solution
    // Boucle for, qui commence à l'index 2 'i = 2', qui itère tant que l'index i est inférieur ou égale à 20 et qui s'incrémante de 2 en 2
    for (int i = 2; i <= 20; i += 2)
    {
        evenNumbers.Add(i);
    }

    Console.WriteLine($"solution #2 even numbers from 2 to 20 are : {string.Join(", ", evenNumbers)}");
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
        // Instruction return pour ignorer le code après notre condition
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