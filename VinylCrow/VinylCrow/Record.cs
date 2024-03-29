﻿using System;
using System.Drawing;

namespace VinylCrow
{
    public class Record
    {
        public int recordId { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public DateTime year { get; set; }
        public string genre { get; set; }
        public string color { get; set; }
        public DateTime dateAdded { get; set; }
        public string condition { get; set; }
        public string pressingNumber { get; set; }
        public bool signed { get; set; }
        public byte[] image { get; set; }
        public bool limited { get; set; }
        public bool seenLive { get; set; }
        public string description { get; set; }
        public string displayTitle { get; set; }
    }
}