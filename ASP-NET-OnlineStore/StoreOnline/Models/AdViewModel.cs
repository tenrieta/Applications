﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreOnline.Models
{
    public class Adviewmodel
    {

        public int pro_id { get; set; }
        public string pro_name { get; set; }
        public string pro_image { get; set; }
        public Nullable<int> pro_price { get; set; }
        public Nullable<int> pro_fk_ad { get; set; }
        public Nullable<int> pro_fk_user { get; set; }
        public int cat_id { get; set; }
        public string cat_name { get; set; }
        public string u_name { get; set; }
        public string u_image { get; set; }
        public string u_contact { get; set; }

    }
}