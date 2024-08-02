using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Window state change event data (<see cref="SDL_Event.Window"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WindowEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_WindowEvent
{
	/// <summary>
	/// One of the <see cref="SDL_EventType"/> values that start with <c>Window</c> (e.g.
	/// <see cref="SDL_EventType.WindowMoved"/>).
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The associated window.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// Event dependent data.
	/// </summary>
	public int Data1;

	/// <summary>
	/// Event dependent data.
	/// </summary>
	public int Data2;
}