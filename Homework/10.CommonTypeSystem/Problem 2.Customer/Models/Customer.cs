namespace Customer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer : ICloneable, IComparable<Customer>
    {
        private string fname;
        private string mname;
        private string lname;
        private string id;
        private string permaddress;
        private string email;
        private string phone;


        public Customer(string fname, string mname, string lname, string id, string permaddrr, string mail, string phone, CustomerTypes type)
        {
            this.FirstName = fname;
            this.MiddleName = mname;
            this.LastName = lname;
            this.ID = id;
            this.PermAddress = permaddrr;
            this.Email = mail;
            this.Payments = new List<Payment>();
            this.Phone = phone;
            this.Type = type;
        }

        public string FirstName
        {
            get
            {
                return this.fname;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("FirstName cannot be null");
                }

                this.fname = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.mname;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("MiddleName cannot be null");
                }

                this.mname = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lname;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("LastName cannot be null");
                }

                this.lname = value;
            }
        }

        public string ID
        {
            get
            {
                return this.id;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("ID cannot be null");
                }

                this.id = value;
            }
        }

        public string PermAddress
        {
            get
            {
                return this.permaddress;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Permament address cannot be null");
                }

                this.permaddress = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone cannot be null");
                }

                this.phone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be null");
                }

                this.email = value;
            }
        }

        public CustomerTypes Type { get; set; }

        public List<Payment> Payments { get; }

        public void AddPayment(Payment payArgument)
        {
            this.Payments.Add(payArgument);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append(string.Format("{0} {1} {2} ", this.FirstName, this.MiddleName, this.LastName));
            output.Append(string.Format("{0} {1} {2} ", this.ID, this.PermAddress, this.Email));
            output.Append(string.Format("{0} {1}", this.Phone, this.Type));
            
            if (this.Payments != null)
            {
                output.AppendLine();
                output.AppendLine("Payments : ");
                foreach (var items in this.Payments)
                {
                    output.AppendLine(items.Price + items.ProductName);
                }
            }

            return output.ToString();
        }

        public override bool Equals(object obj)
        {
            var other = obj as Customer;
            if (other != null)
            {
                return object.Equals(this.ID, other.ID);
            }

            return false;
        }

        public static bool operator ==(Customer obj1, Customer obj2)
        {
            return Customer.Equals(obj1, obj2);
        }

        public static bool operator !=(Customer obj1, Customer obj2)
        {
            return !(obj1 == obj2);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public object Clone()
        {
            var newCustomer = new Customer(
               this.FirstName,
               this.MiddleName,
               this.LastName,
               this.ID,
               this.PermAddress,
               this.Email,
               this.Phone,
               this.Type);

            foreach (var payment in this.Payments)
            {
                newCustomer.AddPayment(payment);
            }

            return newCustomer;
        }

        public int CompareTo(Customer other)
        {
            var comparator = string.Compare($"{this.FirstName} {this.MiddleName} {this.LastName}", $"{other.FirstName} {other.MiddleName} {other.LastName}", StringComparison.Ordinal);

            return comparator == 0 ? this.ID.CompareTo(other.ID) : comparator;
        }
    }
}
