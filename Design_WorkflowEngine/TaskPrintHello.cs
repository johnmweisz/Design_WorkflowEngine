using System;

namespace Design_WorkflowEngine
{
    public class TaskPrintHello : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Hello");
        }
    }
}