namespace SDL_cs;

/// <summary>
/// SDL property type.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_PropertyType">here</see>.
/// </remarks>
public enum SDL_PropertyType
{
	/// <summary>
	/// The property is not valid.
	/// </summary>
	Invalid,

	/// <summary>
	/// The property is an arbitrary object.
	/// </summary>
	Pointer,

	/// <summary>
	/// The property is a string.
	/// </summary>
	String,

	/// <summary>
	/// The property is a signed 64-bit integer.
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