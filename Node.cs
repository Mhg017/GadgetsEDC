public class Node
{
    public Gadget Gadget { get; set; }
    public Node Next { get; set; }

    public Node(Gadget gadget)
    {
        Gadget = gadget;
        Next = null;
    }
}
