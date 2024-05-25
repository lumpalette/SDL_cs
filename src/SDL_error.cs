using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL3;

// SDL_error.h located at: https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_error.h.
unsafe partial class SDL
{
	/// <summary>
	/// Set the SDL error message for the current thread.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetError">here</see>.
	/// </remarks>
	/// <param name="msg"> The error message. </param>
	/// <returns> Always -1. </returns>
	public static int SetError(string msg)
	{
		fixed (byte* m = Encoding.UTF8.GetBytes(msg))
		{
			return _PInvokeSetError(m);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetError")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetError(byte* fmt);

	/// <summary>
	/// Retrieve a message about the last error that occurred on the current thread.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetError">here</see>.
	/// </remarks>
	/// <returns> A message with information about the specific error that occurred, or an empty string if there hasn't been an error message set since the last call to <see cref="ClearError"/>. </returns>
	public static string GetError()
	{
		return Marshal.PtrToStringUTF8((nint)_PInvokeGetError())!;
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetError")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetError();

	/// <summary>
	/// Clear any previous error message for this thread.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ClearError">here</see>.
	/// </remarks>
	public static void ClearError()
	{
		_PInvokeClearError();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_ClearError")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeClearError();
}