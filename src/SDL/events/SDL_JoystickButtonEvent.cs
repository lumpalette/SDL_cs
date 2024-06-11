using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Joystick button event structure (FIXME:event.jbutton.*)
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoystickButtonEvent
{
	/// <summary>
	/// Can be either <see cref="SDL_EventType.JoystickButtonDown"/> or <see cref="SDL_EventType.JoystickButtonUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The joystick button index.
	/// </summary>
	public byte Button;

	/// <summary>
	/// Can be <see cref="SDL_InputState.Pressed"/> or <see cref="SDL_InputState.Released"/>.
	/// </summary>
	public SDL_InputState State;

	private readonly byte _padding1;

	private readonly byte _padding2;
}