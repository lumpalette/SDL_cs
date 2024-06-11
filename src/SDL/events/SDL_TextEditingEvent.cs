using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Keyboard text editing event structure (FIXME:event.edit.*).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_TextEditingEvent">here</see>.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_TextEditingEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.TextEditing"/>.
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
	/// The editing text.
	/// </summary>
	public readonly string Text => Marshal.PtrToStringUTF8((nint)_text)!;

	private readonly byte* _text;

	/// <summary>
	/// The start cursor of selected editing text.
	/// </summary>
	public int Start;

	/// <summary>
	/// The length of selected editing text.
	/// </summary>
	public int Length;
}