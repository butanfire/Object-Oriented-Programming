namespace MassEffect.Engine.Commands.Factories
{
    using System;
    using GameObjects.Enhancements;

    public static class EnhancementFactory
    {
        public static Enhancement Create(EnhancementType enhancementType)
        {
            switch (enhancementType)
            {
                case EnhancementType.ThanixCannon:
                    return new Enhancement("ThanixCannon", 0, 50, 0);
                case EnhancementType.KineticBarrier:
                    return new Enhancement("KineticBarrier", 100, 0, 0);
                case EnhancementType.ExtendedFuelCells:
                    return new Enhancement("ExtendedFuelCells", 0, 0, 200);
                default:
                    throw new NotImplementedException("No such enhancement");
            }
        }
    }
}
