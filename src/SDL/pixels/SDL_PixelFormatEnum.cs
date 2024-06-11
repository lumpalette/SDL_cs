using System;
using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// All pixel formats known to SDL. Represents a collection of <see cref="SDL_PixelFormatValue"/> structures.
/// </summary>
/// <remarks>
/// <para>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormatEnum">here</see>.
/// </para>
/// <para>
/// This symbol is now a collection of properties that return <see cref="SDL_PixelFormatValue"/> structures, where each property
/// represents the entries of the original enumerator. The properties are named after their original counterparts.
/// </para>
/// </remarks>
public static class SDL_PixelFormatEnum
{
	public static SDL_PixelFormatValue Unknown => new();

	public static SDL_PixelFormatValue Index1LSB => new(SDL_PixelType.Index1, SDL_BitmapOrder.Order4321, SDL_PackedLayout.None, 1, 0);

	public static SDL_PixelFormatValue Index1MSB => new(SDL_PixelType.Index1, SDL_BitmapOrder.Order1234, SDL_PackedLayout.None, 1, 0);

	public static SDL_PixelFormatValue Index2LSB => new(SDL_PixelType.Index2, SDL_BitmapOrder.Order4321, SDL_PackedLayout.None, 2, 0);

	public static SDL_PixelFormatValue Index2MSB => new(SDL_PixelType.Index2, SDL_BitmapOrder.Order1234, SDL_PackedLayout.None, 2, 0);

	public static SDL_PixelFormatValue Index4LSB => new(SDL_PixelType.Index4, SDL_BitmapOrder.Order4321, SDL_PackedLayout.None, 4, 0);

	public static SDL_PixelFormatValue Index4MSB => new(SDL_PixelType.Index4, SDL_BitmapOrder.Order1234, SDL_PackedLayout.None, 4, 0);

	public static SDL_PixelFormatValue Index8 => new(SDL_PixelType.Index8, SDL_BitmapOrder.None, SDL_PackedLayout.None, 8, 1);

	public static SDL_PixelFormatValue RGB332 => new(SDL_PixelType.Packed8, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout332, 8, 1);

	public static SDL_PixelFormatValue XRGB4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout4444, 12, 2);

	public static SDL_PixelFormatValue XBGR4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XBGR, SDL_PackedLayout.Layout4444, 12, 2);

	public static SDL_PixelFormatValue XRGB1555 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout1555, 15, 2);

	public static SDL_PixelFormatValue XBGR1555 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XBGR, SDL_PackedLayout.Layout1555, 15, 2);

	public static SDL_PixelFormatValue ARGB4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.ARGB, SDL_PackedLayout.Layout4444, 16, 2);

	public static SDL_PixelFormatValue RGBA4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.RGBA, SDL_PackedLayout.Layout4444, 16, 2);

	public static SDL_PixelFormatValue ABGR4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.ABGR, SDL_PackedLayout.Layout4444, 16, 2);

	public static SDL_PixelFormatValue BGRA4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.BGRA, SDL_PackedLayout.Layout4444, 16, 2);

	public static SDL_PixelFormatValue ARGB1555 => new(SDL_PixelType.Packed16, SDL_PackedOrder.ARGB, SDL_PackedLayout.Layout1555, 16, 2);

	public static SDL_PixelFormatValue RGBA5551 => new(SDL_PixelType.Packed16, SDL_PackedOrder.RGBA, SDL_PackedLayout.Layout5551, 16, 2);

	public static SDL_PixelFormatValue ABGR1555 => new(SDL_PixelType.Packed16, SDL_PackedOrder.ABGR, SDL_PackedLayout.Layout1555, 16, 2);

	public static SDL_PixelFormatValue BGRA5551 => new(SDL_PixelType.Packed16, SDL_PackedOrder.BGRA, SDL_PackedLayout.Layout5551, 16, 2);

	public static SDL_PixelFormatValue RGB565 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout565, 16, 2);

	public static SDL_PixelFormatValue BGR565 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XBGR, SDL_PackedLayout.Layout565, 16, 2);

	public static SDL_PixelFormatValue RGB24 => new(SDL_PixelType.ArrayU8, SDL_ArrayOrder.RGB, SDL_PackedLayout.None, 24, 3);

	public static SDL_PixelFormatValue BGR24 => new(SDL_PixelType.ArrayU8, SDL_ArrayOrder.BGR, SDL_PackedLayout.None, 24, 3);

	public static SDL_PixelFormatValue XRGB8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout8888, 24, 4);

	public static SDL_PixelFormatValue RGBX8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.RGBX, SDL_PackedLayout.Layout8888, 24, 4);

	public static SDL_PixelFormatValue XBGR8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.XBGR, SDL_PackedLayout.Layout8888, 24, 4);

	public static SDL_PixelFormatValue BGRX8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.BGRX, SDL_PackedLayout.Layout8888, 24, 4);

	public static SDL_PixelFormatValue ARGB8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.ARGB, SDL_PackedLayout.Layout8888, 32, 4);

	public static SDL_PixelFormatValue RGBA8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.RGBA, SDL_PackedLayout.Layout8888, 32, 4);

	public static SDL_PixelFormatValue ABGR8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.ABGR, SDL_PackedLayout.Layout8888, 32, 4);

	public static SDL_PixelFormatValue BGRA8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.BGRA, SDL_PackedLayout.Layout8888, 32, 4);

	public static SDL_PixelFormatValue XRGB2101010 => new(SDL_PixelType.Packed32, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout2101010, 32, 4);

	public static SDL_PixelFormatValue XBGR2101010 => new(SDL_PixelType.Packed32, SDL_PackedOrder.XBGR, SDL_PackedLayout.Layout2101010, 32, 4);

	public static SDL_PixelFormatValue ARGB2101010 => new(SDL_PixelType.Packed32, SDL_PackedOrder.ARGB, SDL_PackedLayout.Layout2101010, 32, 4);

	public static SDL_PixelFormatValue ABGR2101010 => new(SDL_PixelType.Packed32, SDL_PackedOrder.ABGR, SDL_PackedLayout.Layout2101010, 32, 4);

	public static SDL_PixelFormatValue RGB48 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.RGB, SDL_PackedLayout.None, 48, 6);

	public static SDL_PixelFormatValue BGR48 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.BGR, SDL_PackedLayout.None, 48, 6);

	public static SDL_PixelFormatValue RGBA64 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.RGBA, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatValue ARGB64 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.ARGB, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatValue BGRA64 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.BGRA, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatValue ABGR64 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.ABGR, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatValue RGB48Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.RGB, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatValue BGR48Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.BGR, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatValue RGBA64Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.RGBA, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatValue ARGB64Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.ARGB, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatValue BGRA64Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.BGRA, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatValue ABGR64Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.ABGR, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatValue RGB96Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.RGB, SDL_PackedLayout.None, 96, 12);

	public static SDL_PixelFormatValue BGR96Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.BGR, SDL_PackedLayout.None, 96, 12);

	public static SDL_PixelFormatValue RGBA128Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.RGBA, SDL_PackedLayout.None, 128, 16);

	public static SDL_PixelFormatValue ARGB128Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.ARGB, SDL_PackedLayout.None, 128, 16);

	public static SDL_PixelFormatValue BGRA128Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.BGRA, SDL_PackedLayout.None, 128, 16);

	public static SDL_PixelFormatValue ABGR128Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.ABGR, SDL_PackedLayout.None, 128, 16);

	public static SDL_PixelFormatValue RGBA32 => BitConverter.IsLittleEndian ? ABGR8888 : RGBA8888;

	public static SDL_PixelFormatValue ARGB32 => BitConverter.IsLittleEndian ? BGRA8888 : ARGB8888;

	public static SDL_PixelFormatValue BGRA32 => BitConverter.IsLittleEndian ? ARGB8888 : BGRA8888;

	public static SDL_PixelFormatValue ABGR32 => BitConverter.IsLittleEndian ? RGBA8888 : ABGR8888;

	public static SDL_PixelFormatValue RGBX32 => BitConverter.IsLittleEndian ? XBGR8888 : XRGB8888;

	public static SDL_PixelFormatValue XRGB32 => BitConverter.IsLittleEndian ? BGRX8888 : RGBX8888;

	public static SDL_PixelFormatValue BGRX32 => BitConverter.IsLittleEndian ? XRGB8888 : BGRX8888;

	public static SDL_PixelFormatValue XBGR32 => BitConverter.IsLittleEndian ? RGBX8888 : XBGR8888;

	public static SDL_PixelFormatValue YV12 => new((byte)'Y', (byte)'V', (byte)'1', (byte)'2');

	public static SDL_PixelFormatValue IYUV => new((byte)'I', (byte)'Y', (byte)'U', (byte)'V');

	public static SDL_PixelFormatValue YUY2 => new((byte)'Y', (byte)'U', (byte)'Y', (byte)'2');

	public static SDL_PixelFormatValue UYVY => new((byte)'U', (byte)'Y', (byte)'V', (byte)'Y');

	public static SDL_PixelFormatValue YVYU => new((byte)'Y', (byte)'V', (byte)'Y', (byte)'U');

	public static SDL_PixelFormatValue NV12 => new((byte)'N', (byte)'V', (byte)'1', (byte)'2');

	public static SDL_PixelFormatValue NV21 => new((byte)'N', (byte)'V', (byte)'2', (byte)'1');

	public static SDL_PixelFormatValue P010 => new((byte)'P', (byte)'0', (byte)'1', (byte)'0');

	public static SDL_PixelFormatValue ExternalOES => new((byte)'O', (byte)'E', (byte)'S', (byte)' ');
}

/// <summary>
/// Represents a single entry of the <see cref="SDL_PixelFormatEnum"/> enumerator.
/// </summary>
/// <remarks>
/// The structure is a wrapper for an unsigned 32-bit integer; see <see cref="SDL_PixelFormatEnum"/> for more details.
/// </remarks>
[Wrapper]
public readonly struct SDL_PixelFormatValue
{
	private static uint CreateValue(SDL_PixelType type, byte order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		return (uint)((1 << 28) | (((byte)type) << 24) | ((order) << 20) | (((byte)layout) << 16) | (bits << 8) | (bytes));
	}

	/// <summary>
	/// Instantiates a new <see cref="SDL_PixelFormatValue"/> with a bitmap order.
	/// </summary>
	/// <param name="type"> The pixel type. </param>
	/// <param name="order"> The format's order. </param>
	/// <param name="layout"> The format's layout. </param>
	/// <param name="bits"> The number of bits a pixel using this format uses. </param>
	/// <param name="bytes"> The number of bytes a pixel using this format uses. </param>
	public SDL_PixelFormatValue(SDL_PixelType type, SDL_BitmapOrder order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		_value = CreateValue(type, (byte)order, layout, bits, bytes);
	}

	/// <summary>
	/// Instantiates a new <see cref="SDL_PixelFormatValue"/> with an array order.
	/// </summary>
	/// <param name="type"> The pixel type. </param>
	/// <param name="order"> The format's order. </param>
	/// <param name="layout"> The format layout. </param>
	/// <param name="bits"> The number of bits a pixel using this format uses. </param>
	/// <param name="bytes"> The number of bytes a pixel using this format uses. </param>
	public SDL_PixelFormatValue(SDL_PixelType type, SDL_ArrayOrder order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		_value = CreateValue(type, (byte)order, layout, bits, bytes);
	}

	/// <summary>
	/// Instantiates a new <see cref="SDL_PixelFormatValue"/> with a packed order.
	/// </summary>
	/// <param name="type"> The pixel type. </param>
	/// <param name="order"> The format's order. </param>
	/// <param name="layout"> The format layout. </param>
	/// <param name="bits"> The number of bits a pixel using this format uses. </param>
	/// <param name="bytes"> The number of bytes a pixel using this format uses. </param>
	public SDL_PixelFormatValue(SDL_PixelType type, SDL_PackedOrder order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		_value = CreateValue(type, (byte)order, layout, bits, bytes);
	}

	/// <summary>
	/// Instantiates a new <see cref="SDL_PixelFormatValue"/> using a FourCC.
	/// </summary>
	/// <param name="a"> The first character. </param>
	/// <param name="b"> The second character. </param>
	/// <param name="c"> The third character. </param>
	/// <param name="d"> The four character. </param>
	public SDL_PixelFormatValue(byte a, byte b, byte c, byte d)
	{
		_value = SDL.FourCC(a, b, c, d);
	}

	internal SDL_PixelFormatValue(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override readonly bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_PixelFormatValue cast)
		{
			return _value == cast._value;
		}
		return false;
	}

	/// <inheritdoc/>
	public override readonly int GetHashCode()
	{
		return _value.GetHashCode();
	}

	public static explicit operator uint(SDL_PixelFormatValue x) => x._value;
	public static explicit operator SDL_PixelFormatValue(uint x) => new(x);

	public static bool operator ==(SDL_PixelFormatValue a, SDL_PixelFormatValue b) => a._value == b._value;
	public static bool operator !=(SDL_PixelFormatValue a, SDL_PixelFormatValue b) => a._value != b._value;

	private readonly uint _value;
}