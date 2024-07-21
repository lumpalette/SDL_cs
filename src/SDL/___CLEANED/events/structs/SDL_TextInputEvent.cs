using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

/// <summary>
/// Keyboard text input event structure (<see cref="SDL_Event.TextInput"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextInputEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_TextInputEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.TextInput"/>.
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
	/// The input text, UTF-8 encoded.
	/// </summary>
	public readonly byte* TextRaw;

	/// <summary>
	/// The input text.
	/// </summary>
	public readonly string? Text => Utf8StringMarshaller.ConvertToManaged(TextRaw);
}