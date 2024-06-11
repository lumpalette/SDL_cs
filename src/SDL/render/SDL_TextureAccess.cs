namespace SDL_cs;

/// <summary>
/// The access pattern allowed for a texture.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_TextureAccess">here</see>.
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