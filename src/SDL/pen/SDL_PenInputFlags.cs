namespace SDL3;

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