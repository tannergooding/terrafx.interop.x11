// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

namespace TerraFX.Interop
{
    public partial struct XCharStruct
    {
        public short lbearing;

        public short rbearing;

        public short width;

        public short ascent;

        public short descent;

        [NativeTypeName("unsigned short")]
        public ushort attributes;
    }
}
