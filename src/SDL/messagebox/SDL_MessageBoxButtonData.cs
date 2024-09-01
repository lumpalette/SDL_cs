using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Individual button data.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MessageBoxButtonData">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_MessageBoxButtonData
{
	public SDL_MessageBoxButtonFlags Flags;

	/// <summary>
	/// User defined button id (value returned via <see cref="FIXME:SDL_ShowMessageBox"/>).
	/// </summary>
	public int ButtonId;

	/// <summary>
	/// The UTF-8 button text.
	/// </summary>
	public byte* Text;
}