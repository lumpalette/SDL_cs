using System.Runtime.InteropServices;
namespace SDL_cs;

/// <summary>
/// Gamepad sensor event structure (<see cref="SDL_Event.GamepadSensor"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadSensorEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_GamepadSensorEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.GamepadSensorUpdate"/>.
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

	/// <summary>
	/// The type of the sensor.
	/// </summary>
	public SDL_SensorType Sensor;

	/// <summary>
	/// Up to 3 values from the sensor.
	/// </summary>
	public fixed float Data[3];

	/// <summary>
	/// The timestamp of the sensor reading in nanoseconds, not necessarily synchronized with the system clock.
	/// </summary>
	public ulong SensorTimestamp;
}