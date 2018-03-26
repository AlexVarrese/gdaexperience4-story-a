using System;

namespace ContosoAir.Clients
{
    public static class GlobalSettings
    {
        public const string ContosoAirEndpoint = "https://contosoairprod-api-mtczerocfa.azurewebsites.net/";
        public const string AuthenticationTokenEndpoint = "https://api.cognitive.microsoft.com/sts/v1.0";
        public const string SpeechRecognitionEndpoint = "https://speech.platform.bing.com/recognize";

        public const string SkypeBotAccount = "28:d38b16ab-1762-4914-9aeb-c0bcaf411e38";
        public const string FacebookBotAccountAndroid = "fb-messenger://user/";
        public const string FacebookBotAccount = "fb-messenger-public://user-thread/";
        public const string FacebookBotAccountId = "260313431102859";
        public const string CognitiveServicesKey = "6da9d3af982248789ab383bff698dd26";//"9d9c35e88d474674a8e8b6f04de75a96";//"6da9d3af982248789ab383bff698dd26";//"8475871faed346eda4abc75ae27dd88d"; 
        public const string BingSpeechApiKey = "372131cee1ab4b38b11d42a9ac924db0";//"e4d4520cc2d1442d89debbbb1d9909e0";
        public const string AudioContentType = @"audio/wav; codec=""audio/pcm""; samplerate=16000";
        public const string AudioFilename = "ContosoAir.wav";
        public const int DefaultDelayedTime = 20; // in seconds
        public const int DefaultFeedbackTime = 120; // in seconds

        // Default DateTime in views
        public static readonly DateTime MyTripsDepartDate = new DateTime(2017, 4, 4);

        // Azure B2C settings
        public const string ClientId = "8db29c10-50c7-416f-b1c9-795c9592ab4e";
        public static string Authority = "https://login.microsoftonline.com/";
        public const string Tenant = "onemtcb2c.onmicrosoft.com";
        public const string SignUpSignInPolicy = "B2C_1_Contosoair";

        // Azure Push Notification
        public const string NotificationHubConnectionString = "Endpoint=sb://c2crohitnotificationnamespace.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=A+Y31883Vo9CuGe34QmOhnmxmwcHtZR3YmAIJEdqHo8=";
        public const string NotificationHubName = "c2cRohitNotificationHub";

        // HockeyApp
        public const string HockeyAppiOS = "c5564727a8d94d99b6e8e51505842fd8";
        public const string HockeyAppAndroid = "a24b7677201a48a38f9ad1e0eec7fc90";
        public const string HockeyAppUWP = "89e906b5e04e43d396971aa9e6d4361f";

        // Android
        public const string AndroidProjectNumber = "";
        public const string AndroidPackageId = "com.contoso.air";

        public const string GetFlightDetailsUrl = "https://azurefunctionrohit.azurewebsites.net/api/selectFlightData?code=yy5jWad0aH7TdT4vkCTM/4OH3fBg1hEi1A1U/tsqTQqacxvXi1vi0g==";
        public const string LogicAppUrl = "https://prod-47.westus.logic.azure.com:443/workflows/725d67e23a7a47aeaa23e4aa397fa93b/triggers/request/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Frequest%2Frun&sv=1.0&sig=meaxumdtDyvmec-or6AfT9VizPx-wF_aRm_u7qX-ODE";
        public const string FaceAPIEndpointUrl = "https://westus.api.cognitive.microsoft.com/face/v1.0/detect";

    }
}