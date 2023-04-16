namespace AdapterPattern
{
    public class TwitterSensitiveWordsFilter
    {
        public string filterSexyWords(string text)
        {
            return $"TwitterSensitiveWordsFilter filter sexy words {text}";
        }

        public string filterPoliticalWords(string text)
        {
            return $"TwitterSensitiveWordsFilter filter political words {text}";
        }
    }
}