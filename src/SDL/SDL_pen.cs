// SDL_pen.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_pen.h
namespace SDL3;

/// <summary>
/// SDL pen instance IDs.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PenID">documentation</see> for more details.
/// </remarks>
public enum SDL_PenId : uint;

/// <summary>
/// Pen input flags, as reported by various pen events' <c>PenState</c> field.
/// </summary>
public enum SDL_PenInputFlags : uint
{
	/// <summary>
	/// &amp; to see if pen is pressed down.
	/// </summary>
	Down = 1u << 0,

	/// <summary>
	/// &amp; to see if button 1 is pressed.
	/// </summary>
	Button1 = 1u << 1,

	/// <summary>
	/// &amp; to see if button 2 is pressed.
	/// </summary>
	Button2 = 1u << 2,

	/// <summary>
	/// &amp; to see if button 3 is pressed.
	/// </summary>
	Button3 = 1u << 3,

	/// <summary>
	/// &amp; to see if button 4 is pressed.
	/// </summary>
	Button4 = 1u << 4,

	/// <summary>
	/// &amp; to see if button 5 is pressed.
	/// </summary>
	Button5 = 1u << 5,

	/// <summary>
	/// &amp; to see if eraser tip is used.
	/// </summary>
	EraserTip = 1u << 30
}

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
	XTilt,

	/// <summary>
	/// Pen vertical tilt angle.  Bidirectional: -90.0 to 90.0 (top-to-down).
	/// </summary>
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