using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Gamepad button event structure (<see cref="SDL_Event.GamepadButton"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadButtonEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadButtonEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.GamepadButtonDown"/> or <see cref="SDL_EventType.GamepadButtonUp"/>.
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
	/// The gamepad button (<see cref="SDL_GamepadButton"/>).
	/// </summary>
	public byte Button;

	/// <summary>
	/// Either <see cref="SDL.Pressed"/> or <see cref="SDL.Released"/>.
	/// </summary>
	public byte State;

	private readonly byte _padding1;

	private readonly byte _padding2;
}