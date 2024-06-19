using System.Runtime.InteropServices;

namespace SDL_cs;

/// <summary>
/// Vertex structure.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_Vertex">here</see> for more details.
/// </remarks>
[StructLayout(LayoutKind.Sequential)]
public struct SDL_Vertex
{
	/// <summary>
	/// Vertex position, in <see cref="SDL_Renderer"/> coordinates.
	/// </summary>
	public SDL_FPoint Position;

	/// <summary>
	/// Vertex color.
	/// </summary>
	public SDL_FColor Color;

	/// <summary>
	/// Normalized texture coordinates, if needed.
	/// </summary>
	public SDL_FPoint TexCoord;
}