namespace Resume.Models
{
    public class Experience
    {
        private int experienceid = -1;
        private string companyname = "N/A";
        private string startdate = "N/A";
        private string enddate = "N/A";
        private string description = "N/A";
        private bool isNew = false;
        private bool isDirty = false;



        public int Experienceid
        {
            get { return experienceid; }
            set
            {
                this.experienceid = value;
                this.isDirty = true;
            }
        }

        public string CompanyName
        {
            get { return companyname; }
            set
            {
                this.companyname = value;
                this.isDirty = true;
            }
        }

        public string Startdate
        {
            get { return startdate; }
            set { this.startdate = value;
                this.isDirty = true; }
        }

        public string Enddate
        {
            get { return enddate; }
            set { this.enddate = value;
                this.isDirty = true; }
        }

        public string Description
        {
            get { return description; }
            set { this.description = value;
                this.isDirty = true; }
        }

        public bool IsNew
        {
            get { return isNew; }
            set { this.isNew = value; }
        }

        public bool IsDirty
        {
            get { return isDirty; }
            set { this.isDirty = value; }
        }


        public Experience(string acompanyname, string astartdate, string anenddate, string adescription) {

            this.CompanyName = acompanyname;
            this.Startdate = astartdate;
            this.Enddate = anenddate;
            this.Description = adescription;

        }

        public Experience() : this("N/A", "N/A", "N/A", "N/A")
        {

        }

        public override string ToString()
        {
            string message = "ExperienceID: " + this.Experienceid + "\nCompanyName: " + this.CompanyName + "\nStartDate: " + this.Startdate + "\nEnddate" + this.Enddate + "\nDescription: " + this.Description + "\nIsNew: " + this.IsNew + "\nIsDirty: " + this.IsDirty;
            return message;
        }

        public string Display()
        {
            string message = "ExperienceID: " + this.Experienceid + "<br />CompanyName: " + this.CompanyName + "<br />StartDate: " + this.Startdate + "<br />Enddate" + this.Enddate + "<br />Description: " + this.Description + "<br />IsNew: " + this.IsNew + "<br />IsDirty: " + this.IsDirty;
            return message;
        }
    }

}
