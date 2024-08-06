using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// The structure used to identify an SDL gamepad
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Gamepad">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_Gamepad;