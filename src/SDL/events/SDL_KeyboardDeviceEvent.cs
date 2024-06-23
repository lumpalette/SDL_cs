using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Keyboard device event structure (<see cref="SDL_Event.KeyboardDevice"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_KeyboardDeviceEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_KeyboardDeviceEvent
{
	/// <summary>
	/// Can be either <see cref="SDL_EventType.KeyboardAdded"/> or <see cref="SDL_EventType.KeyboardRemoved"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The keyboard instance ID.
	/// </summary>
	public SDL_KeyboardId Which;
}