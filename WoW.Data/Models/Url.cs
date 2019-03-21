using System;
using System.Collections.Generic;
using System.Text;

namespace WoW.Data.Models
{
    public class Url
    {
        public int Id { get; set; }
        //public string Title { get; set; }
        public string UrlPath { get; set; }
        //Imeto ce go vnesuvame tuka dodeka ne ja update databazata ili mozi da ne ni treba
        public string Category { get; set; }
    }
}
