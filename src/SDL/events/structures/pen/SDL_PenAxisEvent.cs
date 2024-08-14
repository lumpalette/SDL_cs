using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Pressure-sensitive pen pressure / angle event structure (<see cref="SDL_Event.PenAxis"/>).
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenAxisEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.PenAxis"/>.
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
	/// Axis that has changed.
	/// </summary>
	public SDL_PenAxis Axis;

	/// <summary>
	/// New value of axis.
	/// </summary>
	public float Value;
}