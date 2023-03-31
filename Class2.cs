using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_project_example
{
  internal class Class2
  {
    string s1 = @"/C dir c:\jaya\" + Request.QueryString["dir"];
    ProcessStartInfo i1 = new ProcessStrartInfo("CMD.exe", s1);
    Process.Start(i1);
  }
}
