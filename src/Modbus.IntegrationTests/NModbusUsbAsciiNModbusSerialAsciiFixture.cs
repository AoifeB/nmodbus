using Modbus.Device;
using NUnit.Framework;

namespace Modbus.IntegrationTests
{
	[TestFixture]
	public class NModbusUsbAsciiNModbusSerialAsciiFixture : ModbusSerialMasterFixture
	{
		[TestFixtureSetUp]
		public override void Init()
		{
			base.Init();

			SetupSlaveSerialPort();
			Slave = ModbusSerialSlave.CreateAscii(SlaveAddress, SlaveSerialPort);
			StartSlave();

			MasterUsbPort = CreateAndOpenUsbPort(DefaultMasterUsbPortID);
			Master = ModbusSerialMaster.CreateAscii(MasterUsbPort);
		}

		[Test]
		public override void ReadCoils()
		{
			base.ReadCoils();
		}
	}
}
