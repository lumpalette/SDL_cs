using System.Runtime.InteropServices;

namespace SDL_cs;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void SDL_VirtualJoysticSetPlayerIndexCallback(void* userData, int playerIndex);