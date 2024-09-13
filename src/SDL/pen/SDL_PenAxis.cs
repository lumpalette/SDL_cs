namespace SDL3;

/// <summary>
/// Pen axis indices.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PenAxis">documentation</see> for more details.
/// </remarks>
public enum SDL_PenAxis
{
	/// <summary>
	/// Pen pressure.  Unidirectional: 0 to 1.0.
	/// </summary>
	Pressure,

	/// <summary>
	/// Pen horizontal tilt angle.  Bidirectional: -90.0 to 90.0 (left-to-right).
	/// </summary>
	/// <remarks>
	/// The physical max/min tilt may be smaller than -90.0 / 90.0.
	/// </remarks>
	XTilt,

	/// <summary>
	/// Pen vertical tilt angle.  Bidirectional: -90.0 to 90.0 (top-to-down).
	/// </summary>
	/// <remarks>
	/// The physical max/min tilt may be smaller than -90.0 / 90.0.
	/// </remarks>
	Yilt,

	/// <summary>
	/// Pen distance to drawing surface.  Unidirectional: 0.0 to 1.0.
	/// </summary>
	Distance,

	/// <summary>
	/// Pen barrel rotation.  Bidirectional: -180 to 179.9 (clockwise, 0 is facing up, -180.0 is facing down).
	/// </summary>
	Rotation,

	/// <summary>
	/// Pen finger wheel or slider (e.g., Airbrush Pen).  Unidirectional: 0 to 1.0.
	/// </summary>
	Slider,

	/// <summary>
	/// Pressure from squeezing the pen ("barrel pressure").
	/// </summary>
	TangentialPressure,

	/// <summary>
	/// Total known pen axis types in this version of SDL. This number may grow in future releases!
	/// </summary>
	Count
}