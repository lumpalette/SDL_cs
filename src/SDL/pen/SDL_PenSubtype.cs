namespace SDL_cs;

/// <summary>
/// Pen types.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_PenSubtype">here</see> for more details.
/// </remarks>
public enum SDL_PenSubtype
{
	/// <summary>
	/// Unknown pen.
	/// </summary>
	Unknown,

	/// <summary>
	/// Eraser.
	/// </summary>
	Eraser,

	/// <summary>
	/// Generic pen; this is the default.
	/// </summary>
	Pen,

	/// <summary>
	/// Pencil.
	/// </summary>
	Pencil,

	/// <summary>
	/// Brush-like device.
	/// </summary>
	Brush,

	/// <summary>
	/// Airbrush device that "sprays" ink.
	/// </summary>
	Airbrush,

	/// <summary>
	/// Last valid pen type.
	/// </summary>
	Last = Airbrush
}