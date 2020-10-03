////30
//using System.Collections.Generic;
//using System;
//using System.Net.Http;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//using System.Linq;

//class Solution
//{
//    private const string API_URL = "https://jsonmock.hackerrank.com/api/movies/search/Title={0}";
//    private const string paginationPart = "&page={1}";
//    // Complete the pylons function below.
//    static string[] GetMovieTitles(string substr)
//    {

//        //var client = new HttpClient();
//        //var data = client.GetAsync(url).Result;
//        //if (data.StatusCode != System.Net.HttpStatusCode.OK)
//        //    throw new Exception("Status Code is:" + data.StatusCode);

//        ////{"page":1,"per_page":10,"total":2770,"total_pages":277,"data":[{"Title":"Waterworld","Year":1995,"imdbID":"tt0114898"},{"Title":"Waterworld","Year":1995,"imdbID":"tt0189200"},{"Title":"The Making of 'Waterworld'","Year":1995,"imdbID":"tt2670548"},{"Title":"Waterworld 4: History of the Islands","Year":1997,"imdbID":"tt0161077"},{"Title":"Waterworld","Year":1997,"imdbID":"tt0455840"},{"Title":"Waterworld","Year":1997,"imdbID":"tt0390617"},{"Title":"Swordquest: Waterworld","Year":1983,"imdbID":"tt2761086"},{"Title":"Behind the Scenes of the Most Fascinating Waterworld on Earth: The Great Backwaters, Kerala.","Year":2014,"imdbID":"tt5847056"},{"Title":"Louise's Waterworld","Year":1997,"imdbID":"tt0298417"},{"Title":"Waterworld","Year":2001,"imdbID":"tt0381702"}]}
//        //var responseText = data.Content.ReadAsStringAsync().Result;

//        ////Get Titles
//        //JObject response = JsonConvert.DeserializeObject<JObject>(responseText);

//        //int pages = (int)response["total_pages"];
//        //JArray moviesArray = (JArray)response["data"];
//        //var titles = moviesArray.Select(m => ((JObject)m["Title"]).ToString()).ToList();

//        int currentPage = 1;
//        var titles = new List<string>();


//        var responseObject = HttpGetBySubStrAndPage(substr, currentPage);
//        titles.AddRange(GetTitles(responseObject));

//        int pages = (int)responseObject["total_pages"];

//        for (currentPage = 2; currentPage <= pages; currentPage++)
//        {
//            responseObject = HttpGetBySubStrAndPage(substr, currentPage);
//            titles.AddRange(GetTitles(responseObject));
//        }


//        return titles.ToArray();
//    }

//    public static string httpGetByUrl(string url)
//    {
//        var client = new HttpClient();
//        var data = client.GetAsync(url).Result;
//        if (data.StatusCode != System.Net.HttpStatusCode.OK)
//            throw new Exception("Status Code is:" + data.StatusCode);

//        //{"page":1,"per_page":10,"total":2770,"total_pages":277,"data":[{"Title":"Waterworld","Year":1995,"imdbID":"tt0114898"},{"Title":"Waterworld","Year":1995,"imdbID":"tt0189200"},{"Title":"The Making of 'Waterworld'","Year":1995,"imdbID":"tt2670548"},{"Title":"Waterworld 4: History of the Islands","Year":1997,"imdbID":"tt0161077"},{"Title":"Waterworld","Year":1997,"imdbID":"tt0455840"},{"Title":"Waterworld","Year":1997,"imdbID":"tt0390617"},{"Title":"Swordquest: Waterworld","Year":1983,"imdbID":"tt2761086"},{"Title":"Behind the Scenes of the Most Fascinating Waterworld on Earth: The Great Backwaters, Kerala.","Year":2014,"imdbID":"tt5847056"},{"Title":"Louise's Waterworld","Year":1997,"imdbID":"tt0298417"},{"Title":"Waterworld","Year":2001,"imdbID":"tt0381702"}]}
//        var responseText = data.Content.ReadAsStringAsync().Result;

//        return responseText;
//    }
//    public static JObject HttpGetBySubStrAndPage(string substr, int page)
//    {
//        var url = string.Format(API_URL, substr);
//        if (page > 1)
//            url = string.Format(API_URL + paginationPart, substr, page);

//        var responseText = httpGetByUrl(url);

//        return JsonConvert.DeserializeObject<JObject>(responseText);
//    }
//    public static IEnumerable<string> GetTitles(JObject response)
//    {
//        JArray moviesArray = (JArray)response["data"];
//        var titles = moviesArray.Select(m => ((JObject)m)["Title"].ToString());
//        return titles;
//    }
    

//    public static void Main(string[] args)
//    {
//        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        string[] result = GetMovieTitles(Console.ReadLine());
//        //textWriter.WriteLine(result);

//        //textWriter.Flush();
//        //textWriter.Close();

//        foreach (var title in result)
//            Console.WriteLine(title);

//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}
