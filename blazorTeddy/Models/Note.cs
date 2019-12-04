﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeddyBlazor.Models
{
    public class Note
    {
        public int NoteId { get; set; }

        public string Content { get; set; }

        public int StudentId { get; set; }

        public int TeacherId { get; set; }

        public NoteTypes NoteType { get; set; }

        public DateTime DateCreated { get; set; }

        public enum NoteTypes
        {
            None=0,
            Positive=1,
            Negative=2
        }
    }
}
