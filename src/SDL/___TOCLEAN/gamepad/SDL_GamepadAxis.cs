namespace SDL_cs;

/// <summary>
/// The list of axes available on a gamepad
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadAxis">documentation</see> for more details.
/// </remarks>
public enum SDL_GamepadAxis : sbyte
{
	Invalid = -1,
	LeftX,
	LeftY,
	RightX,
	RightY,
	LeftTrigger,
	RightTrigger,
	Max
}