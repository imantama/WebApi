using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    [Table("Tb_M_Department")]
    public class Department
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Division> Divisions { get; internal set; }

        public Department()
        {

        }
    }
}