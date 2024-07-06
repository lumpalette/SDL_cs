using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_LockJoysticks();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_UnlockJoysticks();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_HasJoystick();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_JoystickId* SDL_GetJoysticks(int* count);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetJoystickInstanceName(SDL_JoystickId joystickId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetJoystickInstancePath(SDL_JoystickId joystickId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetJoystickInstancePlayerIndex(SDL_JoystickId joystickId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_JoystickGuid SDL_GetJoystickInstanceGUID(SDL_JoystickId joystickId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern ushort SDL_GetJoystickInstanceVendor(SDL_JoystickId joystickId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern ushort SDL_GetJoystickInstanceProduct(SDL_JoystickId joystickId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern ushort SDL_GetJoystickInstanceProductVersion(SDL_JoystickId joystickId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_JoystickType SDL_GetJoystickInstanceType(SDL_JoystickId joystickId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Joystick* SDL_OpenJoystick(SDL_JoystickId joystickId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Joystick* SDL_GetJoystickFromInstanceID(SDL_JoystickId joystickId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_Joystick* SDL_GetJoystickFromPlayerIndex(int playerIndex);

	[LibraryImport(LibraryName)]
	public static partial SDL_JoystickId SDL_AttachVirtualJoystick([In] in SDL_VirtualJoystickDesc desc);
}