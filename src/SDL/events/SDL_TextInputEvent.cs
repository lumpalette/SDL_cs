using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Keyboard text input event structure (<see cref="SDL_Event.TextInput"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_TextInputEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_TextInputEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.TextInput"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with keyboard focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The input text.
	/// </summary>
	public readonly string Text => Marshal.PtrToStringUTF8((nint)_text)!;

	private readonly byte* _text;
}