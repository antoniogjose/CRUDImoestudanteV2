using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CRUDImoestudante
{
    public class Pesquisa
    {
        public double lat { get; set; }
        public double lng { get; set; }

        public int radius { get; set; }
        public string type { get; set; }

        public string keyword { get; set; }
        public string key { get; set; }
        //AIzaSyAk7AXTSD8FhpqAixnP6_Alh3uOh4v1198
    }

    public class Location
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Northeast
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Southwest
    {
        public double lat { get; set; }
        public double lng { get; set; }
    }

    public class Viewport
    {
        public Northeast northeast { get; set; }
        public Southwest southwest { get; set; }
    }

    public class Geometry
    {
        public Location location { get; set; }
        public Viewport viewport { get; set; }
    }

    public class Photo
    {
        public int height { get; set; }
        public IList<string> html_attributions { get; set; }
        public string photo_reference { get; set; }
        public int width { get; set; }
    }

    public class OpeningHours
    {
        public bool open_now { get; set; }
        public IList<object> weekday_text { get; set; }
    }

    public class Result
    {
        public Geometry geometry { get; set; }
        public string icon { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public IList<Photo> photos { get; set; }
        public string place_id { get; set; }
        public string reference { get; set; }
        public string scope { get; set; }
        public IList<string> types { get; set; }
        public string vicinity { get; set; }
        public double? rating { get; set; }
        public OpeningHours opening_hours { get; set; }
        public int? price_level { get; set; }
    }

    public class Example
    {
        public IList<object> html_attributions { get; set; }
        public string next_page_token { get; set; }
        public IList<Result> results { get; set; }
        public string status { get; set; }
    }
}