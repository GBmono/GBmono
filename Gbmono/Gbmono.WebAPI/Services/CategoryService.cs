using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using Gbmono.Models;

namespace Gbmono.WebAPI.Services
{
    public class CategoryService
    {
        public async Task<List<Category>> GetAllCagegory()
        {
            var result = await Task<List<Category>>.Run(() =>
            {
                var data = new List<Category>();
                data = GetTempCategoryList();
                return data;
            });


            return result;
        }


        private List<Category> GetTempCategoryList()
        {
            var result = new List<Category>();
            //医药品・医药部外品
            //1
            result.Add(new Category() { CategoryId = 1, CategoryCode = "01", Name = "医药品・医药部外品", ParentId = 0 });
            //2
            result.Add(new Category() { CategoryId = 2, CategoryCode = "01", Name = "饮料", ParentId = 1 });
            result.Add(new Category() { CategoryId = 3, CategoryCode = "02", Name = "维他命", ParentId = 1 });
            result.Add(new Category() { CategoryId = 4, CategoryCode = "03", Name = "感冒", ParentId = 1 });
            result.Add(new Category() { CategoryId = 5, CategoryCode = "04", Name = "过敏", ParentId = 1 });
            result.Add(new Category() { CategoryId = 6, CategoryCode = "05", Name = "肠胃药", ParentId = 1 });
            result.Add(new Category() { CategoryId = 7, CategoryCode = "06", Name = "眼药水", ParentId = 1 });
            result.Add(new Category() { CategoryId = 8, CategoryCode = "07", Name = "外用药", ParentId = 1 });
            result.Add(new Category() { CategoryId = 9, CategoryCode = "08", Name = "育发", ParentId = 1 });
            result.Add(new Category() { CategoryId = 10, CategoryCode = "09", Name = "女性・汉方", ParentId = 1 });
            result.Add(new Category() { CategoryId = 11, CategoryCode = "10", Name = "其他", ParentId = 1 });
            //3
            result.Add(new Category() { CategoryId = 12, CategoryCode = "01", Name = "恢复疲劳类饮料", ParentId = 2 });
            result.Add(new Category() { CategoryId = 13, CategoryCode = "02", Name = "美容饮料", ParentId = 2 });
            result.Add(new Category() { CategoryId = 14, CategoryCode = "01", Name = "维他命剂（固体・粉粉・颗粒）", ParentId = 3 });
            result.Add(new Category() { CategoryId = 15, CategoryCode = "01", Name = "解热镇痛药", ParentId = 4 });
            result.Add(new Category() { CategoryId = 16, CategoryCode = "02", Name = "综合感冒药", ParentId = 4 });
            result.Add(new Category() { CategoryId = 17, CategoryCode = "03", Name = "止咳", ParentId = 4 });
            result.Add(new Category() { CategoryId = 18, CategoryCode = "01", Name = "各种过敏・鼻炎药", ParentId = 5 });
            result.Add(new Category() { CategoryId = 19, CategoryCode = "01", Name = "肠胃药", ParentId = 6 });
            result.Add(new Category() { CategoryId = 20, CategoryCode = "02", Name = "整肠药", ParentId = 6 });
            result.Add(new Category() { CategoryId = 21, CategoryCode = "03", Name = "止泻药", ParentId = 6 });
            result.Add(new Category() { CategoryId = 22, CategoryCode = "01", Name = "眼药", ParentId = 7 });
            result.Add(new Category() { CategoryId = 23, CategoryCode = "02", Name = "洗眼药", ParentId = 7 });
            result.Add(new Category() { CategoryId = 24, CategoryCode = "01", Name = "外用消炎镇痛剂", ParentId = 8 });
            result.Add(new Category() { CategoryId = 25, CategoryCode = "02", Name = "皮肤疾患用药", ParentId = 8 });
            result.Add(new Category() { CategoryId = 26, CategoryCode = "03", Name = "痔疮用药", ParentId = 8 });
            result.Add(new Category() { CategoryId = 27, CategoryCode = "01", Name = "育发剂", ParentId = 9 });
            result.Add(new Category() { CategoryId = 28, CategoryCode = "01", Name = "女性用药", ParentId = 10 });
            result.Add(new Category() { CategoryId = 29, CategoryCode = "02", Name = "汉方药", ParentId = 10 });
            result.Add(new Category() { CategoryId = 30, CategoryCode = "01", Name = "其他医药品・医药部外品", ParentId = 11 });

            //医疗用具
            //1
            result.Add(new Category() { CategoryId = 31, CategoryCode = "01", Name = "医疗用具", ParentId = 0 });
            //2
            result.Add(new Category() { CategoryId = 32, CategoryCode = "01", Name = "口罩・伤口贴", ParentId = 31 });
            result.Add(new Category() { CategoryId = 33, CategoryCode = "02", Name = "肩颈椎护理", ParentId = 31 });
            result.Add(new Category() { CategoryId = 34, CategoryCode = "03", Name = "仪器", ParentId = 31 });
            result.Add(new Category() { CategoryId = 35, CategoryCode = "04", Name = "スキン", ParentId = 31 });
            result.Add(new Category() { CategoryId = 36, CategoryCode = "05", Name = "其他", ParentId = 31 });
            //3
            result.Add(new Category() { CategoryId = 37, CategoryCode = "01", Name = "感冒护理用品", ParentId = 32 });
            result.Add(new Category() { CategoryId = 38, CategoryCode = "02", Name = "伤口护理用品", ParentId = 32 });
            result.Add(new Category() { CategoryId = 39, CategoryCode = "01", Name = "辅助・束身类", ParentId = 33 });
            result.Add(new Category() { CategoryId = 40, CategoryCode = "02", Name = "肩膀酸痛护理用品", ParentId = 33 });
            result.Add(new Category() { CategoryId = 41, CategoryCode = "01", Name = "测定器具", ParentId = 34 });
            result.Add(new Category() { CategoryId = 42, CategoryCode = "01", Name = "受胎调整用品", ParentId = 35 });
            result.Add(new Category() { CategoryId = 43, CategoryCode = "01", Name = "其他医疗用具", ParentId = 36 });


            //健康食品
            //1
            result.Add(new Category() { CategoryId = 44, CategoryCode = "01", Name = "健康食品", ParentId = 0 });
            //2
            result.Add(new Category() { CategoryId = 45, CategoryCode = "01", Name = "减肥", ParentId = 44 });
            result.Add(new Category() { CategoryId = 46, CategoryCode = "02", Name = "维他命", ParentId = 44 });
            result.Add(new Category() { CategoryId = 47, CategoryCode = "03", Name = "氨基酸", ParentId = 44 });
            result.Add(new Category() { CategoryId = 48, CategoryCode = "04", Name = "功能食品", ParentId = 44 });
            result.Add(new Category() { CategoryId = 49, CategoryCode = "05", Name = "茶・提取物", ParentId = 44 });
            result.Add(new Category() { CategoryId = 50, CategoryCode = "06", Name = "他", ParentId = 44 });
            //3
            result.Add(new Category() { CategoryId = 51, CategoryCode = "01", Name = "减肥", ParentId = 45 });
            result.Add(new Category() { CategoryId = 52, CategoryCode = "02", Name = "酵素", ParentId = 45 });
            result.Add(new Category() { CategoryId = 53, CategoryCode = "03", Name = "美容", ParentId = 45 });
            result.Add(new Category() { CategoryId = 54, CategoryCode = "01", Name = "维他命・矿物质", ParentId = 46 });
            result.Add(new Category() { CategoryId = 55, CategoryCode = "01", Name = "氨基酸・蛋白质", ParentId = 47 });
            result.Add(new Category() { CategoryId = 56, CategoryCode = "02", Name = "青汁・螺旋藻・小球藻", ParentId = 47 });
            result.Add(new Category() { CategoryId = 57, CategoryCode = "01", Name = "肝脏护理（饮酒辅助）", ParentId = 48 });
            result.Add(new Category() { CategoryId = 58, CategoryCode = "02", Name = "DHA・EPA", ParentId = 48 });
            result.Add(new Category() { CategoryId = 59, CategoryCode = "03", Name = "软骨素・葡萄糖胺", ParentId = 48 });
            result.Add(new Category() { CategoryId = 60, CategoryCode = "04", Name = "眼睛辅助", ParentId = 48 });
            result.Add(new Category() { CategoryId = 61, CategoryCode = "01", Name = "健康茶・健康醋", ParentId = 49 });
            result.Add(new Category() { CategoryId = 62, CategoryCode = "02", Name = "提取剂", ParentId = 49 });
            result.Add(new Category() { CategoryId = 63, CategoryCode = "01", Name = "其他健康食品", ParentId = 50 });

            return result;
        }



    }
}