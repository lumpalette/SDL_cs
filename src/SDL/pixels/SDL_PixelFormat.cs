using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Details about the format of a pixel.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">documentation</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public readonly unsafe struct SDL_PixelFormat
{
	/// <summary>
	/// The <see cref="SDL_PixelFormatEnum"/> the structure is describing.
	/// </summary>
	public readonly SDL_PixelFormatEnum Format;

	/// <summary>
	/// A palette structure associated with this pixel format, or null if the format doesn't have a palette.
	/// </summary>
	public readonly SDL_Palette* Palette;

	/// <summary>
	/// The number of significant bits in a pixel value, eg: 8, 15, 16, 24, 32.
	/// </summary>
	public readonly byte BitsPerPixel;

	/// <summary>
	/// The number of bytes required to hold a pixel value, eg: 1, 2, 3, 4.
	/// </summary>
	public readonly byte BytesPerPixel;

	private readonly byte _padding1;
	private readonly byte _padding2;

	/// <summary>
	/// A mask representing the location of the red component of the pixel.
	/// </summary>
	public readonly uint RMask;

	/// <summary>
	/// A mask representing the location of the green component of the pixel.
	/// </summary>
	public readonly uint GMask;

	/// <summary>
	/// A mask representing the location of the blue component of the pixel.
	/// </summary>
	public readonly uint BMask;

	/// <summary>
	/// A mask representing the location of the alpha component of the pixel or 0 if the pixel format doesn't have any alpha information.
	/// </summary>
	public readonly uint AMask;

	/// <summary>
	/// The number of bits the red component loses when packing 8-bit color component in a pixel.
	/// </summary>
	public readonly byte RLoss; // |

	/// <summary>
	/// The number of bits the green component loses when packing 8-bit color component in a pixel.
	/// </summary>
	public readonly byte GLoss; // ||

	/// <summary>
	/// The number of bits the blue component loses when packing 8-bit color component in a pixel.
	/// </summary>
	public readonly byte BLoss; // ||

	/// <summary>
	/// The number of bits the alpha component loses when packing 8-bit color component in a pixel.
	/// </summary>
	public readonly uint ALoss; // |_

	/// <summary>
	/// The number of bits to the right of the red component in the pixel value.
	/// </summary>
	public readonly byte RShift;

	/// <summary>
	/// The number of bits to the right of the green component in the pixel value.
	/// </summary>
	public readonly byte GShift;

	/// <summary>
	/// The number of bits to the right of the blue component in the pixel value.
	/// </summary>
	public readonly byte BShift;

	/// <summary>
	/// The number of bits to the right of the alpha component in the pixel value.
	/// </summary>
	public readonly byte AShift;

	private readonly int _refCount;

	private readonly SDL_PixelFormat* _next;
}