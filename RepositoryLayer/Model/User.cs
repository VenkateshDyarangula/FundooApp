using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RepositoryLayer.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { set; get; }
        public string password { get; set; }
        public DateTime createdDate { set; get; }
        public DateTime modifiedDate { set; get; }

    }
}
