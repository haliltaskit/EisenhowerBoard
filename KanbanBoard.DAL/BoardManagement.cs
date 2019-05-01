using KanbanBoard.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanbanBoard.DAL
{
    public class BoardManagement
    {
        Helper h;

        public BoardManagement()
        {
            h = new Helper();
        }

        public int Insert(Board board)
        {
            string query = "INSERT INTO [Board] (BoardID,Name,CreatedDate) VALUES(@boardID,@name,@createdDate)";
            List<SqlParameter> parameters = GetParameters(board, true);
            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Update(Board board)
        {
            string query = "UPDATE [Board] SET Name = @name";
            List<SqlParameter> parameters = GetParameters(board, false);

            h.AddParametersToCommand(parameters);
            return h.MyExecuteQuery(query);
        }

        public int Delete(Guid boardID)
        {
            string query = "DELETE FROM [Board] WHERE BoardID = @boardID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@boardID",
                    Value = boardID

                }
            });

            return h.MyExecuteQuery(query);
        }
        List<SqlParameter> GetParameters(Board board, bool isInsert)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            if (isInsert)
            {
                parameters.Add(new SqlParameter("@boardID", board.BoardID));
            }
            parameters.Add(new SqlParameter("@name", board.Name));
            parameters.Add(new SqlParameter("@createdDate", DateTime.Now));
            return parameters;
        }

        public Board GetBoardByID(Guid boardID)
        {
            string query = "SELECT * FROM [Board] WHERE BoardID = @boardID";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@boardID",
                    Value = boardID
                }
            });

            Board currentBoard = new Board();
            SqlDataReader reader = h.MyExecuteReader(query);
            reader.Read();
            currentBoard.BoardID = boardID;
            currentBoard.Name = reader["Name"].ToString();
            currentBoard.IsFinished = (bool)reader["IsFinished"];
            currentBoard.IsDeleted = (bool)reader["IsDeleted"];
            currentBoard.CreatedDate = (DateTime)reader["CreatedDate"];
            reader.Close();
            return currentBoard;
        }

        public List<Board> GetAllBoards()
        {
            List<Board> boards = new List<Board>();
            string query = "SELECT * FROM [Board]";

            Board currentBoard;
            SqlDataReader reader = h.MyExecuteReader(query);
            while (reader.Read())
            {
                currentBoard = new Board();
                currentBoard.BoardID = (Guid) reader["BoardID"];
                currentBoard.Name = reader["Name"].ToString();
                currentBoard.IsFinished = (bool)reader["IsFinished"];
                currentBoard.IsDeleted = (bool)reader["IsDeleted"];
                currentBoard.CreatedDate = (DateTime)reader["CreatedDate"];
                boards.Add(currentBoard);
            }
            reader.Close();

            return boards;
        }

        public Board GetBoardByName(string boardName)
        {
            string query = "SELECT * FROM Board WHERE Name = @name";
            h.AddParametersToCommand(new List<SqlParameter>()
            {
                new SqlParameter()
                {
                    ParameterName = "@name",
                    Value = boardName
                }
            });

            SqlDataReader reader = h.MyExecuteReader(query);
            Board board = new Board();
            reader.Read();
            board.BoardID = reader.GetGuid(0);
            board.Name = boardName;
            reader.Close();

            return board;
        }
































    }
}
