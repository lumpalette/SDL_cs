namespace SDL_cs;

/// <summary>
/// This is a unique ID for a joystick for the time it is connected to the system, and is never reused for the lifetime
/// of the application.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_JoystickId
{
	/// <summary>
	/// Invalid/null joystick ID.
	/// </summary>
	Invalid = 0
}