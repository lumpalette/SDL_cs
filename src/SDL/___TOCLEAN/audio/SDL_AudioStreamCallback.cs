using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A callback that fires when data passes through an <see cref="SDL_AudioStream"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioStreamCallback">documentation</see> for more details.
/// </remarks>
/// <param name="userData"> An opaque pointer provided by the app for their personal use. </param>
/// <param name="stream"> The SDL audio stream associated with this callback. </param>
/// <param name="additionalAmount"> The amount of data, in bytes, that is needed right now. </param>
/// <param name="totalAmount"> The total amount of data requested, in bytes, that is requested or available. </param>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void SDL_AudioStreamCallback(void* userData, SDL_AudioStream* stream, int additionalAmount, int totalAmount);