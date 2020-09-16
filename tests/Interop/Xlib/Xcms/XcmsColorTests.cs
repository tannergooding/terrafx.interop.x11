// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XcmsColor" /> struct.</summary>
    public static unsafe class XcmsColorTests
    {
        /// <summary>Validates that the <see cref="XcmsColor" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XcmsColor>(), Is.EqualTo(sizeof(XcmsColor)));
        }

        /// <summary>Validates that the <see cref="XcmsColor" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XcmsColor).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XcmsColor" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(XcmsColor), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(XcmsColor), Is.EqualTo(40));
            }
        }
    }
}
