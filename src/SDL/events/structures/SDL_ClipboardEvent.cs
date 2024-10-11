using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// An event triggered when the clipboard contents have changed (<see cref="SDL_Event.Clipboard"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClipboardEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_ClipboardEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.ClipboardUpdate"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// Are we owning the clipboard? (internal update).
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Owner;

	/// <summary>
	/// Number of mime type.
	/// </summary>
	public int NMimeTypes;

	/// <summary>
	/// Current mime types.
	/// </summary>
	/// <remarks>
	/// You can use <see cref="SDL.UnmanagedToManagedStrings(byte**, int)"/> to convert this field into an array of managed strings.
	/// </remarks>
	[Const]
	public byte** MimeTypes;
}