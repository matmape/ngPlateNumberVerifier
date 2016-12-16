using System.IO;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace NgPlateVerifier
{
    public static class PlateWebRequest
    {
        private static WebRequest _request;
        private static Stream _dataStream;

        public static string Status { get; set; }

        public static string GetResponse(string url)
        {
            return GetResponse(url, null);
        }

        public static string GetResponse(string url, string baseUrl)
        {
            return GetResponse(url, baseUrl, null);

        }

        public static string GetResponse(string url, string baseUrl, string method)
        {
            return GetResponse(url, baseUrl, method, null);

        }

        private static string GetResponse(string url, string baseUrl, string method, object data)
        {

            string baseUrl1 = baseUrl ;
            _request = WebRequest.Create(baseUrl1 + url);

            _request.Method = method ?? "Get";

            
            byte[] byteArray = new byte[0];
            if (data != null)
            {
                string postData = JsonConvert.SerializeObject(data);
                byteArray = Encoding.UTF8.GetBytes(postData);
                _request.ContentType = "application/json";
                _request.ContentLength = byteArray.Length;


                _dataStream = _request.GetRequestStream();

                _dataStream.Write(byteArray, 0, byteArray.Length);

                _dataStream.Close();
            }


            return GetResponse();
        }


        private static string GetResponse()
        {
            // Get the original response.
            WebResponse response = _request.GetResponse();

            Status = ((HttpWebResponse)response).StatusDescription;

            // Get the stream containing all content returned by the requested server.
            _dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            var reader = new StreamReader(_dataStream);

            // Read the content fully up to the end.
            string responseFromServer = reader.ReadToEnd();

            // Clean up the streams.
            reader.Close();
            _dataStream.Close();
            response.Close();

            return responseFromServer;
        }
    }
}