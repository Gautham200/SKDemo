using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using System;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using SKDemo;

var builder = Kernel.CreateBuilder();

builder.Plugins.AddFromType<NewReader>();
builder.Plugins.AddFromType<SaveFile>();
builder.AddAzureOpenAIChatCompletion("YOUR_DEPLOYMENT_NAME", "YOUR_END_POINT", "YOUR_KEY");

Kernel kernel = builder.Build();

var chatSrevice = kernel.GetRequiredService<IChatCompletionService>();

ChatHistory chatMessage = new ChatHistory();


while (true)
{
    Console.WriteLine("Enter message:");
    chatMessage.AddUserMessage(Console.ReadLine());
    
    var completion = chatSrevice.GetStreamingChatMessageContentsAsync(
        chatMessage,
        executionSettings: new OpenAIPromptExecutionSettings
        {
            ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions
        },
        kernel: kernel);

    string fullMessage = "";

    await foreach (var message in completion)
    {
        fullMessage+=message.Content;
    }
    Console.WriteLine(fullMessage);
    chatMessage.AddUserMessage(fullMessage);
    Console.WriteLine();
}