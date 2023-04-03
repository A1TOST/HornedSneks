﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RetardFilter;

public class FilterConfig
{
    public double Delay { get; set; } = 30000;
    public double Interval { get; set; } = 15000;
    public double CacheSize { get; set; } = 100;

    public FilterConfig()
    {
    }

    public FilterConfig(double delay, double interval, double cacheSize)
    {
        Delay = delay;
        Interval = interval;
        CacheSize = cacheSize;
    }

    public void WriteFile()
    {
        File.WriteAllText(Path.GetFullPath("data/Medusae/RetardFilter/FilterConfig.json"), JsonConvert.SerializeObject(this, Formatting.Indented));
    }
}