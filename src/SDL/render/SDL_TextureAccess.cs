namespace SDL3;

/// <summary>
/// The access pattern allowed for a texture.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_TextureAccess">documentation</see> for more details.
/// </remarks>
public enum SDL_TextureAccess
{
	/// <summary>
	/// Changes rarely, not lockable.
	/// </summary>
	Static,

	/// <summary>
	/// Changes frequently, lockable.
	/// </summary>
	Streaming,

	/// <summary>
	/// Texture can be used as a render target.
	/// </summary>
	Target
}