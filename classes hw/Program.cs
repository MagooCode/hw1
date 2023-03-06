class Program
{
    public static void Main()
    {
        Console.WriteLine(DeleteNullSpace("Hello World"));
    }

    static string DeleteNullSpace(string Sentence)
    {
        char space = ' ';
        char nospace = '\0';
        string newSentence = string.Empty;
        for (int i = 0; i < Sentence.Length; i++)
        {
            if (Sentence[i] == space)
            {
                newSentence += nospace;
            }
            else
            {
                newSentence += Sentence[i];
            }
        }
        return newSentence;
    }
    
}

