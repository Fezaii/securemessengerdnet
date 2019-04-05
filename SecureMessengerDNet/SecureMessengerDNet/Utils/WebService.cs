using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;


namespace SecureMessengerDNet
{
        public class WebRequestPostExample
        {
        /*
        private const string RequestUriString = "http://baobab.tokidev.fr/api/login";

        public static void Main()
            {
                // Create a request by using a URL that can receive a post.   
                WebRequest request = WebRequest.Create(RequestUriString);
                // Set the Method property of the request to POST.  
                request.Method = "POST";

                // Create POST data and convert it to a byte array.  
                string postData = "This is a test that posts this string to a Web server.";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                // Set the ContentType property of the request.  
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the request.  
                request.ContentLength = byteArray.Length;

                // Get the request stream.  
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.  
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the stream.  
                dataStream.Close();

                // Get the response.  
                WebResponse response = request.GetResponse();
                // Display the status.  
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                // Get the stream containing content returned by the server.  
                dataStream = response.GetResponseStream();
                // Open the stream by using a StreamReader for easy access.  
                StreamReader reader = new StreamReader(dataStream);

                // Read the content.  
                string responseFromServer = reader.ReadToEnd();
                // Display the content.  
                Console.WriteLine(responseFromServer);

                // Clean up the response.  
                reader.Close();
                response.Close();
            }*/
        }
}
