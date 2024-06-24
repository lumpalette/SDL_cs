using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Function prototype for the millisecond timer callback function.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_TimerCallback">here</see> for more details.
/// </remarks>
/// <param name="userData"> An arbitrary pointer provided by the app through <see cref="SDL.SDL_AddTimerMs(uint, SDL_cs.SDL_TimerMsCallback, void*)"/>, for its own use. </param>
/// <param name="timerId"> The current timer being processed. </param>
/// <param name="interval"> The current callback time interval, in miliseconds. </param>
/// <returns> The new callback time interval, or 0 to disable further runs of the callback. </returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate uint SDL_TimerMsCallback(void* userData, SDL_TimerId timerId, uint intervalMs);