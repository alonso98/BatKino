using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cinema.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string Treiler { get; set; }
        public double RatingIMDb { get; set; }
        public double RatingKinoPoisk { get; set; }
        public byte[] ImgFront { get; set; }
        public byte[] ImgBack { get; set; }
    }
}