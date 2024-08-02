using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// The structure that describes a virtual joystick sensor.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_VirtualJoystickSensorDesc">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_VirtualJoystickSensorDesc
{
	/// <summary>
	/// The type of this sensor.
	/// </summary>
	public SDL_SensorType Type;

	/// <summary>
	/// The update frequency of this sensor, may be 0.0f.
	/// </summary>
	public float Rate;
}