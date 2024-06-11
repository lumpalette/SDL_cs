using System.Runtime.InteropServices;
namespace SDL_cs;

/// <summary>
/// Gamepad sensor event structure (FIXME:event.gsensor.*).
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_GamepadSensorEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.GamepadSensorUpdate"/>.
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

	/// <summary>
	/// The type of the sensor.
	/// </summary>
	public SDL_SensorType Sensor;

	/// <summary>
	/// Up to 3 values from the sensor.
	/// </summary>
	public readonly float[] Data
	{
		get
		{
			float[] data = new float[3];
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