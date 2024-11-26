using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Village.Grocery.Exchanging.RNVillageGroceryExchanging
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNVillageGroceryExchangingModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNVillageGroceryExchangingModule"/>.
        /// </summary>
        internal RNVillageGroceryExchangingModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNVillageGroceryExchanging";
            }
        }
    }
}
