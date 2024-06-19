using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Gamepad axis motion event structure (FIXME:event.gaxis.*).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadAxisEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadAxisEvent
{
	/// <summary>
	/// Returns <see cref="SDL_EventType.GamepadAxisMotion"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="FIXME:SDL_GetTicksNS()"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance id.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The gamepad axis.
	/// </summary>
	public SDL_GamepadAxis Axis;

	private readonly ushort _padding1;

	private readonly ushort _padding2;

	private readonly ushort _padding3;

	/// <summary>
	/// The axis value (range: <see cref="SDL.JoystickAxisMin"/> to <see cref="SDL.JoystickAxisMax"/>).
	/// </summary>
	public short Value;

	private readonly ushort _padding4;
}