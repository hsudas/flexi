using MWSFinancesService.Model;

namespace Flexi.Model.Entity
{
    public class MyFinancialEvents : MongoRepository.Entity
    {
        public FinancialEvents financialEvents { get; set; }

    }

}
