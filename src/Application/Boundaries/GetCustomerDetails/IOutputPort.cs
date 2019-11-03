using Domain;

namespace Application.Boundaries.GetCustomerDetails
{
    public interface IOutputPort
    {
        void Standard(GetCustomerDetailsOutput getCustomerDetailsOutput);
        void NotFound(string message);
    }
}