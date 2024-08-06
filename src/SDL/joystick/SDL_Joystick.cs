using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// The joystick structure used to identify an SDL joystick.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Joystick">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_Joystick;