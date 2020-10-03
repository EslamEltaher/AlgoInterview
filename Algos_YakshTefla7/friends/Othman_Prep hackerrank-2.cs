////30
//using System.Collections.Generic;
//using System;
//using System.Net.Http;

//class Solution
//{
//    private const string API_URL = "https://jsonmock.hackerrank.com/api/movies/search/Title={0}";
//    // Complete the pylons function below.
//    static int GetNumberOfMovies(string substr)
//    {
//        var url = string.Format(API_URL, substr);

//        var client = new HttpClient();
//        var data = client.GetAsync(url).Result;
//        if (data.StatusCode != System.Net.HttpStatusCode.OK)
//            throw new Exception("Status Code is:" + data.StatusCode);
        
//        var responseText = data.Content.ReadAsStringAsync().Result;

//        var startIndex = responseText.IndexOf("total\":") + "total\":".Length;
//        var endIndex = responseText.IndexOf(",", startIndex);
//        var numString = responseText.Substring(startIndex, endIndex - startIndex);

//        Console.WriteLine(numString);

//        return Convert.ToInt32(numString);
//    }

//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        
//        int result = GetNumberOfMovies(Console.ReadLine());

//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
