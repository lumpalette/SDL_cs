using System.Runtime.InteropServices;

namespace SDL3;

/// <summary>
/// Details about the format of a pixel.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormatDetails">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public unsafe struct SDL_PixelFormatDetails
{
	public SDL_PixelFormat Format;

	public byte BitsPerPixel;

	public byte BytesPerPixel;

	private readonly byte _padding1;

	private readonly byte _padding2;

	public uint RMask;

	public uint GMask;

	public uint BMask;

	public uint AMask;

	public byte RBits;

	public byte GBits;

	public byte BBits;

	public uint ABits;

	public byte RShift;

	public byte GShift;

	public byte BShift;

	public byte AShift;
}