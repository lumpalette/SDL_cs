namespace SDL_cs;

/// <summary>
/// Position identifiers of a window.
/// </summary>
public enum SDL_Windowpos : uint
{
	/// <summary>
	/// Used to indicate that you don't care what the window position is.
	/// </summary>
	Undefined = SDL.WindowposUndefinedMask | 0,

	/// <summary>
	/// Used to indicate that the window position should be centered.
	/// </summary>
	Centered = SDL.WindowposCenteredMask | 0
}