using System;

namespace CZ_DA.Entity
{
    using SqlSugar;
    public class Con_Linkman
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

        [SugarColumn(Length = 1)]
        public int Sex { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string Email { get; set; }

        /// <summary>
        /// 手机1
        /// </summary>
        [SugarColumn(Length = 20)]
        public string Mobile { get; set; }
        /// <summary>
        /// 手机2
        /// </summary>
        [SugarColumn(Length = 20)]
        public string Mobile1 { get; set; }
        /// <summary>
        /// 短号1
        /// </summary>
        [SugarColumn(Length = 20)]
        public string Mobile2 { get; set; }
        /// <summary>
        /// 短号2
        /// </summary>
        [SugarColumn(Length = 20)]
        public string Mobile3 { get; set; }
        /// <summary>
        /// 内线
        /// </summary>
        [SugarColumn(Length = 20)]
        public string Mobile4 { get; set; }

        [SugarColumn(Length = 20)]
        public string Mobile5 { get; set; }

        [SugarColumn(Length = 11)]
        public long DeptId { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string DeptName { get; set; }

        [SugarColumn(Length = 11)]
        public long PositionId { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string PositionName { get; set; }

        [SugarColumn(Length = 100)]
        public string Address { get; set; }

        [SugarColumn(Length = 11)]
        public long CompanyId { get; set; } = 0;

        [SugarColumn(Length = 50)]
        public string CompanyName { get; set; }
    }
}