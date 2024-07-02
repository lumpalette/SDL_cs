using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class SDL_PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_TouchId* SDL_GetTouchDevices(int* count);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetTouchDeviceName(SDL_TouchId touchId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_TouchDeviceType SDL_GetTouchDeviceType(SDL_TouchId touchId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Finger** SDL_GetTouchFingers(SDL_TouchId touchId, int* count);
}
