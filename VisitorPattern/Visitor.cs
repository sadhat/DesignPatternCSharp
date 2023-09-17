public interface Visitor
{
    void VisitBank(Client client);

    void VisitCompany(Company company);

    void VisitResident(Resident resident);

    void VisitRestaurant(Restaurant restaurant);
}