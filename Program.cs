namespace WorkflowEngine
{
    public interface IActivity
    {
        public void Execute();
    }

    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("uploading video");
        }
    }

    public class Encode : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("encoding video");
        }
    }

    public class EmailNotification: IActivity
    {
        public void Execute()
        {
            Console.WriteLine("emailing notification");
        }
    }

    class WFEngine
    {
        private readonly IList<IActivity> _activities = new List<IActivity>();
        public void Run()
        {
            foreach (IActivity activity in _activities)
            {
                activity.Execute();
            }
        }

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var wfe = new WFEngine();
            wfe.AddActivity(new UploadVideo());
            wfe.AddActivity(new Encode());
            wfe.AddActivity(new EmailNotification());
            wfe.Run();
        }
    }
}