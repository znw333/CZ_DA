using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ_DA.Entity
{
    public class Sys_Users
    {
        public long Id { get; set; }

        public string Guid { get; set; }

        public string No { get; set; }

        public string Account { get; set; }

        public string Name { get; set; }

        public string EnName { get; set; }

        public string NickName { get; set; }

        public string PassWord { get; set; }

        public int Sex { get; set; } = 0;

        public string Email { get; set; }
        /// <summary>
        /// 手机1
        /// </summary>
        public string Mobile { get; set; }

        public string Address { get; set; }

        public long DeptId { get; set; } = 0;

        public string DeptName { get; set; }

        public long PositionId { get; set; } = 0;

        public string PositionName { get; set; }

        public long CompanyId { get; set; } = 0;

        public string CompanyName { get; set; }


        public long CreatedId { get; set; } = 0;

        public string CreatedName { get; set; }

        public DateTime? CreatedDatetime { get; set; } = DateTime.Now;


        public long ModifiedId { get; set; } = 0;

        public string ModifiedName { get; set; }

        public DateTime? ModifiedDatetime { get; set; } = DateTime.Now;



    }
}
