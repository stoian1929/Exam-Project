using Football.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Football.Models.Footballs
{
    public class Edit
    {
        public string TacticName { get; set; }

        public string Formation { get; set; }

        public PlayerPosition PlayerPosition { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        [ScaffoldColumn(false)]
        public int Id { get; set; }
    }
}