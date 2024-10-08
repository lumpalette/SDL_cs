﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

/// <summary>
/// The structure that describes a virtual joystick.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_VirtualJoystickDesc">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_VirtualJoystickDesc
{
	/// <summary>
	/// A value from <see cref="SDL_JoystickType"/>.
	/// </summary>
	public ushort Type;

	private readonly ushort _padding1;

	/// <summary>
	/// The USB vendor ID of this joystick.
	/// </summary>
	public ushort VendorId;

	/// <summary>
	/// The USB product ID of this joystick.
	/// </summary>
	public ushort ProductId;

	/// <summary>
	/// The number of axes on this joystick.
	/// </summary>
	public ushort NumAxes;

	/// <summary>
	/// The number of buttons on this joystick.
	/// </summary>
	public ushort NumButtons;

	/// <summary>
	/// The number of balls on this joystick.
	/// </summary>
	public ushort NumBalls;

	/// <summary>
	/// The number of hats on this joystick.
	/// </summary>
	public ushort NumHats;

	/// <summary>
	/// The number of touchpads on this joystick, requires <see cref="Touchpads"/> to point at valid descriptions
	/// </summary>
	public ushort NumTouchpads;

	/// <summary>
	/// The number of sensors on this joystick, requires <see cref="Sensors"/> to point at valid descriptions.
	/// </summary>
	public ushort NumSensors;

	private readonly ushort _padding2;

	private readonly ushort _padding3;

	/// <summary>
	/// A mask of which buttons are valid for this controller, e.g. (1 &lt;&lt; <see cref="SDL_GamepadButton.South"/>).
	/// </summary>
	public uint ButtonMask;

	/// <summary>
	/// A mask of which axes are valid for this controller, e.g. (1 &lt;&lt; <see cref="SDL_GamepadAxis.LeftX"/>).
	/// </summary>
	public uint AxisMask;

	/// <summary>
	/// The name of the joystick.
	/// </summary>
	public byte* Name;

	/// <summary>
	/// A pointer to an array of touchpad descriptions, required if <see cref="NumTouchpads"/> is > 0.
	/// </summary>
	public SDL_VirtualJoystickTouchpadDesc* Touchpads;

	/// <summary>
	/// A pointer to an array of sensor descriptions, required if <see cref="NumSensors"/> is > 0.
	/// </summary>
	public SDL_VirtualJoystickSensorDesc* Sensors;

	/// <summary>
	/// User data pointer passed to callbacks.
	/// </summary>
	public nint UserData;

	/// <summary>
	/// Called when the joystick state should be updated.
	/// </summary>
	public delegate* unmanaged[Cdecl]<nint, void> Update;

	/// <summary>
	/// Called when the player index is set.
	/// </summary>
	public delegate* unmanaged[Cdecl]<nint, int, void> SetPlayerIndex;

	/// <summary>
	/// Implements <see cref="SDL.RumbleJoystick(SDL_Joystick*, ushort, ushort, uint)"/>.
	/// </summary>
	public delegate* unmanaged[Cdecl]<nint, ushort, ushort, int> Rumble;

	/// <summary>
	/// Implements <see cref="SDL.RumbleJoystickTriggers(SDL_Joystick*, ushort, ushort, uint)"/>.
	/// </summary>
	public delegate* unmanaged[Cdecl]<nint, ushort, ushort, int> RumbleTriggers;

	/// <summary>
	/// Implements <see cref="SDL.SetJoystickLED(SDL_Joystick*, byte, byte, byte)"/>.
	/// </summary>
	public delegate* unmanaged[Cdecl]<nint, byte, byte, byte, int> SetLED;

	/// <summary>
	/// Implements <see cref="SDL.SendJoystickEffect(SDL_Joystick*, nint, int)"/>.
	/// </summary>
	public delegate* unmanaged[Cdecl]<nint, nint, int, int> SendEffect;

	/// <summary>
	/// Implements <see cref="SDL.SetGamepadSensorEnabled(SDL_Gamepad*, SDL_SensorType, bool)"/>.
	/// </summary>
	public delegate* unmanaged[Cdecl]<nint, int, int> SetSensorsEnabled;

	/// <summary>
	/// Cleans up the userdata when the joystick is detached.
	/// </summary>
	public delegate* unmanaged[Cdecl]<nint, void> Cleanup;
}