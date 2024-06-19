namespace SDL_cs;

/// <summary>
/// Enumeration of mouse buttons.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">here</see> for more details.
/// </remarks>
public enum SDL_MouseButton : byte
{
	/// <summary>
	/// Left mouse button.
	/// </summary>
	Left = 1,

	/// <summary>
	/// Middle mouse button.
	/// </summary>
	Middle = 2,

	/// <summary>
	/// Right mouse button.
	/// </summary>
	Right = 3,

	/// <summary>
	/// Side mouse button 1.
	/// </summary>
	X1 = 4,

	/// <summary>
	/// Side mouse button 2.
	/// </summary>
	X2 = 5
}