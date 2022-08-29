using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Async
{
    public class WebSiteTracker
    {
        public async Task Tracker(List<string> website)
        {
            
            using var client = new HttpClient();
            var watch = new Stopwatch();
            var watch2 = new Stopwatch();
            watch2.Start();
            foreach (var item in website)
            {
                
                watch.Start();

                var content= await client.GetStringAsync(item);
                var count = content.Count();
                watch.Stop();
                var responseTimeForCompleteRequest = watch.ElapsedMilliseconds;
                
                Console.WriteLine($"Character Count = {count} Time = {responseTimeForCompleteRequest}");
                watch.Reset();
            }
            watch2.Stop();
            Console.WriteLine($"{watch2.ElapsedMilliseconds} ms");
            Console.WriteLine(new String('_', 70));


        }
        public async Task TaskAsync(List<string> website)
        {
            HttpClient client = new HttpClient();

            List<Task<string>> tasks = new List<Task<string>>();
            Stopwatch watch = new Stopwatch();
            foreach (string url in website)
            {
                tasks.Add(client.GetStringAsync(url));
            }
            watch.Start();

            await Task.WhenAll(tasks);
            watch.Stop();
            foreach (var task in tasks)
            {
                Console.WriteLine($"Character Count = {task.Result.Length} Time = {watch.ElapsedMilliseconds}");
            }
            Console.WriteLine(new String('_', 70));
           

        }
    }
}
