namespace Resume.Models
{
    public class Education
    {
        private int eduid = -1;
        private string description = "N/A";
        private string date = "N/A";
        private string major = "N/A";
        private string minor = "N/A";
        private bool isDirty = false;
        private bool isNew = false;



        public int Eduid
        {
            get { return eduid; }
        }

        public string Description
        {
            get { return description; }
            set { this.description = value;
                this.isDirty = true; 
            }
        }

        public string Date
        {
            get { return date; }
            set { this.date = value;
                this.isDirty = true;
            }
        }

        public string Major
        {
            get { return major; }
            set { this.major = value;
                this.isDirty = true;
            }
        }

        public string Minor
        {
            get { return minor; }
            set { this.minor = value;
            this.isDirty = true;}
        }

        public bool IsDirty
        {
            get { return isDirty; }
            set {  isDirty = value;}
        }

        public bool IsNew
        {
            get { return isNew; }
            set { isNew = value;}
        }


        public Education (string adescription, string adate,string amajor, string aminor)
        {
            this.Description = adescription;
            this.Date = adate;
            this.Major = amajor;
            this.Minor = aminor;
        }

        public Education (): this("N/A", "N/A", "N/A", "N/A")
        {

        }

        public override string ToString()
        {
            string message = "ID: " + this.Eduid + "\nDescription: " + this.Description + "\nDate: " + this.Date + "\nMajor" + this.Major + "\nMinor: " + this.Minor + "\nIsNew: " + this.IsNew + "\nIsDirty: " + this.IsDirty;
            return message;
        }

        public  string Display()
        {
            string message = "ID: " + this.Eduid + "<br/ >Description: " + this.Description + "<br/ >Date: " + this.Date + "<br />Major" + this.Major + "<br />Minor: " + this.Minor + "<br />IsNew: " + this.IsNew + "<br/ >IsDirty: " + this.IsDirty;
            return message;
        }
    }


}
