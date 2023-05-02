using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorOfClassAndConstructor.BL
{
    class assessH
    {
        public string sname;
        public float matricMarks;
        public float fscMarks;
        public float ecatMarks;
        public float aggregate;

        public assessH()
        {
            sname = "Jill";
            matricMarks = 985F;
            fscMarks = 1050F;
            ecatMarks = 175F;
            aggregate = 81.87F;
        }
        public assessH(string sname, float matricMarks, float fscMarks, float ecatMarks, float aggregate)
        {
            this.sname = sname;
            this.matricMarks = matricMarks;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.aggregate = aggregate;
        }

    }

}
