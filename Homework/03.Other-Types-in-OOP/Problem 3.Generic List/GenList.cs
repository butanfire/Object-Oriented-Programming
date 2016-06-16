namespace GenericList
{
    using System;
    using System.Text;

    [Version(1, 11)]
    public class GenList<TGen>
    {
        private TGen[] list;
        private int index;
        private int count;
        private const int capacity = 16;

        public GenList(int cap = capacity)
        {
            this.list = new TGen[cap];
            this.index = 0;
            this.count = 0;
        }

        public int ListLength()
        {
            return this.list.Length;
        }

        public void AddElement(TGen e)
        {
            if (this.index >= this.list.Length)
            {
                this.list = autoGrow(this.list);
            }

            this.list[this.index] = e;
            this.index++;
            this.count++;

        }

        private TGen[] autoGrow(TGen[] input)
        {
            GenList<TGen> result = new GenList<TGen>(input.Length * 2);
            input.CopyTo(result.list, 0);
            return result.list;
        }

        public TGen this[int index]
        {
            get
            {
                if (index < 0 || index >= this.list.Length)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
                }

                TGen result = this.list[index];
                return result;
            }

            set
            {
                if (index < 0 || index >= this.list.Length)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid index: {0}.", index));
                }

                this.list[index] = value;
            }
        }

        public void ClearList()
        {
            this.list = new TGen[capacity];
            this.count = 0;
        }

        public bool CheckElement(TGen e)
        {
           for(int i = 0; i < this.count; i++) { 
                if (this.list[i].Equals(e))
                {
                    return true;
                }
            }

            return false;
        }

        public int FindIndexByValue(TGen e)
        {
            for (int i = 0; i < this.list.Length; i++)
            {
                if (this.list[i].Equals(e))
                {
                    return i;
                }
            }

            return -1;
        }

        public void RemoveElementByIndex(int index)
        {
            if (index > this.list.Length || index < 0)
            {
                throw new ArgumentException("RemoveElement : Invalid index");
            }

            TGen[] newList = new TGen[this.list.Length];
            int counter = 0;
            for (int i = 0; i < this.list.Length; i++)
            {
                if (index == i)
                {
                    continue;
                }

                newList[counter] = list[i];
                counter++;
            }

            list = newList;
            this.count--;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                if (this.list[i] != null)
                {
                    output.Append(this.list[i] + " ");
                }
            }

            return output.ToString();
        }

        public string GetVersion()
        {
            var type = typeof(GenList<TGen>);
            var allAttributes = type.GetCustomAttributes(false);
            foreach (var attr in allAttributes)
            {
                var attribute = attr as VersionAttribute;
                if (attribute != null)
                {
                    var version = attribute;
                    return "Version = " + version.Major.ToString() + "." + version.Minor.ToString();
                }
            }

            return " ";
        }
    }
}
