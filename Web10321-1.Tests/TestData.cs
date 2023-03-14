using System;
using System.Collections.Generic;
using System.Text;
using web1_1.DAL.Data;
using web1_1.DAL.Entities;

namespace Web10321_1.Tests
{
    public class TestData
    {
        public static void FillContext(ApplicationDbContext context)
        {
            context.WheelchairGroups.Add(new WheelchairGroup
            { GroupName = "fake group" });
            context.AddRange(new List<Wheelchair>
            {
                new Wheelchair{ WheelchairId=1, WheelchairGroupId=1},
                new Wheelchair{ WheelchairId=2, WheelchairGroupId=1},
                new Wheelchair{ WheelchairId=3, WheelchairGroupId=2},
                new Wheelchair{ WheelchairId=4, WheelchairGroupId=3},
                new Wheelchair{ WheelchairId=5, WheelchairGroupId=4},
                new Wheelchair{ WheelchairId=6, WheelchairGroupId=5}
            });
            context.SaveChanges();
        }

        public static List<Wheelchair> GetDishesList()
        {
            return new List<Wheelchair>
            {
            new Wheelchair{ WheelchairId=1, WheelchairGroupId=1},
            new Wheelchair{ WheelchairId=2, WheelchairGroupId=1},
            new Wheelchair{ WheelchairId=3, WheelchairGroupId=2},
            new Wheelchair{ WheelchairId=4, WheelchairGroupId=2},
            new Wheelchair{ WheelchairId=5, WheelchairGroupId=3}
            };
        }
        public static IEnumerable<object[]> Params()
        {
            // 1-я страница, кол. объектов 3, id первого объекта 1
            yield return new object[] { 1, 3, 1 };
            // 2-я страница, кол. объектов 2, id первого объекта 4
            yield return new object[] { 2, 2, 4 };
        }
    }
}
