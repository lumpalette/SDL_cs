using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// A callback that fires when data is about to be fed to an audio device.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioPostmixCallback">documentation</see> for more details.
/// </remarks>
/// <param name="userData">A pointer provided by the app through <see cref="SDL.SetAudioPostmixCallback(SDL_AudioDeviceId, SDL_AudioPostmixCallback, nint)"/>, for its own use.</param>
/// <param name="spec">The current format of audio that is to be submitted to the audio device.</param>
/// <param name="buffer">The buffer of audio samples to be submitted. The callback can inspect and/or modify this data.</param>
/// <param name="bufferLength">The size of <paramref name="buffer"/> in bytes.</param>
[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public unsafe delegate void SDL_AudioPostmixCallback(nint userData, in SDL_AudioSpec spec, float[] buffer, int bufferLength);