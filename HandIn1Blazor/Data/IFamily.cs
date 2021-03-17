using System.Collections.Generic;
using Models;

namespace HandIn1Blazor.Data
{
    public interface IFamily
    {
        public IList<Family> GetAllFamilies();
        void AddFamily(Family family);
        void RemoveFamily(Family family);
    }
}