using System.Text.Json;
using System;
using System.IO;


namespace Assignment02 {
    public class TvShow{
        public int? id {get; set;}
        public string? backdrop_path {get; set;}     
        public string? name {get; set;}
        public string? origin_country {get; set;}
        public string? original_language {get; set;}
        public string? original_name {get; set;}
        public string? overview {get; set;}
        public decimal? popularity {get; set;}
        public string? poster_path {get; set;}
        public decimal? vote_average {get; set;}
        public int? vote_count {get; set;}
    }
}