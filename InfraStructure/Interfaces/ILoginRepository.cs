using InfraStructure.ViewModels;

namespace InfraStructure.Interfaces
{
    public interface ILoginRepository
    {
        string GenerateOTP();
        bool SendOTP(string email, string otp);
        OwnerVm Login(LoginVm model);
    }
}
