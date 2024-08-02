namespace SDL3;

/// <summary>
/// Types of gamepad control bindings.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadBindingType">documentation</see> for more details.
/// </remarks>
public enum SDL_GamepadBindingType
{
	None = 0,
	Button,
	Axis,
	Hat
}