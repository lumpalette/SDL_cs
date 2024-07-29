using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Callback function that will be called when the clipboard is cleared, or new data is set.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClipboardCleanupCallback">documentation</see> for more details.
/// </remarks>
/// <param name="userData">A pointer to provided user data.</param>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void SDL_ClipboardCleanupCallback(nint userData);