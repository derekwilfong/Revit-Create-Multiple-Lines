#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;

using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
#endregion

namespace CreateMultipleLines_R3
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {

            try
            {
                UIApplication uiapp = commandData.Application;
                UIDocument uidoc = uiapp.ActiveUIDocument;
                Application app = uiapp.Application;
                Document doc = uidoc.Document;

                Settings settings = doc.Settings;
                Categories cats = settings.Categories;
                Category lineCat = cats.get_Item(BuiltInCategory.OST_Lines);

                using (Transaction tx = new Transaction(doc))
                {
                    tx.Start("Create Multiple Lines R2");

                    foreach (var value in LineStandards.Taco.sauce.Values)
                    {
                        Category lineStyleCat = cats.NewSubcategory(lineCat, value);
                        lineStyleCat.LineColor = new Color(0, 0, 225);
                        lineStyleCat.SetLineWeight(1, GraphicsStyleType.Projection);
                    }

                    tx.Commit();
                }
                return Result.Succeeded;
            }
            catch (Exception)
            {
                TaskDialog.Show("Nope", "Did not work");

            }
            return Result.Succeeded;

        }

    }
}
