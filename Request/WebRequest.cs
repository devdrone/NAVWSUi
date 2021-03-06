﻿using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Request
{
    public class WebRequest
    {
        public string Resopnse(string URL, string username, string password)
        {
            HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create(URL);
            ASCIIEncoding encoding = new ASCIIEncoding();
            request.Method = "GET";
            NetworkCredential credential = new NetworkCredential(username, password);
            request.Credentials = credential;
            request.ContentType = "text/xml; charset=utf-8";


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            return responseFromServer;
        }

        public XElement Request(string soaprequest, string soapAction, string URL, string username, string password)
        {
            var header = string.Format("SOAPAction:\"{0}\"", soapAction);
            HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create(URL);
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytesToWrite = encoding.GetBytes(soaprequest);

            request.Method = "POST";
            request.ContentLength = bytesToWrite.Length;
            request.Headers.Add(header);
            //request.UseDefaultCredentials = true;
            NetworkCredential credential = new NetworkCredential(username, password);
            request.Credentials = credential;
            request.ContentType = "text/xml; charset=utf-8";

            Stream newStream = request.GetRequestStream();
            newStream.Write(bytesToWrite, 0, bytesToWrite.Length);
            newStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            var parsedResopnse = XElement.Parse(responseFromServer);
            return parsedResopnse;
        }
    }
}
