using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Gamepad device event structure (<see cref="SDL_Event.GamepadDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadDeviceEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadDeviceEvent
{
	/// <summary>
	/// Can be <see cref="SDL_EventType.GamepadAdded"/> or <see cref="SDL_EventType.GamepadRemoved"/>, <see cref="SDL_EventType.GamepadRemapped"/> or <see cref="SDL_EventType.GamepadSteamHandleUpdated"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance id.
	/// </summary>
	public SDL_JoystickId Which;
}