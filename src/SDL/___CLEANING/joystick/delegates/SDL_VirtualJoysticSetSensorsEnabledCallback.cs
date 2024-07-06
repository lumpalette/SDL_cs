using System.Runtime.InteropServices;

namespace SDL_cs;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int SDL_VirtualJoysticSetSensorsEnabledCallback(void* userData, [MarshalAs(UnmanagedType.I1)] bool enabled);