namespace SDL3;

/// <summary>
/// A bitmask of pressed mouse buttons, as reported by <see cref="SDL.GetMouseState(float*, float*)"/>, etc.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MouseButtonFlags">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_MouseButtonFlags : uint;