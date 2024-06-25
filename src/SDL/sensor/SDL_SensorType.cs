namespace SDL_cs;

/// <summary>
/// The different sensors defined by SDL.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SensorType">documentation</see> for more details.
/// </remarks>
public enum SDL_SensorType
{
	/// <summary>
	/// Returned for an invalid sensor.
	/// </summary>
	Invalid = -1,

	/// <summary>
	/// Unknown sensor type.
	/// </summary>
	Unknown,

	/// <summary>
	/// Accelerometer.
	/// </summary>
	Accelerometer,

	/// <summary>
	/// Gyroscope.
	/// </summary>
	Gyroscope,

	/// <summary>
	/// Accelerometer for left Joy-Con controller and Wii nunchuk.
	/// </summary>
	AccelerometerLeft,

	/// <summary>
	/// Gyroscope for left Joy-Con controller.
	/// </summary>
	GyroscopeLeft,

	/// <summary>
	/// Accelerometer for right Joy-Con controller.
	/// </summary>
	AccelerometerRight,

	/// <summary>
	/// Gyroscope for right Joy-Con controller.
	/// </summary>
	GyroscopeRight
}