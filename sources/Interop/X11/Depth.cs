// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct Depth
    {
        #region Fields
        public int depth;

        public int nvisuals;

        [NativeTypeName("Visual[]")]
        public Visual* visuals;
        #endregion
    }
}
