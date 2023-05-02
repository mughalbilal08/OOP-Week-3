using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessAPP_C_Sharp_.BL
{
    class detailB
    {
        public string bookList;
        public string bookAuthur;
        public string bookPublish;
        public string addbooks(List<detailB> det, ref int size)
        {
            string isAdd = "false";
            for (int index = 0; index < size; index++)
            {
                detailB v = new detailB();

                Console.Write(" Enter Book Name: ");
                v.bookList = Console.ReadLine();

                Console.Write(" Enter Authuor Name: ");
                v.bookAuthur = Console.ReadLine();

                Console.Write(" Enter Publish Year: ");
                v.bookPublish = Console.ReadLine();
                det.Add(v);
                isAdd = "true";
            }
            
            return isAdd;
        }
        public bool searchBooks(List<detailB> g, string search)
        {

            bool isCheck = false;
            for (int index = 0; index < g.Count; index++)
            {
                if (search == g[index].bookList)
                {
                    isCheck = true;
                    break;
                }
            }
            return isCheck;
        }
        public void viewDetails(List<detailB> g)
        {
            for (int i = 0; i < g.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine(" Book Name " + i + " is: " + g[i].bookList);
                Console.WriteLine(" Author of book " + i + " is: " + g[i].bookAuthur);
                Console.WriteLine(" Publish Date of Book " + i + " is: " + g[i].bookPublish);
                Console.WriteLine();
            }
        }
        public void checkRbooks(List<detailB> d, ref string remove, ref string auhtor)
        {

            for (int index = 0; index < d.Count; index++)
            {
                if (remove == d[index].bookList && auhtor == d[index].bookAuthur)
                {

                    d.RemoveAt(index);
                    Console.Write(" Book Has Been Removed.");
                    break;
                }
                else
                {
                    Console.Write("Irrelevent Details");
                }
            }

        }
    }
}
