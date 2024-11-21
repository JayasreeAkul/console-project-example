using System;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_project_example
{
  public class ExampleController
  {
    private static string TargetDirectory = "/example/directory/";

    public void ExtractEntry(IEnumerator<ZipArchiveEntry> entriesEnumerator)
    {
      ZipArchiveEntry entry = entriesEnumerator.Current;
      string destinationPath = Path.Combine(TargetDirectory, entry.FullName);

      // Ensure the directory exists before extracting the file
      string directoryPath = Path.GetDirectoryName(destinationPath);
      if (!Directory.Exists(directoryPath))
      {
        Directory.CreateDirectory(directoryPath);
      }

      entry.ExtractToFile(destinationPath);
    }
  }

  internal class Class1
  {
    // Class1 can remain empty or you can add functionality here
  }
}
