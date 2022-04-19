using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

namespace KeliasTarpVietoviu
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Data = Server.MapPath("~/App_Data/U3.txt");
            string Result = Server.MapPath("~/App_Data/Results.txt");

            if (File.Exists(Result))
                File.Delete(Result);
            
            InOutUtils toDo = new InOutUtils();
            toDo.ReadFromFile(Data, out string start, out string finish);
            toDo.PrintToFile(Result, start, finish, 6);
            
        }
    }
}