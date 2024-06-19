using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Represents a colorspace in numerical value and the collection of colorspaces recognized by SDL.
/// </summary>
/// <remarks>
/// To keep consistency with <see cref="SDL_PixelFormatEnum"/>, this symbol is defined in the same way. See its documentation for details.
/// </remarks>
[Wrapper]
public readonly struct SDL_Colorspace
{
	/// <summary>
	/// Instantiates a new <see cref="SDL_Colorspace"/> with the given parameters.
	/// </summary>
	/// <param name="type"> The color type. </param>
	/// <param name="range"> The color range, limited or full. </param>
	/// <param name="primaries"> The color primaries. </param>
	/// <param name="transfer"> The transfer characteristics. </param>
	/// <param name="matrix"> The matrix coefficients. </param>
	/// <param name="chroma"> The chroma location. </param>
	public SDL_Colorspace(SDL_ColorType type, SDL_ColorRange range, SDL_ColorPrimaries primaries, SDL_TransferCharacteristics transfer, SDL_MatrixCoefficients matrix, SDL_ChromaLocation chroma)
	{
		_value = (uint)(((byte)type << 28) | ((byte)range << 24) | ((byte)chroma << 20) | ((byte)primaries << 10) | ((byte)transfer << 5) | (byte)matrix);
	}

	internal SDL_Colorspace(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_Colorspace cast)
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

	public static explicit operator uint(SDL_Colorspace x) => x._value;

	public static explicit operator SDL_Colorspace(uint x) => new(x);

	public static bool operator ==(SDL_Colorspace a, SDL_Colorspace b) => a._value == b._value;

	public static bool operator !=(SDL_Colorspace a, SDL_Colorspace b) => a._value != b._value;

	/// <summary>
	/// Unknown colorspace.
	/// </summary>
	public static SDL_Colorspace Unknown => new();

	/// <summary>
	/// sRGB is a gamma corrected colorspace, and the default colorspace for SDL rendering and 8-bit RGB surfaces.
	/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709.
	/// </summary>
	public static SDL_Colorspace SRGB => new(SDL_ColorType.RGB, SDL_ColorRange.Full, SDL_ColorPrimaries.BT709, SDL_TransferCharacteristics.SRGB, SDL_MatrixCoefficients.Identity, SDL_ChromaLocation.None);

	/// <summary>
	/// This is a linear colorspace and the default colorspace for floating point surfaces.
	/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709.
	/// </summary>
	/// <remarks>
	/// On Windows this is the scRGB colorspace, and on Apple platforms this is kCGColorSpaceExtendedLinearSRGB for EDR content.
	/// </remarks>
	public static SDL_Colorspace SRGBLinear => new(SDL_ColorType.RGB, SDL_ColorRange.Full, SDL_ColorPrimaries.BT709, SDL_TransferCharacteristics.Linear, SDL_MatrixCoefficients.Identity, SDL_ChromaLocation.None);

	/// <summary>
	/// HDR10 is a non-linear HDR colorspace and the default colorspace for 10-bit surfaces.
	/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020
	/// </summary>
	public static SDL_Colorspace Hdr10 => new(SDL_ColorType.RGB, SDL_ColorRange.Full, SDL_ColorPrimaries.BT2020, SDL_TransferCharacteristics.PQ, SDL_MatrixCoefficients.Identity, SDL_ChromaLocation.None);

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601.
	/// </summary>
	public static SDL_Colorspace Jpeg => new(SDL_ColorType.YCbCr, SDL_ColorRange.Full, SDL_ColorPrimaries.BT709, SDL_TransferCharacteristics.BT601, SDL_MatrixCoefficients.BT601, SDL_ChromaLocation.None);

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601.
	/// </summary>
	public static SDL_Colorspace BT601Limited => new(SDL_ColorType.YCbCr, SDL_ColorRange.Limited, SDL_ColorPrimaries.BT601, SDL_TransferCharacteristics.BT601, SDL_MatrixCoefficients.BT601, SDL_ChromaLocation.Left);

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601.
	/// </summary>
	public static SDL_Colorspace BT601Full => new(SDL_ColorType.YCbCr, SDL_ColorRange.Full, SDL_ColorPrimaries.BT601, SDL_TransferCharacteristics.BT601, SDL_MatrixCoefficients.BT601, SDL_ChromaLocation.Left);

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020.
	/// </summary>
	public static SDL_Colorspace BT2020Limited => new(SDL_ColorType.YCbCr, SDL_ColorRange.Limited, SDL_ColorPrimaries.BT2020, SDL_TransferCharacteristics.PQ, SDL_MatrixCoefficients.BT2020NCL, SDL_ChromaLocation.Left);

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020.
	/// </summary>
	public static SDL_Colorspace BT2020Full => new(SDL_ColorType.YCbCr, SDL_ColorRange.Full, SDL_ColorPrimaries.BT2020, SDL_TransferCharacteristics.PQ, SDL_MatrixCoefficients.BT2020NCL, SDL_ChromaLocation.Left);

	/// <summary>
	/// The default colorspace for RGB surfaces if no colorspace is specified.
	/// </summary>
	public static SDL_Colorspace DefaultRGB => SRGB;

	/// <summary>
	/// The default colorspace for YUV surfaces if no colorspace is specified.
	/// </summary>
	public static SDL_Colorspace DefaultYUV => Jpeg;

	private readonly uint _value;
}