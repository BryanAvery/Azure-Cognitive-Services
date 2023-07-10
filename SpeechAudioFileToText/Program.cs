using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

// Retrieve the subscription key and region from environment variables
string subscriptionKey = Environment.GetEnvironmentVariable("COGNITIVE_SERVICES_SUBSCRIPTION_KEY");
string region = Environment.GetEnvironmentVariable("COGNITIVE_SERVICES_REGION");

// Create the speech config with your subscription key and region
var config = SpeechConfig.FromSubscription(subscriptionKey, region);

// Replace with the name of the audio file you want to transcribe
using var audioInput = AudioConfig.FromWavFileInput("YourAudioFile.wav");

// Creates a speech recognizer using audio file as input.
using var recognizer = new SpeechRecognizer(config, audioInput);
Console.WriteLine("first result pass...");
var result = await recognizer.RecognizeOnceAsync();

// Check if recognition was successful
if (result.Reason == ResultReason.RecognizedSpeech)
{
    Console.WriteLine($"Recognized Text: {result.Text}");
}
else if (result.Reason == ResultReason.NoMatch)
{
    Console.WriteLine("Speech could not be recognised.");
}
else if (result.Reason == ResultReason.Canceled)
{
    var cancellation = CancellationDetails.FromResult(result);
    Console.WriteLine($"Speech recognition canceled: {cancellation.Reason}");

    if (cancellation.Reason == CancellationReason.Error)
    {
        Console.WriteLine($"Cancellation Error Code: {cancellation.ErrorCode}");
        Console.WriteLine($"Cancellation Error Details: {cancellation.ErrorDetails}");
        Console.WriteLine($"Cancellation Did you update the subscription info?");
    }
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();