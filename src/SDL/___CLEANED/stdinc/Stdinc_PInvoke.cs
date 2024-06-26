using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void SDL_free(void* mem);
}