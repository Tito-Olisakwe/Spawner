using UnityEngine;

public class CommandHandler : MonoBehaviour
{
    // Define ICommand interface here
    public interface ICommand
    {
        void Execute();
    }

    // Define MoveLeftCommand here
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

    // Define MoveRightCommand here
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

    // Define MoveUpCommand here
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

    // Define MoveDownCommand here
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

    private ICommand moveLeftCommand;
    private ICommand moveRightCommand;
    private ICommand moveUpCommand;
    private ICommand moveDownCommand;
    private ObjectPoolSpawner spawner;

    void Start()
    {
        spawner = ObjectPoolSpawner.Instance;
        moveLeftCommand = new MoveLeftCommand(spawner);
        moveRightCommand = new MoveRightCommand(spawner);
        moveUpCommand = new MoveUpCommand(spawner);
        moveDownCommand = new MoveDownCommand(spawner);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            moveLeftCommand.Execute();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveRightCommand.Execute();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveUpCommand.Execute();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            moveDownCommand.Execute();
        }
    }
}
