using System.ComponentModel;
using Microsoft.SemanticKernel;

namespace SKDemo;

public class SaveFile
{
    [KernelFunction("save_file")]
    [Description("Saves a file with the given content")]
    public async Task saveFile(Kernel kernel, string fileName, string content)
    {
        await File.WriteAllTextAsync($"FOLDER_PATH/{fileName}.txt", content);
    }
}