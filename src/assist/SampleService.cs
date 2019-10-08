using System;

public class SampleService : ISampleService
{
    public string GetCurrentDate() => DateTime.Now.ToLongDateString();
}