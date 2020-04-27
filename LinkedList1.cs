using System;
namespace SingleLinkedList
{
    public class SongNode : Node<SongNode>
    {
        public byte[] Data { get; set; }
        public SongNode()
        {

        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
    public class ImageNode : Node<ImageNode>
    {
        public string Data { get; set; }
        public ImageNode()
        {

        }
        public ImageNode(string Data)
        {
            this.Data = Data;
        }
        public override string ToString()
        {
            return Data;
        }
    }

    public class Node<T>
    {
        internal T Next { get; set; }
        public override string ToString()
        {
            return "Node<T>";
        }
    }

    public class SingleLinkedList<T> where T : Node<T>, new()   
    //New constraint här för att säkerhetsställa 
    //att vi kan skapa upp nya instanser av T
    {
        public readonly T top;

        public SingleLinkedList()
        {
            top = new T();
            top.Next = null;
        }
        public void AddFirst(T node)
        {
            node.Next = top.Next;
            top.Next = node;
        }
        public void AddLast(T node)
        {
            T lastNode = top;
            while (lastNode.Next != null)
            {
                lastNode = lastNode.Next;
            }
            lastNode.Next = node;
        }

        public void ForEach(Action<string> action)
        {
            T node = top;
            while (node != null)
            {
                node = node.Next;
                //Hantera noden
                action(node.ToString());
            }
        }
        public void ForEach()
        {
            T node = top;
            while (node != null)
            {
                node = node.Next;
                //Hantera noden
                Console.WriteLine(node);
            }
        }

        public bool Contains(T node)
        {
            T currentNode = top;
            while (currentNode.Next != null)
            {
                if (node == currentNode)
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }

        public void AddAfter(T node, T newNode)
        {
            newNode.Next = node.Next;
            node.Next = newNode;
        }
        public void AddBefore(T node, T newNode)
        {
            if (!Contains(node))
            {
                throw new Exception("Node not found in SingleLinkedList");
            }

            T beforeNode = top;
            while (beforeNode.Next != null)
            {
                if (beforeNode == node)
                {
                    AddAfter(beforeNode, newNode);
                    break;
                }
                beforeNode = beforeNode.Next;
            }
        }

        public void Remove(T node)
        {
            T currentNode = top;
            while (currentNode.Next != null)
            {
                if (currentNode.Next == node)
                {
                    currentNode.Next = node.Next;
                    break;
                }
                currentNode = currentNode.Next;
            }
        }

        public override string ToString()
        {
            string st = string.Empty;
            T node = top;
            while (node.Next != null)
            {
                node = node.Next;
                st += node.ToString();
                if (node.Next != null)
                {
                    st += " ";
                }
            }
            return st;
        }
    }
}