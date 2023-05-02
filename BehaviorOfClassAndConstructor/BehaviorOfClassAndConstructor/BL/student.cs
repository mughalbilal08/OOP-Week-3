using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorOfClassAndConstructor.BL
{
   
        class student
        {
            public string sname;
            public float matricMarks;
            public float fscMarks;
            public float ecatMarks;
            public float aggregate;

        public student()
        {
            Console.Write("Default Constructor Called ");
        }
        public student(string sname)
            {
                this.sname = sname;
            }
            public student(student s)
            {
                sname = s.sname;
                matricMarks = s.matricMarks;
                fscMarks = s.fscMarks;
                ecatMarks = s.ecatMarks;
                aggregate = s.aggregate;
            }
        }
        class stdent
        {
            public string sname;
            public float matricMarks;
            public float fscMarks;
            public float ecatMarks;
            public float aggregate;

            public stdent()
            {
                sname = "Jill";
            }
        public stdent(string sname, float matricMarks, float fscMarks, float ecatMarks, float aggregate)
        {
            this.sname = sname;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.aggregate = aggregate;
        }


    }

}
