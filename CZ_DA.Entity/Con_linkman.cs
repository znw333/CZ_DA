using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ_DA.Entity
{
    public class Con_Linkman
    {
        public long Id { get; set; }

        public string Guid { get; set; }

        public string No { get; set; }

        public string Account { get; set; }

        public string Name { get; set; }

        public string EnName { get; set; }

        public string NickName { get; set; }

        public int Sex { get; set; } = 0;

        public string Email { get; set; }

        /// <summary>
        /// 手机1
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 手机2
        /// </summary>
        public string Mobile1 { get; set; }
        /// <summary>
        /// 短号1
        /// </summary>
        public string Mobile2 { get; set; }
        /// <summary>
        /// 短号2
        /// </summary>
        public string Mobile3 { get; set; }
        /// <summary>
        /// 内线
        /// </summary>
        public string Mobile4 { get; set; }

        public string Mobile5 { get; set; }

        public long DeptId { get; set; } = 0;

        public string DeptName { get; set; }

        public long PositionId { get; set; } = 0;

        public string PositionName { get; set; }

        public string Address { get; set; }

        public long CompanyId { get; set; } = 0;

        public string CompanyName { get; set; }
    }
}
