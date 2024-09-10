using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Pressure-sensitive pen button event structure (<see cref="SDL_Event.PenButton"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PenButtonEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenButtonEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.PenButtonDown"/> or <see cref="SDL_EventType.PenButtonUp"/>.
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
	/// The pen button index (first button is 1).
	/// </summary>
	public byte Button;

	/// <summary>
	/// True if the button is pressed.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Down;
}