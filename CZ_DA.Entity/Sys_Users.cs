using System;

namespace CZ_DA.Entity
{
    using SqlSugar;

    [SugarTable("Sys_Users", "Sys_Users")]
    public class Sys_Users
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, IsNullable = false, Length = 11)]
        public long Id { get; set; }

        public Guid Guid { get; set; }

        [SugarColumn(Length = 20)]
        public string No { get; set; }

        [SugarColumn(Length = 20)]
        public string Account { get; set; }

        [SugarColumn(Length = 50)]
        public string Name { get; set; }

        [SugarColumn(Length = 50)]
        public string EnName { get; set; }

        [SugarColumn(Length = 50)]
        public string NickName { get; set; }

        [SugarColumn(Length = 50)]
        public string PassWord { get; set; }

        public int Sex { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string Email { get; set; }
        /// <summary>
        /// 手机1
        /// </summary>
        [SugarColumn(Length = 20)]
        public string Mobile { get; set; }

        [SugarColumn(Length = 100)]
        public string Address { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        [SugarColumn(Length = 11)]
        public int State { get; set; } = 0;


        [SugarColumn(Length = 11)]
        public long DeptId { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string DeptName { get; set; }

        [SugarColumn(Length = 11)]
        public long PositionId { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string PositionName { get; set; }

        [SugarColumn(Length = 11)]
        public long CompanyId { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string CompanyName { get; set; }

        [SugarColumn(Length = 11)]
        public long CreatedId { get; set; } = 0;

        [SugarColumn(Length = 20)]
        public string CreatedName { get; set; }

        public DateTime CreatedDatetime { get; set; } = DateTime.Now;

        [SugarColumn(Length = 11)]
        public long ModifiedId { get; set; } = 0;

        [SugarColumn(Length = 20)]
        public string ModifiedName { get; set; }

        public DateTime ModifiedDatetime { get; set; } = DateTime.Now;

        /// <summary>
        /// 是否删除
        /// </summary>
        [SugarColumn(Length = 11)]
        public int HasDelete { get; set; } = 0;
    }
}