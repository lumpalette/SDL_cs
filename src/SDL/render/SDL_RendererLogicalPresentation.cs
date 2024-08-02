namespace SDL3;

/// <summary>
/// How the logical size is mapped to the output.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RendererLogicalPresentation">documentation</see> for more details.
/// </remarks>
public enum SDL_RendererLogicalPresentation
{
	/// <summary>
	/// There is no logical size in effect.
	/// </summary>
	Disabled,

	/// <summary>
	/// The rendered content is stretched to the output resolution.
	/// </summary>
	Stretch,

	/// <summary>
	/// The rendered content is fit to the largest dimension and the other dimension is letterboxed with black bars.
	/// </summary>
	Letterbox,

	/// <summary>
	/// The rendered content is fit to the smallest dimension and the other dimension extends beyond the output bounds.
	/// </summary>
	Overscan,

	/// <summary>
	/// The rendered content is scaled up by integer multiples to fit the output resolution.
	/// </summary>
	IntegerScale
}