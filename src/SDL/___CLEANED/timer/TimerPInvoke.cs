using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern ulong SDL_GetTicks();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern ulong SDL_GetTicksNS();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern ulong SDL_GetPerformanceCounter();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern ulong SDL_GetPerformanceFrequency();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_Delay(uint ms);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_DelayNS(ulong ns);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_TimerId SDL_AddTimer(uint intervalMs, SDL_TimerCallback callback, void* userData);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_TimerId SDL_AddTimerNS(ulong intervalMs, SDL_NsTimerCallback callback, void* userData);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_RemoveTimer(SDL_TimerId timerId);
}