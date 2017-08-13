using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
  class Program
  {
    static HttpWebRequest GetRequest(string uri)
    {
      return (HttpWebRequest)WebRequest.Create("http://localhost:9200" + uri);
    }
    static void Bulk()
    {
      var data = File.ReadAllBytes(@"..\..\..\bulk.txt");
      var request = GetRequest("/_bulk");
      request.Method = "POST";
      request.GetRequestStream().Write(data, 0, data.Length);
      var response = request.GetResponse();

    }
    static void Main(string[] args)
    {
      Bulk();
    }
  }
}
