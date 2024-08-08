using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_hidapi.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_hidapi.h.
public static unsafe partial class SDL
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
	public static partial int HidInit();

	/// <summary>
	/// Finalize the HIDAPI library.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_exit">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_exit")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidExit();

	/// <summary>
	/// Check to see if devices may have been added or removed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_device_change_count">documentation</see> for more details.
	/// </remarks>
	/// <returns>A change counter that is incremented with each potential device change, or 0 if device change detection isn't available.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_device_change_count")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial uint HidDeviceChangeCount();

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
	/// or <see langword="null"/> in the case of failure. Free this linked list by calling <see cref="HidFreeEnumeration(SDL_HidDeviceInfo*)"/>.
	/// </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_enumerate")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_HidDeviceInfo* HidEnumerate(ushort vendorId, ushort productId);

	/// <summary>
	/// Free an enumeration linked list.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_free_enumeration">documentation</see> for more details.
	/// </remarks>
	/// <param name="devs">Pointer to a list of struct_device returned from <see cref="HidEnumerate(ushort, ushort)"/>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_free_enumeration")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void HidFreeEnumeration(SDL_HidDeviceInfo* devs);

	/// <summary>
	/// Open a HID device using a Vendor ID (VID), Product ID (PID) and optionally a serial number.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_open">documentation</see> for more details.
	/// </remarks>
	/// <param name="vendorId">The Vendor ID (VID) of the device to open.</param>
	/// <param name="productId">The Product ID (PID) of the device to open.</param>
	/// <param name="serialNumber">The Serial Number of the device to open (Optionally <see langword="null"/>).</param>
	/// <returns>A pointer to a <see cref="SDL_HidDevice"/> object on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_open")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_HidDevice* HidOpen(ushort vendorId, ushort productId, nint serialNumber);

	/// <summary>
	/// Open a HID device by its path name.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_open_path">documentation</see> for more details.
	/// </remarks>
	/// <param name="path">The path name of the device to open.</param>
	/// <returns>A pointer to a <see cref="SDL_HidDevice"/> object on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_open_path", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_HidDevice* HidOpenPath(string path);

	/// <summary>
	/// Write an Output report to a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_write">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="data">The data to send, including the report number as the first byte.</param>
	/// <param name="length">The length in bytes of the data to send.</param>
	/// <returns>The actual number of bytes written and -1 on on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_write")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidWrite(SDL_HidDevice* dev, byte* data, nuint length);

	/// <summary>
	/// Read an Input report from a HID device with timeout.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_read_timeout">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="data">A buffer to put the read data into.</param>
	/// <param name="length">The number of bytes to read. For devices with multiple reports, make sure to read an extra byte for the report number.</param>
	/// <param name="miliseconds">Timeout in milliseconds or -1 for blocking wait.</param>
	/// <returns>
	/// The actual number of bytes read and -1 on on failure; call <see cref="GetError"/> for more information.
	/// If no packet was available to be read within the timeout period, this function returns 0.
	/// </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_read_timeout")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidReadTimeout(SDL_HidDevice* dev, byte* data, nuint length, int miliseconds);

	/// <summary>
	/// Read an Input report from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_read">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="data">A buffer to put the read data into.</param>
	/// <param name="length">The number of bytes to read. For devices with multiple reports, make sure to read an extra byte for the report number.</param>
	/// <returns>
	/// The actual number of bytes read and -1 on on failure; call <see cref="GetError"/> for more information.
	/// If no packet was available to be read within the timeout period, this function returns 0.
	/// </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_read")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidRead(SDL_HidDevice* dev, byte* data, nuint length);

	/// <summary>
	/// Set the device handle to be non-blocking.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_set_nonblocking">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="nonblock">Enable or not the nonblocking reads - 1 to enable nonblocking - 0 to disable nonblocking.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_set_nonblocking")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidSetNonblocking(SDL_HidDevice* dev, int nonblock);

	/// <summary>
	/// Send a Feature report to the device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_send_feature_report">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="data">The data to send, including the report number as the first byte.</param>
	/// <param name="length">The length in bytes of the data to send, including the report number.</param>
	/// <returns>The actual number of bytes written and -1 on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_send_feature_report")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidSendFeatureReport(SDL_HidDevice* dev, byte* data, nuint length);

	/// <summary>
	/// Get a feature report from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_feature_report">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="data">A buffer to put the read data into, including the Report ID. Set the first byte of data to the Report ID of the report to be read, or set it to zero if your device does not use numbered reports.</param>
	/// <param name="length">The number of bytes to read, including an extra byte for the report ID.The buffer can be longer than the actual report.</param>
	/// <returns>The number of bytes read plus one for the report ID (which is still in the first byte), or -1 on on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_feature_report")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidGetFeatureReport(SDL_HidDevice* dev, byte* data, nuint length);

	/// <summary>
	/// Get an input report from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_input_report">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="data">A buffer to put the read data into, including the Report ID. Set the first byte of data to the Report ID of the report to be read, or set it to zero if your device does not use numbered reports.</param>
	/// <param name="length">The number of bytes to read, including an extra byte for the report ID.The buffer can be longer than the actual report.</param>
	/// <returns>The number of bytes read plus one for the report ID (which is still in the first byte), or -1 on on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_input_report")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidGetInputReport(SDL_HidDevice* dev, byte* data, nuint length);

	/// <summary>
	/// Close a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_close">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_close")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidClose(SDL_HidDevice* dev);

	/// <summary>
	/// Get The Manufacturer String from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_manufacturer_string">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="str">A wide string buffer to put the data into.</param>
	/// <param name="maxLen">The length of the buffer in multiples of <c>wchar_t</c>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_manufacturer_string")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidGetManufacturerString(SDL_HidDevice* dev, nint str, nuint maxLen);

	/// <summary>
	/// Get The Product String from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_product_string">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="str">A wide string buffer to put the data into.</param>
	/// <param name="maxLen">The length of the buffer in multiples of <c>wchar_t</c>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_product_string")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidGetProductString(SDL_HidDevice* dev, nint str, nuint maxLen);

	/// <summary>
	/// Get The Serial String from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_serial_number_string">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="str">A wide string buffer to put the data into.</param>
	/// <param name="maxLen">The length of the buffer in multiples of <c>wchar_t</c>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_serial_number_string")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidGetSerialNumberString(SDL_HidDevice* dev, nint str, nuint maxLen);

	/// <summary>
	/// Get a string from a HID device, based on its string index.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_indexed_string">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="strIndex">The index of the string to get.</param>
	/// <param name="str">A wide string buffer to put the data into.</param>
	/// <param name="maxLen">The length of the buffer in multiples of <c>wchar_t</c>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_indexed_string")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidGetIndexedString(SDL_HidDevice* dev, int strIndex, nint str, nuint maxLen);

	/// <summary>
	/// Get the device info from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_device_info">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <returns>
	/// A pointer to the <see cref="SDL_HidDeviceInfo"/> for this hid_device or <see langword="null"/> on failure; call
	/// <see cref="GetError"/> for more information. This struct is valid until the device is closed with
	/// <see cref="HidClose(SDL_HidDevice*)"/>.
	/// </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_device_info")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_HidDeviceInfo* HidGetDeviceInfo(SDL_HidDevice* dev);

	/// <summary>
	/// Get a report descriptor from a HID device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_get_report_descriptor">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device handle returned from <see cref="HidOpen(ushort, ushort, nint)"/>.</param>
	/// <param name="buffer">The buffer to copy descriptor into.</param>
	/// <param name="bufferSize">The size of the buffer in bytes.</param>
	/// <returns>The number of bytes actually copied or -1 on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_get_report_descriptor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int HidGetReportDescription(SDL_HidDevice* dev, byte* buffer, nuint bufferSize);

	/// <summary>
	/// Start or stop a BLE scan on iOS and tvOS to pair Steam Controllers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_hid_ble_scan">documentation</see> for more details.
	/// </remarks>
	/// <param name="active">True to start the scan, false to stop the scan.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_hid_ble_scan")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void HidBleScan([MarshalAs(NativeBool)] bool active);
}