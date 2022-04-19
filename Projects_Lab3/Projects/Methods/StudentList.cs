namespace Projects
{
    public class StudentList
    {
        private sealed class Node
        {
            public Student Data { get; private set; }
            public Node Next { get; set; }

            public Node() { }
            
            public Node(Student Data, Node Next)
            {
                this.Data = Data;
                this.Next = Next;
            }
        }

        private Node Head;                                  // the beginning of a list 
        private Node Tail;                                  // the end of a list
        private Node d;                                     // the list link

        /// <summary>
        /// Sets initial values of student list
        /// </summary>
        public StudentList()
        {
            this.Head = null;
            this.Tail = null;
            this.d = null;
        }

        /// <summary>
        /// Adds student to list
        /// </summary>
        /// <param name="student"> student object </param>
        public void AddStudent(Student student) //fifo
        {
            var dd = new Node(student, null);
            
            if(Head != null)
            {
                Tail.Next = dd;
                Tail = dd;
            } else
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
        /// Gets student
        /// </summary>
        /// <returns> student data </returns>
        public Student Get()
        {
            return d.Data;
        }
    }
}