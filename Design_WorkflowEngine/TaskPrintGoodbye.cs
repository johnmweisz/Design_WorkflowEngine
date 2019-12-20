using System;

namespace Design_WorkflowEngine
{
    public class TaskPrintGoodbye : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Goodbye");
        }
    }
}