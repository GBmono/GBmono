using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbmono.Models
{
    /// <summary>
    /// Code的属性值
    /// </summary>
    public class CdInstanceProperty
    {
        public int CdInstanceId { set; get; }

        public int CdPropertyId { set; get; }

        public string Value { set; get; }
    }
}
