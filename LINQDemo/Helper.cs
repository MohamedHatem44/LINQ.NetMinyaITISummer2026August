namespace LINQDemo
{
    public class Helper
    {
        public static int GetWordsCount(string text)
        {
            if(!string.IsNullOrWhiteSpace(text))
            {
                int count = text.Split(' ').Length;
                return count;
            }
            return 0;
        }
    }
}