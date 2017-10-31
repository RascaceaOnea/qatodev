using NetromMessageBoard.Model;

namespace NetromMessageBoard.Repository
{
    public abstract class BaseRepository
    {
        protected NetromMessageBoardEntities Context;

        protected BaseRepository()
        {
            Context = new NetromMessageBoardEntities();
        }

        protected void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
