using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int SDL_Init(SDL_InitFlags flags);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int SDL_InitSubSystem(SDL_InitFlags flags);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void SDL_QuitSubSystem(SDL_InitFlags flags);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern SDL_InitFlags SDL_WasInit(SDL_InitFlags flags);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern void SDL_Quit();
}