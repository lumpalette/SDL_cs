using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Joystick axis motion event structure (<see cref="SDL_Event.JoystickAxis"/>).
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_JoyAxisEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_JoystickAxisEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.JoystickAxisMotion"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
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
	/// The axis value (range: -32768 to 32767).
	/// </summary>
	public short Value;

	private readonly byte _padding4;
}