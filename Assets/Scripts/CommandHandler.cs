using UnityEngine;

public class CommandHandler : MonoBehaviour
{
    public interface ICommand
    {
        void Execute();
    }

    public class MoveLeftCommand : ICommand
    {
        private ObjectPoolSpawner spawner;

        public MoveLeftCommand(ObjectPoolSpawner spawner)
        {
            this.spawner = spawner;
        }

        public void Execute()
        {
            spawner.MoveLeft();
        }
    }

    public class MoveRightCommand : ICommand
    {
        private ObjectPoolSpawner spawner;

        public MoveRightCommand(ObjectPoolSpawner spawner)
        {
            this.spawner = spawner;
        }

        public void Execute()
        {
            spawner.MoveRight();
        }
    }

    public class MoveUpCommand : ICommand
    {
        private ObjectPoolSpawner spawner;

        public MoveUpCommand(ObjectPoolSpawner spawner)
        {
            this.spawner = spawner;
        }

        public void Execute()
        {
            spawner.MoveUp();
        }
    }

    public class MoveDownCommand : ICommand
    {
        private ObjectPoolSpawner spawner;

        public MoveDownCommand(ObjectPoolSpawner spawner)
        {
            this.spawner = spawner;
        }

        public void Execute()
        {
            spawner.MoveDown();
        }
    }
}
