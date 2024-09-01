using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// RGB value used in a message box color scheme
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxColor">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_MessageBoxColor
{
	public byte R;

	public byte G;

	public byte B;
}