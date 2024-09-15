namespace SDL3;

/// <summary>
/// Description of where standard I/O should be directed when creating a process.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ProcessIO">documentation</see> for more details.
/// </remarks>
public enum SDL_ProcessIO
{
	/// <summary>
	/// The I/O stream is inherited from the application.
	/// </summary>
	StdioInherited,

	/// <summary>
	/// The I/O stream is ignored.
	/// </summary>
	StdioNull,

	/// <summary>
	/// The I/O stream is connected to a new SDL_IOStream that the application can read or write.
	/// </summary>
	StdioApp,

	/// <summary>
	/// The I/O stream is redirected to an existing <see cref="FIXME:SDL_IOStream"/>.
	/// </summary>
	StdioRedirect
}