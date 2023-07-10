using Microsoft.CognitiveServices.Speech;

class Program
{
    static async Task Main()
    {
        // Retrieve the subscription key and region from environment variables
        string subscriptionKey = Environment.GetEnvironmentVariable("COGNITIVE_SERVICES_SUBSCRIPTION_KEY");
        string region = Environment.GetEnvironmentVariable("COGNITIVE_SERVICES_REGION");


        // Configure speech recognition
        var config = SpeechConfig.FromSubscription(subscriptionKey, region);
        config.SpeechRecognitionLanguage = "en-US";

        // Create a speech recognizer
        using (var recognizer = new SpeechRecognizer(config))
        {
            Console.WriteLine("Say something...");

            // Start recognition
            var result = await recognizer.RecognizeOnceAsync();

            // Check recognition result
            if (result.Reason == ResultReason.RecognizedSpeech)
            {
                Console.WriteLine($"Recognized text: {result.Text}");
            }
            else if (result.Reason == ResultReason.NoMatch)
            {
                Console.WriteLine("Speech could not be recognized.");
            }
            else if (result.Reason == ResultReason.Canceled)
            {
                var cancellation = CancellationDetails.FromResult(result);
                Console.WriteLine($"Speech recognition canceled: {cancellation.Reason}");
            }
        }
    }
}
