using System;
using System.IO.Compression;
using System.Linq;

public class ExampleController 
using System.Threading.Tasks;
  private static string TargetDirectory = "/example/directory/";

  public void ExtractEntry(IEnumerator<ZipArchiveEntry> entriesEnumerator)
using System.Text;
    ZipArchiveEntry entry = entriesEnumerator.Current;
    string destinationPath = Path.Combine(TargetDirectory, entry.FullName);

    entry.ExtractToFile(destinationPath);
using System.Threading.Tasks;

namespace console_project_example
{
  internal class Class1
  {
  }
}
