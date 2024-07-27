namespace SDL_cs;

/// <summary>
/// The scaling mode.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ScaleMode">documentation</see> for more details.
/// </remarks>
public enum SDL_ScaleMode
{
	/// <summary>
	/// Nearest pixel sampling.
	/// </summary>
	Nearest,

	/// <summary>
	/// Linear filtering.
	/// </summary>
	Linear,

	/// <summary>
	/// Anisotropic filtering
	/// </summary>
	Best
}