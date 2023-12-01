namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mention the operation you want to perform");
            int val = Convert.ToInt32(Console.ReadLine());
            switch(val) 
            {
                case 1:
                    LinkedListGen<int> list = new LinkedListGen<int>();
                    list.AddLast(1);
                    list.AddLast(2);    
                    list.AddLast(3);
                    list.RemoveFirst();
                    list.AddLast(4);
                    list.AddFirst(5);
                    list.AddFirst(6);
                    list.RemoveLast();
                    list.DisplayNodes();
                    break;
                case 2:
                    QueueGen<int> queueGen = new QueueGen<int>();
                    queueGen.Enqueue(1);
                    queueGen.Enqueue(2);
                    queueGen.Enqueue(3);
                    queueGen.Peek();
                    queueGen.Enqueue(4);
                    queueGen.Enqueue(5);
                    queueGen.Dequeue();
                    queueGen.Peek();
                    queueGen.Dequeue();
                    queueGen.Display();
                    break;
                case 3:
                    StackGen<int> stackGen = new StackGen<int>();
                    stackGen.Push(10);
                    stackGen.Push(20);
                    stackGen.Push(30);
                    stackGen.Peek();
                    stackGen.Pop();
                    stackGen.Peek();
                    stackGen.Display();
                    break;
                case 4:
                    LinkedListImplement lI = new LinkedListImplement();
                    lI.ImplementFunction();
                    break;
                case 5:
                    StackImplement st = new StackImplement();
                    st.implementStack();
                    break;
                case 6:
                    QueueImplementation qim = new QueueImplementation();
                    qim.implementQueue();
                    break;
                case 7:
                    LinkedListDesending ld = new LinkedListDesending();
                    ld.Add(1);
                    ld.Add(2);
                    ld.Add(100);
                    ld.Add(5);
                    ld.Print();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;




            }

        }
    }
}
