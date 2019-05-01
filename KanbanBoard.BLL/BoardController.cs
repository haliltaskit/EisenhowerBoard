using KanbanBoard.DAL;
using KanbanBoard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.BLL
{
    public class BoardController
    {
        BoardManagement _boardManagement;

        public BoardController()
        {
            _boardManagement = new BoardManagement();
        }

        public bool Add(Board board)
        {
            board.BoardID = Guid.NewGuid();
            return _boardManagement.Insert(board) > 0;
        }


        public bool Update(Board board)
        {
            return _boardManagement.Update(board) > 0;
        }

        public bool Delete(Board board)
        {
            return _boardManagement.Delete(board.BoardID) > 0;
        }

        public Board GetBoard(Guid boardID)
        {
            return _boardManagement.GetBoardByID(boardID);
        }

        public List<Board> GetBoards()
        {
            return _boardManagement.GetAllBoards();
        }
    }
}
