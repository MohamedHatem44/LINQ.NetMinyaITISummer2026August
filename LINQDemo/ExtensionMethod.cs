namespace LINQDemo
{
    public static class ExtensionMethod
    {
        public static int GetWordsCount(this string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                int count = text.Split(' ').Length;
                return count;
            }
            return 0;
        }
    }
}