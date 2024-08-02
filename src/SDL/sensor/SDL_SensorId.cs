namespace SDL3;

/// <summary>
/// This is a unique ID for a sensor for the time it is connected to the system, and is never reused for the
/// lifetime of the application.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SensorID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_SensorId : uint
{
	/// <summary>
	/// An invalid/null sensor ID.
	/// </summary>
	Invalid = 0
}