namespace WalletPlusInc.web.Data.Entities
{
    public abstract class BaseEntity<Tkey>
    {
        public Tkey Id { get; set; }
    }
}
