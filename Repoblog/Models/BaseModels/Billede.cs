﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Repoblog.Models.BaseModels
{
    public class Billede
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public string Filnavn { get; set; }
    }
}
