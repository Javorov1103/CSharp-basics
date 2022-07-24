using Hell.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hell.Entities.Commands
{
    public class HeroCommand : AbstractCommand
    {
        public HeroCommand(IList<string> args, IManager manager) : base(args, manager)
        {
        }
    }
}
