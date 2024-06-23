using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The "quit requested" event (<see cref="SDL_Event.Quit"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_QuitEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_QuitEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.Quit"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
	/// </summary>
	public ulong Timestamp;
}