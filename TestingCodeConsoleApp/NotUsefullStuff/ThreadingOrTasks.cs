using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace TestingCodeConsoleApp
{
    class ThreadingOrTasks
    {
        DoSomeWork dsw = new DoSomeWork();
        Test data = null;
        public ThreadingOrTasks()
        {
            MainThread();

            Procced();
        }
        public async void MainThread()
        {
            data = await dsw.DoingSomeWork();
            

            Console.WriteLine(data.Height);
            Console.WriteLine(data.Width);
        }


        // Await for task above
        public  void Procced()
        {
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("procceding");
                if(data == null)
                    Console.WriteLine("data null");
                else
                {
                    Console.WriteLine(data.Height);
                    Console.WriteLine(data.Width);
                }
                    
            }
        }
    }
    class Test
    {
        public int Height { get; set; }
        public int Width  { get; set; }
    }
    class DoSomeWork
    {
        public async Task<Test> DoingSomeWork()
        {
            for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("done");
            return new Test { Height = 100, Width = 255 };
        }
    }

}
    #region Threading part 1 
        //private bool done = false;
        //public void Main()
        //{
        //    Importing importing = new Importing(0);
        //    importing.DoneCouting += SetWayOut;
        //    Thread thread = new Thread(importing.ImportingMap);
        //    thread.Start();
        //    bool outNow = false;

        //    while(outNow == false)
        //    {
        //        if(done == true)
        //        {
        //            outNow = true;
        //            PathFiding();
        //        }
        //    }
        //    // if import is not done await for it 
        //    // call Pathfinding here
            
        //}
        //private void SetWayOut(object sender, EventArgs e)
        //{
        //    done = true;
        //}

        //private void PathFiding()
        //{
        //    Console.WriteLine("we out");
        //}

        #endregion
    #region Threading part 2
    //class Importing
    //{
    //    int x;
    //    public Importing(int x)
    //    {
    //        this.x = x;
    //    }

    //    public void ImportingMap()
    //    {
    //        Console.WriteLine(x);
    //        for (int i = 0; i < 1000; i++)
    //        {
    //            Console.WriteLine("potato");
    //        }
    //        Console.WriteLine("done");
    //        DoneCouting(this, new EventArgs());
    //    }
    //    public EventHandler DoneCouting;
    //}
    #endregion

