namespace Blobs.Core
{
    using System;
    using System.Linq;
    using Interfaces;
    using Models.Attack;
    using Models.Behavior;
    using Models;

    public class GameEngine : IEngine
    {
        private readonly IData data;
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;
        private bool reportEvents;

        public GameEngine(IData data, IInputReader reader, IOutputWriter writer)
        {
            this.reader = reader;
            this.writer = writer;
            this.data = data;
        }

        public bool IsRunning { get; set; }

        public void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();
                this.ExecuteCommand(input);
            }
        }

        public void UpdateTurns()
        {
            foreach (var blob in this.data.Blobs.Where(blob => blob.Alive))
            {
                blob.UpdateBlob();
            }
        }

        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    IBehavior behave = null;
                    switch (inputParams[4])
                    {
                        case "Aggressive":
                            behave = new AggressiveBehavior(inputParams[4], 0, 0);
                            break;
                        case "Inflated":
                            behave = new InflatedBehavior(inputParams[4], 0, 50);
                            break;
                    }

                    var attackType = (AttackType)Enum.Parse(typeof(AttackType), inputParams[5]);
                    var blob = new Blob(
                        inputParams[1], //name
                        Convert.ToInt32(inputParams[2]), //health
                        Convert.ToInt32(inputParams[3]), //damage
                        behave, //behavior
                        attackType);
                    data.AddBlob(blob); //attack type

                    if (this.reportEvents)
                    {
                        blob.OnToggleBehavior += this.PrintToggleBehaviorInfo;
                        blob.OnBlobDeath += this.PrintBlobDeathInfo;
                    }

                    break;
                case "pass":
                    UpdateTurns();
                    break;
                case "status":
                    ExecuteStatusCommand();
                    UpdateTurns();
                    break;
                case "attack":
                    UpdateTurns();
                    ExecuteAttackCommand(inputParams[1], inputParams[2]);

                    break;
                case "drop":
                    System.Environment.Exit(0);
                    break;
                case "report-events":
                    this.reportEvents = true;
                    break;
            }
        }


        private void ExecuteAttackCommand(string attacker, string target)
        {
            IBlob attackingBlob = null, targetBlob = null;

            attackingBlob = this.data.Blobs.FirstOrDefault(s => s.Name == attacker);
            targetBlob = this.data.Blobs.FirstOrDefault(s => s.Name == target);

            IAttack attack = attackingBlob.ProduceAttack();

            if (attackingBlob.Alive && targetBlob.Alive)
            {
                if (attack != null)
                {
                    targetBlob.RespondToAttack(attack);
                }
            }
        }

        private void ExecuteStatusCommand()
        {
            foreach (IBlob blob in this.data.Blobs)
            {
                this.writer.Print(!blob.Alive ? $"Blob {blob.Name} KILLED" : blob.ToString());
            }
        }

        private void PrintToggleBehaviorInfo(IBlob sender, EventArgs eventArgs)
        {
            this.writer.Print($"Blob {sender.Name} toggled {sender.BehaviorType.Name+"Behavior"}");
        }

        private void PrintBlobDeathInfo(IBlob sender, EventArgs eventargs)
        {
            this.writer.Print($"Blob {sender.Name} was killed");
        }
    }
}


