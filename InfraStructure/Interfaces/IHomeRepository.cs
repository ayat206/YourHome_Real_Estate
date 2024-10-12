using InfraStructure.ViewModels;

namespace InfraStructure.Interfaces
{
    public interface IHomeRepository
    {
        Task<List<PropertyVm>> PropertyList();
        Task<PropertyTypesCountVm> PropertyTypeCount();
        Task<List<PropertyVm>> PropertyListOfSearchBar(HomeSearchVm model);
    }
}
