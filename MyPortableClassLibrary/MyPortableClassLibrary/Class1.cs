using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyPortableClassLibrary
{
    public class RedditProgrammingClient
    {
        public async Task<List<string>> GetHotThreads()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://www.reddit.com/r/programming/hot/.json?limit=100");

            throw new Exception("Doesn't matter at all!");
        } 
    }
}
