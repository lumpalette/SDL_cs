using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Function prototype for the millisecond timer callback function.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TimerCallback">documentation</see> for more details.
/// </remarks>
/// <param name="userData">An arbitrary pointer provided by the app through <see cref="SDL.AddTimer(uint, SDL_TimerCallback, nint)"/>, for its own use.</param>
/// <param name="timerId">The current timer being processed.</param>
/// <param name="intervalMs">The current callback time interval, in miliseconds.</param>
/// <returns>The new callback time interval, or 0 to disable further runs of the callback.</returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate uint SDL_TimerCallback(nint userData, SDL_TimerId timerId, uint intervalMs);