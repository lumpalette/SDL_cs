using System.Runtime.InteropServices;

namespace SDL_cs;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int SDL_VirtualJoysticSetSensorsEnabledCallback(nint userData, [MarshalAs(BoolSize)] bool enabled);