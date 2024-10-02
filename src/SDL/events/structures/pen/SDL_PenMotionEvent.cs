using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Pressure-sensitive pen motion event structure (<see cref="SDL_Event.PenMotion"/>).
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenMotionEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.PenMotion"/>.	
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
	/// X coordinate, relative to window
	/// </summary>
	public float X;

	/// <summary>
	/// Y coordinate, relative to window
	/// </summary>
	public float Y;
}