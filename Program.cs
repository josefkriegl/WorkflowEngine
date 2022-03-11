namespace WorkflowEngine
{

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