using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Audio device event structure (<see cref="SDL_Event.AudioDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioDeviceEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_AudioDeviceEvent
{
	/// <summary>
	/// Either <see cref="SDL_EventType.AudioDeviceAdded"/>, <see cref="SDL_EventType.AudioDeviceRemoved"/> or
	/// <see cref="SDL_EventType.AudioDeviceFormatChanged"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// <see cref="SDL_AudioDeviceId"/> for the device being added or removed or changing.
	/// </summary>
	public SDL_AudioDeviceId Which;

	/// <summary>
	/// False if a playback device, true if a recording device.
	/// </summary>
	[MarshalAs(SDL.NativeBool)]
	public bool Recording;
}