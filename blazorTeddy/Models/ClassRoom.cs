﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TeddyBlazor.Models
{
    public class ClassRoom
    {

        public int ClassRoomId{ get; set; }
        public string ClassRoomName { get; set; }
        public int SeatsHorizontally { get; set; }
        public int SeatsVertically { get; set; }
    }
}
