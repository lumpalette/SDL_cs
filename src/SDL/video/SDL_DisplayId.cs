namespace SDL3;

/// <summary>
/// This is a unique ID for a display for the time it is connected to the system, and is never reused for the lifetime of the application.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DisplayID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_DisplayId : uint
{
	/// <summary>
	/// An invalid/null display ID.
	/// </summary>
	Invalid = 0
}