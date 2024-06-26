using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int SDL_GetNumAudioDrivers();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern byte* SDL_GetAudioDriver(int index);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern byte* SDL_GetCurrentAudioDriver();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern SDL_AudioDeviceId* SDL_GetAudioPlaybackDevices(int* count);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern byte* SDL_GetAudioDeviceName(SDL_AudioDeviceId devId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern int SDL_GetAudioDeviceFormat(SDL_AudioDeviceId devId, SDL_AudioSpec* spec, int* sampleFrames);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
	public static extern SDL_AudioDeviceId SDL_OpenAudioDevice(SDL_AudioDeviceId devId, SDL_AudioSpec* spec);
}