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
	/// <param name="fmt">The error message.</param>
	/// <returns>Always -1.</returns>
	/// <seealso cref="ClearError"/>
	/// <seealso cref="GetError"/>
	public static int SetError(string fmt)
	{
		fixed (byte* fmtPtr = Encoding.UTF8.GetBytes(fmt))
		{
			return PInvoke.SDL_SetError(fmtPtr);
		}
	}

	/// <summary>
	/// Set an error indicating that memory allocation failed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OutOfMemory">documentation</see> for more details.
	/// </remarks>
	/// <returns>-1.</returns>
	public static int OutOfMemory()
	{
		return PInvoke.SDL_OutOfMemory();
	}

	/// <summary>
	/// Retrieve a message about the last error that occurred on the current thread.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetError">documentation</see> for more details.
	/// </remarks>
	/// <returns>A message with information about the specific error that occurred, or an empty string if there hasn't been an error message set since the last call to <see cref="ClearError"/>.</returns>
	/// <seealso cref="ClearError"/>
	/// <seealso cref="SetError(string)"/>
	public static string GetError()
	{
		return Marshal.PtrToStringUTF8((nint)PInvoke.SDL_GetError())!;
	}

	/// <summary>
	/// Clear any previous error message for this thread.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearError">documentation</see> for more details.
	/// </remarks>
	/// <returns>0</returns>
	/// <seealso cref="GetError"/>
	/// <seealso cref="SetError(string)"/>
	public static int ClearError()
	{
		return PInvoke.SDL_ClearError();
	}
}