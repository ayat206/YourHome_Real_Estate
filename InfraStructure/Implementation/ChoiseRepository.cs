using Domain_Models;
using InfraStructure.Interfaces;
using InfraStructure.ViewModels;

namespace InfraStructure.Implementation
{
    public class ChoiseRepository: IChoiseRepository
    {
        private readonly IGenericRepository repository;
        public ChoiseRepository(IGenericRepository repository)
        {
            this.repository = repository;
        }

        public async Task<List<ChoiseVm>> ChoiseGetAll()
        {
            List<ChoiseVm> choises = new List<ChoiseVm>();

            var results = await repository.GetAll<Choise>();

            foreach (var choise in results)
            {
                var choiseVm = new ChoiseVm
                {
                    Id = choise.Id,
                    Choise1=choise.Choise1
                };

                choises.Add(choiseVm);
            }

            return choises;
        }
    }
}
