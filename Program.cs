// See https://aka.ms/new-console-template for more information
using SpamDetector;


//Load sample data
var sampleData = new Spam.ModelInput()
{
    Subject = @"Meeting tomorrow at 10 AM",
    Content = @"Hi team, Just a reminder that we have our weekly project status meeting tomorrow at 10 AM in Conference Room B. Please bring your status reports and be prepared to discuss the timeline updates. Thanks, Sarah",
};

//Load model and predict output
var result = Spam.Predict(sampleData);


Console.WriteLine(result.PredictedLabel);
