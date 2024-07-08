using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The opaque handle that represents an audio stream.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioStream">documentation</see> for more details.
/// </remarks>
[Opaque]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_AudioStream;