using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A user-defined event type (<see cref="SDL_Event.User"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UserEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_UserEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.User"/> through <see cref="SDL_EventType.Last"/> - 1.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The associated window if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// User defined event code.
	/// </summary>
	public int Code;

	/// <summary>
	/// User defined data pointer.
	/// </summary>
	public nint Data1;

	/// <summary>
	/// User defined data pointer.
	/// </summary>
	public nint Data2;
}