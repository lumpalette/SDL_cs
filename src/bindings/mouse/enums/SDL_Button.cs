namespace SDL_cs;

/// <summary>
/// Button indices in a mouse.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
/// </remarks>
public enum SDL_Button : byte
{
	/// <summary>
	/// Button 1: Left mouse button.
	/// </summary>
	Left = 1,

	/// <summary>
	/// Button 2: Middle mouse button.
	/// </summary>
	Middle = 2,

	/// <summary>
	/// Button 3: Right mouse button.
	/// </summary>
	Right = 3,

	/// <summary>
	/// Button 4: Side mouse button 1.
	/// </summary>
	X1 = 4,

	/// <summary>
	/// Button 5: Side mouse button 2.
	/// </summary>
	X2 = 5,
}