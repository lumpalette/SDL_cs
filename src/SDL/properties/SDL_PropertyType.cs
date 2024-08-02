namespace SDL3;

/// <summary>
/// SDL property types.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PropertyType">documentation</see> for more details.
/// </remarks>
public enum SDL_PropertyType
{
	/// <summary>
	/// The property is not valid.
	/// </summary>
	Invalid,

	/// <summary>
	/// The property is a pointer.
	/// </summary>
	Pointer,

	/// <summary>
	/// The property is a string.
	/// </summary>
	String,

	/// <summary>
	/// The property is a 64-bit signed integer.
	/// </summary>
	Number,

	/// <summary>
	/// The property is a floating point number.
	/// </summary>
	Float,

	/// <summary>
	/// The property is a boolean.
	/// </summary>
	Boolean
}