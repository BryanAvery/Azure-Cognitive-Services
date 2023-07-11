using Azure;
using Azure.AI.OpenAI;

// Retrieve the subscription key and region from environment variables
string subscriptionKey = Environment.GetEnvironmentVariable("COGNITIVE_SERVICES_SUBSCRIPTION_KEY");
string endpoint = Environment.GetEnvironmentVariable("ENDPOINT");

OpenAIClient client = new OpenAIClient(new Uri(endpoint), new AzureKeyCredential(subscriptionKey));

string prompt = "What is Azure OpenAI?";

CompletionsOptions completionsOptions = new CompletionsOptions()
{
    Prompts = { prompt }
};

Response<Completions> completionsResponse = client.GetCompletions("myModelDeployment", completionsOptions);
string completion = completionsResponse.Value.Choices[0].Text;
Console.WriteLine($"Chatbot: {completion}");
