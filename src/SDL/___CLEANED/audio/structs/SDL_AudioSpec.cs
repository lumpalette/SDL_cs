using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

/// <summary>
/// Format specifier for audio data.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioSpec">documentation</see> for more details.
/// </remarks>
[NativeMarshalling(typeof(SDL_AudioSpecMarshaller))]
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

	/// <summary>
	/// If false, ignore <see cref="ChannelMap"/> and use default order.
	/// </summary>
	public bool UseChannelMap;

	/// <summary>
	/// <see cref="Channels"/> items of channel order.
	/// </summary>
	public byte[] ChannelMap;
}