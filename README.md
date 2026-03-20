# SKDemo

A console application demonstrating the use of Microsoft Semantic Kernel with Azure OpenAI for chat-based interactions, including plugins for fetching news and saving files.

## Features

- Interactive chat interface powered by Azure OpenAI
- Plugin to retrieve top 5 news items from New York Times RSS feeds by category
- Plugin to save text content to files
- Automatic tool invocation for kernel functions

## Prerequisites

- .NET 10.0 or later
- Azure OpenAI service with a deployed model
- API key and endpoint for Azure OpenAI

## Setup

1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd SKDemo
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Update the Azure OpenAI configuration in `Program.cs`:
   - Replace `"YOUR_DEPLOYMENT_NAME"` with your Azure OpenAI deployment name
   - Replace `"YOUR_END_POINT"` with your Azure OpenAI endpoint
   - Replace `"YOUR_KEY"` with your Azure OpenAI API key

4. Build the project:
   ```bash
   dotnet build
   ```

## Usage

Run the application:
```bash
dotnet run
```

The application will start an interactive chat loop. You can:

- Ask for news by category (e.g., "Get me the latest technology news")
- Request to save content to a file (e.g., "Save this text to a file named notes")

The Semantic Kernel will automatically invoke the appropriate plugins based on your requests.

## Project Structure

- `Program.cs`: Main application entry point and chat loop
- `NewReader.cs`: Plugin for fetching news from NYT RSS feeds
- `SaveFile.cs`: Plugin for saving text content to files

## Dependencies

- Microsoft.SemanticKernel
- Microsoft.SemanticKernel.Connectors.AzureOpenAI
- SimpleFeedReader
- Azure.AI.OpenAI

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request

## License

This project is licensed under the MIT License.
