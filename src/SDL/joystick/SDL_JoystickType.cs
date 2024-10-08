﻿namespace SDL3;

/// <summary>
/// An enum of some common joystick types.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickType">documentation</see> for more details.
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
	Throttle,
	Count
}