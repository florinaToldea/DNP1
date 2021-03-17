using System.Collections.Generic;
using FileData;
using Models;

namespace HandIn1Blazor.Data
{
    public class FamilyService : IFamily
    {
        private FileContext fileContext = new FileContext();
        private List<Family> families;

        public IList<Family> GetAllFamilies()
        {
            return fileContext.Families;
        }

        public void AddFamily(Family family)
        {
            families.Add(family);
            fileContext.SaveChanges();
        }

        public void RemoveFamily(Family family)
        {
            families.Remove(family);
            fileContext.SaveChanges();
        }
    }
}
