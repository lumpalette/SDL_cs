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
		return SDL_PInvoke.SDL_GetNumAudioDrivers();
	}

	/// <summary>
	/// Use this function to get the name of a built in audio driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioDriver">documentation</see> for more details.
	/// </remarks>
	/// <param name="index">The index of the audio driver; the value ranges from 0 to <see cref="GetNumAudioDrivers"/> - 1.</param>
	/// <returns>The name of the audio driver at the requested index, or <see langword="null"/> if an invalid index was specified.</returns>
	public static string? GetAudioDriver(int index)
	{
		return Marshal.PtrToStringUTF8((nint)SDL_PInvoke.SDL_GetAudioDriver(index));
	}

	/// <summary>
	/// Get the name of the current audio driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentAudioDriver">documentation</see> for more details.
	/// </remarks>
	/// <returns>The name of the current audio driver or <see langword="null"/> if no driver has been initialized.</returns>
	public static string? GetCurrentAudioDriver()
	{
		return Marshal.PtrToStringUTF8((nint)SDL_PInvoke.SDL_GetCurrentAudioDriver());
	}

	/// <summary>
	/// Get a list of currently-connected audio playback devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioPlaybackDevices">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">The number of devices returned.</param>
	/// <returns>An array of device instance IDs, or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	public static SDL_AudioDeviceId[]? GetAudioPlaybackDevices(out int count)
	{
		fixed (int* countPtr = &count)
		{
			var devicesPtr = SDL_PInvoke.SDL_GetAudioPlaybackDevices(countPtr);
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
	/// Get a list of currently-connected audio recording devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioRecordingDevices">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">The number of devices returned.</param>
	/// <returns>An array of device instance IDs, or <see langword="null"/> on error; call <see cref="GetError"/> for more details.</returns>
	public static SDL_AudioDeviceId[]? GetAudioRecordingDevices(out int count)
	{
		fixed (int* countPtr = &count)
		{
			var devicesPtr = SDL_PInvoke.SDL_GetAudioRecordingDevices(countPtr);
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
	/// <returns>The name of the audio device, or <see langword="null"/> on error.</returns>
	public static string? GetAudioDeviceName(SDL_AudioDeviceId devId)
	{
		return Marshal.PtrToStringUTF8((nint)SDL_PInvoke.SDL_GetAudioDeviceName(devId));
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
				return SDL_PInvoke.SDL_GetAudioDeviceFormat(devId, specPtr, sampleFramesPtr);
			}
		}
	}

	/// <summary>
	/// Open a specific audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The device instance ID to open, or <see cref="SDL_AudioDeviceId.DefaultPlayback"/> or <see cref="SDL_AudioDeviceId.DefaultRecording"/> for the most reasonable default device.</param>
	/// <param name="spec">The requested device configuration. Can be <see langword="null"/> to use reasonable defaults.</param>
	/// <returns>The device ID on success, <see cref="SDL_AudioDeviceId.Invalid"/> on error; call <see cref="GetError"/> for more information.</returns>
	public static SDL_AudioDeviceId OpenAudioDevice(SDL_AudioDeviceId devId, ref SDL_AudioSpec spec)
	{
		fixed (SDL_AudioSpec* specPtr = &spec)
		{
			return SDL_PInvoke.SDL_OpenAudioDevice(devId, specPtr);
		}
	}

	/// <summary>
	/// Open a specific audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The device instance ID to open, or <see cref="SDL_AudioDeviceId.DefaultPlayback"/> or <see cref="SDL_AudioDeviceId.DefaultRecording"/> for the most reasonable default device.</param>
	/// <param name="spec">The requested device configuration. Can be <see langword="null"/> to use reasonable defaults.</param>
	/// <returns>The device ID on success, <see cref="SDL_AudioDeviceId.Invalid"/> on error; call <see cref="GetError"/> for more information.</returns>
	public static SDL_AudioDeviceId OpenAudioDevice(SDL_AudioDeviceId devId, SDL_AudioSpec* spec)
	{
		return SDL_PInvoke.SDL_OpenAudioDevice(devId, spec);
	}

	/// <summary>
	/// Use this function to pause audio playback on a specified device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PauseAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device opened by <see cref="OpenAudioDevice(SDL_AudioDeviceId, ref SDL_AudioSpec)"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int PauseAudioDevice(SDL_AudioDeviceId dev)
	{
		return SDL_PInvoke.SDL_PauseAudioDevice(dev);
	}

	/// <summary>
	/// Use this function to unpause audio playback on a specified device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResumeAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device opened by <see cref="OpenAudioDevice(SDL_AudioDeviceId, ref SDL_AudioSpec)"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ResumeAudioDevice(SDL_AudioDeviceId dev)
	{
		return SDL_PInvoke.SDL_ResumeAudioDevice(dev);
	}

	/// <summary>
	/// Use this function to query if an audio device is paused.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioDevicePaused">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device opened by <see cref="OpenAudioDevice(SDL_AudioDeviceId, ref SDL_AudioSpec)"/>.</param>
	/// <returns>True if device is valid and paused, false otherwise.</returns>
	public static bool AudioDevicePaused(SDL_AudioDeviceId dev)
	{
		return SDL_PInvoke.SDL_AudioDevicePaused(dev) == 1;
	}

	/// <summary>
	/// Close a previously-opened audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CloseAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">An audio device ID previously returned by <see cref="OpenAudioDevice(SDL_AudioDeviceId, ref SDL_AudioSpec)"/>.</param>
	public static void CloseAudioDevice(SDL_AudioDeviceId devId)
	{
		SDL_PInvoke.SDL_CloseAudioDevice(devId);
	}

	/// <summary>
	/// Bind a list of audio streams to an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BindAudioStreams">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">An audio device to bind a stream to.</param>
	/// <param name="streams">An array of audio streams to unbind.</param>
	/// <returns>0 on success, -1 on error; call <see cref="GetError"/> for more information.</returns>
	public static int BindAudioStreams(SDL_AudioDeviceId devId, SDL_AudioStream*[] streams)
	{
		fixed (SDL_AudioStream** streamsPtr = streams)
		{
			return SDL_PInvoke.SDL_BindAudioStreams(devId, streamsPtr, streams.Length);
		}
	}

	/// <summary>
	/// Bind a single audio stream to an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BindAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="deviceId">An audio device to bind a stream to.</param>
	/// <param name="stream">An audio stream to bind to a device.</param>
	/// <returns>0 on success, -1 on error; call <see cref="GetError"/> for more information.</returns>
	public static int BindAudioStream(SDL_AudioDeviceId deviceId, SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_BindAudioStream(deviceId, stream);
	}

	/// <summary>
	/// Unbind a list of audio streams from their audio devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnbindAudioStreams">documentation</see> for more details.
	/// </remarks>
	/// <param name="streams">An array of audio streams to unbind.</param>
	public static void UnbindAudioStreams(SDL_AudioStream*[] streams)
	{
		fixed (SDL_AudioStream** streamsPtr = streams)
		{
			SDL_PInvoke.SDL_UnbindAudioStreams(streamsPtr, streams.Length);
		}
	}

	/// <summary>
	/// Unbind a single audio stream from its audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnbindAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">An audio stream to unbind from a device.</param>
	public static void UnbindAudioStream(SDL_AudioStream* stream)
	{
		SDL_PInvoke.SDL_UnbindAudioStream(stream);
	}

	/// <summary>
	/// Query an audio stream for its currently-bound device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to query.</param>
	/// <returns>The bound audio device, or <see cref="SDL_AudioDeviceId.Invalid"/> if not bound or invalid.</returns>
	public static SDL_AudioDeviceId GetAudioStreamDevice(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_GetAudioStreamDevice(stream);
	}

	/// <summary>
	/// Create a new audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="srcSpec">The format details of the input audio.</param>
	/// <param name="dstSpec">The format details of the output audio.</param>
	/// <returns>A new audio stream on success, or <see langword="null"/> on failure.</returns>
	public static SDL_AudioStream* CreateAudioStream(ref SDL_AudioSpec srcSpec, ref SDL_AudioSpec dstSpec)
	{
		fixed (SDL_AudioSpec* srcSpecPtr = &srcSpec, dstSpecPtr = &dstSpec)
		{
			return SDL_PInvoke.SDL_CreateAudioStream(srcSpecPtr, dstSpecPtr);
		}
	}

	/// <summary>
	/// Get the properties associated with an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to query.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	public static SDL_PropertiesId GetAudioStreamProperties(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_GetAudioStreamProperties(stream);
	}

	/// <summary>
	/// Query the current format of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to query.</param>
	/// <param name="srcSpec">Where to store the input audio format.</param>
	/// <param name="dstSpec">Where to store the output audio format.</param>
	/// <returns>0 on success, or -1 on error.</returns>
	public static int GetAudioStreamFormat(SDL_AudioStream* stream, out SDL_AudioSpec srcSpec, out SDL_AudioSpec dstSpec)
	{
		fixed (SDL_AudioSpec* srcSpecPtr = &srcSpec, dstSpecPtr = &dstSpec)
		{
			return SDL_PInvoke.SDL_GetAudioStreamFormat(stream, srcSpecPtr, dstSpecPtr);
		}
	}

	/// <summary>
	/// Change the input and output formats of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the format is being changed.</param>
	/// <param name="srcSpec">The new format of the audio input; if <see langword="null"/>, it is not changed.</param>
	/// <param name="dstSpec">The new format of the audio output; if <see langword="null"/>, it is not changed.</param>
	/// <returns>0 on success, or -1 on error.</returns>
	public static int SetAudioStreamFormat(SDL_AudioStream* stream, ref SDL_AudioSpec srcSpec, ref SDL_AudioSpec dstSpec)
	{
		fixed (SDL_AudioSpec* srcSpecPtr = &srcSpec, dstSpecPtr = &dstSpec)
		{
			return SDL_PInvoke.SDL_SetAudioStreamFormat(stream, srcSpecPtr, dstSpecPtr);
		}
	}

	/// <summary>
	/// Change the input and output formats of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the format is being changed.</param>
	/// <param name="srcSpec">The new format of the audio input; if <see langword="null"/>, it is not changed.</param>
	/// <param name="dstSpec">The new format of the audio output; if <see langword="null"/>, it is not changed.</param>
	/// <returns>0 on success, or -1 on error.</returns>
	public static int SetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* srcSpec, ref SDL_AudioSpec dstSpec)
	{
		fixed (SDL_AudioSpec* dstSpecPtr = &dstSpec)
		{
			return SDL_PInvoke.SDL_SetAudioStreamFormat(stream, srcSpec, dstSpecPtr);
		}
	}

	/// <summary>
	/// Change the input and output formats of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the format is being changed.</param>
	/// <param name="srcSpec">The new format of the audio input; if <see langword="null"/>, it is not changed.</param>
	/// <param name="dstSpec">The new format of the audio output; if <see langword="null"/>, it is not changed.</param>
	/// <returns>0 on success, or -1 on error.</returns>
	public static int SetAudioStreamFormat(SDL_AudioStream* stream, ref SDL_AudioSpec srcSpec, SDL_AudioSpec* dstSpec)
	{
		fixed (SDL_AudioSpec* srcSpecPtr = &srcSpec)
		{
			return SDL_PInvoke.SDL_SetAudioStreamFormat(stream, srcSpecPtr, dstSpec);
		}
	}

	/// <summary>
	/// Change the input and output formats of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the format is being changed.</param>
	/// <param name="srcSpec">The new format of the audio input; if <see langword="null"/>, it is not changed.</param>
	/// <param name="dstSpec">The new format of the audio output; if <see langword="null"/>, it is not changed.</param>
	/// <returns>0 on success, or -1 on error.</returns>
	public static int SetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* srcSpec, SDL_AudioSpec* dstSpec)
	{
		return SDL_PInvoke.SDL_SetAudioStreamFormat(stream, srcSpec, dstSpec);
	}

	/// <summary>
	/// Get the frequency ratio of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamFrequencyRatio">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to query.</param>
	/// <returns>The frequency ratio of the stream, or 0 on error.</returns>
	public static float GetAudioStreamFrequencyRatio(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_GetAudioStreamFrequencyRatio(stream);
	}

	/// <summary>
	/// Change the frequency ratio of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamFrequencyRatio">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the frequency ratio is being changed.</param>
	/// <param name="ratio">The frequency ratio. 1.0 is normal speed. Must be between 0.01 and 100.</param>
	/// <returns>0 on success, or -1 on error.</returns>
	public static int SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio)
	{
		return SDL_PInvoke.SDL_SetAudioStreamFrequencyRatio(stream, ratio);
	}

	/// <summary>
	/// Add data to the stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PutAudioStreamData">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the audio data is being added to.</param>
	/// <param name="buffer">A pointer to the audio data to add.</param>
	/// <param name="length">The number of bytes to write to the stream.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int PutAudioStreamData(SDL_AudioStream* stream, void* buffer, int length)
	{
		return SDL_PInvoke.SDL_PutAudioStreamData(stream, buffer, length);
	}

	/// <summary>
	/// Get converted/resampled data from the stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamData">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the audio is being requested from.</param>
	/// <param name="buffer">A buffer to fill with audio data.</param>
	/// <param name="length">The maximum number of bytes to fill.</param>
	/// <returns>The number of bytes read from the stream, or -1 on error.</returns>
	public static int GetAudioStreamData(SDL_AudioStream* stream, void* buffer, int length)
	{
		return SDL_PInvoke.SDL_GetAudioStreamData(stream, buffer, length);
	}

	/// <summary>
	/// Get the number of converted/resampled bytes available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamAvailable">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to query.</param>
	/// <returns>The number of converted/resampled bytes available.</returns>
	public static int GetAudioStreamAvailable(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_GetAudioStreamAvailable(stream);
	}

	/// <summary>
	/// Get the number of bytes currently queued.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamQueued">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to query.</param>
	/// <returns>The number of bytes queued.</returns>
	public static int GetAudioStreamQueued(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_GetAudioStreamQueued(stream);
	}

	/// <summary>
	/// Tell the stream that you're done sending data, and anything being buffered should be converted/resampled and
	/// made available immediately.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlushAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to flush.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int FlushAudioStream(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_FlushAudioStream(stream);
	}

	/// <summary>
	/// Clear any pending data in the stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to clear.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ClearAudioStream(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_ClearAudioStream(stream);
	}

	/// <summary>
	/// Use this function to pause audio playback on the audio device associated with an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PauseAudioStreamDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream associated with the audio device to pause.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int PauseAudioStreamDevice(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_PauseAudioStreamDevice(stream);
	}

	/// <summary>
	/// Use this function to unpause audio playback on the audio device associated with an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResumeAudioStreamDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream associated with the audio device to resume.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ResumeAudioStreamDevice(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_ResumeAudioStreamDevice(stream);
	}

	/// <summary>
	/// Lock an audio stream for serialized access.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to lock.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int LockAudioStream(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_LockAudioStream(stream);
	}

	/// <summary>
	/// Unlock an audio stream for serialized access.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to unlock.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int UnlockAudioStream(SDL_AudioStream* stream)
	{
		return SDL_PInvoke.SDL_UnlockAudioStream(stream);
	}

	/// <summary>
	/// Set a callback that runs when data is requested from an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamGetCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to set the new callback on.</param>
	/// <param name="callback">The new callback function to call when data is requested from the stream.</param>
	/// <param name="userData">An opaque pointer provided to the callback for its own personal use.</param>
	/// <returns>0 on success, -1 on error. This only fails if <paramref name="stream"/> is <see langword="null"/>.</returns>
	public static int SetAudioStreamGetCallback(SDL_AudioStream* stream, SDL_AudioStreamCallback callback, void* userData)
	{
		return SDL_PInvoke.SDL_SetAudioStreamGetCallback(stream, callback, userData);
	}

	/// <summary>
	/// Set a callback that runs when data is added to an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamPutCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to set the new callback on.</param>
	/// <param name="callback">The new callback function to call when data is added to the stream.</param>
	/// <param name="userData">An opaque pointer provided to the callback for its own personal use.</param>
	/// <returns>0 on success, -1 on error. This only fails if <paramref name="stream"/> is <see langword="null"/>.</returns>
	public static int SetAudioStreamPutCallback(SDL_AudioStream* stream, SDL_AudioStreamCallback callback, void* userData)
	{
		return SDL_PInvoke.SDL_SetAudioStreamPutCallback(stream, callback, userData);
	}

	/// <summary>
	/// Free an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to destroy.</param>
	public static void DestroyAudioStream(SDL_AudioStream* stream)
	{
		SDL_PInvoke.SDL_DestroyAudioStream(stream);
	}

	/// <summary>
	/// Convenience function for straightforward audio init for the common case.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenAudioDeviceStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">An audio device to open, or <see cref="SDL_AudioDeviceId.DefaultPlayback"/> or <see cref="SDL_AudioDeviceId.DefaultRecording"/></param>
	/// <param name="spec">The audio stream's data format. Can be <see langword="null"/>.</param>
	/// <param name="callback">A callback where the app will provide new data for playback, or receive new data for recording. Can be <see langword="null"/>, in which case the app will need to call <see cref="PutAudioStreamData"/> or <see cref="GetAudioStreamData"/> as necessary.</param>
	/// <param name="userData">App-controlled pointer passed to callback. Can be <see langword="null"/>. Ignored if <paramref name="callback"/> is <see langword="null"/>.</param>
	/// <returns>An audio stream ready to use on success, <see langword="null"/> on error; call <see cref="GetError"/> for more information.</returns>
	public static SDL_AudioStream* OpenAudioDeviceStream(SDL_AudioDeviceId devId, ref SDL_AudioSpec spec, SDL_AudioStreamCallback? callback, void* userData)
	{
		fixed (SDL_AudioSpec* specPtr = &spec)
		{
			return SDL_PInvoke.SDL_OpenAudioDeviceStream(devId, specPtr, callback, userData);
		}
	}

	/// <summary>
	/// Convenience function for straightforward audio init for the common case.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenAudioDeviceStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">An audio device to open, or <see cref="SDL_AudioDeviceId.DefaultPlayback"/> or <see cref="SDL_AudioDeviceId.DefaultRecording"/></param>
	/// <param name="spec">The audio stream's data format. Can be <see langword="null"/>.</param>
	/// <param name="callback">A callback where the app will provide new data for playback, or receive new data for recording. Can be <see langword="null"/>, in which case the app will need to call <see cref="PutAudioStreamData"/> or <see cref="GetAudioStreamData"/> as necessary.</param>
	/// <param name="userData">App-controlled pointer passed to callback. Can be <see langword="null"/>. Ignored if <paramref name="callback"/> is <see langword="null"/>.</param>
	/// <returns>An audio stream ready to use on success, <see langword="null"/> on error; call <see cref="GetError"/> for more information.</returns>
	public static SDL_AudioStream* OpenAudioDeviceStream(SDL_AudioDeviceId devId, SDL_AudioSpec* spec, SDL_AudioStreamCallback? callback, void* userData)
	{
		return SDL_PInvoke.SDL_OpenAudioDeviceStream(devId, spec, callback, userData);
	}

	/// <summary>
	/// Set a callback that fires when data is about to be fed to an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioPostmixCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The ID of an opened audio device.</param>
	/// <param name="callback">A callback function to be called. Can be <see langword="null"/>.</param>
	/// <param name="userData">App-controlled pointer passed to callback. Can be <see langword="null"/>.</param>
	/// <returns>0 on success, -1 on error; call <see cref="GetError"/> for more information.</returns>
	public static int SetAudioPostmixCallback(SDL_AudioDeviceId devId, SDL_AudioPostmixCallback callback, void* userData)
	{
		return SDL_PInvoke.SDL_SetAudioPostmixCallback(devId, callback, userData);
	}

	// FIXME: implement SDL_LoadWAV_IO

	/// <summary>
	/// Loads a WAV from a file path.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LoadWAV">documentation</see> for more details.
	/// </remarks>
	/// <param name="path">The file path of the WAV file to open.</param>
	/// <param name="spec">An <see cref="SDL_AudioSpec"/> that will be set to the WAVE data's format details on successful return.</param>
	/// <param name="audioBuffer">A pointer filled with the audio data, allocated by the function.</param>
	/// <param name="audioLength">The length of the audio data buffer in bytes.</param>
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
						return SDL_PInvoke.SDL_LoadWAV(pathPtr, specPtr, audioBufferPtr, audioLengthPtr);
					}
				}
			}
		}
	}

	/// <summary>
	/// Mix audio data in a specified format.
	/// </summary>
	/// <remarks>
	/// You need to provide a buffer of size <paramref name="length"/> to <paramref name="dst"/>. Refer to the official
	/// documentation <see href="https://wiki.libsdl.org/SDL3/SDL_MixAudio">documentation</see> for more details.
	/// </remarks>
	/// <param name="dst">The destination for the mixed audio.</param>
	/// <param name="src">The source audio buffer to be mixed.</param>
	/// <param name="format">The <see cref="SDL_AudioFormat"/> structure representing the desired audio format</param>
	/// <param name="length">The length of the audio buffer in bytes.</param>
	/// <param name="volume">Ranges from 0.0 - 1.0, and should be set to 1.0 for full audio volume.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int MixAudio(byte* dst, byte* src, SDL_AudioFormat format, uint length, float volume)
	{
		return SDL_PInvoke.SDL_MixAudio(dst, src, format,length, volume);
	}

	/// <summary>
	/// Convert some audio data of one format to another format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertAudioSamples">documentation</see> for more details.
	/// </remarks>
	/// <param name="srcSpec">The format details of the input audio.</param>
	/// <param name="srcData">The audio data to be converted.</param>
	/// <param name="srcLength">The length of <paramref name="srcData"/>.</param>
	/// <param name="dstSpec">The format details of the output audio.</param>
	/// <param name="dstData">A pointer to converted audio data, which should be freed with <see cref="Free(void*)"/>. On error, it will be <see langword="null"/>.</param>
	/// <param name="dstLength">The length of <paramref name="dstData"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ConvertAudioSamples(ref SDL_AudioSpec srcSpec, byte* srcData, int srcLength, ref SDL_AudioSpec dstSpec, out byte* dstData, out int dstLength)
	{
		fixed (byte** dstDataPtr = &dstData)
		{
			fixed (int* dstLengthPtr = &dstLength)
			{
				fixed (SDL_AudioSpec* srcSpecPtr = &srcSpec, dstSpecPtr = &dstSpec)
				{
					return SDL_PInvoke.SDL_ConvertAudioSamples(srcSpecPtr, srcData, srcLength, dstSpecPtr, dstDataPtr, dstLengthPtr);
				}
			}
		}
	}

	/// <summary>
	/// Get the appropriate memset value for silencing an audio format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSilenceValueForFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">The audio data format to query.</param>
	/// <returns>A byte value that can be passed to memset.</returns>
	public static int GetSilenceValueForFormat(SDL_AudioFormat format)
	{
		return SDL_PInvoke.SDL_GetSilenceValueForFormat(format);
	}

	/// <summary>
	/// Signed 16-bit samples.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioFormatS16 => BitConverter.IsLittleEndian ? SDL_AudioFormat.S16LittleEndian : SDL_AudioFormat.S16BigEndian;

	/// <summary>
	/// 32-bit integer samples.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioFormatS32 => BitConverter.IsLittleEndian ? SDL_AudioFormat.S32LittleEndian : SDL_AudioFormat.S32BigEndian;

	/// <summary>
	/// 32-bit floating point samples.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioFormatF32 => BitConverter.IsLittleEndian ? SDL_AudioFormat.F32LittleEndian : SDL_AudioFormat.F32BigEndian;

	public const ushort AudioMaskBitSize = 0xFF;

	public const ushort AudioMaskFloat = 1 << 8;

	public const ushort AudioMaskBigEndian = 1 << 12;

	public const ushort AudioMaskSigned = 1 << 15;
}