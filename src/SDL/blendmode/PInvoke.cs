using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_blendmode.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_blendmode.h.
unsafe partial class SDL
{
	/// <summary>
	/// Compose a custom blend mode for renderers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ComposeCustomBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="srcColorFactor"> The <see cref="SDL_BlendFactor"/> applied to the red, green, and blue components of the source pixels. </param>
	/// <param name="dstColorFactor"> The <see cref="SDL_BlendFactor"/> applied to the red, green, and blue components of the destination pixels. </param>
	/// <param name="colorOperation"> The <see cref="SDL_BlendOperation"/> used to combine the red, green, and blue components of the source and destination pixels. </param>
	/// <param name="srcAlphaFactor"> The <see cref="SDL_BlendFactor"/> applied to alpha component of the source pixels. </param>
	/// <param name="dstAlphaFactor"> The <see cref="SDL_BlendFactor"/> applied to the alpha component of the destination pixels. </param>
	/// <param name="alphaOperation"> The <see cref="SDL_BlendOperation"/> used to combine the alpha component of the source and destination pixels. </param>
	/// <returns> An <see cref="SDL_BlendMode"/> that represents the chosen factors and operations. </returns>
	/// <seealso cref="SetRenderDrawBlendMode(SDL_Renderer*, SDL_BlendMode)"/>
	/// <seealso cref="GetRenderDrawBlendMode(SDL_Renderer*, out SDL_BlendMode)"/>
	/// <seealso cref="SetTextureBlendMode(SDL_Texture*, SDL_BlendMode)"/>
	/// <seealso cref="GetTextureBlendMode(SDL_Texture*, out SDL_BlendMode)"/>
	public static SDL_BlendMode ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation)
	{
		return SDL_ComposeCustomBlendMode(srcColorFactor, dstColorFactor, colorOperation, srcAlphaFactor, SDL_BlendFactor.DstAlpha, alphaOperation);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_BlendMode SDL_ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation);
	}
}