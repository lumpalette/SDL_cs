using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// EGL attribute initialization callback type.
/// </summary>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate SDL_EGLAttrib* SDL_EGLAttribArrayCallback();