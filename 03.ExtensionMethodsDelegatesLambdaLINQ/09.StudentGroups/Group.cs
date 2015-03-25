//Problem 16.* Groups

//Create a class Group with properties GroupNumber and DepartmentName.
//Introduce a property GroupNumber in the Student class.
//Extract all students from "Mathematics" department.
//Use the Join operator.

namespace StudentGroups.MyGroup
{
    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int someGroupNumber, string someDepartmentName)
        {
            this.groupNumber = someGroupNumber;
            this.departmentName = someDepartmentName;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set 
            {
                this.groupNumber = value;
            } 
        }

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }
            private set 
            { 
            } 
        }
    }
}
