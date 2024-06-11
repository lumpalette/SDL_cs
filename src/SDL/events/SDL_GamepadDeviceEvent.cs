using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Gamepad device event structure (FIXME:event.gdevice.*).
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadDeviceEvent
{
	/// <summary>
	/// Can be <see cref="SDL_EventType.GamepadAdded"/> or <see cref="SDL_EventType.GamepadRemoved"/>, <see cref="SDL_EventType.GamepadRemapped"/> or <see cref="SDL_EventType.GamepadSteamHandleUpdated"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance id.
	/// </summary>
	public SDL_JoystickId Which;
}