using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The structure used to identify an SDL gamepad
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Gamepad">documentation</see> for more details.
/// </remarks>
[Opaque]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_Gamepad;