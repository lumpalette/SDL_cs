namespace SDL_cs;

/// <summary>
/// An enum of some common joystick types.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickType">here</see>.
/// </remarks>
public enum SDL_JoystickType
{
	Unknown,
	Gamepad,
	Wheel,
	ArcadeStick,
	FlightStick,
	DancePad,
	Guitar,
	DrumKit,
	ArcadePad,
	Throttle // ??????????
}