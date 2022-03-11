namespace WorkflowEngine
{

    class Program
    {
        /// <summary>
        /// The program entry point
        /// </summary>
        /// <param name="args"></param>
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