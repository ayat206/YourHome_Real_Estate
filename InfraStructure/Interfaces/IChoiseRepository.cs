using InfraStructure.ViewModels;

namespace InfraStructure.Interfaces
{
    public interface IChoiseRepository
    {
        Task<List<ChoiseVm>> ChoiseGetAll();
    }
}
