using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Information about a connected HID device
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_HidDeviceInfo
{
	/// <summary>
	/// Platform-specific device path.
	/// </summary>
	public byte* Path;

	/// <summary>
	/// Device Vendor ID.
	/// </summary>
	public ushort VendorId;

	/// <summary>
	/// Device Product ID.
	/// </summary>
	public ushort ProductId;

	/// <summary>
	/// Serial Number.
	/// </summary>
	public nint SerialNumber;

	/// <summary>
	/// Device Release Number in binary-coded decimal, also known as Device Version Number
	/// </summary>
	public ushort ReleaseNumber;

	/// <summary>
	/// Manufacturer String.
	/// </summary>
	public nint ManufacteurerString;

	/// <summary>
	/// Product string.
	/// </summary>
	public nint ProductString;

	/// <summary>
	/// Usage Page for this Device/Interface (Windows/Mac/hidraw only).
	/// </summary>
	public ushort UsagePage;

	/// <summary>
	/// Usage for this Device/Interface (Windows/Mac/hidraw only).
	/// </summary>
	public ushort Usage;

	/// <summary>
	/// The USB interface which this logical device represents.
	/// </summary>
	/// <remarks>
	/// Valid only if the device is a USB HID device. Set to -1 in all other cases.
	/// </remarks>
	public int Interface;

	/// <summary>
	/// Additional information about the USB interface.
	/// </summary>
	/// <remarks>
	/// Valid on libusb and Android implementations.
	/// </remarks>
	public int InterfaceClass;

	/// <summary>
	/// Additional information about the USB interface.
	/// </summary>
	/// <remarks>
	/// Valid on libusb and Android implementations.
	/// </remarks>
	public int InterfaceSubclass;

	/// <summary>
	/// Additional information about the USB interface.
	/// </summary>
	/// <remarks>
	/// Valid on libusb and Android implementations.
	/// </remarks>
	public int InterfaceProtocol;

	/// <summary>
	/// Underlying bus type.
	/// </summary>
	public SDL_HidBusType BusType;

	/// <summary>
	/// Pointer to the next device.
	/// </summary>
	public SDL_HidDeviceInfo* Next;
}