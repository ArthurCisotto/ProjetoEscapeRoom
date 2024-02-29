// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Experimental.UI
{
    /// <summary>
    /// This class switches back and forth between two symbol boards that otherwise do not fit on the keyboard entirely
    /// </summary>
    public class SymbolKeyboard : MonoBehaviour
    {
        public NonNativeKeyboard Keyboard;
        //[Experimental]
        [SerializeField]
        private UnityEngine.UI.Button m_PageBck = null;

        [SerializeField]
        private UnityEngine.UI.Button m_PageFwd = null;

        private void Update()
        {
            // Visual reflection of state.
            m_PageBck.interactable = Keyboard.IsShifted;
            m_PageFwd.interactable = !Keyboard.IsShifted;
        }
    }
}
