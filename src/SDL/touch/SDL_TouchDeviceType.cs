namespace SDL_cs;

/// <summary>
/// An enumeration that specifies the type of touch device.
/// </summary>
public enum SDL_TouchDeviceType
{
	/// <summary>
	/// Invalid or unknown touch device type.
	/// </summary>
	Invalid = -1,

	/// <summary>
	/// Touch screen with window-relative coordinates.
	/// </summary>
	Direct,

	/// <summary>
	/// Trackpad with absolute device coordinates.
	/// </summary>
	IndirectAbsolute,

	/// <summary>
	/// Trackpad with screen cursor-relative coordinates.
	/// </summary>
	IndirectRelative
}