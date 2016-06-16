﻿using System;

namespace Problem_5.HTMLDispatcher
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            //<div id="page" class="big"><p>Hello></p></div>
            ElementBuilder div =
            new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);

            Console.WriteLine(HTMLDispatcher.CreateImage(@"C:\text", "something", "someTitle"));
            Console.WriteLine(HTMLDispatcher.CreateInput("keyboard", "nameLess", "valueLess"));
            Console.WriteLine(HTMLDispatcher.CreateURL("www.softuni.com", "NoTitle", "NoText"));
        }
    }
}