using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A function pointer used for callbacks that watch the event queue.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EventFilter">documentation</see> for more details.
/// </remarks>
/// <param name="userData">What was passed as <c>userData</c> to <see cref="SDL.SetEventFilter(SDL_EventFilterCallback, nint)"/> or <see cref="SDL.AddEventWatch(SDL_EventFilterCallback, nint)"/>, etc.</param>
/// <param name="e">The event that triggered the callback.</param>
/// <returns>1 to permit event to be added to the queue, and 0 to disallow it. When used with <see cref="SDL.AddEventWatch(SDL_EventFilterCallback, nint)"/>, the return value is ignored.</returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int SDL_EventFilterCallback(nint userData, ref SDL_Event e);