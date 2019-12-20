using System;
using System.Collections.Generic;

namespace Design_WorkflowEngine
{
    public static class WorkflowEngine
    {
        public static void Run(IWorkflow workflow)
        {
            foreach (var task in workflow.GetTasks())
            {
                try
                {
                    task.Execute();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
    }
}