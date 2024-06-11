using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Keyboard button event structure (FIXME:event.key.*)
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_KeyboardEvent">here</see>.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_KeyboardEvent
{
	/// <summary>
	/// Can be either <see cref="SDL_EventType.KeyDown"/> or <see cref="SDL_EventType.KeyUp"/>.
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
	/// The keyboard instance ID, or 0 if unknown or virtual.
	/// </summary>
	public SDL_KeyboardId Which;

	/// <summary>
	/// Can be <see cref="SDL_InputState.Pressed"/> or <see cref="SDL_InputState.Released"/>.
	/// </summary>
	public SDL_InputState State;

	/// <summary>
	/// Non-zero if this is a key repeat.
	/// </summary>
	public byte Repeat;

	private readonly byte _padding;

	private readonly byte _padding1;

	/// <summary>
	/// The key that was pressed or released.
	/// </summary>
	public SDL_Keysym Keysym;
}