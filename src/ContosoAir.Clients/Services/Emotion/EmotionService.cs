using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ContosoAir.Clients.Helpers;
using Microsoft.ProjectOxford.Emotion;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Globalization;
using Newtonsoft.Json;
using ContosoAir.Clients.Models;

namespace ContosoAir.Clients.Services.Emotion
{
    public class EmotionService : IEmotionService
    {
        public float floatVal;
        public static List<FaceAPIResponse> mylist;
        public double happyness = 0;

        public async Task<float> GetHappinessAsync(Stream streams)
        {
            string contentString;
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Settings.CognitiveServicesKey);
            string requestParameters = "returnFaceAttributes=emotion";
            string uri = Settings.FaceAPIEndpointUrl + "?" + requestParameters;

            HttpResponseMessage response;
            BinaryReader binaryReader = new BinaryReader(streams);
            byte[] byteData = binaryReader.ReadBytes((int)streams.Length);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(uri, content);
                contentString = await response.Content.ReadAsStringAsync();
            }

            mylist = JsonConvert.DeserializeObject<List<FaceAPIResponse>>(contentString);

            foreach (FaceAPIResponse item in mylist)
            {
                happyness = item.faceAttributes.emotion.happiness;
            }

            floatVal = (float)happyness;
            return floatVal;
        }

        public async Task<float> GetAverageHappinessScoreAsync(Stream streams)
        {
            string contentString;
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", Settings.CognitiveServicesKey);
            string requestParameters = "returnFaceAttributes=emotion";
            string uri = Settings.FaceAPIEndpointUrl + "?" + requestParameters;

            HttpResponseMessage response;
            BinaryReader binaryReader = new BinaryReader(streams);
            byte[] byteData = binaryReader.ReadBytes((int)streams.Length);

            using (ByteArrayContent content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(uri, content);
                contentString = await response.Content.ReadAsStringAsync();
            }

            mylist = JsonConvert.DeserializeObject<List<FaceAPIResponse>>(contentString);

            foreach (FaceAPIResponse item in mylist)
            {
                happyness = item.faceAttributes.emotion.happiness;
            }

            floatVal = (float)happyness;
            return floatVal;
        }

    }
}
