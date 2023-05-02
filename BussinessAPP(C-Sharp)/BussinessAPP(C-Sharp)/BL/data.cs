using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAPP_C_Sharp_.BL
{
    class data
    {
        public string bookList;
        public string names;
        public string passwords;
        public string roles;
        public string reviews;
        public int months;
        public int dates;
        public string fines;
        public string bookBorrow;
        public bool bookWidraw;
        public string userComplaints;
        public bool complaintCheck;
        public bool reviewCheck;
        public bool registeredStudents(List<data> d)
        {

            bool isCheck = false;
            for (int i = 1; i < d.Count; i++)
            {

                if (d[i].names != " " && d[i].passwords != " ")
                {
                    isCheck = true;
                    Console.WriteLine(" Name of Student " + i + ": " + d[i].names);
                    Console.WriteLine(" Password of Student " + i + ": " + d[i].passwords);
                    Console.WriteLine();
                }
            }
            return isCheck;
        }
        public void borrowlist(List<data> d, data[] a)

        {
            for (int x = 1; x < d.Count; x++)
            {
                data m = new data();

                if (m.bookWidraw == true)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Names OF Students Who Borrow The Books Are: " + d[x].names);
                    Console.WriteLine(" Book name Is: " + d[x].bookList);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(" Names OF Student is: " + d[x].names);
                    Console.WriteLine(" Status: No book Has been Borrowed ");
                }
            }
        }
        public bool removeUser(List<data> a, ref string name, ref string password)
        {

            bool isCheck = false;
            for (int index = 1; index < a.Count; index++)
            {
                if (name == a[index].names && password == a[index].passwords)
                {

                    a.RemoveAt(index);
                    isCheck = true;
                    break;
                }
            }
            return isCheck;
        }

        public string changedetails(List<data> a, ref string name, ref string password)
        {

            string isCheck = "false";
            if (name == a[0].names && password == a[0].passwords)
            {

                Console.Write(" Enter New Admin Name: ");
                a[0].names = Console.ReadLine();

                Console.Write(" Enter New Admin Password: ");
                a[0].passwords = Console.ReadLine(); ;



                Console.WriteLine(" Your Id Has Been Updated :");
                isCheck = "true";
            }
            return isCheck;
        }
        public void checkComplaint(List<data> a, data[] s)
        {

            for (int x = 1; x < a.Count; x++)
            {
                data d = new data();
                if (d.complaintCheck == true)
                {
                    Console.WriteLine(" Name of Student is: " + a[x].names);
                    Console.WriteLine(" Complaint is: " + a[x].userComplaints);
                }
                else if (d.complaintCheck == false)
                {
                    Console.WriteLine(" Name of Student is: " + a[x].names);
                    Console.WriteLine(" Complaint Status :  NO complaint has been submitted. ");
                }
                Console.WriteLine();
            }
        }

        public void checkReview(List<data> a, data[] s)
        {
            for (int x = 1; x < a.Count; x++)
            {

                data d = new data();

                if (d.reviewCheck == true)
                {
                    Console.WriteLine(" Name of Student is: " + a[x].names);
                    Console.WriteLine(" Review : " + a[x].reviews);
                }
                else if (d.reviewCheck == false)
                {
                    Console.WriteLine(" Name of Student is: " + a[x].names);
                    Console.WriteLine(" Review Status :  NO review has been added. ");
                }
                Console.WriteLine();
            }
        }

    }



}
}
