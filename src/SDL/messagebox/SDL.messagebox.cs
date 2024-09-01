using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_messagebox.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_messagebox.h.
unsafe partial class SDL
{
	/// <summary>
	/// Create a modal message box.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowMessageBox">documentation</see> for more details.
	/// </remarks>
	/// <param name="messageBoxData">The <see cref="SDL_MessageBoxData"/> structure with title, text and other options.</param>
	/// <param name="buttonId">The pointer to which user id of hit button should be copied.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowMessageBox")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool ShowMessageBox([Const] SDL_MessageBoxData* messageBoxData, int* buttonId);

	/// <summary>
	/// Display a simple modal message box.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ShowSimpleMessageBox">documentation</see> for more details.
	/// </remarks>
	/// <param name="flags">An <see cref="SDL_MessageBoxFlags"/> value.</param>
	/// <param name="title">UTF-8 title text.</param>
	/// <param name="message">UTF-8 message text.</param>
	/// <param name="window">The parent window, or <see langword="null"/> for no parent.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ShowSimpleMessageBox", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool ShowSimpleMessageBox(SDL_MessageBoxFlags flags, string title, string message, SDL_Window* window);
}