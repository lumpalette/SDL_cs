using System.Runtime.InteropServices;

namespace SDL_cs;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int SDL_VirtualJoysticSetLEDCallback(nint userData, byte red, byte green, byte blue);