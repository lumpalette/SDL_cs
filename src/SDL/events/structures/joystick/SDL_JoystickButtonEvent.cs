using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Joystick button event structure (<see cref="SDL_Event.JoystickButton"/>)
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoyButtonEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoystickButtonEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.JoystickButtonDown"/> or <see cref="SDL_EventType.JoystickButtonUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
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
	/// True if the button is pressed.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Down;

	private readonly byte _padding1;

	private readonly byte _padding2;
}