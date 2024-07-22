using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The structure used to identify a sensor in SDL.
/// </summary>
[Opaque]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_Sensor;