using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL_cs;

// SDL_audio.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_audio.h.
// this header is beautiful, even macros have documentation!
unsafe partial class SDL
{
	/// <summary>
	/// Retrieve the size, in bits, from an <see cref="SDL_AudioFormat"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_BITSIZE">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>Data size in bits.</returns>
	[Macro]
	public static ushort AudioBitSize(SDL_AudioFormat x)
	{
		return (ushort)((ushort)x & AudioMaskBitSize);
	}

	/// <summary>
	/// Retrieve the size, in bytes, from an <see cref="SDL_AudioFormat"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_BYTESIZE">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>Data size in bytes.</returns>
	[Macro]
	public static ushort AudioByteSize(SDL_AudioFormat x)
	{
		return (ushort)(AudioBitSize(x) / 8);
	}

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents integer data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISINT">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>True if format is integer, false otherwise.</returns>
	public static bool AudioIsInt(SDL_AudioFormat x)
	{
		return ((ushort)x & AudioMaskFloat) == 0;
	}

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents floating point data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISFLOAT">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>True if format is floating point, false otherwise.</returns>
	[Macro]
	public static bool AudioIsFloat(SDL_AudioFormat x)
	{
		return ((ushort)x & AudioMaskFloat) != 0;
	}

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents bigendian data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISBIGENDIAN">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>True if format is big endian, false otherwise.</returns>
	[Macro]
	public static bool AudioIsBigEndian(SDL_AudioFormat x)
	{
		return ((ushort)x & AudioMaskBigEndian) != 0;
	}

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents littleendian data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISLITTLEENDIAN">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>. </param>
	/// <returns>True if format is little endian, false otherwise.</returns>
	[Macro]
	public static bool AudioIsLittleEndian(SDL_AudioFormat x)
	{
		return ((ushort)x & AudioMaskBigEndian) == 0;
	}

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents signed data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISSIGNED">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>True if format is signed, false otherwise.</returns>
	[Macro]
	public static bool AudioIsSigned(SDL_AudioFormat x)
	{
		return ((ushort)x & AudioMaskSigned) != 0;
	}

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents unsigned data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISUNSIGNED">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>True if format is unsigned, false otherwise.</returns>
	[Macro]
	public static bool AudioIsUnsigned(SDL_AudioFormat x)
	{
		return ((ushort)x & AudioMaskSigned) == 0;
	}

	/// <summary>
	/// Calculate the size of each audio frame (in bytes) from an <see cref="SDL_AudioSpec"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_FRAMESIZE">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioSpec"/> to query.</param>
	/// <returns>The number of bytes used per sample frame.</returns>
	[Macro]
	public static byte AudioFrameSize(SDL_AudioSpec x)
	{
		return (byte)(AudioByteSize(x.Format) * x.Channels);
	}

	/// <summary>
	/// Use this function to get the number of built-in audio drivers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumAudioDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns>The number of built-in audio drivers.</returns>
	public static int GetNumAudioDrivers()
	{
		return PInvoke.SDL_GetNumAudioDrivers();
	}

	/// <summary>
	/// Use this function to get the name of a built in audio driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioDriver">documentation</see> for more details.
	/// </remarks>
	/// <param name="index">The index of the audio driver; the value ranges from 0 to <see cref="GetNumAudioDrivers"/> - 1.</param>
	/// <returns>The name of the audio driver at the requested index, or null if an invalid index was specified.</returns>
	public static string? GetAudioDriver(int index)
	{
		return Marshal.PtrToStringUTF8((nint)PInvoke.SDL_GetAudioDriver(index));
	}

	/// <summary>
	/// Get the name of the current audio driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentAudioDriver">documentation</see> for more details.
	/// </remarks>
	/// <returns>The name of the current audio driver or null if no driver has been initialized.</returns>
	public static string? GetCurrentAudioDriver()
	{
		return Marshal.PtrToStringUTF8((nint)PInvoke.SDL_GetCurrentAudioDriver());
	}

	/// <summary>
	/// Get a list of currently-connected audio playback devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioPlaybackDevices">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">The number of devices returned.</param>
	/// <returns>An array of device instance IDs, or null on error; call <see cref="GetError"/> for more details.</returns>
	public static SDL_AudioDeviceId[]? GetAudioPlaybackDevices(out int count)
	{
		fixed (int* countPtr = &count)
		{
			var devicesPtr = PInvoke.SDL_GetAudioPlaybackDevices(countPtr);
			if (devicesPtr is null)
			{
				return null;
			}
			var devices = new SDL_AudioDeviceId[count];
			for (int i = 0; i < count; i++)
			{
				devices[i] = devicesPtr[i];
			}
			Free(devicesPtr);
			return devices;
		}
	}

	/// <summary>
	/// Get the human-readable name of a specific audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioDeviceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The instance ID of the device to query.</param>
	/// <returns>The name of the audio device, or null on error.</returns>
	public static string? GetAudioDeviceName(SDL_AudioDeviceId devId)
	{
		return Marshal.PtrToStringUTF8((nint)PInvoke.SDL_GetAudioDeviceName(devId));
	}

	/// <summary>
	/// Get the current audio format of a specific audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioDeviceFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The instance ID of the device to query.</param>
	/// <param name="spec">On return, will be filled with device details.</param>
	/// <param name="sampleFrames">The device buffer size, in sample frames.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GetAudioDeviceFormat(SDL_AudioDeviceId devId, out SDL_AudioSpec spec, out int sampleFrames)
	{
		fixed (SDL_AudioSpec* specPtr = &spec)
		{
			fixed (int* sampleFramesPtr = &sampleFrames)
			{
				return PInvoke.SDL_GetAudioDeviceFormat(devId, specPtr, sampleFramesPtr);
			}
		}
	}

	/// <summary>
	/// Open a specific audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The device instance ID to open, or <see cref="AudioDeviceDefaultPlayback"/> or <see cref="AudioDeviceDefaultRecording"/> for the most reasonable default device.</param>
	/// <param name="spec">The requested device configuration. Can be null to use reasonable defaults.</param>
	/// <returns>The device ID on success, <see cref="InvalidAudioDevice"/> on error; call <see cref="GetError"/> for more information.</returns>
	public static SDL_AudioDeviceId OpenAudioDevice(SDL_AudioDeviceId devId, ref SDL_AudioSpec spec)
	{
		fixed (SDL_AudioSpec* specPtr = &spec)
		{
			return PInvoke.SDL_OpenAudioDevice(devId, specPtr);
		}
	}

	/// <summary>
	/// Open a specific audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The device instance ID to open, or <see cref="AudioDeviceDefaultPlayback"/> or <see cref="AudioDeviceDefaultRecording"/> for the most reasonable default device.</param>
	/// <param name="spec">The requested device configuration. Can be null to use reasonable defaults.</param>
	/// <returns>The device ID on success, <see cref="InvalidAudioDevice"/> on error; call <see cref="GetError"/> for more information.</returns>
	public static SDL_AudioDeviceId OpenAudioDevice(SDL_AudioDeviceId devId, SDL_AudioSpec* spec)
	{
		return PInvoke.SDL_OpenAudioDevice(devId, spec);
	}

	/// <summary>
	/// Use this function to pause audio playback on a specified device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PauseAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="device"> A device opened by <see cref="OpenAudioDevice(SDL_AudioDeviceId, SDL_AudioSpec*)"/>. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int PauseAudioDevice(SDL_AudioDeviceId device)
	{
		return _PInvoke(device);

		[DllImport(LibraryName, EntryPoint = "SDL_PauseAudioDevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioDeviceId device);
	}

	/// <summary>
	/// Use this function to unpause audio playback on a specified device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResumeAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="device"> A device opened by <see cref="OpenAudioDevice(SDL_AudioDeviceId, SDL_AudioSpec*)"/>. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ResumeAudioDevice(SDL_AudioDeviceId device)
	{
		return _PInvoke(device);

		[DllImport(LibraryName, EntryPoint = "SDL_ResumeAudioDevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioDeviceId device);
	}

	/// <summary>
	/// Use this function to query if an audio device is paused.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioDevicePaused">documentation</see> for more details.
	/// </remarks>
	/// <param name="device"> A device opened by <see cref="OpenAudioDevice(SDL_AudioDeviceId, SDL_AudioSpec*)"/>. </param>
	/// <returns> True if device is valid and paused, false otherwise. </returns>
	public static bool AudioDevicePaused(SDL_AudioDeviceId device)
	{
		return _PInvoke(device) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_AudioDevicePaused", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioDeviceId device);
	}

	/// <summary>
	/// Close a previously-opened audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CloseAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="device"> An audio device ID previously returned by <see cref="OpenAudioDevice(SDL_AudioDeviceId, SDL_AudioSpec*)"/>. </param>
	public static void CloseAudioDevice(SDL_AudioDeviceId device)
	{
		_PInvoke(device);

		[DllImport(LibraryName, EntryPoint = "SDL_CloseAudioDevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_AudioDeviceId device);
	}

	/// <summary>
	/// Bind a list of audio streams to an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BindAudioStreams">documentation</see> for more details.
	/// </remarks>
	/// <param name="deviceId"> An audio device to bind a stream to. </param>
	/// <param name="streams"> An array of audio streams to unbind. </param>
	/// <returns> 0 on success, -1 on error; call <see cref="GetError"/> for more information. </returns>
	public static int BindAudioStreams(SDL_AudioDeviceId deviceId, SDL_AudioStream*[] streams)
	{
		fixed (SDL_AudioStream** streamsPtr = streams)
		{
			return _PInvoke(deviceId, streamsPtr, streams.Length);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_BindAudioStreams", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioDeviceId deviceId, SDL_AudioStream** streams, int numStreams);
	}

	/// <summary>
	/// Bind a single audio stream to an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BindAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="deviceId"> An audio device to bind a stream to. </param>
	/// <param name="stream"> An audio stream to bind to a device. </param>
	/// <returns> 0 on success, -1 on error; call <see cref="GetError"/> for more information. </returns>
	public static int BindAudioStream(SDL_AudioDeviceId deviceId, SDL_AudioStream* stream)
	{
		return _PInvoke(deviceId, stream);

		[DllImport(LibraryName, EntryPoint = "SDL_BindAudioStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioDeviceId deviceId, SDL_AudioStream* stream);
	}

	/// <summary>
	/// Unbind a list of audio streams from their audio devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnbindAudioStreams">documentation</see> for more details.
	/// </remarks>
	/// <param name="streams"> An array of audio streams to unbind. </param>
	public static void UnbindAudioStreams(SDL_AudioStream*[] streams)
	{
		fixed (SDL_AudioStream** streamsPtr = streams)
		{
			_PInvoke(streamsPtr, streams.Length);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_UnbindAudioStreams", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_AudioStream** streams, int numStreams);
	}

	/// <summary>
	/// Unbind a single audio stream from its audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnbindAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> An audio stream to unbind from a device. </param>
	public static void UnbindAudioStream(SDL_AudioStream* stream)
	{
		_PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_UnbindAudioStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Query an audio stream for its currently-bound device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream to query. </param>
	/// <returns> The bound audio device, or <see cref="InvalidAudioDevice"/> if not bound or invalid. </returns>
	public static SDL_AudioDeviceId GetAudioStreamDevice(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamDevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_AudioDeviceId _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Create a new audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="srcSpec"> The format details of the input audio. </param>
	/// <param name="dstSpec"> The format details of the output audio. </param>
	/// <returns> A new audio stream on success, or null on failure. </returns>
	public static SDL_AudioStream* CreateAudioStream(SDL_AudioSpec* srcSpec, SDL_AudioSpec* dstSpec)
	{
		return _PInvoke(srcSpec, dstSpec);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateAudioStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_AudioStream* _PInvoke(SDL_AudioSpec* srcSpec, SDL_AudioSpec* dstSpec);
	}

	/// <summary>
	/// Get the properties associated with an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The <see cref="SDL_AudioStream"/> to query. </param>
	/// <returns> A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetAudioStreamProperties(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PropertiesId _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Query the current format of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The <see cref="SDL_AudioStream"/> to query. </param>
	/// <param name="srcSpec"> Returns the input audio format. </param>
	/// <param name="dstSpec"> Returns the output audio format. </param>
	/// <returns> 0 on success, or -1 on error. </returns>
	public static int GetAudioStreamFormat(SDL_AudioStream* stream, out SDL_AudioSpec srcSpec, out SDL_AudioSpec dstSpec)
	{
		fixed (SDL_AudioSpec* srcSpecPtr = &srcSpec, dstSpecPtr = &dstSpec)
		{
			return _PInvoke(stream, srcSpecPtr, dstSpecPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream, SDL_AudioSpec* srcSpec, SDL_AudioSpec* dstSpec);
	}

	/// <summary>
	/// Change the input and output formats of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The stream the format is being changed. </param>
	/// <param name="srcSpec"> The new format of the audio input; if null, it is not changed. </param>
	/// <param name="dstSpec"> The new format of the audio output; if null, it is not changed. </param>
	/// <returns> 0 on success, or -1 on error. </returns>
	public static int SetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* srcSpec, SDL_AudioSpec* dstSpec)
	{
		return _PInvoke(stream, srcSpec, dstSpec);

		[DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream, SDL_AudioSpec* srcSpec, SDL_AudioSpec* dstSpec);
	}

	/// <summary>
	/// Get the frequency ratio of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamFrequencyRatio">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The <see cref="SDL_AudioStream"/> to query. </param>
	/// <returns> The frequency ratio of the stream, or 0.0 on error. </returns>
	public static float GetAudioStreamFrequencyRatio(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamFrequencyRatio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern float _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Change the frequency ratio of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamFrequencyRatio">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The stream the frequency ratio is being changed. </param>
	/// <param name="ratio"> The frequency ratio. 1.0 is normal speed. Must be between 0.01 and 100. </param>
	/// <returns> 0 on success, or -1 on error. </returns>
	public static int SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio)
	{
		return _PInvoke(stream, ratio);

		[DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamFrequencyRatio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream, float ratio);
	}

	/// <summary>
	/// Add data to the stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PutAudioStreamData">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The stream the audio data is being added to. </param>
	/// <param name="buffer"> A pointer to the audio data to add. </param>
	/// <param name="length"> The number of bytes to write to the stream. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int PutAudioStreamData(SDL_AudioStream* stream, void* buffer, int length)
	{
		return _PInvoke(stream, buffer, length);

		[DllImport(LibraryName, EntryPoint = "SDL_PutAudioStreamData", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream, void* buf, int len);
	}

	/// <summary>
	/// Get converted/resampled data from the stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamData">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The stream the audio is being requested from. </param>
	/// <param name="buffer"> A buffer to fill with audio data. </param>
	/// <param name="length"> The maximum number of bytes to fill. </param>
	/// <returns> The number of bytes read from the stream, or -1 on error. </returns>
	public static int GetAudioStreamData(SDL_AudioStream* stream, void* buffer, int length)
	{
		return _PInvoke(stream, buffer, length);

		[DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamData", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream, void* buf, int len);
	}

	/// <summary>
	/// Get the number of converted/resampled bytes available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamAvailable">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream to query. </param>
	/// <returns> The number of converted/resampled bytes available. </returns>
	public static int GetAudioStreamAvailable(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamAvailable", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Get the number of bytes currently queued.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamQueued">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream to query. </param>
	/// <returns> The number of bytes queued. </returns>
	public static int GetAudioStreamQueued(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamQueued", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Tell the stream that you're done sending data, and anything being buffered should be converted/resampled and
	/// made available immediately.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlushAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream to flush. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int FlushAudioStream(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_GetAudioStreamQueued", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Clear any pending data in the stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream to clear. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ClearAudioStream(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_ClearAudioStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Use this function to pause audio playback on the audio device associated with an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PauseAudioStreamDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream associated with the audio device to pause. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int PauseAudioStreamDevice(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_PauseAudioStreamDevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Use this function to unpause audio playback on the audio device associated with an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResumeAudioStreamDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream associated with the audio device to resume. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ResumeAudioStreamDevice(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_ResumeAudioStreamDevice", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Lock an audio stream for serialized access.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream to lock. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int LockAudioStream(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_LockAudioStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Unlock an audio stream for serialized access.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream to unlock. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int UnlockAudioStream(SDL_AudioStream* stream)
	{
		return _PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_UnlockAudioStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Set a callback that runs when data is requested from an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamGetCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream to set the new callback on. </param>
	/// <param name="callback"> The new callback function to call when data is requested from the stream. </param>
	/// <param name="userData"> An opaque pointer provided to the callback for its own personal use. </param>
	/// <returns> 0 on success, -1 on error. This only fails if <paramref name="stream"/> is null. </returns>
	public static int SetAudioStreamGetCallback(SDL_AudioStream* stream, SDL_AudioStreamCallback callback, void* userData)
	{
		return _PInvoke(stream, callback, userData);

		[DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamGetCallback", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream, SDL_AudioStreamCallback callback, void* userData);
	}

	/// <summary>
	/// Set a callback that runs when data is added to an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamPutCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream to set the new callback on. </param>
	/// <param name="callback"> The new callback function to call when data is added to the stream. </param>
	/// <param name="userData"> An opaque pointer provided to the callback for its own personal use. </param>
	/// <returns> 0 on success, -1 on error. This only fails if <paramref name="stream"/> is null. </returns>
	public static int SetAudioStreamPutCallback(SDL_AudioStream* stream, SDL_AudioStreamCallback callback, void* userData)
	{
		return _PInvoke(stream, callback, userData);

		[DllImport(LibraryName, EntryPoint = "SDL_SetAudioStreamPutCallback", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioStream* stream, SDL_AudioStreamCallback callback, void* userData);
	}

	/// <summary>
	/// Free an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream"> The audio stream to destroy. </param>
	public static void DestroyAudioStream(SDL_AudioStream* stream)
	{
		_PInvoke(stream);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyAudioStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_AudioStream* stream);
	}

	/// <summary>
	/// Convenience function for straightforward audio init for the common case.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenAudioDeviceStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="deviceId"> An audio device to open, or <see cref="SDL_AudioDeviceId.DefaultPlayback"/> or <see cref="SDL_AudioDeviceId.DefaultRecording"/> </param>
	/// <param name="spec"> The audio stream's data format. Can be null. </param>
	/// <param name="callback"> A callback where the app will provide new data for playback, or receive new data for recording. Can be null, in which case the app will need to call <see cref="PutAudioStreamData"/> or <see cref="GetAudioStreamData"/> as necessary. </param>
	/// <param name="userData"> App-controlled pointer passed to callback. Can be null. Ignored if <paramref name="callback"/> is null. </param>
	/// <returns> An audio stream on success, ready to use. Null on error; call <see cref="GetError"/> for more information. When done with this stream, call <see cref="DestroyAudioStream(SDL_AudioStream*)"/> to free resources and close the device. </returns>
	public static SDL_AudioStream* OpenAudioDeviceStream(SDL_AudioDeviceId deviceId, SDL_AudioSpec* spec, SDL_AudioStreamCallback callback, void* userData)
	{
		return _PInvoke(deviceId, spec, callback, userData);

		[DllImport(LibraryName, EntryPoint = "SDL_OpenAudioDeviceStream", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_AudioStream* _PInvoke(SDL_AudioDeviceId deviceId, SDL_AudioSpec* spec, SDL_AudioStreamCallback callback, void* userData);
	}

	/// <summary>
	/// Set a callback that fires when data is about to be fed to an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioPostmixCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="deviceId"> The ID of an opened audio device. </param>
	/// <param name="callback"> A callback function to be called. Can be null. </param>
	/// <param name="userData"> App-controlled pointer passed to callback. Can be null. </param>
	/// <returns> 0 on success, -1 on error; call <see cref="GetError"/> for more information. </returns>
	public static int SetAudioPostmixCallback(SDL_AudioDeviceId deviceId, SDL_AudioPostmixCallback callback, void* userData)
	{
		return _PInvoke(deviceId, callback, userData);

		[DllImport(LibraryName, EntryPoint = "SDL_SetAudioPostmixCallback", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioDeviceId deviceId, SDL_AudioPostmixCallback callback, void* userData);
	}

	// FIXME: implement SDL_LoadWAV_IO

	/// <summary>
	/// Loads a WAV from a file path.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LoadWAV">documentation</see> for more details.
	/// </remarks>
	/// <param name="path"> The file path of the WAV file to open. </param>
	/// <param name="spec"> Returns an <see cref="SDL_AudioSpec"/> containing the WAVE data's format details on successful return. </param>
	/// <param name="audioBuffer"> Returns a pointer filled with the audio data, allocated by the function. </param>
	/// <param name="audioLength"> Returns the length of the audio data buffer in bytes. </param>
	/// <returns>
	/// 0 on success. <paramref name="audioBuffer"/> will return a pointer to an allocated buffer containing the audio data,
	/// and <paramref name="audioLength"/> returns the length of that audio buffer in bytes.
	/// <br/>
	/// This function returns -1 if the .WAV file cannot be opened, uses an unknown data format, or is corrupt; call
	/// <see cref="GetError"/> for more information.
	/// <br/><br/>
	/// When the application is done with the data returned in <paramref name="audioBuffer"/>, it should call <see cref="Free(void*)"/>
	/// to dispose of it.
	/// </returns>
	public static int LoadWav(string path, out SDL_AudioSpec spec, out byte* audioBuffer, out uint audioLength)
	{
		// e
		fixed (byte* pathPtr = Encoding.UTF8.GetBytes(path))
		{
			// h
			fixed (SDL_AudioSpec* specPtr = &spec)
			{
				// w
				fixed (byte** audioBufferPtr = &audioBuffer)
				{
					// e
					fixed (uint* audioLengthPtr = &audioLength)
					{
						return _PInvoke(pathPtr, specPtr, audioBufferPtr, audioLengthPtr);
					}
				}
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_LoadWAV", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(byte* path, SDL_AudioSpec* spec, byte** audioBuffer, uint* audioLength);
	}

	/// <summary>
	/// Mix audio data in a specified format.
	/// </summary>
	/// <remarks>
	/// You need to provide a buffer of size <paramref name="length"/> to <paramref name="dst"/>. Refer to the official
	/// documentation <see href="https://wiki.libsdl.org/SDL3/SDL_MixAudio">documentation</see> for more details.
	/// </remarks>
	/// <param name="dst"> The destination for the mixed audio.. </param>
	/// <param name="src"> The source audio buffer to be mixed. </param>
	/// <param name="format"> The <see cref="SDL_AudioFormat"/> structure representing the desired audio format. </param>
	/// <param name="length"> The length of the audio buffer in bytes. </param>
	/// <param name="volume"> Ranges from 0.0 - 1.0, and should be set to 1.0 for full audio volume. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int MixAudio(byte* dst, byte* src, SDL_AudioFormat format, uint length, float volume)
	{
		return _PInvoke(dst, src, format, length, volume);

		[DllImport(LibraryName, EntryPoint = "SDL_MixAudio", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(byte* dst, byte* src, SDL_AudioFormat format, uint length, float volume);
	}

	/// <summary>
	/// Convert some audio data of one format to another format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertAudioSamples">documentation</see> for more details.
	/// </remarks>
	/// <param name="srcSpec"> The format details of the input audio. </param>
	/// <param name="srcData"> The audio data to be converted. </param>
	/// <param name="srcLength"> The length of <paramref name="srcData"/>. </param>
	/// <param name="dstSpec"> The format details of the output audio. </param>
	/// <param name="dstData"> Returns a pointer to converted audio data, which should be freed with <see cref="Free(void*)"/>. On error, it will be null. </param>
	/// <param name="dstLength"> Returns the len of <paramref name="dstData"/>. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ConvertAudioSamples(SDL_AudioSpec* srcSpec, byte* srcData, int srcLength, SDL_AudioSpec* dstSpec, out byte* dstData, out int dstLength)
	{
		fixed (byte** dstDataPtr = &dstData)
		{
			fixed (int* dstLengthPtr = &dstLength)
			{
				return _PInvoke(srcSpec, srcData, srcLength, dstSpec, dstDataPtr, dstLengthPtr);
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertAudioSamples", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioSpec* srcSpec, byte* srcData, int srcLength, SDL_AudioSpec* dstSpec, byte** dstData, int* dstLength);
	}

	/// <summary>
	/// Get the appropriate memset value for silencing an audio format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSilenceValueForFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="format"> The audio data format to query. </param>
	/// <returns> A byte value that can be passed to memset. </returns>
	public static int GetSilenceValueForFormat(SDL_AudioFormat format)
	{
		return _PInvoke(format);

		[DllImport(LibraryName, EntryPoint = "SDL_GetSilenceValueForFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_AudioFormat format);
	}

	/// <summary>
	/// Unsigned 8-bit samples.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioU8 => new(0x0008);

	/// <summary>
	/// Signed 8-bit samples.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioS8 => new(0x8008);

	/// <summary>
	/// Signed 16-bit samples, in little endian.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioS16LittleEndian => new(0x8010);

	/// <summary>
	/// Signed 16-bit samples, in big endian.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioS16BigEndian => new(0x9010);

	/// <summary>
	/// 32-bit integer samples, in little endian.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioS32LittleEndian => new(0x8020);

	/// <summary>
	/// 32-bit integer samples, in big endian.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioS32BigEndian => new(0x9020);

	/// <summary>
	/// 32-bit floating point samples, in little endian.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioF32LittleEndian => new(0x8120);

	/// <summary>
	/// 32-bit floating point samples, in big endian.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioF32BigEndian => new(0x9120);

	/// <summary>
	/// Signed 16-bit samples.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioS16 => BitConverter.IsLittleEndian ? AudioS16LittleEndian : AudioS16BigEndian;

	/// <summary>
	/// 32-bit integer samples.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioS32 => BitConverter.IsLittleEndian ? AudioS32LittleEndian : AudioS32BigEndian;

	/// <summary>
	/// 32-bit floating point samples.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioF32 => BitConverter.IsLittleEndian ? AudioF32LittleEndian : AudioF32BigEndian;

	/// <summary>
	/// A value used to request a default playback audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioDeviceId AudioDeviceDefaultPlayback => new(0xFFFFFFFF);

	/// <summary>
	/// A value used to request a default recording audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_DEVICE_DEFAULT_RECORDING">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioDeviceId AudioDeviceDefaultRecording => new(0xFFFFFFFE);

	public const ushort AudioMaskBitSize = 0xFF;

	public const ushort AudioMaskFloat = 1 << 8;

	public const ushort AudioMaskBigEndian = 1 << 12;

	public const ushort AudioMaskSigned = 1 << 15;
}