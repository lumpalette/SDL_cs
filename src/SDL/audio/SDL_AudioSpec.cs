using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Format specifier for audio data.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioSpec">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_AudioSpec
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