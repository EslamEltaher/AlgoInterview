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

//        responseText,
//    }

//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] nk = Console.ReadLine().Split(' ');

//        int n = Convert.ToInt32(nk[0]);

//        int k = Convert.ToInt32(nk[1]);

//        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//        ;
//        int result = countPairs(k, arr);

//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
