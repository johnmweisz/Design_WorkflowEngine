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
            var isRemoved = _tasks.Remove(task);
            if (!isRemoved) throw new NullReferenceException("Task not in workflow");
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}