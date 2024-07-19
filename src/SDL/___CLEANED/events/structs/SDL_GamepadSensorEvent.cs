using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Gamepad sensor event structure (<see cref="SDL_Event.GamepadSensor"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadSensorEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_GamepadSensorEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.GamepadSensorUpdate"/>.
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
	/// The type of the sensor, one of the values of <see cref="SDL_SensorType"/>.
	/// </summary>
	public SDL_SensorType Sensor;

	/// <summary>
	/// Up to 3 values from the sensor, as defined in SDL_sensor.h.
	/// </summary>
	public float[] Data
	{
		get
		{
			var data = new float[3];
			for (int i = 0; i < 3; i++)
			{
				data[i] = _data[i];
			}
			return data;
		}
	}

	private fixed float _data[3];

	/// <summary>
	/// The timestamp of the sensor reading in nanoseconds, not necessarily synchronized with the system clock.
	/// </summary>
	public ulong SensorTimestamp;
}