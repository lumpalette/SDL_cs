using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// An event triggered when the clipboard contents have changed (<see cref="SDL_Event.Clipboard"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_ClipboardEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_ClipboardEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.ClipboardUpdate"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;
}