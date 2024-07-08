using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Describes how blit operations work internally.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitMap">documentation</see> for more details.
/// </remarks>
[Opaque]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_BlitMap;