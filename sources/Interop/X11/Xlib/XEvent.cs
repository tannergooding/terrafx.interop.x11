// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct XEvent
    {
        [FieldOffset(0)]
        public int type;

        [FieldOffset(0)]
        public XAnyEvent xany;

        [FieldOffset(0)]
        public XKeyEvent xkey;

        [FieldOffset(0)]
        public XButtonEvent xbutton;

        [FieldOffset(0)]
        public XMotionEvent xmotion;

        [FieldOffset(0)]
        public XCrossingEvent xcrossing;

        [FieldOffset(0)]
        public XFocusChangeEvent xfocus;

        [FieldOffset(0)]
        public XExposeEvent xexpose;

        [FieldOffset(0)]
        public XGraphicsExposeEvent xgraphicsexpose;

        [FieldOffset(0)]
        public XNoExposeEvent xnoexpose;

        [FieldOffset(0)]
        public XVisibilityEvent xvisibility;

        [FieldOffset(0)]
        public XCreateWindowEvent xcreatewindow;

        [FieldOffset(0)]
        public XDestroyWindowEvent xdestroywindow;

        [FieldOffset(0)]
        public XUnmapEvent xunmap;

        [FieldOffset(0)]
        public XMapEvent xmap;

        [FieldOffset(0)]
        public XMapRequestEvent xmaprequest;

        [FieldOffset(0)]
        public XReparentEvent xreparent;

        [FieldOffset(0)]
        public XConfigureEvent xconfigure;

        [FieldOffset(0)]
        public XGravityEvent xgravity;

        [FieldOffset(0)]
        public XResizeRequestEvent xresizerequest;

        [FieldOffset(0)]
        public XConfigureRequestEvent xconfigurerequest;

        [FieldOffset(0)]
        public XCirculateEvent xcirculate;

        [FieldOffset(0)]
        public XCirculateRequestEvent xcirculaterequest;

        [FieldOffset(0)]
        public XPropertyEvent xproperty;

        [FieldOffset(0)]
        public XSelectionClearEvent xselectionclear;

        [FieldOffset(0)]
        public XSelectionRequestEvent xselectionrequest;

        [FieldOffset(0)]
        public XSelectionEvent xselection;

        [FieldOffset(0)]
        public XColormapEvent xcolormap;

        [FieldOffset(0)]
        public XClientMessageEvent xclient;

        [FieldOffset(0)]
        public XMappingEvent xmapping;

        [FieldOffset(0)]
        public XErrorEvent xerror;

        [FieldOffset(0)]
        public XKeymapEvent xkeymap;

        [FieldOffset(0)]
        public XGenericEvent xgeneric;

        [FieldOffset(0)]
        public XGenericEventCookie xcookie;

        [FieldOffset(0)]
        [NativeTypeName("long [24]")]
        public _pad_e__FixedBuffer pad;

        public partial struct _pad_e__FixedBuffer
        {
            internal IntPtr e0;
            internal IntPtr e1;
            internal IntPtr e2;
            internal IntPtr e3;
            internal IntPtr e4;
            internal IntPtr e5;
            internal IntPtr e6;
            internal IntPtr e7;
            internal IntPtr e8;
            internal IntPtr e9;
            internal IntPtr e10;
            internal IntPtr e11;
            internal IntPtr e12;
            internal IntPtr e13;
            internal IntPtr e14;
            internal IntPtr e15;
            internal IntPtr e16;
            internal IntPtr e17;
            internal IntPtr e18;
            internal IntPtr e19;
            internal IntPtr e20;
            internal IntPtr e21;
            internal IntPtr e22;
            internal IntPtr e23;

            public unsafe ref IntPtr this[int index]
            {
                get
                {
                    fixed (IntPtr* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
