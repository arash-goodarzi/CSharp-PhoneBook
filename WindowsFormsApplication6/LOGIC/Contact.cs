using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.LOGIC
{
    public class Contact
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = DataText.FirstCharToUpper(value); }
        }
        private string phone_cell;

        public string Phone_cell
        {
            get { return phone_cell; }
            set { phone_cell = value; }
        }
        private string phone_home;

        public string Phone_home
        {
            get { return phone_home; }
            set { phone_home = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string photo;

        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public Contact()
        {
            this.name = "";
            this.phone_cell = "";
            this.phone_home = "";
            this.email = "";
            this.photo = "";
        }

        public override string ToString()
        {
            return this.name + " | " + this.phone_cell + " | " + this.phone_home + " | " + this.email+ " | " +this.photo;
        }
    }
}
