namespace Projects
{
    public class ProfessorList
    {
        private sealed class Node
        {
            public Professor Data { get; set; }
            public Node Next { get; set; }

            public Node() { }

            public Node(Professor Data, Node Next)
            {
                this.Data = Data;
                this.Next = Next;
            }
        }

        private Node Head;                                  // the beginning of a list 
        private Node Tail;                                  // the end of a list
        private Node d;                                     // the list link

        /// <summary>
        /// Initial values of the list
        /// </summary>
        public ProfessorList()
        {
            this.Head = null;
            this.Tail = null;
            this.d = null;
        }

        /// <summary>
        /// Add professor as a queue (fifo)
        /// </summary>
        /// <param name="professor"> professor object </param>
        public void AddProfessor(Professor professor)
        {
            var dd = new Node(professor, null);

            if (Head != null)
            {
                Tail.Next = dd;
                Tail = dd;
            }
            else
            {
                Head = dd;
                Tail = dd;
            }
        }

        /// <summary>
        /// Beginning of list
        /// </summary>
        public void Begin()
        {
            d = Head;
        }

        /// <summary>
        /// Next element of list
        /// </summary>
        public void Next()
        {
            d = d.Next;
        }

        /// <summary>
        /// Checks if the list continues
        /// </summary>
        /// <returns> true if link is not empty </returns>
        public bool Exists()
        {
            return d != null;
        }

        /// <summary>
        /// Get professor object
        /// </summary>
        /// <returns> professor </returns>
        public Professor Get()
        {
            return d.Data;
        }

        /// <summary>
        /// Removes node when it is tail
        /// </summary>
        public void DeleteTail()
        {
            var secondLastNode = Head;
            while (secondLastNode.Next.Next != null)
            {
                secondLastNode = secondLastNode.Next;
            }
            secondLastNode.Next = null;
        }

        /// <summary>
        /// Removes node when it is head
        /// </summary>
        public void DeleteHead()
        {
            Head = Head.Next;
        }

        /// <summary>
        /// Removes node when it's in the middle
        /// </summary>
        public void DeleteMid()
        {
            Node current = Head; Node prev = null;

            while(current.Next != null)
            {
                if (current.Next == d)
                {
                    prev = current;
                    current = current.Next;
                    break;
                }
                else
                    current = current.Next;
            }
            prev.Next = current.Next;
        }
        
        /// <summary>
        /// Removes node from the list 
        /// </summary>
        public void Remove()
        {
            var current = Head;
            if(Head != null && Tail != null)
            {
                if (d == Tail)
                {
                    DeleteTail();
                }
                else if (d == Head)
                {
                    DeleteHead();
                }
                else
                {
                    DeleteMid();
                }

            }
        }

        /// <summary>
        /// Sorts data alphabetically
        /// </summary>
        public void Sort()
        {
            for (Node d1 = Head; d1 != null; d1 = d1.Next)
            {
                Node minv = d1;
                for (Node d2 = d1.Next; d2 != null; d2 = d2.Next)
                    if (d2.Data <= minv.Data)
                        minv = d2;
                
                Professor Pr = d1.Data;
                d1.Data = minv.Data;
                minv.Data = Pr;
            }
        }
    }
}