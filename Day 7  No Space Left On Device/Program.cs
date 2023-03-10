namespace Day_7__No_Space_Left_On_Device;

static class App
{
   public static async Task Main()
   {
      //string[] input = (await RequestInput()).Trim().Split("\n");

      StreamReader reader = new StreamReader("../../../input.txt");
      string[] input = (await reader.ReadToEndAsync()).Split("\n", StringSplitOptions.RemoveEmptyEntries);

      Solution solution = new Solution(input);
      Console.WriteLine(solution.SumOfAllDirWithAtMost100M);
      Console.WriteLine(solution.SizeOfSmallestButEnoughtDir);
   }

   static async Task<string> RequestInput()
   {
      HttpClient client = new HttpClient(new HttpClientHandler());

      HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://adventofcode.com/2022/day/7/input");
      request.Headers.Add("authority", "adventofcode.com");
      request.Headers.Add("accept",
            "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8");
      request.Headers.Add("accept-language", "en-US,en;q=0.7");
      request.Headers.Add("cache-control", "max-age=0");
      request.Headers.Add("cookie",
            "session=53616c7465645f5f295196da90cb714f78cd7fe801a0b978bc85addd06bbad97646fa4c6fee0db1837731c5322035e04add240cfedee23709da4b44b3097cd46");
      request.Headers.Add("referer", "https://adventofcode.com/2022/day/7");
      request.Headers.Add("sec-fetch-dest", "document");
      request.Headers.Add("sec-fetch-mode", "navigate");
      request.Headers.Add("sec-fetch-site", "same-origin");
      request.Headers.Add("sec-fetch-user", "?1");
      request.Headers.Add("sec-gpc", "1");
      request.Headers.Add("upgrade-insecure-requests", "1");
      request.Headers.Add("user-agent",
            "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36");

      HttpResponseMessage response = await client.SendAsync(request);
      response.EnsureSuccessStatusCode();
      return await response.Content.ReadAsStringAsync();
   }
}
