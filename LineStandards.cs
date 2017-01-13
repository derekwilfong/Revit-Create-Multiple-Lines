using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System.Collections;

namespace CreateMultipleLines_R3
{


    public class LineStandards
    {




        //private string butter;

        //public string Butter
        //{
        //    get { return Taco.sauce.ToString(); }
        //}

        //public LineStandards(/*int a, string b*/)
        //{
        //    butter = Taco.sauce.ToString();
        //}




        public class Taco
        {
            public static Dictionary<int, string> sauce = new Dictionary<int, string>()
        {
            {1, "Smokey" },
            {2, "Bob" },
            {3, "Hot Stuff" },
            {4, "Boogie" }

        };
        }


    }

}




