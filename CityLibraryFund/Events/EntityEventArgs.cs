using System;

namespace CityLibraryFund.Events
{
    public class EntityEventArgs : EventArgs
    {
        public string MenuName { get; set; }

        public EntityEventArgs(string menuName)
        {
            MenuName = menuName;
        }
    }

    public class EntityReloadRequestedEventArgs : EntityEventArgs
    {
        public EntityReloadRequestedEventArgs(string menuName) : base(menuName)
        {
        }
    }

    public class EntityCreatedEventArgs : EntityEventArgs
    {
        public EntityCreatedEventArgs(string menuName) : base(menuName)
        {
        }
    }

    public class EntityUpdatedEventArgs : EntityEventArgs
    {
        public EntityUpdatedEventArgs(string menuName) : base(menuName)
        {
        }
    }

    public class EntityDeletedEventArgs : EntityEventArgs
    {
        public EntityDeletedEventArgs(string menuName) : base(menuName)
        {
        }
    }
}
