namespace Quintessence.Models
{
    using System.Linq;

    public partial class QuintessenceDataContext
    {
        public void Save()
        {
            SubmitChanges();
        }
    }
}