class Link
{
    public int data;
    public Link next;

    public Link(int a)
    {
        data = a;
    }
}

class LinkedList
{
    static Link first = null;
    static int length = 0;

    void addFirst(int id)
    {
        Link nnode = new Link(id);
        nnode.next = first;
        first = nnode;
        length++;
        System.Console.WriteLine(id + " is added at first position");
    }
    void deleteFirst()
    {
        if (first == null)
        {
            System.Console.WriteLine("Memory Error");
            return;
        }
        Link temp = first;
        first = first.next;
        System.Console.WriteLine(temp.data + " is deleted");
        length--;
    }
    void printList(Link t)
    {
        if (length == 0)
            System.Console.WriteLine("List is empty");
        else
        {
            System.Console.WriteLine("\nLinked List is:");
            while (t.next != null)
            {
                System.Console.Write(t.data + " -> ");
                t = t.next;
            }
            System.Console.Write(t.data);
            System.Console.WriteLine();
        }
    }

    void addIndex(int num, int ind)
    {
        if (ind > length + 1)
        {
            System.Console.WriteLine("Index Error!! Please enter a valid index.");
            return;
        }
        else
        {
            if (ind == 1)
            {
                addFirst(num);
                return;
            }
            else
            {
                Link nnode = new Link(num);
                Link t = first;
                for (int i = 1; i < ind - 1; i++)
                    t = t.next;
                nnode.next = t.next;
                t.next = nnode;
                length++;
                System.Console.WriteLine(num + " is added at " + ind + "'s position");
            }
        }
    }

    void deleteLast()
    {
        Link t = first;
        if (first == null || length==1)
        {
            deleteFirst();
            return;
        }
        else
        {
            while (t.next.next != null)
                t = t.next;
             System.Console.WriteLine(t.next.data + " is deleted");
            t.next = null;
            length--;
        }
    }
    void deleteIndex(int pos)
    {
        if (pos > length || pos==0)
        {
            System.Console.WriteLine("Invalid Index!! Please enter a valid index");
            return;
        }
        else {
            if (pos == 1 || first == null)
            {
                deleteFirst();
                return;
            }
            else
            {
                Link temp = first;
                for (int i = 1; i < pos - 1; i++)
                    temp = temp.next;
                System.Console.WriteLine(temp.next.data + " is deleted");
                temp.next = temp.next.next;
                length--;
            }
    }
    }
    void addLast(int num)
    {
        if (first == null)
        {
            addFirst(num);
        }
        else
        {
            Link nnode = new Link(num);
            Link t = first;
            while (t.next != null)
                t = t.next;
            nnode.next = t.next;
            t.next = nnode;
            length++;
            System.Console.WriteLine(num + " is added in last");
        }
    }
    string printLength()
    {
        return "Length of Linked List is : "+length;
    }

    public static void Main(string[] s) {
        bool tr = true;
        LinkedList ll=new LinkedList();
        while (tr)
        {
            System.Console.WriteLine("\nEnter a choice\n1.Add\n2.Delete\n3.Print Linked List\n4.Print Length of List\n5.Exit");
            int a = int.Parse(System.Console.ReadLine());
            switch (a)
            {
                case 1:
                    bool tr1 = true;
                    while (tr1)
                    {
                        System.Console.WriteLine("\nPlease enter a choice:\n1.Add at Beginning\n2.Add in middle\n3.Add at end\n4.Print Linked List\n5.Print Length of List\n6.Back");
                        int sw = int.Parse(System.Console.ReadLine());
                        switch (sw)
                        {
                            case 1:
                                 System.Console.WriteLine("Enter element to enter:");
                                 int ad = int.Parse(System.Console.ReadLine());
                                ll.addFirst(ad);
                                break;
                            case 2:
                                 System.Console.WriteLine("Enter element to enter:");
                                 ad = int.Parse(System.Console.ReadLine());
                                System.Console.WriteLine("Enter the index :");
                                int n = int.Parse(System.Console.ReadLine());
                                ll.addIndex(ad, n);
                                System.Console.WriteLine();
                                break;
                            case 3:
                                 System.Console.WriteLine("\nEnter element to enter:");
                                 ad = int.Parse(System.Console.ReadLine());
                                ll.addLast(ad);
                                break;
                            case 4:
                                ll.printList(first);
                                break;
                            case 5:
                                System.Console.WriteLine(ll.printLength());
                                break;
                            case 6:
                                tr1 = false;
                                break;
                            default:
                                System.Console.WriteLine("Invalid Choice!!!");
                                break;
                        }
                    }
                    break;
                    
                case 2:
                    bool tr2 = true;
                    while (tr2)
                    {
                        System.Console.WriteLine("\nPlease enter a choice:\n1.Delete at Beginning\n2.Delete in middle\n3.Delete at end\n4.Print Linked List\n5.Print Length of List\n6.Back");
                        int sw = int.Parse(System.Console.ReadLine());
                        switch (sw)
                        {
                            case 1:
                                ll.deleteFirst();
                                break;
                            case 2:
                                System.Console.WriteLine("Enter pos to del the element:");
                                int ps = int.Parse(System.Console.ReadLine());
                                ll.deleteIndex(ps);
                                break;
                            case 3:
                                ll.deleteLast();
                                break;
                            case 4:
                                ll.printList(first);
                                break;
                            case 5:
                                System.Console.WriteLine(ll.printLength());
                                break;
                            case 6:
                                tr2 = false;
                                break;
                            default:
                                System.Console.WriteLine("Invalid Option!!");
                                break;
                        }
                        
                    }
                    break;

                case 3:
                    ll.printList(first);
                    break;
                case 4:
                    System.Console.WriteLine(ll.printLength());
                    break;
                case 5:
                    tr = false;
                    break;
                default:
                    System.Console.WriteLine("Invalid Option!!");
                    break;

            }
        }
    }
}