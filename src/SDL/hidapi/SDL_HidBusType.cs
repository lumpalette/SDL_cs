namespace SDL3;

/// <summary>
/// HID underlying bus types.
/// </summary>
public enum SDL_HidBusType
{
	/// <summary>
	/// Unknown bus type.
	/// </summary>
	Unknown = 0x00,

	/// <summary>
	/// USB bus.
	/// </summary>
	/// <remarks>
	/// Specifications: <see href="https://usb.org/hid"/>
	/// </remarks>
	Usb = 0x01,

	/// <summary>
	/// Bluetooth or Bluetooth LE bus.
	/// </summary>
	/// <remarks>
	/// Specifications:<br/>
	/// <see href="https://www.bluetooth.com/specifications/specs/human-interface-device-profile-1-1-1/"/><br/>
	/// <see href="https://www.bluetooth.com/specifications/specs/hid-service-1-0/"/><br/>
	/// <see href="https://www.bluetooth.com/specifications/specs/hid-over-gatt-profile-1-0/"/>
	/// </remarks>
	Bluetooth = 0x02,

	/// <summary>
	/// I2C bus.
	/// </summary>
	/// <remarks>
	/// Specifications: <see href="https://docs.microsoft.com/previous-versions/windows/hardware/design/dn642101(v=vs.85)"/>
	/// </remarks>
	I2C = 0x03,

	/// <summary>
	/// SPI bus.
	/// </summary>
	/// <remarks>
	/// Specifications: <see href="https://www.microsoft.com/download/details.aspx?id=103325"/>
	/// </remarks>
	Spi = 0x04
}