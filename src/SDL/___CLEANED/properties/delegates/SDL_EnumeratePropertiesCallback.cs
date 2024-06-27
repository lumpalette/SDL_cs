using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A callback used to enumerate all properties set in an <see cref="SDL_PropertiesId"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_EnumeratePropertiesCallback">documentation</see> for more details.
/// </remarks>
/// <param name="userData">An app-defined pointer passed to the callback.</param>
/// <param name="props">The <see cref="SDL_PropertiesId"/> that is being enumerated.</param>
/// <param name="name">The next property name in the enumeration. Use <see cref="Marshal.PtrToStringUTF8(nint)"/> to convert the pointer into a C# string.</param>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void SDL_EnumeratePropertiesCallback(void* userData, SDL_PropertiesId props, byte* name);