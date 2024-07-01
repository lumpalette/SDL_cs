using System.Runtime.InteropServices;

namespace SDL_cs;

unsafe partial class SDL_PInvoke
{
	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetNumAudioDrivers();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetAudioDriver(int index);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetCurrentAudioDriver();

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_AudioDeviceId* SDL_GetAudioPlaybackDevices(int* count);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_AudioDeviceId* SDL_GetAudioRecordingDevices(int* count);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern byte* SDL_GetAudioDeviceName(SDL_AudioDeviceId devId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetAudioDeviceFormat(SDL_AudioDeviceId devId, SDL_AudioSpec* spec, int* sampleFrames);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_AudioDeviceId SDL_OpenAudioDevice(SDL_AudioDeviceId devId, SDL_AudioSpec* spec);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_PauseAudioDevice(SDL_AudioDeviceId dev);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_ResumeAudioDevice(SDL_AudioDeviceId dev);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_AudioDevicePaused(SDL_AudioDeviceId dev);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_CloseAudioDevice(SDL_AudioDeviceId devId);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_BindAudioStreams(SDL_AudioDeviceId devId, SDL_AudioStream** streams, int numStreams);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_BindAudioStream(SDL_AudioDeviceId devId, SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_UnbindAudioStreams(SDL_AudioStream** streams, int numStreams);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_UnbindAudioStream(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_AudioDeviceId SDL_GetAudioStreamDevice(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_AudioStream* SDL_CreateAudioStream(SDL_AudioSpec* srcSpec, SDL_AudioSpec* dstSpec);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_PropertiesId SDL_GetAudioStreamProperties(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* srcSpec, SDL_AudioSpec* dstSpec);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* srcSpec, SDL_AudioSpec* dstSpec);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern float SDL_GetAudioStreamFrequencyRatio(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_PutAudioStreamData(SDL_AudioStream* stream, void* buf, int len);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetAudioStreamData(SDL_AudioStream* stream, void* buf, int len);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetAudioStreamAvailable(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetAudioStreamQueued(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_FlushAudioStream(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_ClearAudioStream(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_PauseAudioStreamDevice(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_ResumeAudioStreamDevice(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_LockAudioStream(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_UnlockAudioStream(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetAudioStreamGetCallback(SDL_AudioStream* stream, SDL_AudioStreamCallback callback, void* userData);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetAudioStreamPutCallback(SDL_AudioStream* stream, SDL_AudioStreamCallback callback, void* userData);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern void SDL_DestroyAudioStream(SDL_AudioStream* stream);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern SDL_AudioStream* SDL_OpenAudioDeviceStream(SDL_AudioDeviceId devId, SDL_AudioSpec* spec, SDL_AudioStreamCallback? callback, void* userData);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_SetAudioPostmixCallback(SDL_AudioDeviceId devId, SDL_AudioPostmixCallback callback, void* userData);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_LoadWAV(byte* path, SDL_AudioSpec* spec, byte** audioBuffer, uint* audioLength);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_MixAudio(byte* dst, byte* src, SDL_AudioFormat format, uint length, float volume);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_ConvertAudioSamples(SDL_AudioSpec* srcSpec, byte* srcData, int srcLength, SDL_AudioSpec* dstSpec, byte** dstData, int* dstLength);

	[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
	public static extern int SDL_GetSilenceValueForFormat(SDL_AudioFormat format);
}