using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Advanced.Singleton
{
    //https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/

    public sealed class NoThreadSafeSingleton
    {
        private static NoThreadSafeSingleton instance = null;
        private NoThreadSafeSingleton() { }
        /*
         * Two different threads could both have evaluated the test (if instance == null) 
         * and found it to be true, then both create instances, 
         * which violates the singleton pattern.
         */
        public static NoThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new NoThreadSafeSingleton();
                return instance;
            }
        }

        void showMessage()
        {
            Console.WriteLine("Message from NoThreadSafeSingleton class");
        }
    }
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton instance = null;
        private static readonly object instanceLock = new object();
        private ThreadSafeSingleton() { }
        /*
         * 1. In the code, the thread is locked on a shared object and checks whether an instance has been created or not
         * It takes care of the memory barrier issue and ensures that only one thread will create an instance.
         * For example: Since only one thread can be in that part of the code at a time, 
         * by the time the second thread enters it, the first thread will have created the instance, 
         * so the expression will evaluate as false.
         * 
         * 2. The biggest problem with this is performance; 
         * performance suffers since a lock is required every time an instance is requested
         */
        public static ThreadSafeSingleton Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                        instance = new ThreadSafeSingleton();
                }
                return instance;
            }
        }

        void showMessage()
        {
            Console.WriteLine("Message from ThreadSafeSingleton class");
        }
    }
    public sealed class DoubleCheckThreadSafeSingleton
    {
        private static DoubleCheckThreadSafeSingleton instance = null;
        private static readonly object instanceLock = new object();
        private DoubleCheckThreadSafeSingleton() { }
        /*
         * the thread is locked on a shared object and checks whether an instance has been created or not with double checking.
         */
        public static DoubleCheckThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        if (instance == null)
                            instance = new DoubleCheckThreadSafeSingleton();
                    }
                }
                return instance;
            }
        }

        void showMessage()
        {
            Console.WriteLine("Message from DoubleCheckThreadSafeSingleton class");
        }
    }
    public sealed class NoInstantiationSingleton
    {
        private static readonly NoInstantiationSingleton instance = new NoInstantiationSingleton();
        static NoInstantiationSingleton() { }
        private NoInstantiationSingleton() { }
        /*
         * This type of implementation has a static constructor, so it executes only once per Application Domain.
         */
        public static NoInstantiationSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        void showMessage()
        {
            Console.WriteLine("Message from NoInstantiationSingleton class");
        }
    }
    public sealed class LazySingleton
    {
        private LazySingleton() { }
        private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(
            () => new LazySingleton());
        public static LazySingleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        void showMessage()
        {
            Console.WriteLine("Message from LazySingleton class");
        }
    }
}
