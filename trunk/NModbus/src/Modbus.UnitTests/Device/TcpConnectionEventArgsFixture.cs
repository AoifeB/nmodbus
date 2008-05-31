﻿using System;
using Modbus.Device;
using NUnit.Framework;

namespace Modbus.UnitTests.Device
{
	[TestFixture]
	public class TcpConnectionEventArgsFixture
	{
		[Test, ExpectedException(typeof(ArgumentNullException))]
		public void TcpConnectionEventArgs_NullEndPoint()
		{
			new TcpConnectionEventArgs(null);
		}

		[Test, ExpectedException(typeof(ArgumentException))]
		public void TcpConnectionEventArgs_EmptyEndPoint()
		{
			new TcpConnectionEventArgs(String.Empty);
		}

		[Test]
		public void TcpConnectionEventArgs()
		{
			var args = new TcpConnectionEventArgs("foo");

			Assert.AreEqual("foo", args.EndPoint);
		}
	}
}
