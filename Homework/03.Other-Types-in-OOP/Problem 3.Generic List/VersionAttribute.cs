namespace GenericList
{
    using System;

    [AttributeUsage(AttributeTargets.All)]
    public class VersionAttribute : Attribute
    {
        public VersionAttribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major { get; set; }

        public int Minor { get; set; }
    }
}
