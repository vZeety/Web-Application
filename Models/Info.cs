namespace Resume.Models
{
    public class Info
    {
        private int myid = -1;
        private string name = "N/A";
        private string adress = "N/A";
        private string phonenumber = "N/A";
        private string mail = "N/A";
        private string introduction = "N/A";
        private int eduid = -1;
        private int skillid = -1;
        private int experienceid = -1;

        private bool isNew = false;
        private bool isDirty = false;
        private bool inActive = false;


        public int Myid
        {
            get { return myid; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value;
                  this.isDirty = true;
            }
        }


        public string Adress
        {
            get { return adress; }
            set { this.adress = value;
            this.isDirty = true;}
        }

        public string Phonenumber
        {
            get { return phonenumber; }
            set { this.phonenumber = value;
            this.isDirty = true;}
        }

        public string Mail
        {
            get { return mail; }
            set { this.mail = value;
            this.isDirty = true;}
        }

        public string Introduction
        {
            get { return introduction; }
            set { this.introduction = value;
            this.isDirty = true;}
        }


        public bool IsNew
        {
            get { return this.isNew; }
            set { this.isNew = value; }
        }
        public bool IsDirty
        {
            get { return this.isDirty; }
            set { this.isDirty = value; }
        }

        public bool InActive
        {
            get { return this.inActive; }
            set
            {
                this.inActive = value;
                this.IsDirty = true;
            }


        }

        public int Eduid
        {
            get { return this.eduid; }
            set { this.eduid = value;
            this.isDirty = true;}
        }

        public int Skillid
        {
            get { return this.skillid; }
            set { this.skillid = value;
                this.isDirty = true;
            }
        }

        public int Experienceid
        {
            get { return this.experienceid; }
            set
            {
                this.experienceid = value; this.isDirty = true;
            }
        }


        public Info (string aname, string anadress,string aphonenumber, string amail, string anintroduction ,bool inactive, int aneduid, int askillid,int  anexperienceid)
        {
            //this.Myid = anid;
            this.Name = aname;
            this.Adress = anadress;
            this.Phonenumber = aphonenumber;
            this.Mail = amail;
            this.Introduction = anintroduction;
            this.InActive=inactive;
            this.Eduid = aneduid;
            this.Skillid = skillid;
            this.Experienceid = experienceid;
            this.IsNew = false;
            this.IsDirty = false;
        }

        public Info() : this("N/A","N/A","N/A","N/A","N/A",false,-1,-1,-1) { }


        public override string ToString()
        {
            string message ="MyID: " + this.Myid + "\nName: " + this.Name + "\nAdress: " + this.Adress + "\nPhoneNumber" + this.Phonenumber + "\nMail: " + this.Mail + "\nIsNew: " + this.IsNew + "\nIsDirty: " + this.IsDirty + "\nInactive: " + this.InActive + "\nEduid: " + this.Eduid + "\nSkillid: " + this.Skillid + "ExperienceID: " + this.Experienceid;
            return message;
        }
        public string Display()
        {
            string message = "MyID: " + this.Myid + "<br />Name: " + this.Name + "<br />Adress: " + this.Adress + "<br />PhoneNumber" + this.Phonenumber + "<br />Mail: " + this.Mail + "<br />IsNew: " + this.IsNew + "<br />IsDirty: " + this.IsDirty + "<br />Inactive: " + this.InActive + "<br />Eduid: " + this.Eduid + "<br />Skillid: " + this.Skillid + "<br />ExperienceID: " + this.Experienceid;
            return message;
        }

    }





}
