List<Client> clients = new()
{
    new Bank(),
    new Company(),
    new Resident(),
    new Restaurant()
};
new InsuranceMessagingVisitor().SendInsuranceMails(clients);

