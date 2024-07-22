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
	/// An invalid/null timer ID.
	/// </summary>
	Invalid = 0
}