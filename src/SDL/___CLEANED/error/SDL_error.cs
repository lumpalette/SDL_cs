using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_error.h located at: https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_error.h.
unsafe partial class SDL
{
	/// <summary>
	/// Set the SDL error message for the current thread.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetError">documentation</see> for more details.
	/// </remarks>
	/// <param name="fmt">The error message.</param>
	/// <returns>Always -1.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetError", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetError(string fmt);

	/// <summary>
	/// Set an error indicating that memory allocation failed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OutOfMemory">documentation</see> for more details.
	/// </remarks>
	/// <returns>-1.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_OutOfMemory")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int OutOfMemory();

	/// <summary>
	/// Retrieve a message about the last error that occurred on the current thread.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetError">documentation</see> for more details.
	/// </remarks>
	/// <returns>A message with information about the specific error that occurred, or an empty string if there hasn't been an error message set since the last call to <see cref="ClearError"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetError", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string GetError();

	/// <summary>
	/// Clear any previous error message for this thread.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearError">documentation</see> for more details.
	/// </remarks>
	/// <returns>0</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ClearError")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ClearError();
}