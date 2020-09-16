// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="xListHostsReply" /> struct.</summary>
    public static unsafe class xListHostsReplyTests
    {
        /// <summary>Validates that the <see cref="xListHostsReply" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<xListHostsReply>(), Is.EqualTo(sizeof(xListHostsReply)));
        }

        /// <summary>Validates that the <see cref="xListHostsReply" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(xListHostsReply).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="xListHostsReply" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(xListHostsReply), Is.EqualTo(32));
        }
    }
}
