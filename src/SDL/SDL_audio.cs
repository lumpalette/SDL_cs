using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

// SDL_audio.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_audio.h.
namespace SDL3;

/// <summary>
/// Audio format.
/// </summary>
/// <remarks>
/// <para>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
/// </para>
/// <para>
/// For audio formats that can be used regardless on the system endianness, use <see cref="SDL.AudioFormatS16"/>,
/// <see cref="SDL.AudioFormatS32"/> or <see cref="SDL.AudioFormatF32"/>.
/// </para>
/// </remarks>
[Typedef]
public enum SDL_AudioFormat
{
	/// <summary>
	/// Unsigned 8-bit samples.
	/// </summary>
	U8 = 0x0008,

	/// <summary>
	/// Signed 8-bit samples.
	/// </summary>
	S8 = 0x8008,

	/// <summary>
	/// Signed 16-bit samples, in little endian.
	/// </summary>
	S16LE = 0x8010,

	/// <summary>
	/// Signed 16-bit samples, in big endian.
	/// </summary>
	S16BE = 0x9010,

	/// <summary>
	/// 32-bit integer samples, in little endian.
	/// </summary>
	S32LE = 0x8020,

	/// <summary>
	/// 32-bit integer samples, in big endian.
	/// </summary>
	S32BE = 0x9020,

	/// <summary>
	/// 32-bit floating point samples, in little endian.
	/// </summary>
	F32LE = 0x8120,

	/// <summary>
	/// 32-bit floating point samples, in big endian.
	/// </summary>
	F32BE = 0x9120
}

/// <summary>
/// SDL Audio Device instance IDs.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioDeviceID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_AudioDeviceId : uint
{
	/// <summary>
	/// An invalid/null audio device ID.
	/// </summary>
	Invalid = 0
}

/// <summary>
/// Format specifier for audio data.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioSpec">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_AudioSpec
{
	/// <summary>
	/// Audio data format.
	/// </summary>
	public SDL_AudioFormat Format;

	/// <summary>
	/// Number of channels: 1 mono, 2 stereo, etc.
	/// </summary>
	public int Channels;

	/// <summary>
	/// Sample rate: sample frames per second.
	/// </summary>
	public int Freq;
}

/// <summary>
/// The opaque handle that represents an audio stream.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioStream">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_AudioStream;

unsafe partial class SDL
{
	/// <summary>
	/// A mask used to determine the size of an <see cref="SDL_AudioFormat"/>.
	/// </summary>
	public const ushort AudioMaskBitSize = 0xFF;

	/// <summary>
	/// A mask used to get if an <see cref="SDL_AudioFormat"/> uses floating-point data.
	/// </summary>
	public const ushort AudioMaskFloat = 1 << 8;

	/// <summary>
	/// A mask used to get if an <see cref="SDL_AudioFormat"/> uses big-endian data.
	/// </summary>
	public const ushort AudioMaskBigEndian = 1 << 12;

	/// <summary>
	/// A mask used to get if an <see cref="SDL_AudioFormat"/> uses signed data.
	/// </summary>
	public const ushort AudioMaskSigned = 1 << 15;

	// i don't even remember if this is right or not, it has been like 5 months or something since i worked in this subsystem lol.
	/// <summary>
	/// Define a new audio format with the given attributes.
	/// </summary>
	/// <param name="signed">Whether the audio format uses signed data or not.</param>
	/// <param name="bigEndian">Whether the audio format is formatted in big-endian.</param>
	/// <param name="flt">Whether the audio format uses floating-point data.</param>
	/// <param name="size">The size of the audio format, in bytes.</param>
	/// <returns>A new <see cref="SDL_AudioFormat"/> value.</returns>
	[Macro]
	public static SDL_AudioFormat DefineAudioFormat(ushort signed, ushort bigEndian, ushort flt, ushort size) => (SDL_AudioFormat)((signed << 15) | (bigEndian << 12) | (flt << 8) | (size & AudioMaskBitSize));

	/// <summary>
	/// Signed 16-bit samples.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioFormatS16 => BitConverter.IsLittleEndian ? SDL_AudioFormat.S16LE : SDL_AudioFormat.S16BE;

	/// <summary>
	/// 32-bit integer samples in the correct endian format for the target machine.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioFormatS32 => BitConverter.IsLittleEndian ? SDL_AudioFormat.S32LE : SDL_AudioFormat.S32BE;

	/// <summary>
	/// 32-bit floating point samples in the correct endian format for the target machine.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioFormat">documentation</see> for more details.
	/// </remarks>
	public static SDL_AudioFormat AudioFormatF32 => BitConverter.IsLittleEndian ? SDL_AudioFormat.F32LE : SDL_AudioFormat.F32BE;

	/// <summary>
	/// Retrieve the size, in bits, from an <see cref="SDL_AudioFormat"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_BITSIZE">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>Data size in bits.</returns>
	[Macro]
	public static ushort AudioBitSize(SDL_AudioFormat x) => (ushort)((ushort)x & AudioMaskBitSize);

	/// <summary>
	/// Retrieve the size, in bytes, from an <see cref="SDL_AudioFormat"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_BYTESIZE">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>Data size in bytes.</returns>
	[Macro]
	public static ushort AudioByteSize(SDL_AudioFormat x) => (ushort)(AudioBitSize(x) / 8);

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents integer data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISINT">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>True if format is integer, false otherwise.</returns>
	public static bool AudioIsInt(SDL_AudioFormat x) => ((ushort)x & AudioMaskFloat) == 0;

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents floating point data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISFLOAT">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>True if format is floating point, false otherwise.</returns>
	[Macro]
	public static bool AudioIsFloat(SDL_AudioFormat x) => ((ushort)x & AudioMaskFloat) != 0;

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents bigendian data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISBIGENDIAN">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>True if format is big endian, false otherwise.</returns>
	[Macro]
	public static bool AudioIsBigEndian(SDL_AudioFormat x) => ((ushort)x & AudioMaskBigEndian) != 0;

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents littleendian data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISLITTLEENDIAN">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>. </param>
	/// <returns>True if format is little endian, false otherwise.</returns>
	[Macro]
	public static bool AudioIsLittleEndian(SDL_AudioFormat x) => ((ushort)x & AudioMaskBigEndian) == 0;

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents signed data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISSIGNED">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>True if format is signed, false otherwise.</returns>
	[Macro]
	public static bool AudioIsSigned(SDL_AudioFormat x) => ((ushort)x & AudioMaskSigned) != 0;

	/// <summary>
	/// Determine if an <see cref="SDL_AudioFormat"/> represents unsigned data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_ISUNSIGNED">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioFormat"/>.</param>
	/// <returns>True if format is unsigned, false otherwise.</returns>
	[Macro]
	public static bool AudioIsUnsigned(SDL_AudioFormat x) => ((ushort)x & AudioMaskSigned) == 0;

	/// <summary>
	/// A value used to request a default recording audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_DEVICE_DEFAULT_RECORDING">documentation</see> for more details.
	/// </remarks>
	public const SDL_AudioDeviceId AudioDeviceDefaultRecording = (SDL_AudioDeviceId)0xFFFFFFFE;

	/// <summary>
	/// A value used to request a default playback audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK">documentation</see> for more details.
	/// </remarks>
	public const SDL_AudioDeviceId AudioDeviceDefaultPlayback = (SDL_AudioDeviceId)0xFFFFFFFF;

	/// <summary>
	/// Calculate the size of each audio frame (in bytes) from an <see cref="SDL_AudioSpec"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_FRAMESIZE">documentation</see> for more details.
	/// </remarks>
	/// <param name="x">An <see cref="SDL_AudioSpec"/> to query.</param>
	/// <returns>The number of bytes used per sample frame.</returns>
	[Macro]
	public static byte AudioFrameSize(SDL_AudioSpec x) => (byte)(AudioByteSize(x.Format) * x.Channels);

	/// <summary>
	/// Use this function to get the number of built-in audio drivers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumAudioDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns>The number of built-in audio drivers.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumAudioDrivers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumAudioDrivers();

	/// <summary>
	/// Use this function to get the name of a built in audio driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioDriver">documentation</see> for more details.
	/// </remarks>
	/// <param name="index">The index of the audio driver; the value ranges from 0 to <see cref="GetNumAudioDrivers"/> - 1.</param>
	/// <returns>The name of the audio driver at the requested index, or <see langword="null"/> if an invalid index was specified.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioDriver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetAudioDriver(int index);

	/// <summary>
	/// Get the name of the current audio driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentAudioDriver">documentation</see> for more details.
	/// </remarks>
	/// <returns>The name of the current audio driver or <see langword="null"/> if no driver has been initialized.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentAudioDriver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetCurrentAudioDriver();

	/// <summary>
	/// Get a list of currently-connected audio playback devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioPlaybackDevices">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of devices returned, may be <see langword="null"/>.</param>
	/// <returns>A null-terminated array of device instance IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioPlaybackDevices")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_AudioDeviceId* GetAudioPlaybackDevices(int* count);

	/// <summary>
	/// Get a list of currently-connected audio recording devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioRecordingDevices">documentation</see> for more details.
	/// </remarks>
	/// <param name="count">A pointer filled in with the number of devices returned, may be <see langword="null"/>.</param>
	/// <returns>A null-terminated array of device instance IDs or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioRecordingDevices")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_AudioDeviceId* GetAudioRecordingDevices(int* count);

	/// <summary>
	/// Get the human-readable name of a specific audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioDeviceName">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The instance ID of the device to query.</param>
	/// <returns>The name of the audio device, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetAudioDeviceName(SDL_AudioDeviceId devId);

	/// <summary>
	/// Get the current audio format of a specific audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioDeviceFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The instance ID of the device to query.</param>
	/// <param name="spec">On return, will be filled with device details.</param>
	/// <param name="sampleFrames">Pointer to store device buffer size, in sample frames..</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetAudioDeviceFormat(SDL_AudioDeviceId devId, SDL_AudioSpec* spec, int* sampleFrames);

	/// <summary>
	/// Get the current channel map of an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioDeviceChannelMap">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The instance ID of the device to query.</param>
	/// <param name="count">On output, set to number of channels in the map. Can be <see langword="null"/>.</param>
	/// <returns>An array of the current channel mapping, with as many elements as the current output spec's channels, or <see langword="null"/> if default. This should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceChannelMap")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int* GetAudioDeviceChannelMap(SDL_AudioDeviceId devId, int* count);

	/// <summary>
	/// Open a specific audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The device instance ID to open, or <see cref="AudioDeviceDefaultPlayback"/> or <see cref="AudioDeviceDefaultRecording"/> for the most reasonable default device.</param>
	/// <param name="spec">The requested device configuration. Can be <see langword="null"/> to use reasonable defaults.</param>
	/// <returns>The device ID on success, <see cref="SDL_AudioDeviceId.Invalid"/> on error; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_OpenAudioDevice")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_AudioDeviceId OpenAudioDevice(SDL_AudioDeviceId devId, [Const] SDL_AudioSpec* spec);

	/// <summary>
	/// Determine if an audio device is physical (instead of logical).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_IsAudioDevicePhysical">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The device ID to query.</param>
	/// <returns>True if devid is a physical device, false if it is logical.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_IsAudioDevicePhysical")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool IsAudioDevicePhysical(SDL_AudioDeviceId devId);

	/// <summary>
	/// Determine if an audio device is a playback device (instead of recording).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_IsAudioDevicePlayback">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The device ID to query.</param>
	/// <returns>True if devid is a playback device, false if it is recording.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_IsAudioDevicePlayback")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool IsAudioDevicePlayback(SDL_AudioDeviceId devId);

	/// <summary>
	/// Use this function to pause audio playback on a specified device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PauseAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device opened by <see cref="OpenAudioDevice(SDL_AudioDeviceId, SDL_AudioSpec*)"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_PauseAudioDevice")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool PauseAudioDevice(SDL_AudioDeviceId dev);

	/// <summary>
	/// Use this function to unpause audio playback on a specified device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResumeAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device opened by <see cref="OpenAudioDevice(SDL_AudioDeviceId, SDL_AudioSpec*)"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ResumeAudioDevice")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool ResumeAudioDevice(SDL_AudioDeviceId dev);

	/// <summary>
	/// Use this function to query if an audio device is paused.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioDevicePaused">documentation</see> for more details.
	/// </remarks>
	/// <param name="dev">A device opened by <see cref="OpenAudioDevice(SDL_AudioDeviceId, SDL_AudioSpec*)"/>.</param>
	/// <returns>True if device is valid and paused, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AudioDevicePaused")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool AudioDevicePaused(SDL_AudioDeviceId dev);

	/// <summary>
	/// Get the gain of an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioDeviceGain">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The audio device to query.</param>
	/// <returns>The gain of the device or -1.0f on failure; call <see cref="GetError"/> for more information</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioDeviceGain")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial float GetAudioDeviceGain(SDL_AudioDeviceId devId);

	/// <summary>
	/// Change the gain of an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioDeviceGain">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The audio device on which to change gain.</param>
	/// <param name="gain">The gain. 1.0f is no change, 0.0f is silence.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioDeviceGain")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetAudioDeviceGain(SDL_AudioDeviceId devId, float gain);

	/// <summary>
	/// Close a previously-opened audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CloseAudioDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">An audio device ID previously returned by <see cref="OpenAudioDevice(SDL_AudioDeviceId, SDL_AudioSpec*)"/>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CloseAudioDevice")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void CloseAudioDevice(SDL_AudioDeviceId devId);

	/// <summary>
	/// Bind a list of audio streams to an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BindAudioStreams">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">An audio device to bind a stream to.</param>
	/// <param name="streams">An array of audio streams to bind.</param>
	/// <param name="numStreams">Number of streams listed in the <paramref name="streams"/> array.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BindAudioStreams")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool BindAudioStreams(SDL_AudioDeviceId devId, SDL_AudioStream** streams, int numStreams);

	/// <summary>
	/// Bind a single audio stream to an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BindAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">An audio device to bind a stream to.</param>
	/// <param name="stream">An audio stream to bind to a device.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BindAudioStream")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool BindAudioStream(SDL_AudioDeviceId devId, SDL_AudioStream* stream);

	/// <summary>
	/// Unbind a list of audio streams from their audio devices.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnbindAudioStreams">documentation</see> for more details.
	/// </remarks>
	/// <param name="streams">An array of audio streams to unbind.</param>
	/// <param name="numStreams">Number of streams listed in the <paramref name="streams"/> array.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UnbindAudioStreams")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void UnbindAudioStreams(SDL_AudioStream** streams, int numStreams);

	/// <summary>
	/// Unbind a single audio stream from its audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnbindAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">An audio stream to unbind from a device.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UnbindAudioStream")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void UnbindAudioStream(SDL_AudioStream* stream);

	/// <summary>
	/// Query an audio stream for its currently-bound device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to query.</param>
	/// <returns>The bound audio device, or <see cref="SDL_AudioDeviceId.Invalid"/> if not bound or invalid.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamDevice")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_AudioDeviceId GetAudioStreamDevice(SDL_AudioStream* stream);

	/// <summary>
	/// Create a new audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="srcSpec">The format details of the input audio.</param>
	/// <param name="dstSpec">The format details of the output audio.</param>
	/// <returns>A new audio stream on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateAudioStream")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_AudioStream* CreateAudioStream([Const] SDL_AudioSpec* srcSpec, [Const] SDL_AudioSpec* dstSpec);

	/// <summary>
	/// Get the properties associated with an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to query.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetAudioStreamProperties(SDL_AudioStream* stream);

	/// <summary>
	/// Query the current format of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to query.</param>
	/// <param name="srcSpec">Where to store the input audio format; ignored if <see langword="null"/>.</param>
	/// <param name="dstSpec">Where to store the output audio format; ignored if <see langword="null"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetAudioStreamFormat(SDL_AudioStream* stream, SDL_AudioSpec* srcSpec, SDL_AudioSpec* dstSpec);

	/// <summary>
	/// Change the input and output formats of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the format is being changed.</param>
	/// <param name="srcSpec">The new format of the audio input; if <see langword="null"/>, it is not changed.</param>
	/// <param name="dstSpec">The new format of the audio output; if <see langword="null"/>, it is not changed.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetAudioStreamFormat(SDL_AudioStream* stream, [Const] SDL_AudioSpec* srcSpec, [Const] SDL_AudioSpec* dstSpec);

	/// <summary>
	/// Get the frequency ratio of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamFrequencyRatio">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to query.</param>
	/// <returns>The frequency ratio of the stream or 0.0f on error; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamFrequencyRatio")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial float GetAudioStreamFrequencyRatio(SDL_AudioStream* stream);

	/// <summary>
	/// Change the frequency ratio of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamFrequencyRatio">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the frequency ratio is being changed.</param>
	/// <param name="ratio">The frequency ratio. 1.0 is normal speed. Must be between 0.01 and 100.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamFrequencyRatio")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetAudioStreamFrequencyRatio(SDL_AudioStream* stream, float ratio);

	/// <summary>
	/// Get the gain of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamGain">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to query.</param>
	/// <returns>The gain of the stream or -1.0f on error; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamGain")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial float GetAudioStreamGain(SDL_AudioStream* stream);

	/// <summary>
	/// Change the gain of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamGain">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream on which the gain is being changed.</param>
	/// <param name="gain">The gain. 1.0f is no change, 0.0f is silence.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamGain")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetAudioStreamGain(SDL_AudioStream* stream, float gain);

	/// <summary>
	/// Get the current input channel map of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamInputChannelMap">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to query.</param>
	/// <param name="count">On output, set to number of channels in the map. Can be <see langword="null"/>.</param>
	/// <returns>An array of the current channel mapping, with as many elements as the current output spec's channels, or <see langword="null"/> if default. This should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamInputChannelMap")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int* GetAudioStreamInputChannelMap(SDL_AudioStream* stream, int* count);

	/// <summary>
	/// Get the current output channel map of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamOutputChannelMap">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to query.</param>
	/// <param name="count">On output, set to number of channels in the map. can be <see langword="null"/>.</param>
	/// <returns>An array of the current channel mapping, with as many elements as the current output spec's channels, or <see langword="null"/> if default. This should be freed with <see cref="free(void*)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamOutputChannelMap")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int* GetAudioStreamOutputChannelMap(SDL_AudioStream* stream, int* count);

	/// <summary>
	/// Set the current input channel map of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamInputChannelMap">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to change.</param>
	/// <param name="channelMap">The new channel map, <see langword="null"/> to reset to default.</param>
	/// <param name="count">The number of channels in the map.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamInputChannelMap")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetAudioStreamInputChannelMap(SDL_AudioStream* stream, [Const] int* channelMap, int count);

	/// <summary>
	/// Set the current output channel map of an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamOutputChannelMap">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The <see cref="SDL_AudioStream"/> to change.</param>
	/// <param name="channelMap">The new channel map, <see langword="null"/> to reset to default.</param>
	/// <param name="count">The number of channels in the map.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamOutputChannelMap")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetAudioStreamOutputChannelMap(SDL_AudioStream* stream, [Const] int* channelMap, int count);

	/// <summary>
	/// Add data to the stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PutAudioStreamData">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the audio data is being added to.</param>
	/// <param name="buffer">A pointer to the audio data to add.</param>
	/// <param name="length">The number of bytes to write to the stream.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_PutAudioStreamData")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool PutAudioStreamData(SDL_AudioStream* stream, nint buffer, int length);

	/// <summary>
	/// Get converted/resampled data from the stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamData">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The stream the audio is being requested from.</param>
	/// <param name="buffer">A buffer to fill with audio data.</param>
	/// <param name="length">The maximum number of bytes to fill.</param>
	/// <returns>The number of bytes read from the stream or -1 on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamData")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetAudioStreamData(SDL_AudioStream* stream, nint buffer, int length);

	/// <summary>
	/// Get the number of converted/resampled bytes available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamAvailable">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to query.</param>
	/// <returns>The number of converted/resampled bytes available or -1 on failure; call <see cref="GetError"/> for more information..</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamAvailable")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetAudioStreamAvailable(SDL_AudioStream* stream);

	/// <summary>
	/// Get the number of bytes currently queued.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioStreamQueued">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to query.</param>
	/// <returns>The number of bytes queued or -1 on failure; call <see cref="GetError"/> for more information..</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioStreamQueued")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetAudioStreamQueued(SDL_AudioStream* stream);

	/// <summary>
	/// Tell the stream that you're done sending data, and anything being buffered should be converted/resampled and
	/// made available immediately.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlushAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to flush.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_FlushAudioStream")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool FlushAudioStream(SDL_AudioStream* stream);

	/// <summary>
	/// Clear any pending data in the stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to clear.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ClearAudioStream")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool ClearAudioStream(SDL_AudioStream* stream);

	/// <summary>
	/// Use this function to pause audio playback on the audio device associated with an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PauseAudioStreamDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream associated with the audio device to pause.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_PauseAudioStreamDevice")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool PauseAudioStreamDevice(SDL_AudioStream* stream);

	/// <summary>
	/// Use this function to unpause audio playback on the audio device associated with an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ResumeAudioStreamDevice">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream associated with the audio device to resume.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ResumeAudioStreamDevice")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool ResumeAudioStreamDevice(SDL_AudioStream* stream);

	/// <summary>
	/// Lock an audio stream for serialized access.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to lock.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_LockAudioStream")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool LockAudioStream(SDL_AudioStream* stream);

	/// <summary>
	/// Unlock an audio stream for serialized access.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to unlock.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UnlockAudioStream")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool UnlockAudioStream(SDL_AudioStream* stream);

	/// <summary>
	/// Set a callback that runs when data is requested from an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamGetCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to set the new callback on.</param>
	/// <param name="callback">The new callback function to call when data is requested from the stream.</param>
	/// <param name="userData">An opaque pointer provided to the callback for its own personal use.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information. This only fails if <paramref name="stream"/> is <see langword="null"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamGetCallback")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetAudioStreamGetCallback(SDL_AudioStream* stream, delegate* unmanaged[Cdecl]<nint, SDL_AudioStream*, int, int, void> callback, nint userData);

	/// <summary>
	/// Set a callback that runs when data is added to an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioStreamPutCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to set the new callback on.</param>
	/// <param name="callback">The new callback function to call when data is added to the stream.</param>
	/// <param name="userData">An opaque pointer provided to the callback for its own personal use.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information. This only fails if <paramref name="stream"/> is <see langword="null"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioStreamPutCallback")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetAudioStreamPutCallback(SDL_AudioStream* stream, delegate* unmanaged[Cdecl]<nint, SDL_AudioStream*, int, int, void> callback, nint userData);

	/// <summary>
	/// Free an audio stream.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyAudioStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="stream">The audio stream to destroy.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyAudioStream")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroyAudioStream(SDL_AudioStream* stream);

	/// <summary>
	/// Convenience function for straightforward audio init for the common case.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_OpenAudioDeviceStream">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">An audio device to open, or <see cref="AudioDeviceDefaultPlayback"/> or <see cref="AudioDeviceDefaultRecording"/></param>
	/// <param name="spec">The audio stream's data format. Can be <see langword="null"/>.</param>
	/// <param name="callback">A callback where the app will provide new data for playback, or receive new data for recording. Can be <see langword="null"/>, in which case the app will need to call <see cref="PutAudioStreamData"/> or <see cref="GetAudioStreamData"/> as necessary.</param>
	/// <param name="userData">App-controlled pointer passed to callback. Can be <see cref="nint.Zero"/>. Ignored if <paramref name="callback"/> is <see langword="null"/>.</param>
	/// <returns>An audio stream on success, ready to use, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. When done with this stream, call <see cref="DestroyAudioStream(SDL_AudioStream*)"/> to free resources and close the device.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_OpenAudioDeviceStream")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_AudioStream* OpenAudioDeviceStream(SDL_AudioDeviceId devId, [Const] SDL_AudioSpec* spec, delegate* unmanaged[Cdecl]<nint, SDL_AudioStream*, int, int, void> callback, nint userData);

	/// <summary>
	/// Set a callback that fires when data is about to be fed to an audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetAudioPostmixCallback">documentation</see> for more details.
	/// </remarks>
	/// <param name="devId">The ID of an opened audio device.</param>
	/// <param name="callback">A callback function to be called. Can be <see langword="null"/>.</param>
	/// <param name="userData">App-controlled pointer passed to callback. Can be <see cref="nint.Zero"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetAudioPostmixCallback")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetAudioPostmixCallback(SDL_AudioDeviceId devId, delegate* unmanaged[Cdecl]<nint, SDL_AudioSpec*, float*, int, void> callback, nint userData);

	// TODO: implement SDL_LoadWAV_IO

	/// <summary>
	/// Loads a WAV from a file path.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LoadWAV">documentation</see> for more details.
	/// </remarks>
	/// <param name="path">The file path of the WAV file to open.</param>
	/// <param name="spec">An <see cref="SDL_AudioSpec"/> that will be set to the WAVE data's format details on successful return.</param>
	/// <param name="audioBuffer">A pointer filled with the audio data, allocated by the function.</param>
	/// <param name="audioLength">A pointer filled with the length of the audio data buffer in bytes.</param>
	/// <returns>
	/// True on success. <paramref name="audioBuffer"/> will be filled with a pointer to an allocated buffer containing the audio data,
	/// and <paramref name="audioLength"/> is filled with the length of that audio buffer in bytes.
	/// This function returns false if the .WAV file cannot be opened, uses an unknown data format, or is corrupt; call
	/// <see cref="GetError"/> for more information.
	/// When the application is done with the data returned in <paramref name="audioBuffer"/>, it should call <see cref="free(void*)"/>
	/// to dispose of it.
	/// </returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_LoadWAV", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool LoadWav(string path, SDL_AudioSpec* spec, byte** audioBuffer, uint* audioLength);

	/// <summary>
	/// Mix audio data in a specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_MixAudio">documentation</see> for more details.
	/// </remarks>
	/// <param name="dst">The destination for the mixed audio.</param>
	/// <param name="src">The source audio buffer to be mixed.</param>
	/// <param name="format">The <see cref="SDL_AudioFormat"/> structure representing the desired audio format</param>
	/// <param name="length">The length of the audio buffer in bytes.</param>
	/// <param name="volume">Ranges from 0.0 - 1.0, and should be set to 1.0 for full audio volume.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MixAudio")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool MixAudio(byte* dst, byte* src, SDL_AudioFormat format, uint length, float volume);

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
	/// <param name="dstData">Will be filled with a pointer to the converted audio data, which should be freed with <see cref="free(void*)"/>. On error, it will be <see langword="null"/>.</param>
	/// <param name="dstLength">Will be filled with the len of <paramref name="dstData"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ConvertAudioSamples")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool ConvertAudioSamples([Const] SDL_AudioSpec* srcSpec, [Const] byte* srcData, int srcLength, [Const] SDL_AudioSpec* dstSpec, byte** dstData, int* dstLength);

	/// <summary>
	/// Get the human readable name of an audio format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetAudioFormatName">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">The audio format to query.</param>
	/// <returns>The human readable name of the specified audio format or "SDL_AUDIO_UNKNOWN" if the format isn't recognized.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetAudioFormatName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string GetAudioFormatName(SDL_AudioFormat format);

	/// <summary>
	/// Get the appropriate memset value for silencing an audio format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSilenceValueForFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="format">The audio data format to query.</param>
	/// <returns>A byte value that can be passed to memset.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSilenceValueForFormat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetSilenceValueForFormat(SDL_AudioFormat format);
}