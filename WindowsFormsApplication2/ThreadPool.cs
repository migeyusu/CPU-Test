using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CPUTest
{
    internal class LightThreadPool
    {
        private readonly Stack<ThreadPoolCell> ThreadStack;
        private bool _working = true;
        private readonly int _max;

        public event Action OnThreadCompleted;

        private int ThreadLeave { get; set; }

        public LightThreadPool(int max)
        {
            _max = max;
            ThreadStack = new Stack<ThreadPoolCell>(max);
            for (var i = 0; i < max; ++i)
            {
                var cell = new ThreadPoolCell() {controler = new AutoResetEvent(false)};
                var td = new Thread(() =>
                {
                    while (_working)
                    {
                        cell.controler.WaitOne();
                        cell.UnparamDelegate?.Invoke();
                        ThreadStack.Push(cell);
                    }
                }) {IsBackground = true};
                cell.child = td;
                cell.child.Start();
                ThreadStack.Push(cell);
            }
        }

        public bool TaskIn(Action func)
        {
            if (ThreadStack.Count < 0)
                return false;
            var tpc = ThreadStack.Pop();
            tpc.UnparamDelegate = func;
            tpc.controler.Set();
            return true;
        }

        public void Close()
        {
            if (ThreadStack.Count < _max)
                return;
            _working = false;
            foreach (var x in ThreadStack)
                x.controler.Set();
        }

        protected virtual void OnOnThreadCompleted()
        {
            OnThreadCompleted?.Invoke();
        }
    }

    internal struct ThreadPoolCell
    {
        public AutoResetEvent controler;
        public Thread child;
        public Action UnparamDelegate;
    }
}
