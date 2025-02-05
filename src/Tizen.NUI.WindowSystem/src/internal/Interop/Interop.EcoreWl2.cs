using System;
using System.Collections.Generic;
using System.Text;

namespace Tizen.NUI.WindowSystem
{
    internal static partial class Interop
    {
        internal static partial class EcoreWl2
        {
            const string lib = "libtizen-core-wayland.so.0";

            [global::System.Runtime.InteropServices.DllImport(lib, EntryPoint = "tizen_core_wayland_get_window_id")]
            internal static extern int GetWindowId(IntPtr win);
        }
    }
}
