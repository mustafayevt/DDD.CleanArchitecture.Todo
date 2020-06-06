namespace AppDomain.Common.Entities
{
    public interface ISoftDelete
    {
        public bool IsDeleted { get; set; }
    }
}