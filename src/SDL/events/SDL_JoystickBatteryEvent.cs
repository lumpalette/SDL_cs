using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Joysick battery level change event structure (FIXME:event.jbattery.*).
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoystickBatteryEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.JoystickBatteryUpdated"/>.
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
	/// The joystick battery state.
	/// </summary>
	public SDL_PowerState State;

	/// <summary>
	/// The joystick battery percent charge remaining.
	/// </summary>
	public int Percent;
}