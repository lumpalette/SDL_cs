using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A structure that encodes the stable unique id for a joystick device.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickGUID">documentation</see> for more details.
/// </remarks>
[Typedef, StructLayout(LayoutKind.Sequential)]
public readonly struct SDL_JoystickGuid
{
	internal SDL_JoystickGuid(SDL_Guid value)
	{
		_value = value;
	}

	/// <summary>
	/// Converts an <see cref="SDL_Guid"/> into an <see cref="SDL_JoystickGuid"/>.
	/// </summary>
	/// <param name="guid">The <see cref="SDL_Guid"/> to convert.</param>
	public static explicit operator SDL_JoystickGuid(SDL_Guid guid) => new(guid);

	/// <summary>
	/// Converts an <see cref="SDL_JoystickGuid"/> into an <see cref="SDL_Guid"/>.
	/// </summary>
	/// <param name="guid">The <see cref="SDL_JoystickGuid"/> to convert.</param>
	public static explicit operator SDL_Guid(SDL_JoystickGuid guid) => guid._value;

	private readonly SDL_Guid _value;
}