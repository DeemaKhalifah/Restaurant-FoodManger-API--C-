using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IFoodServices
    {
        Task<List<FoodDTO>> GetAll();
        Task Add(FoodDTO food);
        Task Delete(int id);
        Task Update(int id, FoodDTO updatedFood);

    }
}