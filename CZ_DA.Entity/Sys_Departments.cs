using System;

namespace CZ_DA.Entity
{
    using SqlSugar;

    [SugarTable("Sys_Departments", "Sys_Departments")]
    public class Sys_Departments
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, IsNullable = false, Length = 11)]
        public long Id { get; set; }

        public Guid Guid { get; set; }

        [SugarColumn(Length = 20)]
        public string No { get; set; }

        [SugarColumn(Length = 50)]
        public string Name { get; set; }

        [SugarColumn(Length = 50)]
        public string EnName { get; set; }

        [SugarColumn(Length = 11)]
        public long ParentId { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string ParentName { get; set; }

        [SugarColumn(Length = 11)]
        public int Level { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string LevelPath { get; set; }

        [SugarColumn(Length = 11)]
        public long CompanyId { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string CompanyName { get; set; }
    }
}
