namespace SDL3;

/// <summary>
/// The list of buttons available on a gamepad
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadButton">documentation</see> for more details.
/// </remarks>
public enum SDL_GamepadButton
{
	/// <summary>
	/// Invalid button.
	/// </summary>
	Invalid = -1,

	/// <summary>
	/// Bottom face button (e.g. Xbox A button).
	/// </summary>
	South,

	/// <summary>
	/// Right face button (e.g. Xbox B button).
	/// </summary>
	East,

	/// <summary>
	/// Left face button (e.g. Xbox X button).
	/// </summary>
	West,

	/// <summary>
	/// Top face button (e.g. Xbox Y button).
	/// </summary>
	North,

	Back,
	Guide,
	Start,
	LeftStick,
	RightStick,
	LeftShoulder,
	RightShoulder,
	DPadUp,
	DPadDown,
	DPadLeft,
	DPadRight,

	/// <summary>
	/// Additional button (e.g. Xbox Series X share button, PS5 microphone button, Nintendo Switch Pro capture button,
	/// Amazon Luna microphone button, Google Stadia capture button)
	/// </summary>
	Misc1,

	/// <summary>
	/// Upper or primary paddle, under your right hand (e.g. Xbox Elite paddle P1).
	/// </summary>
	RightPaddle1,

	/// <summary>
	/// Upper or primary paddle, under your left hand (e.g. Xbox Elite paddle P3).
	/// </summary>
	LeftPaddle1,

	/// <summary>
	/// Lower or secondary paddle, under your right hand (e.g. Xbox Elite paddle P2).
	/// </summary>
	RightPaddle2,

	/// <summary>
	/// Lower or secondary paddle, under your left hand (e.g. Xbox Elite paddle P4).
	/// </summary>
	LeftPaddle2,

	/// <summary>
	/// PS4/PS5 touchpad button.
	/// </summary>
	Touchpad,

	/// <summary>
	/// Additional button.
	/// </summary>
	Misc2,

	/// <summary>
	/// Additional button.
	/// </summary>
	Misc3,

	/// <summary>
	/// Additional button.
	/// </summary>
	Misc4,

	/// <summary>
	/// Additional button.
	/// </summary>
	Misc5,

	/// <summary>
	/// Additional button.
	/// </summary>
	Misc6,

	Count
}