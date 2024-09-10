using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Pressure-sensitive pen touched event structure (<see cref="SDL_Event.PenTouch"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PenTouchEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenTouchEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.PenDown"/> or <see cref="SDL_EventType.PenUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with pen focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The pen instance ID.
	/// </summary>
	public SDL_PenId Which;

	/// <summary>
	/// Complete pen input state at time of event.
	/// </summary>
	public SDL_PenInputFlags PenState;

	/// <summary>
	/// X position of pen on tablet.
	/// </summary>
	public float X;

	/// <summary>
	/// Y position of pen on tablet.
	/// </summary>
	public float Y;

	/// <summary>
	/// True if eraser end is used (not all pens support this).
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Eraser;

	/// <summary>
	/// True if the pen is touching or false if the pen is lifted off.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Down;
}