namespace _02Demo_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpellCheckerFactory spellCheckerFactory = new SpellCheckerFactory();
            Console.WriteLine("1 : English, 2: Hindi");
            int choice = Convert.ToInt32(Console.ReadLine());
            ISpellChecker checker = spellCheckerFactory.GetSpellChecker(choice);

            Editor editor = new Editor(checker);
            //Editor editor = new Editor(null);
            editor.SpellCheck("abcd");
            Console.ReadLine();
        }


    }

    public class Editor
    {
        ISpellChecker checker = null;
        public Editor(ISpellChecker somechecker)
        {
            if (somechecker == null)
            {
                checker = new EnglishSpellChecker();
            }
            else
            {
                checker = somechecker;
            }
        }
        public void SpellCheck(string word)
        {
            checker.SpellCheck(word);
        }
    }

    public interface ISpellChecker
    {
        void SpellCheck(string word);
    }

    public class EnglishSpellChecker : ISpellChecker
    {
        public void SpellCheck(string word)
        {
            //logic to check the spelling
            Console.WriteLine("SpellCheck done in English");

        }

    }

    public class HindiSpellChecker : ISpellChecker
    {
        public void SpellCheck(string word)
        {
            //logic to check the spelling
            Console.WriteLine("SpellCheck done in Hindi");

        }

    }


    //This factory is now known as Inversion of Control
    //as this is helping us solve Dependency Injection 
    //Some examples of IOC in market:
    //Singularity, IOC, Windser, Unity
    public class SpellCheckerFactory
    {
        public ISpellChecker GetSpellChecker(int choice)
        {
            if (choice == 1)
            {
                return new EnglishSpellChecker();
            }
            else //if (choice == 2)
            {
                return new HindiSpellChecker();
            }

        }
    }
}
