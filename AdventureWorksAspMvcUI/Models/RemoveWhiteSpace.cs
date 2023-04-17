using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace AdventureWorksAspMvcUI.Models
{
    public static class RemoveWhiteSpace
    {
        public static string removeWhiteSpace(this string input)
        {
            return new string(input.Where(c => !Char.IsWhiteSpace(c)).ToArray());
        }
    }
}
