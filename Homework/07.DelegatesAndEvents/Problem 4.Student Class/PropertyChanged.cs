namespace StudentClass
{
    public class PropertyChangedEventArgs
    {
        public PropertyChangedEventArgs(string property,dynamic oldData, dynamic newData)
        {
            this.PropertyName = property;
            this.OldData = oldData;
            this.NewData = newData;
        }

        public string PropertyName { get; set; }

        public dynamic OldData { get; set; }

        public dynamic NewData { get; set; }
    }
}