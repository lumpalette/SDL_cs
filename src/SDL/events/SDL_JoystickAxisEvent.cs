using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Joystick axis motion event structure (FIXME:event.jaxis.*)
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_JoyAxisEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoystickAxisEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.JoystickAxisMotion"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance ID.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The joystick axis index.
	/// </summary>
	public byte Axis;

	private readonly byte _padding1;

	private readonly byte _padding2;

	private readonly byte _padding3;

	/// <summary>
	/// The axis value (range: <see cref="SDL.JoystickAxisMin"/> to <see cref="SDL.JoystickAxisMax"/>).
	/// </summary>
	public short Value;

	private readonly byte _padding4;
}