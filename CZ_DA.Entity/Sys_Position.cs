using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ_DA.Entity
{
    public class Sys_Position
    {
        public long Id { get; set; }

        public string Guid { get; set; }

        public string No { get; set; }

        public string Name { get; set; }

        public string EnName { get; set; }

        public long ParentId { get; set; } = 0;

        public string ParentName { get; set; }

        public int Level { get; set; } = 0;

        public string LevelPath { get; set; }

        public long DeptId { get; set; } = 0;

        public string DeptName { get; set; }
    }
}
