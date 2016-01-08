using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gbmono.Models
{
    public class Commodity
    {
        public int Id { get; set; }

        #region category
        public int CategoryId { get; set; }
        #endregion

        #region 促销活动, 消费券, topics
        #endregion

        #region basic data
        public string CommodityName { get; set; }
        public string CommodityName2 { get; set; }

        //brands id ,TODO: brands table
        public int BrandsId { get; set; }

        //flavor table? capacity ml? g?

        public string Barcode { get; set; }

        public decimal SalePrice { get; set; }

        public string PhotoPath { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime OnDate { get; set; }
        public DateTime OffDate { get; set; }
        #endregion


        #region 收费数据库
        #endregion
    }
}
