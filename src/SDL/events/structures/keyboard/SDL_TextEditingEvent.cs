using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

/// <summary>
/// Keyboard text editing event structure (<see cref="SDL_Event.TextEditing"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextEditingEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_TextEditingEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.TextEditing"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The window with keyboard focus, if any.
	/// </summary>
	public SDL_WindowId WindowId;

	/// <summary>
	/// The editing text.
	/// </summary>
	public readonly string? Text => Utf8StringMarshaller.ConvertToManaged(_text);

	private readonly byte* _text;

	/// <summary>
	/// The start cursor of selected editing text, or -1 if not set.
	/// </summary>
	public int Start;

	/// <summary>
	/// The length of selected editing text, or -1 if not set.
	/// </summary>
	public int Length;
}