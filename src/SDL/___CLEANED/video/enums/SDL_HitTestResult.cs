namespace SDL_cs;

/// <summary>
/// Possible return values from the <see cref="SDL_HitTestCallback"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HitTestResult">documentation</see> for more details.
/// </remarks>
public enum SDL_HitTestResult
{
	/// <summary>
	/// Region is normal. No special properties.
	/// </summary>
	Normal,

	/// <summary>
	/// Region can drag entire window.
	/// </summary>
	Draggable,

	/// <summary>
	/// Region is the resizable top-left corner border.
	/// </summary>
	ResizeTopLeft,

	/// <summary>
	/// Region is the resizable top border.
	/// </summary>
	ResizeTop,

	/// <summary>
	/// Region is the resizable top-right corner border.
	/// </summary>
	ResizeTopRight,

	/// <summary>
	/// Region is the resizable right border.
	/// </summary>
	ResizeRight,

	/// <summary>
	/// Region is the resizable bottom-right corner border.
	/// </summary>
	BottomRight,

	/// <summary>
	/// Region is the resizable bottom border.
	/// </summary>
	Bottom,

	/// <summary>
	/// Region is the resizable bottom-left corner border.
	/// </summary>
	BottomLeft,

	/// <summary>
	/// Region is the resizable left border.
	/// </summary>
	ResizeLeft
}