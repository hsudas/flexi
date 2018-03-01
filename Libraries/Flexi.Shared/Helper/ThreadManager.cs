using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexi.Shared.Helper
{
    public class ThreadManager //: IDisposable
    {
        //private bool _Up = false;
        //private int _MaxThreadCount;
        //private Thread _MainWorker;
        //private Semaphore _ThreadSemaphore;
        //private Mutex _WorkerMutex, _TaskMutex;
        //private LinkedList<Thread> _WorkerList;
        //private Queue<List<Action>> _TaskQueue;

        //public ThreadManager(int maxThreadCount)
        //{
        //    _MaxThreadCount = maxThreadCount;
        //    _Up = true;

        //    _TaskMutex = new Mutex();
        //    _WorkerMutex = new Mutex();
        //    _ThreadSemaphore = new Semaphore(_MaxThreadCount, _MaxThreadCount);

        //    _WorkerList = new LinkedList<Thread>();
        //    _TaskQueue = new Queue<List<Action>>();
        //}

        ///// <summary>
        ///// initializes main worker thread
        ///// </summary>
        //public void Start()
        //{
        //    _MainWorker = new Thread(() => MainWorker());
        //    _MainWorker.Start();
        //}

        ///// <summary>
        ///// inserts new task to queue
        ///// </summary>
        ///// <param name="task"></param>
        //public void AddTask(List<Action> tasks)
        //{
        //    _TaskMutex.WaitOne();
        //    {
        //        _TaskQueue.Enqueue(tasks);
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Logger.WriteLine("New task added. There are " + _TaskQueue.Count + " task(s) in queue.");
        //        Console.ResetColor();
        //    }
        //    _TaskMutex.ReleaseMutex();
        //}

        ///// <summary>
        ///// Rules all threads
        ///// </summary>
        //private void MainWorker()
        //{
        //    while (_Up)
        //    {
        //        _TaskMutex.WaitOne();

        //        if (_TaskQueue.Count > 0)
        //        {
        //            if (_TaskQueue.Peek() == null)
        //            {
        //                _TaskQueue.Dequeue();
        //            }
        //            else
        //            {
        //                _ThreadSemaphore.WaitOne(); //thread limit

        //                List<Action> tasks = _TaskQueue.Dequeue();

        //                Thread t = new Thread(() =>
        //                {
        //                    foreach (var task in tasks)
        //                    {
        //                        task();
        //                    }
        //                    ThreadFinished();
        //                });

        //                _WorkerMutex.WaitOne();
        //                {
        //                    _WorkerList.AddLast(t);
        //                }
        //                _WorkerMutex.ReleaseMutex();

        //                t.Start();
        //            }
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Logger.WriteLine("One task released, there are " + _TaskQueue.Count + " task(s) left.");
        //            Console.ResetColor();
        //        }

        //        _TaskMutex.ReleaseMutex();
        //    }
        //}

        ///// <summary>
        ///// every thread calls that function automatically to remove itself from worker queue
        ///// </summary>
        //private void ThreadFinished()
        //{
        //    _WorkerMutex.WaitOne();
        //    {//critical section
        //        Thread removableThread = null;

        //        foreach (Thread worker in _WorkerList)
        //        {
        //            if (object.ReferenceEquals(Thread.CurrentThread, worker))
        //            {
        //                removableThread = worker;
        //                break;
        //            }
        //        }

        //        if (removableThread != null)
        //        {
        //            _WorkerList.Remove(removableThread);
        //            Console.ForegroundColor = ConsoleColor.Cyan;
        //            Logger.WriteLine("A thread finised. There are " + _WorkerList.Count + " thread(s) left.");
        //            Console.ResetColor();
        //            _ThreadSemaphore.Release();
        //        }
        //    }
        //    _WorkerMutex.ReleaseMutex();
        //}

        ///// <summary>
        ///// Disposes all threads
        ///// </summary>
        //public void Dispose()
        //{
        //    //wait all tasks
        //    while (_TaskQueue.Count > 0)
        //        Thread.Sleep(100);

        //    //wait all threads
        //    while (_WorkerList.Count > 0)
        //    {
        //        if (_WorkerList.First.Value.IsAlive)
        //            _WorkerList.First.Value.Join();

        //        Thread.Sleep(100);
        //    }

        //    _Up = false;
        //}
    }
}
