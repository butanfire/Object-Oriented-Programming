namespace Problem_5.HTMLDispatcher
{
    public static class HTMLDispatcher
    {
        public static string CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder image = new ElementBuilder("image");
            image.AddAttribute("source", imageSource);
            image.AddAttribute("alt", alt);
            image.AddAttribute("title", title);
            return image.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder URL = new ElementBuilder("url");
            URL.AddAttribute("href", url);
            URL.AddAttribute("title", title);
            URL.AddContent(text);
            return URL.ToString();
        }

        public static string CreateInput(string inputType, string name, string value)
        {
            ElementBuilder CreateURL = new ElementBuilder("input");
            CreateURL.AddAttribute("type", inputType);
            CreateURL.AddAttribute("name", name);
            CreateURL.AddAttribute("value", value);
            return CreateURL.ToString();
        }
    }
}
