using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// A collection of <see cref="SDL_ColorspaceValue"/> structures.
/// </summary>
/// <remarks>
/// This symbol is now a collection of properties that return <see cref="SDL_ColorspaceValue"/> structures, representing
/// the entries of the original enumerator.
/// </remarks>
public static class SDL_Colorspace
{
	/// <summary>
	/// Unknown colorspace.
	/// </summary>
	public static SDL_ColorspaceValue Unknown => new();

	/// <summary>
	/// sRGB is a gamma corrected colorspace, and the default colorspace for SDL rendering and 8-bit RGB surfaces.
	/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G22_NONE_P709.
	/// </summary>
	public static SDL_ColorspaceValue SRGB => new(SDL_ColorType.RGB, SDL_ColorRange.Full, SDL_ColorPrimaries.BT709, SDL_TransferCharacteristics.SRGB, SDL_MatrixCoefficients.Identity, SDL_ChromaLocation.None);

	/// <summary>
	/// This is a linear colorspace and the default colorspace for floating point surfaces.
	/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G10_NONE_P709.
	/// </summary>
	/// <remarks>
	/// On Windows this is the scRGB colorspace, and on Apple platforms this is kCGColorSpaceExtendedLinearSRGB for EDR content.
	/// </remarks>
	public static SDL_ColorspaceValue SRGBLinear => new(SDL_ColorType.RGB, SDL_ColorRange.Full, SDL_ColorPrimaries.BT709, SDL_TransferCharacteristics.Linear, SDL_MatrixCoefficients.Identity, SDL_ChromaLocation.None);

	/// <summary>
	/// HDR10 is a non-linear HDR colorspace and the default colorspace for 10-bit surfaces.
	/// Equivalent to DXGI_COLOR_SPACE_RGB_FULL_G2084_NONE_P2020
	/// </summary>
	public static SDL_ColorspaceValue Hdr10 => new(SDL_ColorType.RGB, SDL_ColorRange.Full, SDL_ColorPrimaries.BT2020, SDL_TransferCharacteristics.PQ, SDL_MatrixCoefficients.Identity, SDL_ChromaLocation.None);

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_FULL_G22_NONE_P709_X601.
	/// </summary>
	public static SDL_ColorspaceValue Jpeg => new(SDL_ColorType.YCbCr, SDL_ColorRange.Full, SDL_ColorPrimaries.BT709, SDL_TransferCharacteristics.BT601, SDL_MatrixCoefficients.BT601, SDL_ChromaLocation.None);

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601.
	/// </summary>
	public static SDL_ColorspaceValue BT601Limited => new(SDL_ColorType.YCbCr, SDL_ColorRange.Limited, SDL_ColorPrimaries.BT601, SDL_TransferCharacteristics.BT601, SDL_MatrixCoefficients.BT601, SDL_ChromaLocation.Left);

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P601.
	/// </summary>
	public static SDL_ColorspaceValue BT601Full => new(SDL_ColorType.YCbCr, SDL_ColorRange.Full, SDL_ColorPrimaries.BT601, SDL_TransferCharacteristics.BT601, SDL_MatrixCoefficients.BT601, SDL_ChromaLocation.Left);

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_STUDIO_G22_LEFT_P2020.
	/// </summary>
	public static SDL_ColorspaceValue BT2020Limited => new(SDL_ColorType.YCbCr, SDL_ColorRange.Limited, SDL_ColorPrimaries.BT2020, SDL_TransferCharacteristics.PQ, SDL_MatrixCoefficients.BT2020NCL, SDL_ChromaLocation.Left);

	/// <summary>
	/// Equivalent to DXGI_COLOR_SPACE_YCBCR_FULL_G22_LEFT_P2020.
	/// </summary>
	public static SDL_ColorspaceValue BT2020Full => new(SDL_ColorType.YCbCr, SDL_ColorRange.Full, SDL_ColorPrimaries.BT2020, SDL_TransferCharacteristics.PQ, SDL_MatrixCoefficients.BT2020NCL, SDL_ChromaLocation.Left);

	/// <summary>
	/// The default colorspace for RGB surfaces if no colorspace is specified.
	/// </summary>
	public static SDL_ColorspaceValue DefaultRGB => SRGB;

	/// <summary>
	/// The default colorspace for YUV surfaces if no colorspace is specified.
	/// </summary>
	public static SDL_ColorspaceValue DefaultYUV => Jpeg;
}

/// <summary>
/// Represents a single entry of the <see cref="SDL_Colorspace"/> enumerator.
/// </summary>
/// <remarks>
/// The structure is a wrapper for an unsigned 32-bit integer; see <see cref="SDL_Colorspace"/> for more details.
/// </remarks>
[Wrapper]
public readonly struct SDL_ColorspaceValue
{
	/// <summary>
	/// Instantiates a new <see cref="SDL_ColorspaceValue"/> with the given parameters.
	/// </summary>
	/// <param name="type"> The color type. </param>
	/// <param name="range"> The color range, limited or full. </param>
	/// <param name="primaries"> The color primaries. </param>
	/// <param name="transfer"> The transfer characteristics. </param>
	/// <param name="matrix"> The matrix coefficients. </param>
	/// <param name="chroma"> The chroma location. </param>
	public SDL_ColorspaceValue(SDL_ColorType type, SDL_ColorRange range, SDL_ColorPrimaries primaries, SDL_TransferCharacteristics transfer, SDL_MatrixCoefficients matrix, SDL_ChromaLocation chroma)
	{
		_value = (uint)(((byte)type << 28) | ((byte)range << 24) | ((byte)chroma << 20) | ((byte)primaries << 10) | ((byte)transfer << 5) | (byte)matrix);
	}

	internal SDL_ColorspaceValue(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_ColorspaceValue cast)
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

	public static explicit operator uint(SDL_ColorspaceValue x) => x._value;
	public static explicit operator SDL_ColorspaceValue(uint x) => new(x);

	public static bool operator ==(SDL_ColorspaceValue a, SDL_ColorspaceValue b) => a._value == b._value;
	public static bool operator !=(SDL_ColorspaceValue a, SDL_ColorspaceValue b) => a._value != b._value;

	private readonly uint _value;
}