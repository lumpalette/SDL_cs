using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// The structure that describes a virtual joystick touchpad.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_VirtualJoystickTouchpadDesc">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_VirtualJoystickTouchpadDesc
{
	/// <summary>
	/// The number of simultaneous fingers on this touchpad.
	/// </summary>
	public ushort NFingers;

	private readonly ushort _padding1;

	private readonly ushort _padding2;

	private readonly ushort _padding3;
}