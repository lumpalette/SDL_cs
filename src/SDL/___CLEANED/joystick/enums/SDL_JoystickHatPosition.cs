namespace SDL_cs;

/// <summary>
/// The possible positions of a POV hat on a joystick.
/// </summary>
public enum SDL_JoystickHatPosition : uint
{
	Centered = 0x00,
	Up = 0x01,
	Right = 0x02,
	Down = 0x04,
	Left = 0x08,
	RightUp = Right | Up,
	RightDown = Right | Down,
	LeftUp = Left | Up,
	LeftDown = Left | Down,
}