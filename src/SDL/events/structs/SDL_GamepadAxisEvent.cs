using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadAxisEvent">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadAxisEvent
{
	/// <summary>
	/// Set to <see cref="SDL_EventType.GamepadAxisMotion"/>.
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
	/// The gamepad axis (<see cref="SDL_GamepadAxis"/>).
	/// </summary>
	public byte Axis;

	private readonly byte _padding1;
	
	private readonly byte _padding2;
	
	private readonly byte _padding3;
	
	/// <summary>
	/// The axis value (range: -32768 to 32767).
	/// </summary>
	public short Value;

	private readonly ushort _padding4;
}