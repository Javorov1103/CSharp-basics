using Hell.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Entities.Commands
{
    public abstract class AbstractCommand
    {
        private IManager manager;

        private IList<string> argsList;


        public AbstractCommand(IList<string> args, IManager manager)
        {
            this.manager = manager;
            this.argsList = args;
        }

        public IManager Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public IList<string> ArgsList
        {
            get { return argsList; }
            set { argsList = value; }
        }

        public virtual string Execute()
        {
            return "";
        }
    }
}
