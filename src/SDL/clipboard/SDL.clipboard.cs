using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

public static unsafe partial class SDL
{
	/// <summary>
	/// Put UTF-8 text into the clipboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetClipboardText">documentation</see> for more details.
	/// </remarks>
	/// <param name="text">The text to store in the clipboard.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetClipboardText", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetClipboardText(string text);

	/// <summary>
	/// Get UTF-8 text from the clipboard.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetClipboardText">documentation</see> for more details.
	/// </remarks>
	/// <returns>The clipboard text on success or an empty string on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetClipboardText")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial byte* GetClipboardText();

	/// <summary>
	/// Query whether the clipboard exists and contains a non-empty text string.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasClipboardText">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the clipboard has text, or false if it does not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasClipboardText")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasClipboardText();

	/// <summary>
	/// Put UTF-8 text into the primary selection.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetPrimarySelectionText">documentation</see> for more details.
	/// </remarks>
	/// <param name="text">The text to store in the primary selection.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetPrimarySelectionText", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetPrimarySelectionText(string text);

	/// <summary>
	/// Get UTF-8 text from the primary selection.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPrimarySelectionText">documentation</see> for more details.
	/// </remarks>
	/// <returns>The primary selection text on success or an empty string on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPrimarySelectionText")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial byte* GetPrimarySelectionText();

	/// <summary>
	/// Query whether the primary selection exists and contains a non-empty text string.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasPrimarySelectionText">documentation</see> for more details.
	/// </remarks>
	/// <returns>True if the primary selection has text, or false if it does not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasPrimarySelectionText")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasPrimarySelectionText();

	/// <summary>
	/// Offer clipboard data to the OS.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetClipboardData">documentation</see> for more details.
	/// </remarks>
	/// <param name="callback">A function pointer to the function that provides the clipboard data.</param>
	/// <param name="cleanup">A function pointer to the function that cleans up the clipboard data.</param>
	/// <param name="userData">An opaque pointer that will be forwarded to the callbacks.</param>
	/// <param name="mimeTypes">A list of mime-types that are being offered.</param>
	/// <param name="numMimeTypes">The number of mime-types in the mime_types list.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetClipboardData", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetClipboardData(delegate* unmanaged[Cdecl]<nint, string, nuint*, void> callback, delegate* unmanaged[Cdecl]<nint, void> cleanup, nint userData, [In] string[] mimeTypes, nuint numMimeTypes);

	/// <summary>
	/// Clear the clipboard data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearClipboardData">documentation</see> for more details.
	/// </remarks>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ClearClipboardData")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ClearClipboardData();

	/// <summary>
	/// Get the data from clipboard for a given mime type.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetClipboardData">documentation</see> for more details.
	/// </remarks>
	/// <param name="mimeType">The mime type to read from the clipboard.</param>
	/// <param name="size">A pointer filled in with the length of the returned data.</param>
	/// <returns>The retrieved data buffer or <see cref="nint.Zero"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetClipboardData", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nint GetClipboardData(string mimeType, out nuint size);

	/// <summary>
	/// Query whether there is data in the clipboard for the provided mime type.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_HasClipboardData">documentation</see> for more details.
	/// </remarks>
	/// <param name="mimeType">The mime type to check for data for.</param>
	/// <returns>True if there exists data in clipboard for the provided mime type, false if it does not.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_HasClipboardData", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool HasClipboardData(string mimeType);
}