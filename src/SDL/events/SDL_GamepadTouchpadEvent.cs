using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Gamepad touchpad event structure (<see cref="SDL_Event.GamepadTouchpad"/>).
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GamepadTouchpadEvent">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_GamepadTouchpadEvent
{
	/// <summary>
	/// Can be <see cref="SDL_EventType.GamepadTouchpadDown"/>, <see cref="SDL_EventType.GamepadTouchpadMotion"/> or <see cref="SDL_EventType.GamepadTouchpadUp"/>.
	/// </summary>
	public SDL_EventType Type;

	private readonly uint _reserved;

	/// <summary>
	/// In nanoseconds, populated using <see cref="SDL.GetTicksNs"/>.
	/// </summary>
	public ulong Timestamp;

	/// <summary>
	/// The joystick instance id.
	/// </summary>
	public SDL_JoystickId Which;

	/// <summary>
	/// The index of the touchpad.
	/// </summary>
	public int Touchpad;

	/// <summary>
	/// The index of the finger on the touchpad.
	/// </summary>
	public int Finger;

	/// <summary>
	/// Normalized in the range 0...1 with 0 being on the left.
	/// </summary>
	public float X;

	/// <summary>
	/// Normalized in the range 0...1 with 0 being at the top.
	/// </summary>
	public float Y;

	/// <summary>
	/// Normalized in the range 0...1.
	/// </summary>
	public float Pressure;
}