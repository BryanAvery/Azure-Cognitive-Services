## Azure Cognitive Services Examples

Welcome to the Azure Cognitive Services Examples GitHub repository! This repository provides a collection of practical and illustrative examples showcasing the capabilities of Azure Cognitive Services. These examples demonstrate how to leverage powerful artificial intelligence (AI) and machine learning (ML) capabilities to enhance your applications and solve real-world challenges.

### Service Examples Included

1. **Azure Computer Vision**: Explore examples that demonstrate image recognition, object detection, optical character recognition (OCR), and image analysis. From detecting faces in images to extracting text from documents, these examples showcase the versatility and accuracy of Azure Computer Vision.

2. **Azure Speech Services**: Discover examples that leverage speech recognition and synthesis capabilities. Build applications that can transcribe audio files, convert text to speech, and even enable real-time speech translation across languages using Azure Speech Services.

3. **Azure Language Understanding (LUIS)**: Dive into examples that demonstrate how to create language models and train them to understand user intents. These examples cover scenarios such as building chatbots, creating voice assistants, and enabling natural language understanding in your applications.

4. **Azure Text Analytics**: Gain insights from text with examples that showcase sentiment analysis, key phrase extraction, and language detection. Harness the power of Azure Text Analytics to analyze social media feeds, customer reviews, and text data from various sources.

5. **Azure Translator**: Explore examples that utilize Azure Translator to enable language translation in your applications. These examples demonstrate how to translate text, documents, and even entire websites effortlessly, breaking down language barriers and enabling global communication.

6. **Azure Form Recognizer**: Discover examples that showcase the capabilities of Azure Form Recognizer. This service enables automated data extraction from structured documents, such as receipts, invoices, and forms, facilitating efficient data processing and analysis.

### How to Use

Each service within this repository contains its own dedicated folder, housing multiple examples and accompanying documentation. You can navigate through the folders and explore the examples relevant to your use case.

For each example, you'll find comprehensive documentation, including step-by-step instructions, code samples, and configuration guidance. This documentation will help you understand the capabilities of Azure Cognitive Services and provide a solid foundation for integrating these services into your applications.

### Contributing

We welcome contributions to this repository! If you have an example or an improvement suggestion, feel free to submit a pull request. Please refer to the contributing guidelines for more details on how to contribute to this project.

### Get Started

Get started now by cloning this repository and exploring the diverse examples available for Azure Cognitive Services. Empower your applications with AI and ML capabilities, enhance user experiences, and unlock new possibilities for your projects. We hope you find these examples helpful in leveraging the power of Azure Cognitive Services. Happy coding!

### Environment Variables

Visual Studio provides a convenient way to set and manage environment variables during development. Here's how you can use the development environment in Visual Studio to set the required environment variables:

Open your project in Visual Studio.

Right-click on the project in the Solution Explorer and select "Properties" from the context menu.

In the project properties window, go to the "Debug" tab.

Under the "Environment Variables" section, you can add the required environment variables and their values. In your case, add the following variables:

Variable: COGNITIVE_SERVICES_SUBSCRIPTION_KEY, Value: YourSubscriptionKey
Variable: COGNITIVE_SERVICES_REGION, Value: YourRegion
Replace YourSubscriptionKey and YourRegion with your actual API key and region.

Click "OK" to save the project properties.

Now, when you run the project from Visual Studio, it will automatically use the environment variables you set in the development environment. These values will be retrieved using Environment.GetEnvironmentVariable in your code, as shown in the previous example.

By setting the environment variables within Visual Studio, you don't need to manually manage them every time you run your code from within the development environment. This allows for a smoother development experience while keeping the sensitive information separate from your code repository.
