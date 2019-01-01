using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace My.Toast.Library.RNMyToastLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNMyToastLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNMyToastLibraryModule"/>.
        /// </summary>
        internal RNMyToastLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNMyToastLibrary";
            }
        }
    }
}
