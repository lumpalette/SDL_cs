namespace SDL_cs;

/// <summary>
/// An enum of some common joystick types.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickType">documentation</see> for more details.
/// </remarks>
public enum SDL_JoystickType : ushort
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
	Throttle
}