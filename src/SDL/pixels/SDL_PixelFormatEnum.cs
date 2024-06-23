using System;
using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Represents a pixel format in numerical form and the collection of all pixel formats known to SDL.
/// </summary>
/// <remarks>
/// <para>
/// This symbol cannot not be defined as an enum because some entries' values are defined depending on the system endianness,
/// but C# does not support enum run-time definitions.
/// </para>
/// <para>
/// Instead of defining the symbol as an enum, it is defined as a wrapper structure that represents an entry of the original
/// enum. The entries of the enum are defined as static properties that return <see cref="SDL_PixelFormatEnum"/> structures.
/// </para>
/// <para>
/// The structure is a wrapper for an unsigned 32-bit integer. Refer to the official documentation
/// <see href="https://wiki.libsdl.org/SDL3/SDL_PixelFormatEnum">here</see> for more details.
/// </para>
/// </remarks>
[Wrapper]
public readonly struct SDL_PixelFormatEnum
{
	private static uint CreateValue(SDL_PixelType type, byte order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		return (uint)((1 << 28) | (((byte)type) << 24) | ((order) << 20) | (((byte)layout) << 16) | (bits << 8) | (bytes));
	}

	/// <summary>
	/// Instantiates a new <see cref="SDL_PixelFormatEnum"/> with a bitmap order.
	/// </summary>
	/// <param name="type"> The pixel type. </param>
	/// <param name="order"> The format's order. </param>
	/// <param name="layout"> The format's layout. </param>
	/// <param name="bits"> The number of bits a pixel using this format uses. </param>
	/// <param name="bytes"> The number of bytes a pixel using this format uses. </param>
	public SDL_PixelFormatEnum(SDL_PixelType type, SDL_BitmapOrder order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		_value = CreateValue(type, (byte)order, layout, bits, bytes);
	}

	/// <summary>
	/// Instantiates a new <see cref="SDL_PixelFormatEnum"/> with an array order.
	/// </summary>
	/// <param name="type"> The pixel type. </param>
	/// <param name="order"> The format's order. </param>
	/// <param name="layout"> The format layout. </param>
	/// <param name="bits"> The number of bits a pixel using this format uses. </param>
	/// <param name="bytes"> The number of bytes a pixel using this format uses. </param>
	public SDL_PixelFormatEnum(SDL_PixelType type, SDL_ArrayOrder order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		_value = CreateValue(type, (byte)order, layout, bits, bytes);
	}

	/// <summary>
	/// Instantiates a new <see cref="SDL_PixelFormatEnum"/> with a packed order.
	/// </summary>
	/// <param name="type"> The pixel type. </param>
	/// <param name="order"> The format's order. </param>
	/// <param name="layout"> The format layout. </param>
	/// <param name="bits"> The number of bits a pixel using this format uses. </param>
	/// <param name="bytes"> The number of bytes a pixel using this format uses. </param>
	public SDL_PixelFormatEnum(SDL_PixelType type, SDL_PackedOrder order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		_value = CreateValue(type, (byte)order, layout, bits, bytes);
	}

	/// <summary>
	/// Instantiates a new <see cref="SDL_PixelFormatEnum"/>, without a specific order type.
	/// </summary>
	/// <param name="type"> The pixel type. </param>
	/// <param name="order"> The format's order. </param>
	/// <param name="layout"> The format layout. </param>
	/// <param name="bits"> The number of bits a pixel using this format uses. </param>
	/// <param name="bytes"> The number of bytes a pixel using this format uses. </param>
	public SDL_PixelFormatEnum(SDL_PixelType type, byte order, SDL_PackedLayout layout, byte bits, byte bytes)
	{
		_value = CreateValue(type, order, layout, bits, bytes);
	}

	/// <summary>
	/// Instantiates a new <see cref="SDL_PixelFormatEnum"/> using a FourCC.
	/// </summary>
	/// <param name="a"> The first character. </param>
	/// <param name="b"> The second character. </param>
	/// <param name="c"> The third character. </param>
	/// <param name="d"> The four character. </param>
	public SDL_PixelFormatEnum(byte a, byte b, byte c, byte d)
	{
		_value = SDL.FourCC(a, b, c, d);
	}

	internal SDL_PixelFormatEnum(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override readonly bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_PixelFormatEnum cast)
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

	public static explicit operator uint(SDL_PixelFormatEnum x) => x._value;

	public static explicit operator SDL_PixelFormatEnum(uint x) => new(x);

	public static bool operator ==(SDL_PixelFormatEnum a, SDL_PixelFormatEnum b) => a._value == b._value;

	public static bool operator !=(SDL_PixelFormatEnum a, SDL_PixelFormatEnum b) => a._value != b._value;

	public static SDL_PixelFormatEnum Unknown => new();

	public static SDL_PixelFormatEnum Index1LSB => new(SDL_PixelType.Index1, SDL_BitmapOrder.Order4321, SDL_PackedLayout.None, 1, 0);

	public static SDL_PixelFormatEnum Index1MSB => new(SDL_PixelType.Index1, SDL_BitmapOrder.Order1234, SDL_PackedLayout.None, 1, 0);

	public static SDL_PixelFormatEnum Index2LSB => new(SDL_PixelType.Index2, SDL_BitmapOrder.Order4321, SDL_PackedLayout.None, 2, 0);

	public static SDL_PixelFormatEnum Index2MSB => new(SDL_PixelType.Index2, SDL_BitmapOrder.Order1234, SDL_PackedLayout.None, 2, 0);

	public static SDL_PixelFormatEnum Index4LSB => new(SDL_PixelType.Index4, SDL_BitmapOrder.Order4321, SDL_PackedLayout.None, 4, 0);

	public static SDL_PixelFormatEnum Index4MSB => new(SDL_PixelType.Index4, SDL_BitmapOrder.Order1234, SDL_PackedLayout.None, 4, 0);

	public static SDL_PixelFormatEnum Index8 => new(SDL_PixelType.Index8, SDL_BitmapOrder.None, SDL_PackedLayout.None, 8, 1);

	public static SDL_PixelFormatEnum RGB332 => new(SDL_PixelType.Packed8, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout332, 8, 1);

	public static SDL_PixelFormatEnum XRGB4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout4444, 12, 2);

	public static SDL_PixelFormatEnum XBGR4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XBGR, SDL_PackedLayout.Layout4444, 12, 2);

	public static SDL_PixelFormatEnum XRGB1555 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout1555, 15, 2);

	public static SDL_PixelFormatEnum XBGR1555 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XBGR, SDL_PackedLayout.Layout1555, 15, 2);

	public static SDL_PixelFormatEnum ARGB4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.ARGB, SDL_PackedLayout.Layout4444, 16, 2);

	public static SDL_PixelFormatEnum RGBA4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.RGBA, SDL_PackedLayout.Layout4444, 16, 2);

	public static SDL_PixelFormatEnum ABGR4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.ABGR, SDL_PackedLayout.Layout4444, 16, 2);

	public static SDL_PixelFormatEnum BGRA4444 => new(SDL_PixelType.Packed16, SDL_PackedOrder.BGRA, SDL_PackedLayout.Layout4444, 16, 2);

	public static SDL_PixelFormatEnum ARGB1555 => new(SDL_PixelType.Packed16, SDL_PackedOrder.ARGB, SDL_PackedLayout.Layout1555, 16, 2);

	public static SDL_PixelFormatEnum RGBA5551 => new(SDL_PixelType.Packed16, SDL_PackedOrder.RGBA, SDL_PackedLayout.Layout5551, 16, 2);

	public static SDL_PixelFormatEnum ABGR1555 => new(SDL_PixelType.Packed16, SDL_PackedOrder.ABGR, SDL_PackedLayout.Layout1555, 16, 2);

	public static SDL_PixelFormatEnum BGRA5551 => new(SDL_PixelType.Packed16, SDL_PackedOrder.BGRA, SDL_PackedLayout.Layout5551, 16, 2);

	public static SDL_PixelFormatEnum RGB565 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout565, 16, 2);

	public static SDL_PixelFormatEnum BGR565 => new(SDL_PixelType.Packed16, SDL_PackedOrder.XBGR, SDL_PackedLayout.Layout565, 16, 2);

	public static SDL_PixelFormatEnum RGB24 => new(SDL_PixelType.ArrayU8, SDL_ArrayOrder.RGB, SDL_PackedLayout.None, 24, 3);

	public static SDL_PixelFormatEnum BGR24 => new(SDL_PixelType.ArrayU8, SDL_ArrayOrder.BGR, SDL_PackedLayout.None, 24, 3);

	public static SDL_PixelFormatEnum XRGB8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout8888, 24, 4);

	public static SDL_PixelFormatEnum RGBX8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.RGBX, SDL_PackedLayout.Layout8888, 24, 4);

	public static SDL_PixelFormatEnum XBGR8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.XBGR, SDL_PackedLayout.Layout8888, 24, 4);

	public static SDL_PixelFormatEnum BGRX8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.BGRX, SDL_PackedLayout.Layout8888, 24, 4);

	public static SDL_PixelFormatEnum ARGB8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.ARGB, SDL_PackedLayout.Layout8888, 32, 4);

	public static SDL_PixelFormatEnum RGBA8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.RGBA, SDL_PackedLayout.Layout8888, 32, 4);

	public static SDL_PixelFormatEnum ABGR8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.ABGR, SDL_PackedLayout.Layout8888, 32, 4);

	public static SDL_PixelFormatEnum BGRA8888 => new(SDL_PixelType.Packed32, SDL_PackedOrder.BGRA, SDL_PackedLayout.Layout8888, 32, 4);

	public static SDL_PixelFormatEnum XRGB2101010 => new(SDL_PixelType.Packed32, SDL_PackedOrder.XRGB, SDL_PackedLayout.Layout2101010, 32, 4);

	public static SDL_PixelFormatEnum XBGR2101010 => new(SDL_PixelType.Packed32, SDL_PackedOrder.XBGR, SDL_PackedLayout.Layout2101010, 32, 4);

	public static SDL_PixelFormatEnum ARGB2101010 => new(SDL_PixelType.Packed32, SDL_PackedOrder.ARGB, SDL_PackedLayout.Layout2101010, 32, 4);

	public static SDL_PixelFormatEnum ABGR2101010 => new(SDL_PixelType.Packed32, SDL_PackedOrder.ABGR, SDL_PackedLayout.Layout2101010, 32, 4);

	public static SDL_PixelFormatEnum RGB48 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.RGB, SDL_PackedLayout.None, 48, 6);

	public static SDL_PixelFormatEnum BGR48 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.BGR, SDL_PackedLayout.None, 48, 6);

	public static SDL_PixelFormatEnum RGBA64 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.RGBA, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatEnum ARGB64 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.ARGB, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatEnum BGRA64 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.BGRA, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatEnum ABGR64 => new(SDL_PixelType.ArrayU16, SDL_ArrayOrder.ABGR, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatEnum RGB48Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.RGB, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatEnum BGR48Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.BGR, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatEnum RGBA64Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.RGBA, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatEnum ARGB64Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.ARGB, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatEnum BGRA64Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.BGRA, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatEnum ABGR64Float => new(SDL_PixelType.ArrayF16, SDL_ArrayOrder.ABGR, SDL_PackedLayout.None, 64, 8);

	public static SDL_PixelFormatEnum RGB96Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.RGB, SDL_PackedLayout.None, 96, 12);

	public static SDL_PixelFormatEnum BGR96Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.BGR, SDL_PackedLayout.None, 96, 12);

	public static SDL_PixelFormatEnum RGBA128Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.RGBA, SDL_PackedLayout.None, 128, 16);

	public static SDL_PixelFormatEnum ARGB128Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.ARGB, SDL_PackedLayout.None, 128, 16);

	public static SDL_PixelFormatEnum BGRA128Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.BGRA, SDL_PackedLayout.None, 128, 16);

	public static SDL_PixelFormatEnum ABGR128Float => new(SDL_PixelType.ArrayF32, SDL_ArrayOrder.ABGR, SDL_PackedLayout.None, 128, 16);

	public static SDL_PixelFormatEnum RGBA32 => BitConverter.IsLittleEndian ? ABGR8888 : RGBA8888;

	public static SDL_PixelFormatEnum ARGB32 => BitConverter.IsLittleEndian ? BGRA8888 : ARGB8888;

	public static SDL_PixelFormatEnum BGRA32 => BitConverter.IsLittleEndian ? ARGB8888 : BGRA8888;

	public static SDL_PixelFormatEnum ABGR32 => BitConverter.IsLittleEndian ? RGBA8888 : ABGR8888;

	public static SDL_PixelFormatEnum RGBX32 => BitConverter.IsLittleEndian ? XBGR8888 : XRGB8888;

	public static SDL_PixelFormatEnum XRGB32 => BitConverter.IsLittleEndian ? BGRX8888 : RGBX8888;

	public static SDL_PixelFormatEnum BGRX32 => BitConverter.IsLittleEndian ? XRGB8888 : BGRX8888;

	public static SDL_PixelFormatEnum XBGR32 => BitConverter.IsLittleEndian ? RGBX8888 : XBGR8888;

	public static SDL_PixelFormatEnum YV12 => new((byte)'Y', (byte)'V', (byte)'1', (byte)'2');

	public static SDL_PixelFormatEnum IYUV => new((byte)'I', (byte)'Y', (byte)'U', (byte)'V');

	public static SDL_PixelFormatEnum YUY2 => new((byte)'Y', (byte)'U', (byte)'Y', (byte)'2');

	public static SDL_PixelFormatEnum UYVY => new((byte)'U', (byte)'Y', (byte)'V', (byte)'Y');

	public static SDL_PixelFormatEnum YVYU => new((byte)'Y', (byte)'V', (byte)'Y', (byte)'U');

	public static SDL_PixelFormatEnum NV12 => new((byte)'N', (byte)'V', (byte)'1', (byte)'2');

	public static SDL_PixelFormatEnum NV21 => new((byte)'N', (byte)'V', (byte)'2', (byte)'1');

	public static SDL_PixelFormatEnum P010 => new((byte)'P', (byte)'0', (byte)'1', (byte)'0');

	public static SDL_PixelFormatEnum ExternalOES => new((byte)'O', (byte)'E', (byte)'S', (byte)' ');

	private readonly uint _value;
}