using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Joysick battery level change event structure (<see cref="SDL_Event.JoystickBattery"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_JoyBatteryEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoystickBatteryEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.JoystickBatteryUpdated"/>.
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
	/// The joystick battery state.
	/// </summary>
	public SDL_PowerState State;

	/// <summary>
	/// The joystick battery percent charge remaining.
	/// </summary>
	public int Percent;
}