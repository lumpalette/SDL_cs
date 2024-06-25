using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A function pointer used for callbacks that watch the event queue.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EventFilter">documentation</see> for more details.
/// </remarks>
/// <param name="userData"> What was passed as 'userData' to <see cref="SDL.SetEventFilter(SDL_cs.SDL_EventFilterCallback, void*)"/> or <see cref="SDL.AddEventWatch(SDL_cs.SDL_EventFilterCallback, void*)"/>, etc. </param>
/// <param name="e"> The event that triggered the callback. </param>
/// <returns> 1 to permit event to be added to the queue, and 0 to disallow it. When used with <see cref="SDL_AddEventWatch()"/>, the return value is ignored. </returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int SDL_EventFilterCallback(void* userData, SDL_Event* e);