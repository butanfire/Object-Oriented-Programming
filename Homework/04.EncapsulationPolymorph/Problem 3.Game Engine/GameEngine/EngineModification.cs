using System;
using TheSlum.GameEngine;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    public class EngineModification : Engine
    {
      public EngineModification() : base() { }

        protected override void CreateCharacter(string[] inputParams)
        {
            base.CreateCharacter(inputParams);
        }

        protected override void AddItem(string[] inputParams)
        {
            switch (inputParams[2])
            {
                case "axe":
                    this.GetCharacterById(inputParams[1]).AddToInventory(new Axe(inputParams[3],0,0,75));
                    break;
                case "pill":
                    this.GetCharacterById(inputParams[1]).AddToInventory(new Pill(inputParams[3],0,0,100));
                    break;
                case "injection":
                    this.GetCharacterById(inputParams[1]).AddToInventory(new Injection(inputParams[3],200,0,0));
                    break;
                case "shield":
                    this.GetCharacterById(inputParams[1]).AddToInventory(new Shield(inputParams[3], 0,50,0));
                    break;
                default:
                    throw new ArgumentException("No such item exists");
            }
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            base.ExecuteCommand(inputParams);
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
            }
        }
    }
}
