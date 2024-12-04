using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// SDL_hidapi.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_hidapi.h.
namespace SDL3;

/// <summary>
/// An opaque handle representing an open HID device.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_device">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_hid_device;

/// <summary>
/// HID underlying bus types.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_bus_type">documentation</see> for more details.
/// </remarks>
public enum SDL_hid_bus_type
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

/// <summary>
/// Information about a connected HID device
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_device_info">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_hid_device_info
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
	public SDL_hid_bus_type BusType;

	/// <summary>
	/// Pointer to the next device.
	/// </summary>
	public SDL_hid_device_info* Next;
}

unsafe partial class SDL
{
	/// <summary>
	/// Initialize the HIDAPI library.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_init">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_init")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_init();

	/// <summary>
	/// Finalize the HIDAPI library.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_exit">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_exit")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_exit();

	/// <summary>
	/// Check to see if devices may have been added or removed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_device_change_count">documentation</see> for more details.
	/// </remarks>
	/// <returns>A change counter that is incremented with each potential device change, or 0 if device change detection isn't available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_device_change_count")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial uint hid_device_change_count();

	/// <summary>
	/// Enumerate the HID Devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_enumerate">documentation</see> for more details.
	/// </remarks>
	/// <param name="vendorId">The Vendor ID (VID) of the types of device to open, or 0 to match any vendor.</param>
	/// <param name="productId">The Product ID (PID) of the types of device to open, or 0 to match any product.</param>
	/// <returns>
	/// A pointer to a linked list of type SDL_hid_device_info, containing information about the HID devices attached to the system,
	/// or <see langword="null"/> in the case of failure. Free this linked list by calling <see cref="hid_free_enumeration(SDL_hid_device_info*)"/>.
	/// </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_enumerate")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_hid_device_info* hid_enumerate(ushort vendorId, ushort productId);

	/// <summary>
	/// Free an enumeration linked list.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_free_enumeration">documentation</see> for more details.
	/// </remarks>
	/// <param name="devs">Pointer to a list of struct_device returned from <see cref="hid_enumerate(ushort, ushort)"/>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_free_enumeration")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void hid_free_enumeration(SDL_hid_device_info* devs);

	/// <summary>
	/// Open a HID device using a Vendor ID (VID), Product ID (PID) and optionally a serial number.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_open">documentation</see> for more details.
	/// </remarks>
	/// <param name="vendorId">The Vendor ID (VID) of the device to open.</param>
	/// <param name="productId">The Product ID (PID) of the device to open.</param>
	/// <param name="serialNumber">The Serial Number of the device to open (Optionally <see langword="null"/>).</param>
	/// <returns>A pointer to a <see cref="SDL_hid_device"/> object on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_open")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_hid_device* hid_open(ushort vendorId, ushort productId, nint serialNumber);

	/// <summary>
	/// Open a HID device by its path name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_open_path">documentation</see> for more details.
	/// </remarks>
	/// <param name="path">The path name of the device to open.</param>
	/// <returns>A pointer to a <see cref="SDL_hid_device"/> object on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_open_path", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_hid_device* hid_open_path(string path);

	/// <summary>
	/// Write an Output report to a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_write">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="data">The data to send, including the report number as the first byte.</param>
	/// <param name="length">The length in bytes of the data to send.</param>
	/// <returns>The actual number of bytes written and -1 on on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_write")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_write(SDL_hid_device* dev, byte* data, nuint length);

	/// <summary>
	/// Read an Input report from a HID device with timeout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_read_timeout">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="data">A buffer to put the read data into.</param>
	/// <param name="length">The number of bytes to read. For devices with multiple reports, make sure to read an extra byte for the report number.</param>
	/// <param name="miliseconds">Timeout in milliseconds or -1 for blocking wait.</param>
	/// <returns>
	/// The actual number of bytes read and -1 on on failure; call <see cref="GetError"/> for more information.
	/// If no packet was available to be read within the timeout period, this function returns 0.
	/// </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_read_timeout")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_read_timeout(SDL_hid_device* dev, byte* data, nuint length, int miliseconds);

	/// <summary>
	/// Read an Input report from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_read">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="data">A buffer to put the read data into.</param>
	/// <param name="length">The number of bytes to read. For devices with multiple reports, make sure to read an extra byte for the report number.</param>
	/// <returns>
	/// The actual number of bytes read and -1 on on failure; call <see cref="GetError"/> for more information.
	/// If no packet was available to be read within the timeout period, this function returns 0.
	/// </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_read")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_read(SDL_hid_device* dev, byte* data, nuint length);

	/// <summary>
	/// Set the device handle to be non-blocking.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_set_nonblocking">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="nonblock">Enable or not the nonblocking reads - 1 to enable nonblocking - 0 to disable nonblocking.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_set_nonblocking")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_set_nonblocking(SDL_hid_device* dev, int nonblock);

	/// <summary>
	/// Send a Feature report to the device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_send_feature_report">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="data">The data to send, including the report number as the first byte.</param>
	/// <param name="length">The length in bytes of the data to send, including the report number.</param>
	/// <returns>The actual number of bytes written and -1 on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_send_feature_report")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_send_feature_report(SDL_hid_device* dev, byte* data, nuint length);

	/// <summary>
	/// Get a feature report from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_feature_report">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="data">A buffer to put the read data into, including the Report ID. Set the first byte of data to the Report ID of the report to be read, or set it to zero if your device does not use numbered reports.</param>
	/// <param name="length">The number of bytes to read, including an extra byte for the report ID.The buffer can be longer than the actual report.</param>
	/// <returns>The number of bytes read plus one for the report ID (which is still in the first byte), or -1 on on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_feature_report")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_get_feature_report(SDL_hid_device* dev, byte* data, nuint length);

	/// <summary>
	/// Get an input report from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_input_report">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="data">A buffer to put the read data into, including the Report ID. Set the first byte of data to the Report ID of the report to be read, or set it to zero if your device does not use numbered reports.</param>
	/// <param name="length">The number of bytes to read, including an extra byte for the report ID.The buffer can be longer than the actual report.</param>
	/// <returns>The number of bytes read plus one for the report ID (which is still in the first byte), or -1 on on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_input_report")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_get_input_report(SDL_hid_device* dev, byte* data, nuint length);

	/// <summary>
	/// Close a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_close">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_close")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_close(SDL_hid_device* dev);

	/// <summary>
	/// Get The Manufacturer String from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_manufacturer_string">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="str">A wide string buffer to put the data into.</param>
	/// <param name="maxLen">The length of the buffer in multiples of <c>wchar_t</c>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_manufacturer_string")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_get_manufacturer_string(SDL_hid_device* dev, nint str, nuint maxLen);

	/// <summary>
	/// Get The Product String from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_product_string">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="str">A wide string buffer to put the data into.</param>
	/// <param name="maxLen">The length of the buffer in multiples of <c>wchar_t</c>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_product_string")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_get_product_string(SDL_hid_device* dev, nint str, nuint maxLen);

	/// <summary>
	/// Get The Serial String from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_serial_number_string">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="str">A wide string buffer to put the data into.</param>
	/// <param name="maxLen">The length of the buffer in multiples of <c>wchar_t</c>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_serial_number_string")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_get_serial_number_string(SDL_hid_device* dev, nint str, nuint maxLen);

	/// <summary>
	/// Get a string from a HID device, based on its string index.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_indexed_string">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="strIndex">The index of the string to get.</param>
	/// <param name="str">A wide string buffer to put the data into.</param>
	/// <param name="maxLen">The length of the buffer in multiples of <c>wchar_t</c>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_indexed_string")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_get_indexed_string(SDL_hid_device* dev, int strIndex, nint str, nuint maxLen);

	/// <summary>
	/// Get the device info from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_device_info">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <returns>
	/// A pointer to the <see cref="SDL_hid_device_info"/> for this hid_device or <see langword="null"/> on failure; call
	/// <see cref="GetError"/> for more information. This struct is valid until the device is closed with
	/// <see cref="hid_close(SDL_hid_device*)"/>.
	/// </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_device_info")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_hid_device_info* hid_get_device_info(SDL_hid_device* dev);

	/// <summary>
	/// Get a report descriptor from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_report_descriptor">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="hid_open(ushort, ushort, nint)"/>.</param>
	/// <param name="buffer">The buffer to copy descriptor into.</param>
	/// <param name="bufferSize">The size of the buffer in bytes.</param>
	/// <returns>The number of bytes actually copied or -1 on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_report_descriptor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int hid_get_report_descriptor(SDL_hid_device* dev, byte* buffer, nuint bufferSize);

	/// <summary>
	/// Start or stop a BLE scan on iOS and tvOS to pair Steam Controllers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_ble_scan">documentation</see> for more details.
	/// </remarks>
	/// <param name="active">True to start the scan, false to stop the scan.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_ble_scan")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void hid_ble_scan([MarshalAs(NativeBool)] bool active);
}