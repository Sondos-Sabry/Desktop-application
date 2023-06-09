﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp2
{
    [Table("department")]
    public partial class department
    {
        public department()
        {
            students = new HashSet<student>();
        }

        [Key]
        public int id { get; set; }
        [StringLength(50)]
        public string dept { get; set; }
        [StringLength(50)]
        public string lecture { get; set; }

        [InverseProperty("dept")]
        public virtual ICollection<student> students { get; set; }
    }
}