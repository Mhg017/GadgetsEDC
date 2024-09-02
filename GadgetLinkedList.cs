public class GadgetLinkedList
{
    private Node head;

    public GadgetLinkedList()
    {
        head = null;
    }

    // Add gadget to the end of the list
    public void Add(Gadget gadget)
    {
        Node newNode = new Node(gadget);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    // Insert gadget at specific position
    public void InsertAt(int index, Gadget gadget)
    {
        Node newNode = new Node(gadget);
        if (index == 0)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node current = head;
            int currentIndex = 0;

            while (current != null && currentIndex < index - 1)
            {
                current = current.Next;
                currentIndex++;
            }

            if (current == null)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }

    // Remove gadget by name
    public bool Remove(string name)
    {
        if (head == null) return false;

        if (head.Gadget.Name == name)
        {
            head = head.Next;
            return true;
        }

        Node current = head;
        while (current.Next != null && current.Next.Gadget.Name != name)
        {
            current = current.Next;
        }

        if (current.Next == null) return false;

        current.Next = current.Next.Next;
        return true;
    }

    // Find gadget by name
    public Gadget Find(string name)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Gadget.Name == name)
            {
                return current.Gadget;
            }
            current = current.Next;
        }
        return null;
    }

    // Count the gadgets in the list
    public int Count()
    {
        int count = 0;
        Node current = head;
        while (current != null)
        {
            count++;
            current = current.Next;
        }
        return count;
    }

    // Reverse the list
    public void Reverse()
    {
        Node prev = null;
        Node current = head;
        Node next = null;

        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next;
        }

        head = prev;
    }

    // Clear the list
    public void Clear()
    {
        head = null;
    }

    // Display the list
    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.Gadget);
            current = current.Next;
        }
    }

    // Display the list based on the day of the week
    public void Display(DayOfWeek day)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Gadget.CarryEveryday || current.Gadget.SpecificDays.Contains(day))
            {
                Console.WriteLine(current.Gadget);
            }
            current = current.Next;
        }
    }
}
