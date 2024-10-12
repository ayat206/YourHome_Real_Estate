using InfraStructure.ViewModels;

namespace InfraStructure.Interfaces
{
	public interface IOwnerRepository
	{
		Task<bool> AddOwner(OwnerCreateVm model);
		Task<OwnerUpdateVm> OwnerGetById(int id);
		Task<bool> OwnerUpdate(OwnerUpdateVm model);
		Task<OwnerVm> OwnerVmGetById(int id);

    }
}
