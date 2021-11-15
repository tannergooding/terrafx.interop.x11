// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop.Xlib
{
    public partial struct xListFontsReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD16")]
        public ushort maxNames;

        [NativeTypeName("CARD16")]
        public ushort nbytes;
    }
}
