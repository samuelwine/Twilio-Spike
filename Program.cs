using System;
using Twilio;
using Twilio.Rest.Conversations.V1;


class Program
{
    static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // and set the environment variables. See http://twil.io/secure
        string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

        TwilioClient.Init(accountSid, authToken);

        var conversation = ConversationResource.Create(
            friendlyName: "My First Conversation"
        );

        Console.WriteLine(conversation.Sid);
    }
}
