using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// The "quit requested" event (<see cref="SDL_Event.Quit"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_QuitEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_QuitEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.Quit"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;
}