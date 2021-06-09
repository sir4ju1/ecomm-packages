namespace Common.Model
{
    public partial interface IStoreMappingSupported
    {
        /// <summary>
        /// Gets or sets a value indicating whether the entity is limited/restricted to certain stores
        /// </summary>
        bool LimitedToStores { get; set; }
    }
}