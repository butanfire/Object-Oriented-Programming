using MassEffect.Engine.Commands;

namespace MassEffect.Engine
{
    public class ExtendedCommandManager : CommandManager
    {
        public ExtendedCommandManager() : base() { }

        public override void SeedCommands()
        {
            base.SeedCommands();
            this.commandsByName["system-report"] = new SystemReportCommand(this.Engine);
        }
    }
}
