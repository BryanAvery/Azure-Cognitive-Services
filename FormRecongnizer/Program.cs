using Azure;
using Azure.AI.FormRecognizer.DocumentAnalysis;

// Retrieve the subscription key and region from environment variables
string subscriptionKey = Environment.GetEnvironmentVariable("COGNITIVE_SERVICES_SUBSCRIPTION_KEY");
string endpoint = Environment.GetEnvironmentVariable("ENDPOINT");

AzureKeyCredential credential = new AzureKeyCredential(subscriptionKey);
DocumentAnalysisClient client = new DocumentAnalysisClient(new Uri(endpoint), credential);

//sample document
Uri fileUri = new Uri("https://raw.githubusercontent.com/Azure-Samples/cognitive-services-REST-api-samples/master/curl/form-recognizer/rest-api/read.png");
AnalyzeDocumentOperation operation = await client.AnalyzeDocumentFromUriAsync(WaitUntil.Completed, "prebuilt-read", fileUri);
AnalyzeResult result = operation.Value;

foreach (DocumentPage page in result.Pages)
{
    Console.WriteLine($"Document Page {page.PageNumber} has {page.Lines.Count} line(s), {page.Words.Count} word(s),");
    Console.WriteLine($"and {page.SelectionMarks.Count} selection mark(s).");

    for (int i = 0; i < page.Lines.Count; i++)
    {
        DocumentLine line = page.Lines[i];
        Console.WriteLine($" Line {i} has content: '{line.Content}'.");
    }
}