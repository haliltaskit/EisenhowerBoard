using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.CustomException
{
    class NotNullException : Exception
    {
        string _data;

        public NotNullException(string data)
        {
            _data = data;
        }

        public override string Message => $"Alan boş geçilemez. Alan : {_data}";
    }
}
