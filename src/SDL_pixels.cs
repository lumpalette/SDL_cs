using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_pixels.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_pixels.h.
unsafe partial class SDL
{
	/// <summary>
	/// All pixel formats known to SDL. Represents a collection of <see cref="PixelFormatValue"/> structures.
	/// </summary>
	/// <remarks>
	/// This symbol is now a collection of properties that return <see cref="PixelFormatValue"/> structures, representing
	/// the entries of the original enumerator.
	/// <br/><br/>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormatEnum">here</see>.
	/// </remarks>
	public static class PixelFormatEnum
	{
		public static PixelFormatValue Unknown => new();

		public static PixelFormatValue Index1LSB => new(PixelType.Index1, BitmapOrder.Order4321, PackedLayout.None, 1, 0);

		public static PixelFormatValue Index1MSB => new(PixelType.Index1, BitmapOrder.Order1234, PackedLayout.None, 1, 0);

		public static PixelFormatValue Index2LSB => new(PixelType.Index2, BitmapOrder.Order4321, PackedLayout.None, 2, 0);

		public static PixelFormatValue Index2MSB => new(PixelType.Index2, BitmapOrder.Order1234, PackedLayout.None, 2, 0);

		public static PixelFormatValue Index4LSB => new(PixelType.Index4, BitmapOrder.Order4321, PackedLayout.None, 4, 0);

		public static PixelFormatValue Index4MSB => new(PixelType.Index4, BitmapOrder.Order1234, PackedLayout.None, 4, 0);

		public static PixelFormatValue Index8 => new(PixelType.Index8, BitmapOrder.None, PackedLayout.None, 8, 1);

		public static PixelFormatValue RGB332 => new(PixelType.Packed8, PackedOrder.XRGB, PackedLayout.Layout332, 8, 1);

		public static PixelFormatValue XRGB4444 => new(PixelType.Packed16, PackedOrder.XRGB, PackedLayout.Layout4444, 12, 2);

		public static PixelFormatValue XBGR4444 => new(PixelType.Packed16, PackedOrder.XBGR, PackedLayout.Layout4444, 12, 2);

		public static PixelFormatValue XRGB1555 => new(PixelType.Packed16, PackedOrder.XRGB, PackedLayout.Layout1555, 15, 2);

		public static PixelFormatValue XBGR1555 => new(PixelType.Packed16, PackedOrder.XBGR, PackedLayout.Layout1555, 15, 2);

		public static PixelFormatValue ARGB4444 => new(PixelType.Packed16, PackedOrder.ARGB, PackedLayout.Layout4444, 16, 2);

		public static PixelFormatValue RGBA4444 => new(PixelType.Packed16, PackedOrder.RGBA, PackedLayout.Layout4444, 16, 2);

		public static PixelFormatValue ABGR4444 => new(PixelType.Packed16, PackedOrder.ABGR, PackedLayout.Layout4444, 16, 2);

		public static PixelFormatValue BGRA4444 => new(PixelType.Packed16, PackedOrder.BGRA, PackedLayout.Layout4444, 16, 2);

		public static PixelFormatValue ARGB1555 => new(PixelType.Packed16, PackedOrder.ARGB, PackedLayout.Layout1555, 16, 2);

		public static PixelFormatValue RGBA5551 => new(PixelType.Packed16, PackedOrder.RGBA, PackedLayout.Layout5551, 16, 2);

		public static PixelFormatValue ABGR1555 => new(PixelType.Packed16, PackedOrder.ABGR, PackedLayout.Layout1555, 16, 2);

		public static PixelFormatValue BGRA5551 => new(PixelType.Packed16, PackedOrder.BGRA, PackedLayout.Layout5551, 16, 2);

		public static PixelFormatValue RGB565 => new(PixelType.Packed16, PackedOrder.XRGB, PackedLayout.Layout565, 16, 2);

		public static PixelFormatValue BGR565 => new(PixelType.Packed16, PackedOrder.XBGR, PackedLayout.Layout565, 16, 2);

		public static PixelFormatValue RGB24 => new(PixelType.ArrayU8, ArrayOrder.RGB, PackedLayout.None, 24, 3);

		public static PixelFormatValue BGR24 => new(PixelType.ArrayU8, ArrayOrder.BGR, PackedLayout.None, 24, 3);

		public static PixelFormatValue XRGB8888 => new(PixelType.Packed32, PackedOrder.XRGB, PackedLayout.Layout8888, 24, 4);

		public static PixelFormatValue RGBX8888 => new(PixelType.Packed32, PackedOrder.RGBX, PackedLayout.Layout8888, 24, 4);

		public static PixelFormatValue XBGR8888 => new(PixelType.Packed32, PackedOrder.XBGR, PackedLayout.Layout8888, 24, 4);

		public static PixelFormatValue BGRX8888 => new(PixelType.Packed32, PackedOrder.BGRX, PackedLayout.Layout8888, 24, 4);

		public static PixelFormatValue ARGB8888 => new(PixelType.Packed32, PackedOrder.ARGB, PackedLayout.Layout8888, 32, 4);

		public static PixelFormatValue RGBA8888 => new(PixelType.Packed32, PackedOrder.RGBA, PackedLayout.Layout8888, 32, 4);

		public static PixelFormatValue ABGR8888 => new(PixelType.Packed32, PackedOrder.ABGR, PackedLayout.Layout8888, 32, 4);

		public static PixelFormatValue BGRA8888 => new(PixelType.Packed32, PackedOrder.BGRA, PackedLayout.Layout8888, 32, 4);

		public static PixelFormatValue XRGB2101010 => new(PixelType.Packed32, PackedOrder.XRGB, PackedLayout.Layout2101010, 32, 4);

		public static PixelFormatValue XBGR2101010 => new(PixelType.Packed32, PackedOrder.XBGR, PackedLayout.Layout2101010, 32, 4);

		public static PixelFormatValue ARGB2101010 => new(PixelType.Packed32, PackedOrder.ARGB, PackedLayout.Layout2101010, 32, 4);

		public static PixelFormatValue ABGR2101010 => new(PixelType.Packed32, PackedOrder.ABGR, PackedLayout.Layout2101010, 32, 4);

		public static PixelFormatValue RGB48 => new(PixelType.ArrayU16, ArrayOrder.RGB, PackedLayout.None, 48, 6);

		public static PixelFormatValue BGR48 => new(PixelType.ArrayU16, ArrayOrder.BGR, PackedLayout.None, 48, 6);

		public static PixelFormatValue RGBA64 => new(PixelType.ArrayU16, ArrayOrder.RGBA, PackedLayout.None, 64, 8);

		public static PixelFormatValue ARGB64 => new(PixelType.ArrayU16, ArrayOrder.ARGB, PackedLayout.None, 64, 8);

		public static PixelFormatValue BGRA64 => new(PixelType.ArrayU16, ArrayOrder.BGRA, PackedLayout.None, 64, 8);

		public static PixelFormatValue ABGR64 => new(PixelType.ArrayU16, ArrayOrder.ABGR, PackedLayout.None, 64, 8);

		public static PixelFormatValue RGB48Float => new(PixelType.ArrayF16, ArrayOrder.RGB, PackedLayout.None, 64, 8);

		public static PixelFormatValue BGR48Float => new(PixelType.ArrayF16, ArrayOrder.BGR, PackedLayout.None, 64, 8);

		public static PixelFormatValue RGBA64Float => new(PixelType.ArrayF16, ArrayOrder.RGBA, PackedLayout.None, 64, 8);

		public static PixelFormatValue ARGB64Float => new(PixelType.ArrayF16, ArrayOrder.ARGB, PackedLayout.None, 64, 8);

		public static PixelFormatValue BGRA64Float => new(PixelType.ArrayF16, ArrayOrder.BGRA, PackedLayout.None, 64, 8);

		public static PixelFormatValue ABGR64Float => new(PixelType.ArrayF16, ArrayOrder.ABGR, PackedLayout.None, 64, 8);

		public static PixelFormatValue RGB96Float => new(PixelType.ArrayF32, ArrayOrder.RGB, PackedLayout.None, 96, 12);

		public static PixelFormatValue BGR96Float => new(PixelType.ArrayF32, ArrayOrder.BGR, PackedLayout.None, 96, 12);

		public static PixelFormatValue RGBA128Float => new(PixelType.ArrayF32, ArrayOrder.RGBA, PackedLayout.None, 128, 16);

		public static PixelFormatValue ARGB128Float => new(PixelType.ArrayF32, ArrayOrder.ARGB, PackedLayout.None, 128, 16);

		public static PixelFormatValue BGRA128Float => new(PixelType.ArrayF32, ArrayOrder.BGRA, PackedLayout.None, 128, 16);

		public static PixelFormatValue ABGR128Float => new(PixelType.ArrayF32, ArrayOrder.ABGR, PackedLayout.None, 128, 16);

		public static PixelFormatValue RGBA32 => BitConverter.IsLittleEndian ? ABGR8888 : RGBA8888;

		public static PixelFormatValue ARGB32 => BitConverter.IsLittleEndian ? BGRA8888 : ARGB8888;

		public static PixelFormatValue BGRA32 => BitConverter.IsLittleEndian ? ARGB8888 : BGRA8888;

		public static PixelFormatValue ABGR32 => BitConverter.IsLittleEndian ? RGBA8888 : ABGR8888;

		public static PixelFormatValue RGBX32 => BitConverter.IsLittleEndian ? XBGR8888 : XRGB8888;

		public static PixelFormatValue XRGB32 => BitConverter.IsLittleEndian ? BGRX8888 : RGBX8888;

		public static PixelFormatValue BGRX32 => BitConverter.IsLittleEndian ? XRGB8888 : BGRX8888;

		public static PixelFormatValue XBGR32 => BitConverter.IsLittleEndian ? RGBX8888 : XBGR8888;

		public static PixelFormatValue YV12 => new((byte)'Y', (byte)'V', (byte)'1', (byte)'2');

		public static PixelFormatValue IYUV => new((byte)'I', (byte)'Y', (byte)'U', (byte)'V');

		public static PixelFormatValue YUY2 => new((byte)'Y', (byte)'U', (byte)'Y', (byte)'2');

		public static PixelFormatValue UYVY => new((byte)'U', (byte)'Y', (byte)'V', (byte)'Y');

		public static PixelFormatValue YVYU => new((byte)'Y', (byte)'V', (byte)'Y', (byte)'U');

		public static PixelFormatValue NV12 => new((byte)'N', (byte)'V', (byte)'1', (byte)'2');

		public static PixelFormatValue NV21 => new((byte)'N', (byte)'V', (byte)'2', (byte)'1');

		public static PixelFormatValue P010 => new((byte)'P', (byte)'0', (byte)'1', (byte)'0');

		public static PixelFormatValue ExternalOES => new((byte)'O', (byte)'E', (byte)'S', (byte)' ');
	}

	/// <summary>
	/// A collection of <see cref="ColorspaceValue"/> structures.
	/// </summary>
	/// <remarks>
	/// This symbol is now a collection of properties that return <see cref="ColorspaceValue"/> structures, representing
	/// the entries of the original enumerator.
	/// </remarks>
	public static class Colorspace
	{
		/// <summary>
		/// Unknown colorspace.
		/// </summary>
		public static ColorspaceValue Unknown => new();

		/// <summary>
		/// sRGB is a gamma corrected colorspace, and the default colorspace for SDL rendering and 8-bit RGB surfaces.
		/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709.
		/// </summary>
		public static ColorspaceValue SRGB => new(ColorType.RGB, ColorRange.Full, ColorPrimaries.BT709, TransferCharacteristics.SRGB, MatrixCoefficients.Identity, ChromaLocation.None);

		/// <summary>
		/// This is a linear colorspace and the default colorspace for floating point surfaces.
		/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709.
		/// </summary>
		/// <remarks>
		/// On Windows this is the scRGB colorspace, and on Apple platforms this is kCGColorSpaceExtendedLinearSRGB for EDR content.
		/// </remarks>
		public static ColorspaceValue SRGBLinear => new(ColorType.RGB, ColorRange.Full, ColorPrimaries.BT709, TransferCharacteristics.Linear, MatrixCoefficients.Identity, ChromaLocation.None);

		/// <summary>
		/// HDR10 is a non-linear HDR colorspace and the default colorspace for 10-bit surfaces.
		/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020
		/// </summary>
		public static ColorspaceValue Hdr10 => new(ColorType.RGB, ColorRange.Full, ColorPrimaries.BT2020, TransferCharacteristics.PQ, MatrixCoefficients.Identity, ChromaLocation.None);

		/// <summary>
		/// Equivalent to DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601.
		/// </summary>
		public static ColorspaceValue Jpeg => new(ColorType.YCbCr, ColorRange.Full, ColorPrimaries.BT709, TransferCharacteristics.BT601, MatrixCoefficients.BT601, ChromaLocation.None);

		/// <summary>
		/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601.
		/// </summary>
		public static ColorspaceValue BT601Limited => new(ColorType.YCbCr, ColorRange.Limited, ColorPrimaries.BT601, TransferCharacteristics.BT601, MatrixCoefficients.BT601, ChromaLocation.Left);

		/// <summary>
		/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601.
		/// </summary>
		public static ColorspaceValue BT601Full => new(ColorType.YCbCr, ColorRange.Full, ColorPrimaries.BT601, TransferCharacteristics.BT601, MatrixCoefficients.BT601, ChromaLocation.Left);

		/// <summary>
		/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020.
		/// </summary>
		public static ColorspaceValue BT2020Limited => new(ColorType.YCbCr, ColorRange.Limited, ColorPrimaries.BT2020, TransferCharacteristics.PQ, MatrixCoefficients.BT2020NCL, ChromaLocation.Left);

		/// <summary>
		/// Equivalent to DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020.
		/// </summary>
		public static ColorspaceValue BT2020Full => new(ColorType.YCbCr, ColorRange.Full, ColorPrimaries.BT2020, TransferCharacteristics.PQ, MatrixCoefficients.BT2020NCL, ChromaLocation.Left);

		/// <summary>
		/// The default colorspace for RGB surfaces if no colorspace is specified.
		/// </summary>
		public static ColorspaceValue DefaultRGB => SRGB;

		/// <summary>
		/// The default colorspace for YUV surfaces if no colorspace is specified.
		/// </summary>
		public static ColorspaceValue DefaultYUV => Jpeg;
	}

	/// <summary>
	/// A structure that represents a color as RGBA components.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Color">here</see>.
	/// </remarks>
	/// <param name="r"> The red component. </param>
	/// <param name="g"> The green component. </param>
	/// <param name="b"> The blue component. </param>
	/// <param name="a"> The alpha component. </param>
	[StructLayout(LayoutKind.Sequential)]
	public struct Color(byte r, byte g, byte b, byte a)
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

	/// <summary>
	/// A structure that represents a color as RGBA floating-point components.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_FColor">here</see>.
	/// </remarks>
	/// <param name="r"> The red component. </param>
	/// <param name="g"> The green component. </param>
	/// <param name="b"> The blue component. </param>
	/// <param name="a"> The alpha component. </param>
	[StructLayout(LayoutKind.Sequential)]
	public struct FColor(float r, float g, float b, float a)
	{
		/// <summary>
		/// The red component, as a floating-point number.
		/// </summary>
		public float R = r;

		/// <summary>
		/// The green component, as a floating-point number.
		/// </summary>
		public float G = g;

		/// <summary>
		/// The blue component, as a floating-point number.
		/// </summary>
		public float B = b;

		/// <summary>
		/// The alpha component, as a floating-point number.
		/// </summary>
		public float A = a;
	}

	/// <summary>
	/// A set of indexed colors representing a palette.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Palette">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public readonly struct Palette
	{
		/// <summary>
		/// Number of elements in <see cref="Colors"/>.
		/// </summary>
		public readonly int NColors;

		/// <summary>
		/// An array of <see cref="Color"/> structures representing this palette, <see cref="NColors"/> long.
		/// </summary>
		public readonly Color[] Colors
		{
			// it's easier to use this way, i guess
			get
			{
				var colors = new Color[NColors];
				for (int i = 0; i < NColors; i++)
				{
					colors[i] = _colors[i];
				}
				return colors;
			}
		}

		private readonly Color* _colors;

		private readonly uint _version;

		private readonly int _refCount;
	}

	/// <summary>
	/// Details about the format of a pixel.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormat">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct PixelFormat
	{
		/// <summary>
		/// The <see cref="PixelFormatValue"/> the structure is describing.
		/// </summary>
		public readonly PixelFormatValue Format;

		/// <summary>
		/// A palette structure associated with this pixel format, or null if the format doesn't have a palette.
		/// </summary>
		public readonly Palette* Palette;

		/// <summary>
		/// The number of significant bits in a pixel value, eg: 8, 15, 16, 24, 32
		/// </summary>
		public readonly byte BitsPerPixel;

		/// <summary>
		/// The number of bytes required to hold a pixel value, eg: 1, 2, 3, 4.
		/// </summary>
		public readonly byte BytesPerPixel;

		private fixed byte _padding[2];

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

		private readonly PixelFormat* _next;
	}

	/// <summary>
	/// A pixel format in numerical form. The structure is a wrapper for an unsigned 32-bit integer.
	/// </summary>
	/// <remarks>
	/// This structure represents a single entry of SDL_PixelFormatEnum; see <see cref="PixelFormatEnum"/> for more details.
	/// </remarks>
	[Wrapper]
	public readonly struct PixelFormatValue
	{
		private static uint CreateValue(PixelType type, byte order, PackedLayout layout, byte bits, byte bytes)
		{
			return (uint)((1 << 28) | (((byte)type) << 24) | ((order) << 20) | (((byte)layout) << 16) | (bits << 8) | (bytes));
		}

		/// <summary>
		/// Instantiates a new <see cref="PixelFormatValue"/> with a bitmap order.
		/// </summary>
		/// <param name="type"> The pixel type. </param>
		/// <param name="order"> The format's order. </param>
		/// <param name="layout"> The format's layout. </param>
		/// <param name="bits"> The number of bits a pixel using this format uses. </param>
		/// <param name="bytes"> The number of bytes a pixel using this format uses. </param>
		public PixelFormatValue(PixelType type, BitmapOrder order, PackedLayout layout, byte bits, byte bytes)
		{
			_value = CreateValue(type, (byte)order, layout, bits, bytes);
		}

		/// <summary>
		/// Instantiates a new <see cref="PixelFormatValue"/> with an array order.
		/// </summary>
		/// <param name="type"> The pixel type. </param>
		/// <param name="order"> The format's order. </param>
		/// <param name="layout"> The format layout. </param>
		/// <param name="bits"> The number of bits a pixel using this format uses. </param>
		/// <param name="bytes"> The number of bytes a pixel using this format uses. </param>
		public PixelFormatValue(PixelType type, ArrayOrder order, PackedLayout layout, byte bits, byte bytes)
		{
			_value = CreateValue(type, (byte)order, layout, bits, bytes);
		}

		/// <summary>
		/// Instantiates a new <see cref="PixelFormatValue"/> with a packed order.
		/// </summary>
		/// <param name="type"> The pixel type. </param>
		/// <param name="order"> The format's order. </param>
		/// <param name="layout"> The format layout. </param>
		/// <param name="bits"> The number of bits a pixel using this format uses. </param>
		/// <param name="bytes"> The number of bytes a pixel using this format uses. </param>
		public PixelFormatValue(PixelType type, PackedOrder order, PackedLayout layout, byte bits, byte bytes)
		{
			_value = CreateValue(type, (byte)order, layout, bits, bytes);
		}

		/// <summary>
		/// Instantiates a new <see cref="PixelFormatValue"/> using a FourCC.
		/// </summary>
		/// <param name="a"> The first character. </param>
		/// <param name="b"> The second character. </param>
		/// <param name="c"> The third character. </param>
		/// <param name="d"> The four character. </param>
		public PixelFormatValue(byte a, byte b, byte c, byte d)
		{
			_value = FourCC(a, b, c, d);
		}

		internal PixelFormatValue(uint value)
		{
			_value = value;
		}

		/// <inheritdoc/>
		public override bool Equals([NotNullWhen(true)] object? obj)
		{
			if (obj is PixelFormatValue cast)
			{
				return _value == cast._value;
			}
			return false;
		}

		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}

		public static explicit operator uint(PixelFormatValue x) => x._value;
		public static explicit operator PixelFormatValue(uint x) => new(x);

		public static bool operator ==(PixelFormatValue a, PixelFormatValue b) => a._value == b._value;
		public static bool operator !=(PixelFormatValue a, PixelFormatValue b) => a._value != b._value;

		private readonly uint _value;
	}

	/// <summary>
	/// A colorspace represented in numerical form. The structure is a wrapper for an unsigned 32-bit integer.
	/// </summary>
	/// <remarks>
	/// This structure represents a single entry of the SDL_Colorspace enum; see <see cref="Colorspace"/> for more details.
	/// </remarks>
	[Wrapper]
	public readonly struct ColorspaceValue
	{
		/// <summary>
		/// Instantiates a new <see cref="ColorspaceValue"/> with the given parameters.
		/// </summary>
		/// <param name="type"> The color type. </param>
		/// <param name="range"> The color range, limited or full. </param>
		/// <param name="primaries"> The color primaries. </param>
		/// <param name="transfer"> The transfer characteristics. </param>
		/// <param name="matrix"> The matrix coefficients. </param>
		/// <param name="chroma"> The chroma location. </param>
		public ColorspaceValue(ColorType type, ColorRange range, ColorPrimaries primaries, TransferCharacteristics transfer, MatrixCoefficients matrix, ChromaLocation chroma)
		{
			_value = (uint)(((byte)type << 28) | ((byte)range << 24) | ((byte)chroma << 20) | ((byte)primaries << 10) | ((byte)transfer << 5) | (byte)matrix);
		}

		internal ColorspaceValue(uint value)
		{
			_value = value;
		}

		/// <inheritdoc/>
		public override bool Equals([NotNullWhen(true)] object? obj)
		{
			if (obj is ColorspaceValue cast)
			{
				return _value == cast._value;
			}
			return false;
		}

		/// <inheritdoc/>
		public override int GetHashCode()
		{
			return _value.GetHashCode();
		}

		public static explicit operator uint(ColorspaceValue x) => x._value;
		public static explicit operator ColorspaceValue(uint x) => new(x);

		public static bool operator ==(ColorspaceValue a, ColorspaceValue b) => a._value == b._value;
		public static bool operator !=(ColorspaceValue a, ColorspaceValue b) => a._value != b._value;

		private readonly uint _value;
	}

	/// <summary>
	/// Pixel type.
	/// </summary>
	public enum PixelType : byte
	{
		Unknown,
		Index1,
		Index4,
		Index8,
		Packed8,
		Packed16,
		Packed32,
		ArrayU8,
		ArrayU16,
		ArrayU32,
		ArrayF16,
		ArrayF32,
		Index2
	}

	/// <summary>
	/// Bitmap pixel order, high bit -> low bit.
	/// </summary>
	public enum BitmapOrder : byte
	{
		None,
		Order4321,
		Order1234
	}

	/// <summary>
	/// Packed component order, high bit -> low bit.
	/// </summary>
	public enum PackedOrder : byte
	{
		None,
		XRGB,
		RGBX,
		ARGB,
		RGBA,
		XBGR,
		BGRX,
		ABGR,
		BGRA
	}

	/// <summary>
	/// Array component order, low byte -> high byte.
	/// </summary>
	public enum ArrayOrder : byte
	{
		None,
		RGB,
		RGBA,
		ARGB,
		BGR,
		BGRA,
		ABGR
	}

	/// <summary>
	/// Packed component layout.
	/// </summary>
	public enum PackedLayout : byte
	{
		None,
		Layout332,
		Layout4444,
		Layout1555,
		Layout5551,
		Layout565,
		Layout8888,
		Layout2101010,
		Layout1010102
	}

	/// <summary>
	/// The color type.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ColorType">here</see>.
	/// </remarks>
	public enum ColorType
	{
		/// <summary>
		/// Unknown.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// RGB colors consist of red, green, and blue channels of color that are added together to represent the colors we see
		/// on the screen. See <see href="https://en.wikipedia.org/wiki/RGB_color_model"/> for more details.
		/// </summary>
		RGB = 1,

		/// <summary>
		/// YCbCr colors represent colors as a Y luma brightness component and red and blue chroma color offsets. This color
		/// representation takes advantage of the fact that the human eye is more sensitive to brightness than the color in an
		/// image. The Cb and Cr components are often compressed and have lower resolution than the luma component. See
		/// <see href="https://en.wikipedia.org/wiki/YCbCr"/> for more details.
		/// </summary>
		YCbCr = 2
	}

	/// <summary>
	/// The color range, as described by <see href="https://www.itu.int/rec/R-REC-BT.2100-2-201807-I/en"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ColorRange">here</see>.
	/// </remarks>
	public enum ColorRange
	{
		/// <summary>
		/// Unknown.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// Narrow range, e.g. 16-235 for 8-bit RGB and luma, and 16-240 for 8-bit chroma.
		/// </summary>
		Limited = 1,

		/// <summary>
		/// Full range, e.g. 0-255 for 8-bit RGB and luma, and 1-255 for 8-bit chroma.
		/// </summary>
		Full = 2
	}

	/// <summary>
	/// The color primaries, as described by <see href="https://www.itu.int/rec/T-REC-H.273-201612-S/en"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ColorPrimaries">here</see>.
	/// </remarks>
	public enum ColorPrimaries
	{
		/// <summary>
		/// Unknown.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// ITU-R BT.709-6.
		/// </summary>
		BT709 = 1,

		/// <summary>
		/// Unspecified.
		/// </summary>
		Unspecified = 2,

		/// <summary>
		/// ITU-R BT.470-6 System M.
		/// </summary>
		BT470M = 4,

		/// <summary>
		/// ITU-R BT.470-6 System B, G / ITU-R BT.601-7 625.
		/// </summary>
		BT470BG = 5,

		/// <summary>
		/// ITU-R BT.601-7 525.
		/// </summary>
		BT601 = 6,

		/// <summary>
		/// SMPTE 240M, functionally the same as <see cref="BT601"/>.
		/// </summary>
		SMPTE240 = 7,

		/// <summary>
		/// Generic film (color filters using Illuminant C).
		/// </summary>
		GenericFilm = 8,

		/// <summary>
		/// ITU-R BT.2020-2 / ITU-R BT.2100-0
		/// </summary>
		BT2020 = 9,

		/// <summary>
		/// SMPTE ST 428-1.
		/// </summary>
		XYZ = 10,

		/// <summary>
		/// SMPTE RP 431-2.
		/// </summary>
		SMPTE431 = 11,

		/// <summary>
		/// SMPTE EG 432-1 / DCI P3.
		/// </summary>
		SMPTE432 = 12,

		/// <summary>
		/// EBU Tech. 3213-E.
		/// </summary>
		EBU3213 = 22,

		/// <summary>
		/// Custom.
		/// </summary>
		Custom = 31
	}

	/// <summary>
	/// The color transfer characteristics. These are as described by <see href="https://www.itu.int/rec/T-REC-H.273-201612-S/en"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_TransferCharacteristics">here</see>.
	/// </remarks>
	public enum TransferCharacteristics
	{
		/// <summary>
		/// Unknown.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// ITU-R BT.709-6.
		/// </summary>
		BT709 = 1,

		/// <summary>
		/// Unspecified.
		/// </summary>
		Unspecified = 2,

		/// <summary>
		/// ITU-R BT.470-6 System M / ITU-R BT1700 625 PAL & SECAM.
		/// </summary>
		Gamma22 = 4,

		/// <summary>
		/// ITU-R BT.470-6 System B, G.
		/// </summary>
		Gamma28 = 5,

		/// <summary>
		/// SMPTE ST 170M / ITU-R BT.601-7 525 or 625.
		/// </summary>
		BT601 = 6,

		/// <summary>
		/// SMPTE ST 240M.
		/// </summary>
		Smpte240 = 7,

		/// <summary>
		/// Linear.
		/// </summary>
		Linear = 8,

		/// <summary>
		/// Logarithmic (100 : 1 range).
		/// </summary>
		Log100 = 9,

		/// <summary>
		/// Logarithmic (100 * Sqrt(10) : 1 range) 
		/// </summary>
		Log100Sqrt10 = 10,

		/// <summary>
		/// IEC 61966-2-4.
		/// </summary>
		IEC61966 = 11,

		/// <summary>
		/// ITU-R BT1361 Extended Colour Gamut.
		/// </summary>
		BT1361 = 12,

		/// <summary>
		/// IEC 61966-2-1 (sRGB or sYCC).
		/// </summary>
		SRGB = 13,

		/// <summary>
		/// ITU-R BT2020 for 10-bit system.
		/// </summary>
		BT2020TenBit = 14,

		/// <summary>
		/// ITU-R BT2020 for 12-bit system.
		/// </summary>
		BT2020TwelveBit = 15,

		/// <summary>
		/// SMPTE ST 2084 for 10-, 12-, 14- and 16-bit systems.
		/// </summary>
		PQ = 16,

		/// <summary>
		/// SMPTE ST 428-1
		/// </summary>
		SMPTE428 = 17,

		/// <summary>
		/// RIB STD-B67, known as "hybrid log-gamma" (HLG).
		/// </summary>
		HGL = 18,

		/// <summary>
		/// Custom.
		/// </summary>
		Custom = 31
	}

	/// <summary>
	/// The matrix coefficients. These are as described by <see href="https://www.itu.int/rec/T-REC-H.273-201612-S/en"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_MatrixCoefficients">here</see>.
	/// </remarks>
	public enum MatrixCoefficients
	{
		/// <summary>
		/// Identity matrix.
		/// </summary>
		Identity = 0,

		/// <summary>
		/// ITU-R BT.709-6.
		/// </summary>
		BT709 = 1,

		/// <summary>
		/// Unspecified.
		/// </summary>
		Unspecified = 2,

		/// <summary>
		/// US FCC.
		/// </summary>
		FCC = 4,

		/// <summary>
		/// ITU-R BT.470-6 System B, G / ITU-R BT.601-7 625, functionally the same as <see cref="BT601"/>.
		/// </summary>
		BT470BG = 5,

		/// <summary>
		/// ITU-R BT.601-7 525.
		/// </summary>
		BT601 = 6,

		/// <summary>
		/// SMPTE 240M.
		/// </summary>
		Smpte240 = 7,

		/// <summary>
		/// YCgCo.
		/// </summary>
		YCgCo = 8,

		/// <summary>
		/// BT.2020-2 non-constant luminance, BT.2100-0 YCbCr.
		/// </summary>
		BT2020NCL = 9,

		/// <summary>
		/// BT.2020-2 constant luminance.
		/// </summary>
		BT2020CL = 10,

		/// <summary>
		/// SMPTE ST 2085.
		/// </summary>
		Smpte2085 = 11,

		/// <summary>
		/// Chromaticity-derived non-constant luminance.
		/// </summary>
		CromatDerivedNCL = 12,

		/// <summary>
		/// Chromaticity-derived constant luminance.
		/// </summary>
		CromatDerivedCL = 13,

		/// <summary>
		/// BT.2100-0 ICtCp.
		/// </summary>
		ICtCp = 14
	}

	/// <summary>
	/// The chroma sample location.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ChromaLocation">here</see>.
	/// </remarks>
	public enum ChromaLocation
	{
		/// <summary>
		/// RGB, no chroma sampling
		/// </summary>
		None = 0,

		/// <summary>
		/// In MPEG-2, MPEG-4, and AVC, Cb and Cr are taken on midpoint of the left-edge of the 2x2 square. In other words,
		/// they have the same horizontal location as the top-left pixel, but is shifted one-half pixel down vertically.
		/// </summary>
		Left = 1,

		/// <summary>
		/// In JPEG/JFIF, H.261, and MPEG-1, Cb and Cr are taken at the center of the 2x2 square. In other words, they are
		/// offset one-half pixel to the right and one-half pixel down compared to the top-left pixel.
		/// </summary>
		Center = 2,

		/// <summary>
		/// In HEVC for BT.2020 and BT.2100 content (in particular on Blu-rays), Cb and Cr are sampled at the same location
		/// as the group's top-left Y pixel ("co-sited", "co-located").
		/// </summary>
		TopLeft = 3
	}

	[Macro]
	public static byte GetPixelFlag(PixelFormatValue format)
	{
		return (byte)((((uint)format) >> 28) & 0x0F);
	}

	[Macro]
	public static PixelType GetPixelType(PixelFormatValue format)
	{
		return (PixelType)(((uint)format >> 24) & 0x0F);
	}

	[Macro]
	public static byte GetPixelOrder(PixelFormatValue format)
	{
		return (byte)(((uint)format >> 20) & 0x0F);
	}

	[Macro]
	public static PackedLayout GetPixelLayout(PixelFormatValue format)
	{
		return (PackedLayout)(((uint)format >> 16) & 0x0F);
	}

	[Macro]
	public static byte GetBitsPerPixel(PixelFormatValue format)
	{
		return (byte)(((uint)format >> 8) & 0xFF);
	}

	[Macro]
	public static byte GetBytesPerPixel(PixelFormatValue format)
	{
		if (IsPixelFormatFourCC(format))
		{
			return (byte)(((format == PixelFormatEnum.YUY2) || (format == PixelFormatEnum.UYVY) || (format == PixelFormatEnum.YVYU) || (format == PixelFormatEnum.P010)) ? 2 : 1);
		}
		return (byte)(((uint)format >> 0) & 0xFF);
	}

	[Macro]
	public static bool IsPixelFormatIndexed(PixelFormatValue format)
	{
		return (!IsPixelFormatFourCC(format)) && ((GetPixelType(format) == PixelType.Index1) || (GetPixelType(format) == PixelType.Index2) || (GetPixelType(format) == PixelType.Index4) || (GetPixelType(format) == PixelType.Index8));
	}

	[Macro]
	public static bool IsPixelFormatPacked(PixelFormatValue format)
	{
		return (!IsPixelFormatFourCC(format)) && ((GetPixelType(format) == PixelType.Packed8) || (GetPixelType(format) == PixelType.Packed16) || (GetPixelType(format) == PixelType.Packed32));
	}

	[Macro]
	public static bool IsPixelFormatArray(PixelFormatValue format)
	{
		return (!IsPixelFormatFourCC(format)) && ((GetPixelType(format) == PixelType.ArrayU8) || (GetPixelType(format) == PixelType.ArrayU16) || (GetPixelType(format) == PixelType.ArrayU32) || (GetPixelType(format) == PixelType.ArrayF16) || (GetPixelType(format) == PixelType.ArrayF32));
	}

	[Macro]
	public static bool IsPixelFormatAlpha(PixelFormatValue format)
	{
		var order = (PackedOrder)GetPixelOrder(format);
		return IsPixelFormatPacked(format) && ((order == PackedOrder.ARGB) || (order == PackedOrder.RGBA) || (order == PackedOrder.ABGR) || (order == PackedOrder.BGRA));
	}

	[Macro]
	public static bool IsPixelFormat10Bit(PixelFormatValue format)
	{
		return (!IsPixelFormatFourCC(format)) && ((GetPixelType(format) == PixelType.Packed32) || (GetPixelLayout(format) == PackedLayout.Layout2101010));
	}

	[Macro]
	public static bool IsPixelFormatFloat(PixelFormatValue format)
	{
		return (!IsPixelFormatFourCC(format)) && ((GetPixelType(format) == PixelType.ArrayF16) || (GetPixelType(format) == PixelType.ArrayF32));
	}

	[Macro]
	public static bool IsPixelFormatFourCC(PixelFormatValue format)
	{
		return (format != PixelFormatEnum.Unknown) && (GetPixelFlag(format) != 1);
	}

	[Macro]
	public static ColorType GetColorspaceType(ColorspaceValue colorspace)
	{
		return (ColorType)(((uint)colorspace >> 28) & 0x0F);
	}

	[Macro]
	public static ColorRange GetColorspaceRange(ColorspaceValue colorspace)
	{
		return (ColorRange)(((uint)colorspace >> 24) & 0x0F);
	}

	[Macro]
	public static ChromaLocation GetColorspaceChroma(ColorspaceValue colorspace)
	{
		return (ChromaLocation)(((uint)colorspace >> 20) & 0x0F);
	}

	[Macro]
	public static ColorPrimaries GetColorspacePrimaries(ColorspaceValue colorspace)
	{
		return (ColorPrimaries)(((uint)colorspace >> 10) & 0x1F);
	}

	[Macro]
	public static TransferCharacteristics GetColorspaceTransfer(ColorspaceValue colorspace)
	{
		return (TransferCharacteristics)(((uint)colorspace >> 5) & 0x1F);
	}

	[Macro]
	public static MatrixCoefficients GetColorspaceMatrix(ColorspaceValue colorspace)
	{
		return (MatrixCoefficients)((uint)colorspace & 0x1F);
	}

	[Macro]
	public static bool IsColorspaceMatrixBT601(ColorspaceValue colorspace)
	{
		return (GetColorspaceMatrix(colorspace) == MatrixCoefficients.BT601) || (GetColorspaceMatrix(colorspace) == MatrixCoefficients.BT470BG);
	}

	[Macro]
	public static bool IsColorspaceMatrixBT709(ColorspaceValue colorspace)
	{
		return GetColorspaceMatrix(colorspace) == MatrixCoefficients.BT709;
	}

	[Macro]
	public static bool IsColorspaceMatrixBT2020Ncl(ColorspaceValue colorspace)
	{
		return GetColorspaceMatrix(colorspace) == MatrixCoefficients.BT2020NCL;
	}

	[Macro]
	public static bool IsColorspaceLimitedRange(ColorspaceValue colorspace)
	{
		return GetColorspaceRange(colorspace) != ColorRange.Full;
	}

	[Macro]
	public static bool IsColorspaceFullRange(ColorspaceValue colorspace)
	{
		return GetColorspaceRange(colorspace) == ColorRange.Full;
	}

	/// <summary>
	/// Get the human readable name of a pixel format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatName">here</see>
	/// </remarks>
	/// <param name="format"> The pixel format to query. </param>
	/// <returns> The human readable name of the specified pixel format or "SDL_PIXELFORMAT_UNKNOWN" if the format isn't recognized. </returns>
	public static string GetPixelFormatName(PixelFormatValue format)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(format))!;

		[DllImport(LibraryName, EntryPoint = "SDL_GetPixelFormatName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(PixelFormatValue format);
	}

	/// <summary>
	/// Convert a pixel format value to a bpp value and RGBA masks.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetMasksForPixelFormatEnum">here</see>
	/// </remarks>
	/// <param name="format"> One of the <see cref="PixelFormatValue"/> values from the <see cref="PixelFormatEnum"/> class. </param>
	/// <param name="bpp"> Returns a bits per pixel value; usually 15, 16, or 32. </param>
	/// <param name="rMask"> Returns the red mask for the format. </param>
	/// <param name="gMask"> Returns the green mask for the format. </param>
	/// <param name="bMask"> Returns the blue mask for the format. </param>
	/// <param name="aMask"> Returns the alpha mask for the format. </param>
	/// <returns> True on success or false if the conversion wasn't possible; call <see cref="GetError"/> for more information. </returns>
	public static bool GetMasksForPixelFormatValue(PixelFormatValue format, out int bpp, out uint rMask, out uint gMask, out uint bMask, out uint aMask)
	{
		fixed (int* bb = &bpp)
		{
			fixed (uint* r = &rMask, g = &gMask, b = &bMask, a = &aMask)
			{
				return _PInvoke(format, bb, r, g, b, a) == 1;
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetMasksForPixelFormatEnum", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PixelFormatValue format, int* bpp, uint* rMask, uint* gMask, uint* bMask, uint* aMask);
	}

	/// <summary>
	/// Convert a bpp value and RGBA masks to a pixel format value.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetPixelFormatEnumForMasks">here</see>.
	/// </remarks>
	/// <param name="bpp"> A bits per pixel value; usually 15, 16, or 32 </param>
	/// <param name="rMask"> The red mask for the format. </param>
	/// <param name="gMask"> The green mask for the format. </param>
	/// <param name="bMask"> The blue mask for the format. </param>
	/// <param name="aMask"> The alpha mask for the format. </param>
	/// <returns> The <see cref="PixelFormatValue"/> value corresponding to the format masks, or <see cref="PixelFormatEnum.Unknown"/> if there isn't a match. </returns>
	public static PixelFormatValue GetPixelFormatValueForMasks(int bpp, uint rMask, uint gMask, uint bMask, uint aMask)
	{
		return _PInvoke(bpp, rMask, gMask, bMask, aMask);

		[DllImport(LibraryName, EntryPoint = "SDL_GetPixelFormatEnumForMasks", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern PixelFormatValue _PInvoke(int bpp, uint rMask, uint gMask, uint bMask, uint aMask);
	}

	/// <summary>
	/// Create a <see cref="PixelFormat"/> structure corresponding to a pixel format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePixelFormat">here</see>.
	/// </remarks>
	/// <param name="format"> One of the <see cref="PixelFormatValue"/> values from the <see cref="PixelFormatEnum"/> class. </param>
	/// <returns> The new <see cref="PixelFormat"/> structure on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static PixelFormat* CreatePixelFormat(PixelFormatValue format)
	{
		return _PInvoke(format);

		[DllImport(LibraryName, EntryPoint = "SDL_CreatePixelFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern PixelFormat* _PInvoke(PixelFormatValue format);
	}

	/// <summary>
	/// Free a <see cref="PixelFormat"/> structure allocated by <see cref="CreatePixelFormat"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyPixelFormat">here</see>.
	/// </remarks>
	/// <param name="format"> The <see cref="PixelFormat"/> structure to free. </param>
	public static void DestroyPixelFormat(PixelFormat* format)
	{
		_PInvoke(format);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyPixelFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(PixelFormat* format);
	}

	/// <summary>
	/// Create a <see cref="Palette"/> structure with the specified number of color entries.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreatePalette">here</see>.
	/// </remarks>
	/// <param name="nColors"> Represents the number of color entries in the color palette. </param>
	/// <returns> A new <see cref="Palette"/> structure on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Palette* CreatePalette(int nColors)
	{
		return _PInvoke(nColors);

		[DllImport(LibraryName, EntryPoint = "SDL_CreatePalette", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Palette* _PInvoke(int nColors);
	}

	/// <summary>
	/// Set the palette for a pixel format structure.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetPixelFormatPalette">here</see>.
	/// </remarks>
	/// <param name="format"> The <see cref="PixelFormat"/> structure that will use the palette. </param>
	/// <param name="palette"> The <see cref="Palette"/> structure that will be used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetPixelFormatPalette(PixelFormat* format, Palette* palette)
	{
		return _PInvoke(format, palette);

		[DllImport(LibraryName, EntryPoint = "SDL_SetPixelFormatPalette", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(PixelFormat* format, Palette* palette);
	}

	/// <summary>
	/// Set a range of colors in a palette.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetPaletteColors">here</see>.
	/// </remarks>
	/// <param name="palette"> The <see cref="Palette"/> structure to modify. </param>
	/// <param name="colors"> An array of <see cref="Color"/> structures to copy into the palette. </param>
	/// <param name="firstColor"> The index of the first palette entry to modify. </param>
	/// <param name="nColors"> The number of entries to modify. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetPaletteColors(Palette* palette, Color[] colors, int firstColor, int nColors)
	{
		// i don't think this is the right way of doing this... oh well! it works, right???
		fixed (Color* c = colors)
		{
			return _PInvoke(palette, c, firstColor, nColors);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetPaletteColors", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Palette* palette, Color* colors, int firstColor, int nColors);
	}

	/// <summary>
	/// Free a <see cref="Palette"/> structure created with <see cref="CreatePalette(int)"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyPalette">here</see>.
	/// </remarks>
	/// <param name="palette"> The <see cref="Palette"/> structure to be freed. </param>
	public static void DestroyPalette(Palette* palette)
	{
		_PInvoke(palette);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroyPalette", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(Palette* palette);
	}

	/// <summary>
	/// Map an RGB triple to an opaque pixel value for a given pixel format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_MapRGB">here</see>.
	/// </remarks>
	/// <param name="format"> A <see cref="PixelFormat"/> structure describing the pixel format. </param>
	/// <param name="r"> The red component of the pixel in the range 0-255. </param>
	/// <param name="g"> The green component of the pixel in the range 0-255. </param>
	/// <param name="b"> The blue component of the pixel in the range 0-255. </param>
	/// <returns> A pixel value. </returns>
	public static uint MapRGB(PixelFormat* format, byte r, byte g, byte b)
	{
		return _PInvoke(format, r, g, b);

		[DllImport(LibraryName, EntryPoint = "SDL_MapRGB", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern uint _PInvoke(PixelFormat* format, byte r, byte g, byte b);
	}

	/// <summary>
	/// Map an RGBA quadruple to a pixel value for a given pixel format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_MapRGBA">here</see>.
	/// </remarks>
	/// <param name="format"> A <see cref="PixelFormat"/> structure describing the pixel format. </param>
	/// <param name="r"> The red component of the pixel in the range 0-255. </param>
	/// <param name="g"> The green component of the pixel in the range 0-255. </param>
	/// <param name="b"> The blue component of the pixel in the range 0-255. </param>
	/// <param name="a"> The blue component of the pixel in the range 0-255. </param>
	/// <returns> A pixel value. </returns>
	public static uint MapRGBA(PixelFormat* format, byte r, byte g, byte b, byte a)
	{
		return _PInvoke(format, r, g, b, a);

		[DllImport(LibraryName, EntryPoint = "SDL_MapRGBA", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern uint _PInvoke(PixelFormat* format, byte r, byte g, byte b, byte a);
	}

	/// <summary>
	/// Get RGB values from a pixel in the specified format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRGB">here</see>.
	/// </remarks>
	/// <param name="pixel"> A pixel value. </param>
	/// <param name="format"> A <see cref="PixelFormat"/> structure describing the pixel format. </param>
	/// <param name="r"> Returns the red component of <paramref name="pixel"/>. </param>
	/// <param name="g"> Returns the green component of <paramref name="pixel"/>. </param>
	/// <param name="b"> Returns the blue component of <paramref name="pixel"/>. </param>
	public static void GetRGB(uint pixel, PixelFormat* format, out byte r, out byte g, out byte b)
	{
		fixed (byte* rr = &r, gg = &g, bb = &b)
		{
			_PInvoke(pixel, format, rr, gg, bb);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRGBA", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(uint pixel, PixelFormat* format, byte* r, byte* g, byte* b);
	}

	/// <summary>
	/// Get RGBA values from a pixel in the specified format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRGBA">here</see>.
	/// </remarks>
	/// <param name="pixel"> A pixel value. </param>
	/// <param name="format"> A <see cref="PixelFormat"/> structure describing the pixel format. </param>
	/// <param name="r"> Returns the red component of <paramref name="pixel"/>. </param>
	/// <param name="g"> Returns the green component of <paramref name="pixel"/>. </param>
	/// <param name="b"> Returns the blue component of <paramref name="pixel"/>. </param>
	/// <param name="a"> Returns the alpha component of <paramref name="pixel"/>. </param>
	public static void GetRGBA(uint pixel, PixelFormat* format, out byte r, out byte g, out byte b, out byte a)
	{
		fixed (byte* rr = &r, gg = &g, bb = &b, aa = &a)
		{
			_PInvoke(pixel, format, rr, gg, bb, aa);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRGBA", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(uint pixel, PixelFormat* format, byte* r, byte* g, byte* b, byte* a);
	}

	/// <summary>
	/// No transparency.
	/// </summary>
	public const int AlphaOpaque = 255;

	/// <summary>
	/// Full transparency.
	/// </summary>
	public const int AlphaTransparent = 0;
}