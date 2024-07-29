using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Callback function that will be called when data for the specified mime-type is requested by the OS.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClipboardDataCallback">documentation</see> for more details.
/// </remarks>
/// <param name="userData">A pointer to provided user data.</param>
/// <param name="mimeType">The requested mime-type.</param>
/// <param name="size">A pointer filled in with the length of the returned data.</param>
/// <returns>
/// A pointer to the data for the provided mime-type. Returning <see langword="null"/> or setting length to 0 will cause no data to be 
/// sent to the "receiver". It is up to the receiver to handle this. Essentially returning no data is more or less undefined behavior
/// and may cause breakage in receiving applications.The returned data will not be freed so it needs to be retained and dealt with
/// internally.
/// </returns>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate nint SDL_ClipboardDataCallback(nint userData, string mimeType, out nuint size);