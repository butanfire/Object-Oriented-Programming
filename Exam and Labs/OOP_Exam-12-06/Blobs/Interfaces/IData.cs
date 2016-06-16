namespace Blobs.Interfaces
{
    using System.Collections.Generic;

    public interface IData
    {
        IEnumerable<IBlob> Blobs { get; }

        void AddBlob(IBlob blob);
    }
}
