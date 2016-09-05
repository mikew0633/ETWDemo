using System.Diagnostics.Tracing;

namespace ETWDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EventSourceImplementation.Tracer.AppStarted();
        }
    }

    public sealed class EventSourceImplementation : EventSource
    {
        static public EventSourceImplementation Tracer = new EventSourceImplementation();

        public void AppStarted()
        {
            WriteEvent(1);
        }
    }
}
