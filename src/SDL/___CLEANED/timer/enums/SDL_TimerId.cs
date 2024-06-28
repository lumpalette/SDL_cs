namespace SDL_cs;

/// <summary>
/// Definition of the timer ID type.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TimerID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_TimerId : uint
{
	/// <summary>
	/// An invalid timer ID. Used when a function that returns an <see cref="SDL_TimerId"/> fails.
	/// </summary>
	Invalid = 0
}