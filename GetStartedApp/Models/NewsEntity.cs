using System;

public class NewsEntity 
{
    public string Text { get; set; }
    public DateTime PublishDate { get; set; }
    public DateTime PublishTime { get; internal set; }
}