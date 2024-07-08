using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Details about the format of a pixel.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe readonly struct SDL_PixelFormat
{
	public readonly SDL_PixelFormatEnum Format;

	public readonly SDL_Palette* Palette;

	public readonly byte BitsPerPixel;

	public readonly byte BytesPerPixel;

	private readonly byte _padding1;

	private readonly byte _padding2;

	public readonly uint RMask;

	public readonly uint GMask;

	public readonly uint BMask;

	public readonly uint AMask;
	// :(
	public readonly byte RBits;

	public readonly byte GBits;

	public readonly byte BBits;

	public readonly uint ABits;

	public readonly byte RShift;

	public readonly byte GShift;

	public readonly byte BShift;

	public readonly byte AShift;

	private readonly int _refCount;

	private readonly nint _next;
}