using System.Collections.Generic;
using FileData;
using HandIn1Blazor.Models;

namespace HandIn1Blazor.Data
{
    public class AdultService : IAdult
    {
        private FileContext fileContext;
        
        public AdultService()
        {
            fileContext = new FileContext();
        }

        public IList<Adult> GetAllAdults()
        {
            return fileContext.Adults;
        }

        public void AddAdult(Adult adult)
        {
            fileContext.addAdult(adult);
        }

        public void RemoveAdult(int id)
        {
            fileContext.removeAdult(id);
        }
    }
}