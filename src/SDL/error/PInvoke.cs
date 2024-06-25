using System.Runtime.InteropServices;
using System.Text;

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
	/// <param name="msg"> The error message. </param>
	/// <returns> Always -1. </returns>
	public static int SetError(string msg)
	{
		fixed (byte* msgPtr = Encoding.UTF8.GetBytes(msg))
		{
			return _PInvoke(msgPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetError", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(byte* fmt);
	}

	/// <summary>
	/// Set an error indicating that memory allocation failed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OutOfMemory">documentation</see> for more details.
	/// </remarks>
	/// <returns> -1. </returns>
	public static int OutOfMemory()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_OutOfMemory", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Retrieve a message about the last error that occurred on the current thread.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetError">documentation</see> for more details.
	/// </remarks>
	/// <returns> A message with information about the specific error that occurred, or an empty string if there hasn't been an error message set since the last call to <see cref="ClearError"/>. </returns>
	public static string GetError()
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke())!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetError", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke();
	}

	/// <summary>
	/// Clear any previous error message for this thread.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearError">documentation</see> for more details.
	/// </remarks>
	public static void ClearError()
	{
		_PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_ClearError", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke();
	}
}