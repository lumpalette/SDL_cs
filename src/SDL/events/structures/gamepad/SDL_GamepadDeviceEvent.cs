using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Gamepad device event structure (<see cref="SDL_Event.GamepadDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadDeviceEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadDeviceEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.GamepadAdded"/>, <see cref="SDL_EventType.GamepadRemoved"/>,
	/// <see cref="SDL_EventType.GamepadRemapped"/>, <see cref="SDL_EventType.GamepadUpdateComplete"/> or
	/// <see cref="SDL_EventType.GamepadSteamHandleUpdated"/>.
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
}