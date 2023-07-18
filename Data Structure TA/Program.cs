while (true)
{
    string phrase = null;
    
    
    while (true)
    {
        Console.WriteLine("Please enter a word or phrase.");
        string input = Console.ReadLine().Trim();
        if(input.Any(ch => char.IsDigit(ch)) || input.Any(ch => char.IsSymbol(ch)))
        {
            Console.WriteLine("Invalid Input: Only enter letters.");
        }
        else
        {
            phrase = input;
            break;
        }
    }
    Console.WriteLine($"Your new sentence is \"{StringReversal(phrase).Trim()}\"");
    Console.WriteLine("Go again?");
    if (!Continue())
    {
        Console.WriteLine("Good Bye");
        break;
    }

}

static string StringReversal(string phrase)
{
    string newPhrase = null;
    string newWord = null;
    List<string> words = phrase.Split(" ").ToList();
    Stack<char> letters = new Stack<char>();
    foreach (string word in words)
    {
        letters.Clear();
        newWord = null;

        foreach (char w in word)
        {
            letters.Push(w);
        }
        foreach (char l in letters)
        {
            newWord += l;
        }
        newPhrase += newWord + " ";
    }
    return newPhrase;
}
static bool Continue()
{
    while(true)
    {
        string input = Console.ReadLine().ToLower().Trim();
        if("yes".Contains(input))
        {
            return true;
        }
        if("no".Contains(input))
        {
            return false;
        }
        else
        {
            Console.WriteLine("Invalid Input: only use y/n.");
        }
    }
}