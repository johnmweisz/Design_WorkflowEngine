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
            var task = new TaskPrintGoodbye();
            
            work.Add(new TaskPrintHello());
            work.Add(task);
            
            WorkflowEngine.Run(work);
            
            work.Remove(task);
            
            WorkflowEngine.Run(work);
            
            // throws task not in workflow error.
            // work.Remove(task); 
        }
    }
}
