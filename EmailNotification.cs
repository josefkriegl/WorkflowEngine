namespace WorkflowEngine
{
    public class EmailNotification: IActivity
    {
        public void Execute()
        {
            Console.WriteLine("emailing notification");
        }
    }
}