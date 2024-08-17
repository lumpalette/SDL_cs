namespace SDL3;

/// <summary>
/// This is a unique ID for a mouse for the time it is connected to the system, and is never reused for the lifetime of the application.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_MouseId : uint;