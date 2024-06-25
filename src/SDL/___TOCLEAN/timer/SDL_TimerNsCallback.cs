using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Function prototype for the nanosecond timer callback function.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_NSTimerCallback">documentation</see> for more details.
/// </remarks>
/// <param name="userData"> Sn arbitrary pointer provided by the app through <see cref="SDL.SDL_AddTimerNs(uint, SDL_TimerMsCallback, void*)"/>, for its own use. </param>
/// <param name="timerId"> The current timer being processed. </param>
/// <param name="intervalNs"> The current callback time interval, in nanoseconds. </param>
/// <returns> The new callback time interval, or 0 to disable further runs of the callback. </returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate ulong SDL_TimerNsCallback(void* userData, SDL_TimerId timerId, ulong intervalNs);