using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbmono.Models
{
    public class FollowOption
    {
        public Guid UserId { get; set; }
        public int OptionId { get; set; }
        public short FollowTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
