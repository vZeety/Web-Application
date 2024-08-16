namespace Resume.Models
{
    public class Skills
    {
        private int skillid = -1;
        private string skillname = "N/A";
        private string description = "N/A";
        private bool isNew = false;
        private bool isDirty = false;


        public int Skillid
        {
            get { return skillid; }
            set
            {
                this.skillid = value;
                this.isDirty = true;
            }
        }

        public string Skillname
        {
            get { return skillname; }
            set
            {
                this.skillname = value;
                this.isDirty = true;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                this.description = value;
                this.isDirty = true;
            }
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


        public Skills( string askillname, string adescription ) {

            this.Skillname = askillname;
            this.Description = adescription;
            


        
        }


        public Skills() : this("N/A","N/A")
        { }


        public override string ToString()
        {
            string message = "SkillID: " + this.Skillid + "\nSkillName: " + this.Skillname + "\nDescription: " + this.Description + "\nIsNew" + this.IsNew + "IsDirty: " + this.IsDirty;
            return message;
        }

        public string Display() {

            string message = "SkillID: " + this.Skillid + "<br/ >SkillName: " + this.Skillname + "<br/ >Description: " + this.Description + "<br/ >IsNew" + this.IsNew + "<br />IsDirty: " + this.IsDirty;
            return message;

        }

    }
}
