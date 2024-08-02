using System.Runtime.InteropServices;

namespace SDL3;

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
	public int Frequency;
}