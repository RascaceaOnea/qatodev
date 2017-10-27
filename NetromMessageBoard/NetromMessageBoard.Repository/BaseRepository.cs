using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
