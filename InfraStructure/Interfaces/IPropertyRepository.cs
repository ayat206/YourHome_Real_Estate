﻿using InfraStructure.ViewModels;
using Microsoft.AspNetCore.Http;

namespace InfraStructure.Interfaces
{
    public interface IPropertyRepository
    {
         Task<bool> IsImageFile(IFormFile file);
        Task<bool> AddProperty(PropertyCreatVm model);
        Task<List<PropertyVm>> PropertyListForOwner(int id);
        Task<List<PropertyVm>> PropertyListForType(int id);
        Task<List<PropertyVm>> PropertyListForChoise(int id);
        Task<PropertyDetailsVm> PropertyDetails(int id);
        Task<bool> PropertyDelete(int id);
    }
}
