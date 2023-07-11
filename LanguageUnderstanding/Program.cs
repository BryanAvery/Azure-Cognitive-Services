using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime;
using Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models;

// Retrieve the subscription key and region from environment variables
string subscriptionKey = Environment.GetEnvironmentVariable("COGNITIVE_SERVICES_SUBSCRIPTION_KEY");
string appId = Environment.GetEnvironmentVariable("APPID");
string endpoint = Environment.GetEnvironmentVariable("ENDPOINT");

// Create a LUIS runtime client
var credentials = new ApiKeyServiceClientCredentials(subscriptionKey);
var client = new LUISRuntimeClient(credentials)
{
    Endpoint = endpoint
};

// Replace with your query
var query = "What is the weather like today?";

// Predict the intent and entities
var predictionRequest = new PredictionRequest
{
    Query = query
};

var predictionResponse = await client.Prediction.GetSlotPredictionAsync(appId, "production", predictionRequest);

// Process the prediction results
var topIntent = predictionResponse.Prediction.TopIntent;
var entities = predictionResponse.Prediction.Entities;

Console.WriteLine($"Top intent: {topIntent}");
Console.WriteLine("Entities:");

foreach (var entity in entities)
{
    Console.WriteLine($"- {entity.Key}: {entity.Value.First}");
}
