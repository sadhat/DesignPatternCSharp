public abstract class Client
{
    public abstract void Accept(IVisitor visitor);
}

public class Bank : Client
{
    public override void Accept(IVisitor visitor)
    {
        visitor.VisitBank(this);
    }
}

public class Company : Client
{
    public override void Accept(IVisitor visitor)
    {
        visitor.VisitCompany(this);
    }
}

public class Resident : Client
{
    public override void Accept(IVisitor visitor)
    {
        visitor.VisitResident(this);
    }
}

public class Restaurant : Client
{
    public override void Accept(IVisitor visitor)
    {
        visitor.VisitRestaurant(this);
    }
}