namespace SDL_cs;

/// <summary>
/// Types of gamepad control bindings.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadBindingType">here</see> for more details.
/// </remarks>
public enum SDL_GamepadBindingType
{
	None = 0,
	Button,
	Axis,
	Hat
}