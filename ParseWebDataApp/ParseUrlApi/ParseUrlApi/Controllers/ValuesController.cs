using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;
using System.IO;

namespace ParseUrlApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(string base64encode_url)
        {
            //get url from caller
            string strUrl = Encoding.GetEncoding("utf-8").GetString(Convert.FromBase64String(base64encode_url));
            string gethtml = string.Empty;

            //取得網頁原始碼
            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;
            Byte[] pageData = MyWebClient.DownloadData(strUrl);
            gethtml = Encoding.UTF8.GetString(pageData); 
            
            //System.Diagnostics.Process.Start("view-source:" + strUrl);

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUrl);
            //HttpWebResponse webresponse = (HttpWebResponse)request.GetResponse();
            //StreamReader streamReader = new StreamReader(webresponse.GetResponseStream(), Encoding.UTF8);

            //gethtml = streamReader.ReadToEnd();
            //webresponse.Close();
            return gethtml;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
