using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;


    public class Users
    {
        [Key]
        public int id { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? type_user { get; set; }
        public static Users? currentUser { get; set; }
    }

    public class product
    {
        [Key]
        public int? id { get; set; }
        public string? name { get; set; }
        public int? price { get; set; }
        public static product? currentProduct { get; set; }
    }

