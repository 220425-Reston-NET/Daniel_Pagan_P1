using ModelGundam;

namespace ModelBL
{
    public interface IStoreBL
    {
        public List<Gundam> ViewStoreInventory(int p_sId);
    }
}