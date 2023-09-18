public class InsuranceMessagingVisitor: IVisitor
{
    public void SendInsuranceMails(List<Client> clients)
    {
        foreach(Client client in clients)
        {
            client.Accept(this);
        }
    }

    public void VisitBank(Client client)
    {
        Console.WriteLine("Sending main about theft insurance...");
    }

    public void VisitCompany(Company company)
    {
        Console.WriteLine("Sending employees and equipment insurance mail...");
    }

    public void VisitResident(Resident resident)
    {
        Console.WriteLine("Sending mail about medical insurance...");
    }

    public void VisitRestaurant(Restaurant restaurant)
    {
        Console.WriteLine("Sending mail about fire and food insurance...");
    }
}

