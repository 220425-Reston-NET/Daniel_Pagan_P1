using ModelDL;
using ModelGundam;

namespace ModelBL
{
    public class StoreBL : IStoreBL
    {
        private IRepository<Store> _storeRepo;
        public StoreBL(IRepository<Store> p_storeRepo)
        {
            _storeRepo = p_storeRepo;
        }
        public List<Gundam> ViewStoreInventory(int p_sId)
        {
            List<Store> listOfCurrentStore = _storeRepo.GetAll();

            foreach (Store item in listOfCurrentStore)
            {
                if (item.sId == p_sId)
                {
                    return item.Gundams;
                }
            }

            return null;
        }
    }
}