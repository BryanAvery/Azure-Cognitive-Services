using System.Net.Http.Json;

// Retrieve the subscription key and region from environment variables
string subscriptionKey = Environment.GetEnvironmentVariable("COGNITIVE_SERVICES_SUBSCRIPTION_KEY");

// Set the API URL
string visionUrl = $"{Environment.GetEnvironmentVariable("ENDPOINT")}vision/v3.2/analyze";

// Set the image URL
string imageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/Broadway_and_Times_Square_by_night.jpg/450px-Broadway_and_Times_Square_by_night.jpg";

// Set the parameters for the API request
string parameters = "visualFeatures=Categories,Description";

using (HttpClient client = new HttpClient())
{
    client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);

    // Make the API request
    HttpResponseMessage response = await client.PostAsJsonAsync($"{visionUrl}?{parameters}", new { url = imageUrl });

    // Get the response content as a JSON object
    var result = await response.Content.ReadAsStringAsync();

    // Print the response
    Console.WriteLine(result);
}
