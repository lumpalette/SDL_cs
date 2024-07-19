using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Sensor event structure (<see cref="SDL_Event.Sensor"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SensorEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_SensorEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.SensorUpdate"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The instance ID of the sensor.
	/// </summary>
	public SDL_SensorId Which;

	/// <summary>
	/// Up to 6 values from the sensor - additional values can be queried using
	/// <see cref="SDL.GetSensorData(SDL_Sensor*, float[], int)"/>.
	/// </summary>
	public float[] Data
	{
		get
		{
			var data = new float[6];
			for (int i = 0; i < 6; i++)
			{
				data[i] = _data[i];
			}
			return data;
		}
	}

	private fixed float _data[6];

	/// <summary>
	/// The timestamp of the sensor reading in nanoseconds, not necessarily synchronized with the system clock.
	/// </summary>
	public ulong SensorTimestamp;
}