using System;
using System.Collections.Generic;

namespace Design_WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly IList<ITask> _tasks = new List<ITask>();
        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            if (!_tasks.Remove(task)) throw new NullReferenceException("Task not in workflow");
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}