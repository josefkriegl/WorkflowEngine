namespace WorkflowEngine
{
    class WFEngine
    {
        private readonly IList<IActivity> _activities;
        
        public WFEngine()
        {
            _activities = new List<IActivity>();
        }
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
}