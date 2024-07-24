using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Keyboard button event structure (<see cref="SDL_Event.Keyboard"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_KeyboardEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_KeyboardEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.KeyDown"/> or <see cref="SDL_EventType.KeyUp"/>.
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
	/// The keyboard instance id, or 0 if unknown or virtual
	/// </summary>
	public SDL_KeyboardId Which;

	/// <summary>
	/// SDL physical key code.
	/// </summary>
	public SDL_Scancode Scancode;

	/// <summary>
	/// SDL virtual key code.
	/// </summary>
	public SDL_Keycode Key;

	/// <summary>
	/// Current key modifiers.
	/// </summary>
	public SDL_Keymod Mod;

	/// <summary>
	/// The platform dependent scancode for this event.
	/// </summary>
	public ushort Raw;

	/// <summary>
	/// Either <see cref="SDL_State.Pressed"/> or <see cref="SDL_State.Released"/>.
	/// </summary>
	public SDL_State State;

	/// <summary>
	/// Non-zero if this is a key repeat.
	/// </summary>
	public byte Repeat;
}