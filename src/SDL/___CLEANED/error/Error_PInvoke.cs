using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int SDL_SetError(byte* fmt);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int SDL_OutOfMemory();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern byte* SDL_GetError();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int SDL_ClearError();
}