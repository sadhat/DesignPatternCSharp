public abstract class Client
{
    public abstract void Accept(Visitor visitor);
}

public class Bank : Client
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitBank(this);
    }
}

public class Company : Client
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitCompany(this);
    }
}

public class Resident : Client
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitResident(this);
    }
}

public class Restaurant : Client
{
    public override void Accept(Visitor visitor)
    {
        visitor.VisitRestaurant(this);
    }
}