using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_blendmode.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_blendmode.h.
public static unsafe partial class SDL
{
	/// <summary>
	/// Compose a custom blend mode for renderers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ComposeCustomBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="srcColorFactor">The <see cref="SDL_BlendFactor"/> applied to the red, green, and blue components of the source pixels.</param>
	/// <param name="dstColorFactor">The <see cref="SDL_BlendFactor"/> applied to the red, green, and blue components of the destination pixels.</param>
	/// <param name="colorOperation">The <see cref="SDL_BlendOperation"/> used to combine the red, green, and blue components of the source and destination pixels.</param>
	/// <param name="srcAlphaFactor">The <see cref="SDL_BlendFactor"/> applied to alpha component of the source pixels.</param>
	/// <param name="dstAlphaFactor">The <see cref="SDL_BlendFactor"/> applied to the alpha component of the destination pixels.</param>
	/// <param name="alphaOperation">The <see cref="SDL_BlendOperation"/> used to combine the alpha component of the source and destination pixels.</param>
	/// <returns>An <see cref="SDL_BlendMode"/> that represents the chosen factors and operations.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ComposeCustomBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_BlendMode ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation);
}