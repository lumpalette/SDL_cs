using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Window state change event data (<see cref="SDL_Event.Window"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_WindowEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_WindowEvent
{
	/// <summary>
	/// An <see cref="SDL_EventType"/> that has <c>Window</c> as prefix.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
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