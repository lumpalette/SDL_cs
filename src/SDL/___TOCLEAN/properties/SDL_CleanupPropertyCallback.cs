using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A callback used to free resources when a property is deleted.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CleanupPropertyCallback">documentation</see> for more details.
/// </remarks>
/// <param name="userData"> An app-defined pointer passed to the callback. </param>
/// <param name="value"> The pointer assigned to the property to clean up. </param>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void SDL_CleanupPropertyCallback(void* userData, void* value);