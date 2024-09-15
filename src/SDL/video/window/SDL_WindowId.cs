namespace SDL3;

/// <summary>
/// This is a unique ID for a window.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WindowID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_WindowId : uint
{
	/// <summary>
	/// An invalid/null window ID.
	/// </summary>
	Invalid = 0
}