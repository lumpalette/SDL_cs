using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Data about a single finger in a multitouch event.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Finger">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct /* kid named */ SDL_Finger
{
	/// <summary>
	/// The finger ID.
	/// </summary>
	public SDL_FingerId Id;

	/// <summary>
	/// The x-axis location of the touch event, normalized (0...1).
	/// </summary>
	public float X;

	/// <summary>
	/// The y-axis location of the touch event, normalized (0...1).
	/// </summary>
	public float Y;

	/// <summary>
	/// The quantity of pressure applied, normalized (0...1).
	/// </summary>
	public float Pressure;
}