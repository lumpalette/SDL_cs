using System.Runtime.InteropServices;

namespace SDL_cs;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int SDL_VirtualJoysticRumbleCallback(nint userData, ushort lowFrequencyRumble, ushort highFrequencyRumble);