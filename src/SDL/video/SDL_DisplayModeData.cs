using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Internal display mode data.
/// </summary>
[Opaque]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_DisplayModeData;