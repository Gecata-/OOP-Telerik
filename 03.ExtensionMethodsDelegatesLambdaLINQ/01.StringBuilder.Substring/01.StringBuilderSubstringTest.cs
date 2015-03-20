
namespace MyStringBuilder
{
    using System.Text;

    using MyStringBuilder.Substring;

    class StringBuilderSubstring
    {
        static void Main()
        {
            StringBuilder stringBuilder = new StringBuilder("Shareno pile pee na sharena ograda.");

            System.Console.WriteLine(stringBuilder.Substring(0,7));
        }
    }
}
