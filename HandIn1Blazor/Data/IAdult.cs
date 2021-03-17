using System.Collections.Generic;
using HandIn1Blazor.Models;

namespace HandIn1Blazor.Data
{
    public interface IAdult 
    {
        IList<Adult> GetAllAdults();
        void AddAdult(Adult adult);
        void RemoveAdult(int id);
    }
}