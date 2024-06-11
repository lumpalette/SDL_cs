using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Fields shared by every event.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CommonEvent">here</see>.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_CommonEvent
{
	/// <summary>
	/// Event type, shared with all events, an unsigned 32-bit integer to cover user events which are not in the <see cref="SDL_EventType"/>
	/// enumeration.
	/// </summary>
	public uint Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
	/// </summary>
	public ulong Timestamp;
}