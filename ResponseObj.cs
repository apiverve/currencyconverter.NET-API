using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("from")]
    public string from { get; set; }

    [JsonProperty("to")]
    public string to { get; set; }

    [JsonProperty("value")]
    public int value { get; set; }

    [JsonProperty("convertedValue")]
    public double convertedValue { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
