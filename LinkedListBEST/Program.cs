using System;

namespace LinkedListBEST
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList SLL1 = new SingleLinkedList();
            bool quit = false;
            
            while (!quit)
            {
                Console.WriteLine("Nereye eklemek istiyorsunuz? Başına (B) Ortasına (O) Sonuna (S)");
                char userAddStyle = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Eklemek istediğiniz tam sayı değerini giriniz");
                int userData = Convert.ToInt32(Console.ReadLine());
                switch (userAddStyle)
                {
                    case 'B':
                    case 'b':
                        SLL1.AddFirst(userData);
                        break;
                    case 'O':
                    case 'o':
                        SLL1.AddMiddle(userData);
                        break;
                    case 'S':
                    case 's':
                        SLL1.AddLast(userData);
                        break;
                }
                Console.WriteLine("Program sonlandırılsın mı ? Y/N ");
                string wantQuit = Console.ReadLine();
                if(wantQuit == "y" || wantQuit == "Y")
                {
                    quit = true;
                    SLL1.printAllNodes();
                }
            }
        }
    }

    internal class Node
    {
        internal int data;
        internal Node next = null;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }

    internal class SingleLinkedList
    {
        internal Node head;
        private int SLLlength = 0;

        public void printAllNodes()
        {
            Node current = head;
            string StringLinkedList = "";
            while(current != null)
            {
                StringLinkedList += current.data + " ";
                current = current.next;
            }
            Console.WriteLine("\nLinked List\n****************************\n" + StringLinkedList + "\n****************************");
        }

        public bool isEmpty()
        {
            if(this.SLLlength == 0)
            {
                return true;
            }
            return false;
        }

        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (this.isEmpty())
            {
                this.head = newNode;
            }
            else
            {
                newNode.next = this.head;
                this.head = newNode;
            }
            this.SLLlength += 1;
        }

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (this.isEmpty())
            {
                this.head = newNode;
            }
            else
            {
                Node current = head;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            this.SLLlength += 1;
        }

        
        public void AddMiddle(int data)
        {
            Node newNode = new Node(data);
            if (this.isEmpty())
            {
                this.head = newNode;
            }
            else
            {
                Node current = head;
                int middleNodeIndex = (int) Math.Floor((double)SLLlength / 2);
                int i =1 ;
                while(i < middleNodeIndex)
                {
                    current = current.next;
                    i += 1;
                }
                newNode.next = current.next;
                current.next = newNode;
            }
            this.SLLlength += 1;
        }
    }
}
