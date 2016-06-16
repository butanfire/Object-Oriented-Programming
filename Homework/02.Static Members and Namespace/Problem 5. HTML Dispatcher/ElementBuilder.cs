namespace Problem_5.HTMLDispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ElementBuilder
    {
        private string elementName;
        private string content;

        public ElementBuilder(string element)
        {
            this.Attributes = new Dictionary<string, string>();
            this.ElementName = element;
        }

        public string ElementName
        {
            get
            {
                return this.elementName;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Element cannot be null");
                }

                this.elementName = value;
            }
        }

        private Dictionary<string, string> Attributes { get; }

        public void AddAttribute(string attribute, string value)
        {
            if (string.IsNullOrEmpty(attribute) || string.IsNullOrEmpty(value))
            {
                throw new InvalidOperationException("Cannot add empty attribute/value");
            }

            this.Attributes.Add(attribute, value);
        }

        public void AddContent(string content)
        {
            this.content += content;
        }

        public static string operator *(ElementBuilder element, int number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException("Cannot multiply by a negative number");
            }

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                output.Append(element);
            }

            return output.ToString();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append($"<{this.ElementName}");

            foreach (var attr in this.Attributes)
            {
                output.Append($@" {attr.Key}=""{attr.Value}""");
            }
            output.Append(">");
            if (this.content != null)
            {
                output.Append($"{this.content}");
            }
            output.Append($@"</{this.ElementName}>");

            return output.ToString();
        }
    }
}
