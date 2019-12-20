using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var work = new Workflow();
            work.Add(new TaskPrintHello());
            var task = new TaskPrintGoodbye();
            work.Add(task);
            WorkflowEngine.Run(work);
            work.Remove(task);
            WorkflowEngine.Run(work);
            // work.Remove(task); throws task not in workflow error.
        }
    }
}
