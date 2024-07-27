using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Type definition of the hint callback function.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HintCallback">documentation</see> for more details.
/// </remarks>
/// <param name="userData">What was passed as <c>userData</c> to <see cref="SDL.AddHintCallback(string, SDL_HintCallback, nint)"/>.</param>
/// <param name="name">What was passed as <c>name</c> to <see cref="SDL.AddHintCallback(string, SDL_HintCallback, nint)"/>.</param>
/// <param name="oldValue">The previous hint value.</param>
/// <param name="newValue">The new value hint is to be set to.</param>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SDL_HintCallback(nint userData, string name, string oldValue, string newValue);