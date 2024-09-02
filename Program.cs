class Program
{
    static void Main(string[] args)
    {
        GadgetLinkedList edcList = new GadgetLinkedList();

        edcList.Add(new Gadget("Smartphone", true));
        edcList.Add(new Gadget("Laptop", false, new DayOfWeek[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday }));
        edcList.Add(new Gadget("Gym Bag", false, new DayOfWeek[] { DayOfWeek.Monday, DayOfWeek.Wednesday, DayOfWeek.Friday }));
        edcList.Add(new Gadget("Wallet", true));

        Console.WriteLine("All Gadgets:");
        edcList.Display();

        Console.WriteLine("\nGadgets for Monday:");
        edcList.Display(DayOfWeek.Monday);

        Console.WriteLine("\nRemoving 'Laptop':");
        edcList.Remove("Laptop");
        edcList.Display();

        Console.WriteLine("\nReversing the list:");
        edcList.Reverse();
        edcList.Display();
    }
}
