namespace Blobs.Models
{
    using System;
    using Interfaces;

    public class EventHandlers
    {
        public delegate void OnToggleBehaviorEventHandler(IBlob sender, EventArgs eventArgs);

        public delegate void OnBlobDeathEventHandler(IBlob sender, EventArgs eventArgs);
    }
}
