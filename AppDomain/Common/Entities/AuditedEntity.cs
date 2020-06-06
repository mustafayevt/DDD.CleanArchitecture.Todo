using System;

namespace AppDomain.Common.Entities
{
    public interface IAudited
    {

    }

    public interface IHasCreationTime : IAudited
    {
        public DateTime CreatedDate { get; set; }
    }

    public interface ICreationAudited : IHasCreationTime
    {
        public long? CreatedUserId { get; set; }
    }

    public interface IHasModificationTime : IAudited
    {
        public DateTime? LastModifiedDate { get; set; }
    }

    public interface IModificationAudited : IHasModificationTime
    {
        public long? LastModifiedUserId { get; set; }
    }

    public interface IHasDeletionTime : IAudited
    {
        public DateTime? DeletedDate { get; set; }
    }

    public interface IDeletionAudited : IHasDeletionTime
    {
        public long? DeletedUserId { get; set; }
    }
}