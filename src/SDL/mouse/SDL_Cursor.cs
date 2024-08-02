using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// The structure that represents a cursor in SDL.
/// </summary>
[Opaque]
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_Cursor;