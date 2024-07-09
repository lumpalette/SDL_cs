namespace SDL_cs;

partial class SDL_Prop
{
	/// <summary>
	/// Properties used in <see cref="SDL.GetSurfaceProperties(SDL_Surface*)"/>.
	/// </summary>
	public static class Surface
	{
		/// <summary>
		/// An <see cref="SDL_Colorspace"/> value describing the surface colorspace, defaults to:
		/// <list type="bullet">
		///		<item>
		///			<term><see cref="SDL_Colorspace.SRGBLinear"/></term>
		///			<description>for floating point formats</description>
		///		</item>
		///		<item>
		///			<term><see cref="SDL_Colorspace.Hdr10"/></term>
		///			<description>for 10-bit formats</description>
		///		</item>
		///		<item>
		///			<term><see cref="SDL_Colorspace.SRGB"/></term>
		///			<description>for other RGB surfaces</description>
		///		</item>
		///		<item>
		///			<term><see cref="SDL_Colorspace.BT709Full"/></term>
		///			<description>for YUV surfaces</description>
		///		</item>
		/// </list>
		/// </summary>
		public const string ColorspaceNumber = "SDL.surface.colorspace";

		/// <summary>
		/// For HDR10 and floating point surfaces, this defines the value of 100% diffuse white, with higher values being
		/// displayed in the High Dynamic Range headroom. This defaults to 203 for HDR10 surfaces and 1.0 for floating point
		/// surfaces.
		/// </summary>
		public const string SdrWhitePointFloat = "SDL.surface.SDR_white_point";

		/// <summary>
		/// For HDR10 and floating point surfaces, this defines the maximum dynamic range used by the content, in terms of
		/// the SDR white point. This defaults to 0.0, which disables tone mapping.
		/// </summary>
		public const string HdrHeadroomFloat = "SDL.surface.HDR_headroom";

		/// <summary>
		/// The tone mapping operator used when compressing from a surface with high dynamic range to another with lower
		/// dynamic range. Currently this supports "chrome", which uses the same tone mapping that Chrome uses for HDR
		/// content, the form "*=N", where N is a floating point scale factor applied in linear space, and "none", which
		/// disables tone mapping. This defaults to "chrome".
		/// </summary>
		public const string TonemapOperatorString = "SDL.surface.tonemap";
	}
}