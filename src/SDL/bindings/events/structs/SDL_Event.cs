using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The structure for all events in SDL.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Event">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Explicit)]
public unsafe struct SDL_Event
{
	/// <summary>
	/// Event type, shared with all events.
	/// </summary>
	[FieldOffset(0)]
	public SDL_EventType Type;

	/// <summary>
	/// Common event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_CommonEvent Common;

	/// <summary>
	/// Display event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_DisplayEvent Display;

	/// <summary>
	/// Window event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_WindowEvent Window;

	/// <summary>
	/// Keyboard device change event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_KeyboardDeviceEvent KeyboardDevice;

	/// <summary>
	/// Keyboard event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_KeyboardEvent Keyboard;

	/// <summary>
	/// Text editing event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_TextEditingEvent TextEditing;

	/// <summary>
	/// Text editing candidates event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_TextEditingCandidatesEvent TextEditingCandidates;

	/// <summary>
	/// Text input event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_TextInputEvent TextInput;

	/// <summary>
	/// Mouse device change event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_MouseDeviceEvent MouseDevice;

	/// <summary>
	/// Mouse motion event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_MouseMotionEvent MouseMotion;

	/// <summary>
	/// Mouse button event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_MouseButtonEvent MouseButton;

	/// <summary>
	/// Mouse wheel event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_MouseWheelEvent MouseWheel;

	/// <summary>
	/// Joystick device change event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoystickDeviceEvent JoystickDevice;

	/// <summary>
	/// Joystick axis event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoystickAxisEvent JoystickAxis;

	/// <summary>
	/// Joystick ball event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoystickBallEvent JoystickBall;

	/// <summary>
	/// Joystick hat event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoystickHatEvent JoystickHat;

	/// <summary>
	/// Joystick button event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoystickButtonEvent JoystickButton;

	/// <summary>
	/// Joystick battery event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_JoystickBatteryEvent JoystickBattery;

	/// <summary>
	/// Gamepad device event data
	/// </summary>
	[FieldOffset(0)]
	public SDL_GamepadDeviceEvent GamepadDevice;

	/// <summary>
	/// Gamepad axis event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_GamepadAxisEvent GamepadAxis;

	/// <summary>
	/// Gamepad button event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_GamepadButtonEvent GamepadButton;

	/// <summary>
	/// Gamepad touchpad event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_GamepadTouchpadEvent GamepadTouchpad;

	/// <summary>
	/// Gamepad sensor event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_GamepadSensorEvent GamepadSensor;

	/// <summary>
	/// Audio device event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_AudioDeviceEvent AudioDevice;

	/// <summary>
	/// Camera device event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_CameraDeviceEvent CameraDevice;

	/// <summary>
	/// Sensor event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_SensorEvent Sensor;

	/// <summary>
	/// Quit request event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_QuitEvent Quit;

	/// <summary>
	/// Custom event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_UserEvent User;

	/// <summary>
	/// Touch finger event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_TouchFingerEvent TouchFinger;

	/// <summary>
	/// Pen tip touching or leaving drawing surface.
	/// </summary>
	[FieldOffset(0)]
	public SDL_PenTipEvent PenTip;

	/// <summary>
	/// Pen change in position, pressure, or angle.
	/// </summary>
	[FieldOffset(0)]
	public SDL_PenMotionEvent PenMotion;

	/// <summary>
	/// Pen button press.
	/// </summary>
	[FieldOffset(0)]
	public SDL_PenButtonEvent PenButton;

	/// <summary>
	/// Drag and drop event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_DropEvent Drop;

	/// <summary>
	/// Clipboard event data.
	/// </summary>
	[FieldOffset(0)]
	public SDL_ClipboardEvent Clipboard;

	[FieldOffset(0)]
	private fixed byte _padding[128];
}