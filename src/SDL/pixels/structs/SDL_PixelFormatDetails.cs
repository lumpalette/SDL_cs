using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Details about the format of a pixel.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormatDetails">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe readonly struct SDL_PixelFormatDetails
{
	public readonly SDL_PixelFormat Format;

	public readonly byte BitsPerPixel;

	public readonly byte BytesPerPixel;

	private readonly byte _padding1;

	private readonly byte _padding2;

	public readonly uint RMask;

	public readonly uint GMask;

	public readonly uint BMask;

	public readonly uint AMask;

	public readonly byte RBits;

	public readonly byte GBits;

	public readonly byte BBits;
	
	public readonly uint ABits;

	public readonly byte RShift;

	public readonly byte GShift;

	public readonly byte BShift;

	public readonly byte AShift;
}