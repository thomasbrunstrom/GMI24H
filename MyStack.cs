namespace Exempel
{
    public class MyStack<T>
    {
        public class Node
        {
            public T Data { get; set; }
            internal Node Next { get; set; }
            internal Node Previous { get; set; }
        }

        public readonly Node top;
        public readonly Node bottom;

        public MyStack()
        {
            top = new Node();
            top.Next = null;
            bottom = new Node();
            bottom.Next = null;
            //top.Previous = bottom;
            bottom.Next = top;
        }

        public void Push(T data)
        {
            Node tmp = new Node();
            tmp.Data = data;
            tmp.Next = top.Next;
            tmp.Previous = top;
            top.Next = tmp;
        }

        public T Pop()
        {
            T retData = top.Next.Data;
            top.Next = top.Next.Next;
            //top.Next.Next.Previous = top;
            return retData;
        }

        public T Peek()
        {
            T retData = top.Next.Data;
            return retData;
        }

        public bool TryPeek(out T data)
        {
            data = default(T);
            if(top.Next == null) {
                return false;    
            }
            data = top.Next.Data;
            return true;
        }

        public bool TryPop(out T data)
        {
            data = default(T);
            if(top.Next == null) {
                return false;    
            }
            data = top.Next.Data;
            top.Next = top.Next.Next;
            //top.Next.Next.Previous = top;
            return true;
        }

        public bool Contains(T data)
        {
            Node tmp = top;
            while(tmp.Next != null)
            {
                if(tmp.Data.Equals(data))
                {
                    return true;
                }
                tmp = tmp.Next;
            }
            return false;
        }

        public void Clear()
        {
            var tmp = top;
            while(tmp != null)
            {
                var current = tmp;
                tmp = tmp.Next;
                current.Next = null;
            }
        }
    }
}