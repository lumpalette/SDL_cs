using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Mouse motion event structure (<see cref="SDL_Event.MouseMotion"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseMotionEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MouseMotionEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.MouseMotion"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with mouse focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The mouse instance ID, <see cref="SDL.TouchMouseId"/>, or <see cref="SDL.PenMouseId"/>.
	/// </summary>
	public SDL_MouseId Which;

	/// <summary>
	/// The current button state
	/// </summary>
	public SDL_MouseButtonFlags State;

	/// <summary>
	/// X coordinate, relative to window.
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window.
	/// </summary>
	public float Y;

	/// <summary>
	/// The relative motion in the X direction.
	/// </summary>
	public float XRelative;

	/// <summary>
	/// The relative motion in the Y direction.
	/// </summary>
	public float YRelative;
}