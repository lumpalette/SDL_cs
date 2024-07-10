namespace SDL_cs;

/// <summary>
/// States of a key or button.
/// </summary>
public enum SDL_InputState : byte
{
	/// <summary>
	/// A value that signifies a button is no longer pressed.
	/// </summary>
	Released,

	/// <summary>
	/// A value that signifies a button has been pressed down.
	/// </summary>
	Pressed
}