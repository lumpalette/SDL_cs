using System.Runtime.InteropServices;

namespace SDL_cs;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate int SDL_VirtualJoysticRumbleTriggersCallback(void* userdata, ushort leftRumble, ushort rightRumble);