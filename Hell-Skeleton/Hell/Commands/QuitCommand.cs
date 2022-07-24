using Hell.Entities.Commands;
using Hell.Interfaces;
using System.Collections.Generic;

public class QuitCommand : AbstractCommand
{
    //protected QuitCommand()
    //{

    //}
    public QuitCommand(List<string> args, IManager manager) : base (args, manager)
    {
    }

    public override string Execute()
    {
        return base.Manager.Quit(this.ArgsList);
    }
}