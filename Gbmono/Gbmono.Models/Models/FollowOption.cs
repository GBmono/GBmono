using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbmono.Models
{
    public class FollowOption
    {
        [Key,Column(Order =1)]
        public int UserProfileId { get; set; }
        [Key, Column(Order = 2)]
        public int OptionId { get; set; }
        [Key, Column(Order = 3)]
        public short FollowTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
