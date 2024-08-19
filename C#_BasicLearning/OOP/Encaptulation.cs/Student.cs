using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encaptulation.cs
{
    public class Student
    {
        private string fName;
        private string lName;

        public string FName
        {
            get { return fName; }   
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string FullNameGet()
        {
            return fName + " " + lName; 
        }
    }
    public class UniversityInfo
    {
        private string universityName;
        private int universityId;
        private string uniAddress;

        public string UniversityName
        {
            get { return universityName; }
            set { universityName = value;}
        }
        public int UniversityId
        {
            get { return universityId; }
            set { universityId = value; }
        }
        public string UniAddress
        {
            get { return uniAddress; }
            set { uniAddress = value; }
        }

        public void FullUniversityInfo()
        {
            Console.WriteLine("Name: {0} Id: {1} Address: {2}", UniversityName, UniversityId, UniAddress);
        }
    }
}
