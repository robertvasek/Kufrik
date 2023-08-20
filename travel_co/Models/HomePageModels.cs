﻿public class Post
{
    public int Id { get; set; }
    public string Title { get; set; } = "unset";
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Subtitle { get; set; } = "unset";
    public string Content { get; set; } = "unset";
    public string[] ImageUrls { get; set; } = { };
}

public class Question
{
    public string QuestionQ { get; set; } = "unset";
    public string AnswerQ { get; set; } = "unset";
}

public class Trip
{
    public int Id { get; set; }
    public string Country { get; set; } = "unset";
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Price { get; set; }
    public int Capacity { get; set; }
    public string ShortDescription { get; set; } = "unset";
    public string[] ImageUrls { get; set; } = { };
}

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; } = "unset";
    public string Capital { get; set; } = "unset";
    public Currency CountryCurrency { get; set; }
    public Language CountryLanguage { get; set; }
    public int Area { get; set; }
    public int Population { get; set; }
    public string[] ImageUrls { get; set; } = { };
}

public enum Currency
{
    EUR,
    CZK,
    PLN,
    USD,
    GBP,
    JPY,
    AUD,
    CAD,
}

public enum Language
{
    Čeština,
    Slovenčina,
    Němčina,
    Angličtina,
    Španělština,
    Francouzština,
    Polština,
    Japonština,
}