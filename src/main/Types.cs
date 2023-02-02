using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ei8.Cortex.Diary.Plugins.MessageTree
{
    public enum ContextMenuOption
    {
        NotSet,
        New,
        Edit,
        Delete,
        AddRelative
    }

    public struct ErrorMessage
    {
        public const string MissingExternalInstantiatesMessage = "Required External Reference 'Instantiates, Message' was not found.";
        public const string MissingExternalInstantiatesGoogleDriveImage = "Required External Reference 'Instantiates, Google Drive Image' was not found.";
    }
}
