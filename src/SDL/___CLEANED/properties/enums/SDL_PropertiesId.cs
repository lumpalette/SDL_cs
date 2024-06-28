namespace SDL_cs;

/// <summary>
/// SDL properties ID.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PropertiesID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_PropertiesId : uint
{
	/// <summary>
	/// An invalid set of properties. Used when a function that returns an <see cref="SDL_PropertiesId"/> fails or when
	/// you don't need/is not required to pass a set of properties to a function.
	/// </summary>
	Invalid = 0
}