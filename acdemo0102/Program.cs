using OpenAI_API;
using OpenAI_API.Completions;
using OpenAI_API.Models;

Console.WriteLine("Hello, World!");

var api = new OpenAIAPI("YOUR_API_KEY_HERE");

var prompt = "A long time ago, in a galaxy far, far away..";

var request = new CompletionRequest
{
    Prompt = prompt,
    Model = Model.DavinciText,
    MaxTokens = 100,
    Temperature = 0.7
};

var response = await api.Completions.CreateCompletionAsync(request);

Console.WriteLine("Generated Text:");
Console.WriteLine(response.Completions[0].Text);



