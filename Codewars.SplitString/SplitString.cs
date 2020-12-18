namespace Codewars.SplitString
{
    public class SplitString
    {
        internal static string[] Solution(string text)
        {
            if(text.Length%2 >0)
            {
                text += "_";
            }

            var totalSplitString = text.Length / 2;
            string[] splitString = new string[totalSplitString];

            // abc ==> string[] {"ab", "c_"}
            // abcdef ==> string[] {"ab, "cd", "ef"}
            for (int i = 0, j = 0; i < totalSplitString; i++, j += 2)
            {
                splitString[i] = text.Substring(j, 2);
            }
            return splitString;
        }
    }
}