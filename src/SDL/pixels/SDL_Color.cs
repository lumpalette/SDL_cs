using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// A structure that represents a color as RGBA components.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Color">documentation</see> for more details.
/// </remarks>
/// <param name="r">The red component.</param>
/// <param name="g">The green component.</param>
/// <param name="b">The blue component.</param>
/// <param name="a">The alpha component.</param>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_Color(byte r, byte g, byte b, byte a)
{
	/// <summary>
	/// The red component.
	/// </summary>
	public byte R = r;

	/// <summary>
	/// The green component.
	/// </summary>
	public byte G = g;

	/// <summary>
	/// The blue component.
	/// </summary>
	public byte B = b;

	/// <summary>
	/// The alpha component.
	/// </summary>
	public byte A = a;
}