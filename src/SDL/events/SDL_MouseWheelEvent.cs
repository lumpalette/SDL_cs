using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Mouse wheel event structure (FIXME:event.wheel.*).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MouseWheelEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.MouseWheel"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with mouse focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The mouse instance ID, <see cref="FIXME:SDL_TOUCH_MOUSEID"/>, or <see cref="FIXME:SDL_PEN_MOUSEID"/>.
	/// </summary>
	public SDL_MouseId Which;

	/// <summary>
	/// The amount scrolled horizontally, positive to the right and negative to the left.
	/// </summary>
	public float X;

	/// <summary>
	/// The amount scrolled vertically, positive away from the user and negative toward the user.
	/// </summary>
	public float Y;

	/// <summary>
	/// Set to one value of the <see cref="SDL_MouseWheelDirection"/> enum.
	/// </summary>
	/// <remarks>
	/// When it is <see cref="SDL_MouseWheelDirection.Flipped"/>, the values in X and Y will be opposite. Multiply by -1 to change them back.
	/// </remarks>
	public SDL_MouseWheelDirection Direction;

	/// <summary>
	/// X coordinate, relative to window.
	/// </summary>
	public float MouseX;

	/// <summary>
	/// Y coordinate, relative to window.
	/// </summary>
	public float MouseY;
}