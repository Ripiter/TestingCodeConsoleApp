using System;

namespace WorkingOnEvents
{
    class CleanEvent
    {

        Add add = new Add();
        float value = 0f;

        public void Start()
        {
            add.eventHandler += Print;

            for (int i = 0; i < 5; i++)
            {

            add.PlusOne();
            }

        }

        private void Print()
        {
            value++;
            Console.WriteLine(value);
        }
    }

    class Add
    {
        public delegate void DelegateName();
        public event DelegateName eventHandler;

        public void PlusOne()
        {
            if (eventHandler != null)
                eventHandler();
        }
    }

    class EventSub
    {

    }
}
