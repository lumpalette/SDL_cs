namespace SDL_cs;

/// <summary>
/// A structure that encodes the stable unique ID for a joystick device.
/// </summary>
/// <remarks>
/// This structure is a wrapper for an <see cref="SDL_Guid"/>. Refer to the official documentation
/// <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickGUID">here</see> for more details.
/// </remarks>
[Wrapper]
public readonly struct SDL_JoystickGuid
{
	internal SDL_JoystickGuid(SDL_Guid value)
	{
		_value = value;
	}

	public static explicit operator SDL_Guid(SDL_JoystickGuid x) => x._value;

	public static explicit operator SDL_JoystickGuid(SDL_Guid x) => new(x);

	private readonly SDL_Guid _value;
}