using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Callback used for hit-testing.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HitTest">documentation</see> for more details.
/// </remarks>
/// <param name="window">Te <see cref="SDL_Window"/> where hit-testing was set on.</param>
/// <param name="area">An <see cref="SDL_Point"/> which should be hit-tested.</param>
/// <param name="data">What was passed as <c>callbackData</c> to <see cref="SDL.SetWindowHitTest(SDL_Window*, SDL_HitTestCallback, nint)"/>.</param>
/// <returns>An <see cref="SDL_HitTestResult"/> value</returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate SDL_HitTestResult SDL_HitTestCallback(SDL_Window* window, in SDL_Point area, nint data);