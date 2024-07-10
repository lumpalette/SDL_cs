using System.Runtime.InteropServices;

namespace SDL_cs;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate SDL_EGLAttrib* SDL_EGLAttribArrayCallback();