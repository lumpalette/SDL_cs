using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Pressure-sensitive pen proximity event structure (<see cref="SDL_Event.PenProximity"/>)
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_PenProximityEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.PenProximityIn"/> or <see cref="SDL_EventType.PenProximityOut"/>.
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
}