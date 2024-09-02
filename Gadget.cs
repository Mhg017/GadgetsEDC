using System;

public class Gadget
{
    public string Name { get; set; }
    public bool CarryEveryday { get; set; }
    public DayOfWeek[] SpecificDays { get; set; }

    public Gadget(string name, bool carryEveryday, DayOfWeek[] specificDays = null)
    {
        Name = name;
        CarryEveryday = carryEveryday;
        SpecificDays = specificDays ?? new DayOfWeek[] { };
    }

    public override string ToString()
    {
        if (CarryEveryday)
        {
            return $"{Name} (Carried Everyday)";
        }
        else
        {
            return $"{Name} (Carried on: {string.Join(", ", SpecificDays)})";
        }
    }
}
