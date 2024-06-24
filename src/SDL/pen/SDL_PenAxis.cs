namespace SDL_cs;

/// <summary>
/// Pen axis indices.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_PenAxis">here</see> for more details.
/// </remarks>
public enum SDL_PenAxis
{
	/// <summary>
	/// Pen pressure.  Unidirectional: 0..1.0
	/// </summary>
	Pressure = 0,

	/// <summary>
	/// Pen horizontal tilt angle. Bidirectional: -90.0..90.0 (left-to-right).
	/// </summary>
	/// <remarks>
	/// The physical max/min tilt may be smaller than -90.0 / 90.0, cf. <see cref="SDL_PenCapabilityInfo"/>.
	/// </remarks>
	XTilt,

	/// <summary>
	/// Pen vertical tilt angle.  Bidirectional: -90.0..90.0 (top-to-down).
	/// </summary>
	/// <remarks>
	/// The physical max/min tilt may be smaller than -90.0 / 90.0, cf. <see cref="SDL_PenCapabilityInfo"/>.
	/// </remarks>
	YTilt,

	/// <summary>
	/// Pen distance to drawing surface.  Unidirectional: 0.0..1.0
	/// </summary>
	Distance,

	/// <summary>
	/// Pen barrel rotation.  Bidirectional: -180..179.9 (clockwise, 0 is facing up, -180.0 is facing down).
	/// </summary>
	Rotation,

	/// <summary>
	/// Pen finger wheel or slider (e.g., Airbrush Pen).  Unidirectional: 0..1.0
	/// </summary>
	Slider,

	/// <summary>
	/// Last valid axis index.
	/// </summary>
	NumAxes,

	/// <summary>
	/// Last axis index plus 1
	/// </summary>
	Last = Slider
}