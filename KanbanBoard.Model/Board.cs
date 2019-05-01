using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.Model
{
    class Board : BaseEntity
    {
        public Guid BoarID { get; set; }
        public string Name { get; set; }
    }
}
