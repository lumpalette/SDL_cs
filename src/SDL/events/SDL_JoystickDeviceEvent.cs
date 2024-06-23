using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Joystick device event structure (<see cref="SDL_Event.JoystickDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_JoyDeviceEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoystickDeviceEvent
{
	/// <summary>
	/// Can be <see cref="SDL_EventType.JoystickAdded"/>, <see cref="SDL_EventType.JoystickRemoved"/> or <see cref="SDL_EventType.JoystickUpdateComplete"/>.
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
}