using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

[CustomMarshaller(typeof(SDL_AudioSpec), MarshalMode.ManagedToUnmanagedIn, typeof(SDL_AudioSpecMarshaller))]
[CustomMarshaller(typeof(SDL_AudioSpec), MarshalMode.ManagedToUnmanagedRef, typeof(SDL_AudioSpecMarshaller))]
[CustomMarshaller(typeof(SDL_AudioSpec), MarshalMode.ManagedToUnmanagedOut, typeof(SDL_AudioSpecMarshaller))]
internal static unsafe class SDL_AudioSpecMarshaller
{
	// its true identity.
	[StructLayout(LayoutKind.Sequential)]
	public unsafe struct SDL_AudioSpecUnmanaged
	{
		public SDL_AudioFormat format;

		public int channels;

		public int freq;

		public int use_channel_map;

		public fixed byte channel_map[SDL.MaxChannelMapSize];
	}

	public static SDL_AudioSpec ConvertToManaged(SDL_AudioSpecUnmanaged unmanaged)
	{
		SDL_AudioSpec managed = new()
		{
			Format = unmanaged.format,
			Channels = unmanaged.channels,
			Frequency = unmanaged.freq,
			UseChannelMap = unmanaged.use_channel_map == 1,
			ChannelMap = new byte[SDL.MaxChannelMapSize]
		};
		for (int i = 0; i < SDL.MaxChannelMapSize; i++)
		{
			managed.ChannelMap[i] = unmanaged.channel_map[i];
		}
		return managed;
	}

	public static SDL_AudioSpecUnmanaged ConvertToUnmanaged(SDL_AudioSpec managed)
	{
		SDL_AudioSpecUnmanaged unmanaged = new()
		{
			format = managed.Format,
			channels = managed.Channels,
			freq = managed.Frequency,
			use_channel_map = managed.UseChannelMap ? 1 : 0
		};
		for (int i = 0; i < SDL.MaxChannelMapSize; i++)
		{
			unmanaged.channel_map[i] = managed.ChannelMap[i];
		}
		return unmanaged;
	}
}