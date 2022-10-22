using PigLattin;

Console.WriteLine("Pig Latin Translator");

Console.Write("Enter a word: ");
string entry = Console.ReadLine().ToLower();

if (entry == "")
{
    Console.WriteLine("Sorry, please enter a real word.");
}
else
{
    Console.WriteLine(Translator.PigLatinize(entry));
}

