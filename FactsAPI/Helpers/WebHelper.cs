﻿using FactsAPI.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FactsAPI.Helpers
{
    public static class WebHelper
    {
        public static async Task<String> GetJSONDate(string month, string day)
        {
            Debug.WriteLine(month + " : day: " + day);
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add(
                "X-Mashape-Key", "zNB4dsQ6LcmshwwuqK0jT1oZKwzrp1zJH6jjsncb5MpKE0CHGW");


            string loginUrl = "https://numbersapi.p.mashape.com/"+ month+"/" + day+ "/date?fragment=true&json=true";
            HttpResponseMessage response = await httpClient.GetAsync(loginUrl);
            string resp = await response.Content.ReadAsStringAsync();
            var school = JsonConvert.DeserializeObject<MonthFact>(resp);
            Debug.WriteLine(resp);
            return school.text;
        }

        public static async Task<String> GetJSONMath(string number)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add(
                "X-Mashape-Key", "zNB4dsQ6LcmshwwuqK0jT1oZKwzrp1zJH6jjsncb5MpKE0CHGW");


            string loginUrl = "https://numbersapi.p.mashape.com/" + number + "/math?fragment=true&json=true";
            HttpResponseMessage response = await httpClient.GetAsync(loginUrl);
            string resp = await response.Content.ReadAsStringAsync();
            var school = JsonConvert.DeserializeObject<MonthFact>(resp);
            Debug.WriteLine(resp);
            return school.text;
        }

        public static async Task<String> GetTrivia(string number)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add(
                "X-Mashape-Key", "zNB4dsQ6LcmshwwuqK0jT1oZKwzrp1zJH6jjsncb5MpKE0CHGW");


            string loginUrl = "https://numbersapi.p.mashape.com/" + number + "/trivia?fragment=true&json=true";
            HttpResponseMessage response = await httpClient.GetAsync(loginUrl);
            string resp = await response.Content.ReadAsStringAsync();
            var school = JsonConvert.DeserializeObject<MonthFact>(resp);
            Debug.WriteLine(resp);
            return school.text;
        }
    }
}
