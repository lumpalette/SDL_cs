using System.Runtime.InteropServices;
using System.Text;

namespace SDL_cs;

// SDL_surface.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_surface.h.
unsafe partial class SDL
{
	/// <summary>
	/// Evaluates to true if the surface needs to be locked before access.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_MUSTLOCK">here</see>
	/// </remarks>
	/// <param name="surface"> (Ref) The <see cref="SDL_Surface"/> structure to evaluate. </param>
	/// <returns> True if <paramref name="surface"/> needs to be locked, otherwise false. </returns>
	[Macro]
	public static bool MustLock(SDL_Surface* surface)
	{
		return (surface->Flags & SDL_SurfaceFlags.RleAccel) != 0;
	}

	/// <summary>
	/// Allocate a new RGB surface with a specific pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSurface">here</see> for more details.
	/// </remarks>
	/// <param name="width"> The width of the surface. </param>
	/// <param name="height"> The height of the surface. </param>
	/// <param name="format"> The <see cref="SDL_PixelFormatEnum"/> for the new surface's pixel format. </param>
	/// <returns> The new <see cref="SDL_Surface"/> structure that is created or null if it fails; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Surface* CreateSurface(int width, int height, SDL_PixelFormatEnum format) // CHECK:overload
	{
		return _PInvoke(width, height, format);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Surface* _PInvoke(int width, int height, SDL_PixelFormatEnum format);
	}

	/// <summary>
	/// Allocate a new RGB surface with a specific pixel format and existing pixel data.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSurfaceFrom">here</see> for more details.
	/// </remarks>
	/// <param name="pixels"> The pixel data, represented as unsigned 32-bit integer array. </param>
	/// <param name="width"> The width of the surface. </param>
	/// <param name="height"> The height of the surface. </param>
	/// <param name="pitch"> The number of bytes between each row, including padding </param>
	/// <param name="format"> The pixel format value for the new surface's pixel format. </param>
	/// <returns> The new <see cref="SDL_Surface"/> structure that is created or null if it fails; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Surface* CreateSurface(uint[] pixels, int width, int height, int pitch, SDL_PixelFormatEnum format) // CHECK:overload
	{
		fixed (uint* p = pixels)
		{
			// i'm not sure if the garbage collector messes up the 'pixels' managed array, because the documentation for
			// this function says that no copy of the pixel data is made. if the managed array gets destroyed from memory
			// by the gc, then it would also affect the C side, right? help
			return _PInvoke(p, width, height, pitch, format);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_CreateSurfaceFrom", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Surface* _PInvoke(uint* pixels, int width, int height, int pitch, SDL_PixelFormatEnum format);
	}

	/// <summary>
	/// Free an RGB surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_DestroySurface">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to free. It is safe to this be null. </param>
	public static void DestroySurface(SDL_Surface* surface)
	{
		if (surface is null)
		{
			return;
		}
		_PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroySurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_Surface* surface);
	}

	/// <summary>
	/// Get the properties associated with a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceProperties">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to query. </param>
	/// <returns> A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetSurfaceProperties(SDL_Surface* surface)
	{
		return _PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PropertiesId _PInvoke(SDL_Surface* surface);
	}

	/// <summary>
	/// Set the colorspace used by a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceColorspace">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to update. </param>
	/// <param name="colorspace"> An <see cref="SDL_Colorspace"/> value describing the surface colorspace. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace colorspace)
	{
		return _PInvoke(surface, colorspace);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorspace", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, SDL_Colorspace colorspace);
	}

	/// <summary>
	/// Get the colorspace used by a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorspace">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to query. </param>
	/// <param name="colorspace"> Returns the <see cref="SDL_Colorspace"/> value describing the surface colorspace. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceColorspace(SDL_Surface* surface, out SDL_Colorspace colorspace)
	{
		fixed (SDL_Colorspace* c = &colorspace)
		{
			return _PInvoke(surface, c);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorspace", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, SDL_Colorspace* colorspace);
	}

	/// <summary>
	/// Set the palette used by a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfacePalette">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to update. </param>
	/// <param name="palette"> The <see cref="SDL_Palette"/> structure to use. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette)
	{
		return _PInvoke(surface, palette);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfacePalette", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, SDL_Palette* palette);
	}

	/// <summary>
	/// Set up a surface for directly accessing the pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_LockSurface">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to be locked. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int LockSurface(SDL_Surface* surface)
	{
		return _PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_LockSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface);
	}

	/// <summary>
	/// Release a surface after directly accessing the pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockSurface">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to be unlocked. </param>
	public static void UnlockSurface(SDL_Surface* surface)
	{
		_PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_UnlockSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_Surface* surface);
	}

	// i'll rather die than having to implement IO shit, so i'll just skip the IO stream functions LOL
	// FIXME: implement SDL_LoadBMP_IO()

	/// <summary>
	/// Load a BMP image from a file.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_LoadBMP">here</see> for more details.
	/// </remarks>
	/// <param name="file"> The BMP file to load. </param>
	/// <returns> A pointer to a new <see cref="SDL_Surface"/> structure or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Surface* LoadBMP(string file)
	{
		fixed (byte* f = Encoding.UTF8.GetBytes(file))
		{
			return _PInvoke(f);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_LoadBMP", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Surface* _PInvoke(byte* file);
	}

	// FIXME: implement SDL_SaveBMP_IO()

	/// <summary>
	/// Save a surface to a file.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SaveBMP">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure containing the image to be saved. </param>
	/// <param name="file"> A file to save to. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SaveBMP(SDL_Surface* surface, string file)
	{
		fixed (byte* f = Encoding.UTF8.GetBytes(file))
		{
			return _PInvoke(surface, f);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SaveBMP", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, byte* file);
	}

	/// <summary>
	/// Set the RLE acceleration hint for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceRLE">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to optimize. </param>
	/// <param name="enable"> True to enable RLE acceleration, otherwise false. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceRLE(SDL_Surface* surface, bool enable)
	{
		return _PInvoke(surface, enable ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceRLE", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, int flag);
	}

	/// <summary>
	/// Returns whether the surface is RLE enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasRLE">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to query. </param>
	/// <returns> True if the surface has RLE enabled, false otherwise. </returns>
	public static bool SurfaceHasRLE(SDL_Surface* surface)
	{
		return _PInvoke(surface) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_SurfaceHasRLE", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface);
	}

	/// <summary>
	/// Set the color key (transparent pixel) in a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasRLE">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to update. </param>
	/// <param name="enable"> True to enable color key, false to disable color key. </param>
	/// <param name="key"> The transparent pixel. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceColorKey(SDL_Surface* surface, bool enable, uint key)
	{
		return _PInvoke(surface, enable ? 1 : 0, key);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorKey", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, int enable, uint key);
	}

	/// <summary>
	/// Returns whether the surface has a color key.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasColorKey">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to query. </param>
	/// <returns> True if the surface has a color key, otherwise false. </returns>
	public static bool SurfaceHasColorKey(SDL_Surface* surface)
	{
		return _PInvoke(surface) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_SurfaceHasColorKey", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface);
	}

	/// <summary>
	/// Get the color key (transparent pixel) for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorKey">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to query. </param>
	/// <param name="key"> Returns the transparent pixel. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceColorKey(SDL_Surface* surface, out uint key)
	{
		fixed (uint* k = &key)
		{
			return _PInvoke(surface, k);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorKey", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, uint* key);
	}

	/// <summary>
	/// Set an additional color value multiplied into blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceColorMod">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to update. </param>
	/// <param name="r"> The red color value multiplied into blit operations. </param>
	/// <param name="g"> The green color value multiplied into blit operations. </param>
	/// <param name="b"> The blue color value multiplied into blit operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceColorMod(SDL_Surface* surface, byte r, byte g, byte b)
	{
		return _PInvoke(surface, r, g, b);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, byte r, byte g, byte b);
	}

	/// <summary>
	/// Get the additional color value multiplied into blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorMod">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to query. </param>
	/// <param name="r"> Returns the current red color value. </param>
	/// <param name="g"> Returns the current green color value. </param>
	/// <param name="b"> Returns the the current blue color value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceColorMod(SDL_Surface* surface, out byte r, out byte g, out byte b)
	{
		fixed (byte* rr = &r, gg = &g, bb = &b)
		{
			return _PInvoke(surface, rr, gg, bb);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, byte* r, byte* g, byte* b);
	}

	/// <summary>
	/// Set an additional alpha value used in blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceAlphaMod">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to update. </param>
	/// <param name="alpha"> The alpha value multiplied into blit operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceAlphaMod(SDL_Surface* surface, byte alpha)
	{
		return _PInvoke(surface, alpha);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceAlphaMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, byte alpha);
	}

	/// <summary>
	/// Get the additional alpha value used in blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceAlphaMod">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to query. </param>
	/// <param name="alpha"> Returns the current alpha value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceAlphaMod(SDL_Surface* surface, out byte alpha)
	{
		fixed (byte* a = &alpha)
		{
			return _PInvoke(surface, a);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceAlphaMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, byte* alpha);
	}

	/// <summary>
	/// Set the blend mode used for blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceBlendMode">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to update. </param>
	/// <param name="blendMode"> The <see cref="SDL_BlendMode"/> to use for blit blending. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode blendMode)
	{
		return _PInvoke(surface, blendMode);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceBlendMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, SDL_BlendMode blendMode);
	}

	/// <summary>
	/// Get the blend mode used for blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceBlendMode">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to query. </param>
	/// <param name="blendMode"> Returns the current <see cref="SDL_BlendMode"/>. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceBlendMode(SDL_Surface* surface, out SDL_BlendMode blendMode)
	{
		fixed (SDL_BlendMode* b = &blendMode)
		{
			return _PInvoke(surface, b);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceBlendMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, SDL_BlendMode* blendMode);
	}

	/// <summary>
	/// Set the clipping rectangle for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceClipRect">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure to be clipped. </param>
	/// <param name="rect"> The <see cref="SDL_Rect"/> structure representing the clipping rectangle, or null to disable clipping. </param>
	/// <returns> True if the rectangle intersects the surface, otherwise false and blits will be completely clipped. </returns>
	public static bool SetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect)
	{
		return _PInvoke(surface, rect) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceClipRect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, SDL_Rect* rect);
	}

	/// <summary>
	/// Get the clipping rectangle for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceClipRect">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure representing the surface to be clipped. </param>
	/// <param name="rect"> Returns An <see cref="SDL_Rect"/> structure representing the clipping rectangle for the surface. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceClipRect(SDL_Surface* surface, out SDL_Rect rect)
	{
		fixed (SDL_Rect* r = &rect)
		{
			return _PInvoke(surface, r);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceClipRect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, SDL_Rect* rect);
	}

	/// <summary>
	/// Flip a surface vertically or horizontally.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_FlipSurface">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The surface to flip. </param>
	/// <param name="flip"> The direction to flip. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int FlipSurface(SDL_Surface* surface, SDL_FlipMode flip)
	{
		return _PInvoke(surface, flip);

		[DllImport(LibraryName, EntryPoint = "SDL_FlipSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, SDL_FlipMode flip);
	}

	/// <summary>
	/// Creates a new surface identical to the existing surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_DuplicateSurface">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The surface to duplicate. </param>
	/// <returns> A copy of the surface, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Surface* DuplicateSurface(SDL_Surface* surface)
	{
		return _PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_DuplicateSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Surface* _PInvoke(SDL_Surface* surface);
	}

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurface">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The existing <see cref="SDL_Surface"/> structure to convert. </param>
	/// <param name="format"> The <see cref="SDL_PixelFormat"/> structure that the new surface is optimized for. </param>
	/// <returns> The new <see cref="SDL_Surface"/> structure that is created or null if it fails; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Surface* ConvertSurfaceFormat(SDL_Surface* surface, SDL_PixelFormat* format) // CHECK:overload
	{
		return _PInvoke(surface, format);

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Surface* _PInvoke(SDL_Surface* surface, SDL_PixelFormat* format);
	}

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurfaceFormat">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The existing <see cref="SDL_Surface"/> structure to convert. </param>
	/// <param name="format"> The new pixel format. </param>
	/// <returns> The new <see cref="SDL_Surface"/> structure that is created or null if it fails; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Surface* ConvertSurfaceFormat(SDL_Surface* surface, SDL_PixelFormatEnum format) // CHECK:overload
	{
		// i think ConvertSurface and ConvertSurfaceFormat were meant to be overloadings, but since C doesn't have
		// function overloading, they just created two functions instead. also, this function name is more accurate
		// (for both cases) to what the function does haha.
		return _PInvoke(surface, format);

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertSurfaceFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Surface* _PInvoke(SDL_Surface* surface, SDL_PixelFormatEnum format);
	}

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format and colorspace.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurfaceFormatAndColorspace">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The existing <see cref="SDL_Surface"/> structure to convert. </param>
	/// <param name="format"> The new pixel format. </param>
	/// <param name="colorspace"> The new colorspace. </param>
	/// <param name="props"> An <see cref="SDL_PropertiesId"/> with additional color properties, or <see cref="SDL_PropertiesId.Invalid"/>. </param>
	/// <returns> The new <see cref="SDL_Surface"/> structure that is created or null if it fails; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Surface* ConvertSurfaceFormat(SDL_Surface* surface, SDL_PixelFormatEnum format, SDL_Colorspace colorspace, SDL_PropertiesId props) // CHECK:overload
	{
		return _PInvoke(surface, format, colorspace, props);

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertSurfaceFormatAndColorspace", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Surface* _PInvoke(SDL_Surface* surface, SDL_PixelFormatEnum format, SDL_Colorspace colorspace, SDL_PropertiesId props);
	}

	/// <summary>
	/// Copy a block of pixels of one format to another format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertPixels">here</see> for more details.
	/// </remarks>
	/// <param name="width"> The width of the block to copy, in pixels. </param>
	/// <param name="height"> The height of the block to copy, in pixels. </param>
	/// <param name="srcFormat"> An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="src"/> pixels format. </param>
	/// <param name="src"> The source pixels, as an unsigned 32-bit integers array. </param>
	/// <param name="srcPitch"> The pitch of the source pixels, in bytes. </param>
	/// <param name="dstFormat"> An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="dst"/> pixels format. </param>
	/// <param name="dst"> Returns the new pixel data, as an unsigned 32-bit integer array. </param>
	/// <param name="srcPitch"> The pitch of the destination pixels, in bytes. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ConvertPixels(int width, int height, SDL_PixelFormatEnum srcFormat, uint[] src, int srcPitch, SDL_PixelFormatEnum dstFormat, out uint[] dst, int dstPitch)  // CHECK:overload
	{
		// somehow this shit works.
		dst = new uint[src.Length];
		fixed (uint* s = src, d = dst)
		{
			return _PInvoke(width, height, srcFormat, s, srcPitch, dstFormat, d, dstPitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertPixels", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(int width, int height, SDL_PixelFormatEnum srcFormat, uint* src, int srcPitch, SDL_PixelFormatEnum dstFormat, uint* dst, int dstPitch);
	}

	/// <summary>
	/// Copy a block of pixels of one format and colorspace to another format and colorspace.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertPixelsAndColorspace">here</see> for more details.
	/// </remarks>
	/// <param name="width"> The width of the block to copy, in pixels. </param>
	/// <param name="height"> The height of the block to copy, in pixels. </param>
	/// <param name="srcFormat"> An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="src"/> pixels format. </param>
	/// <param name="srcColorspace"> An <see cref="SDL_Colorspace"/> value describing the colorspace of the <paramref name="src"/> pixels. </param>
	/// <param name="srcProps"> An <see cref="SDL_PropertiesId"/> with additional source color properties, or <see cref="SDL_PropertiesId.Invalid"/>. </param>
	/// <param name="src"> The source pixels, as an unsigned 32-bit integers array. </param>
	/// <param name="srcPitch"> The pitch of the source pixels, in bytes. </param>
	/// <param name="dstFormat"> An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="dst"/> pixels format. </param>
	/// <param name="dstColorspace"> An <see cref="SDL_Colorspace"/> value describing the colorspace of the <paramref name="dst"/> pixels. </param>
	/// <param name="dstProps"> An <see cref="SDL_PropertiesId"/> with additional destination color properties, or <see cref="SDL_PropertiesId.Invalid"/>. </param>
	/// <param name="dst"> Returns the new pixel data, as an unsigned 32-bit integer array. </param>
	/// <param name="srcPitch"> The pitch of the destination pixels, in bytes. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ConvertPixels(int width, int height, SDL_PixelFormatEnum srcFormat, SDL_Colorspace srcColorspace, SDL_PropertiesId srcProps, uint[] src, int srcPitch, SDL_PixelFormatEnum dstFormat, SDL_Colorspace dstColorspace, SDL_PropertiesId dstProps, out uint[] dst, int dstPitch) // CHECK:overload
	{
		dst = new uint[src.Length];
		fixed (uint* s = src, d = dst)
		{
			return _PInvoke(width, height, srcFormat, srcColorspace, srcProps, s, srcPitch, dstFormat, dstColorspace, dstProps, d, dstPitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertPixelsAndColorspace", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(int width, int height, SDL_PixelFormatEnum srcFormat, SDL_Colorspace srcColorspace, SDL_PropertiesId srcProps, uint* src, int srcPitch, SDL_PixelFormatEnum dstFormat, SDL_Colorspace dstColorspace, SDL_PropertiesId dstProps, uint* dst, int dstPitch); // wtf with this function.
	}

	/// <summary>
	/// Premultiply the alpha on a block of pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_PremultiplyAlpha">here</see> for more details.
	/// </remarks>
	/// <param name="width"> The width of the block to convert, in pixels. </param>
	/// <param name="height"> The height of the block to convert, in pixels. </param>
	/// <param name="srcFormat"> An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="src"/> pixels format. </param>
	/// <param name="src"> The source pixels, as an unsigned 32-bit integers array. </param>
	/// <param name="srcPitch"> The pitch of the source pixels, in bytes. </param>
	/// <param name="srcFormat"> An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="dst"/> pixels format. </param>
	/// <param name="dst"> Returns the premultiplied pixel data, as an unsigned 32-bit integer array. </param>
	/// <param name="srcPitch"> The pitch of the destination pixels, in bytes. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int PremultiplyAlpha(int width, int height, SDL_PixelFormatEnum srcFormat, uint[] src, int srcPitch, SDL_PixelFormatEnum dstFormat, out uint[] dst, int dstPitch)
	{
		dst = new uint[src.Length];
		fixed (uint* s = src, d = dst)
		{
			return _PInvoke(width, height, srcFormat, s, srcPitch, dstFormat, d, dstPitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_PremultiplyAlpha", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(int width, int height, SDL_PixelFormatEnum srcFormat, uint* src, int srcPitch, SDL_PixelFormatEnum dstFormat, uint* dst, int dstPitch);
	}

	/// <summary>
	/// Perform a fast fill of a rectangle with a specific color.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_FillSurfaceRect">here</see> for more details.
	/// </remarks>
	/// <param name="dst"> The <see cref="SDL_Surface"/> structure that is the drawing target. </param>
	/// <param name="rect"> The <see cref="SDL_Rect"/> structure representing the rectangle to fill, or null to fill the entire surface. </param>
	/// <param name="color"> The color to fill with. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int FillSurfaceRect(SDL_Surface* dst, SDL_Rect* rect, uint color)
	{
		return _PInvoke(dst, rect, color);

		[DllImport(LibraryName, EntryPoint = "SDL_FillSurfaceRect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* dst, SDL_Rect* rect, uint color);
	}

	/// <summary>
	/// Perform a fast fill of a set of rectangles with a specific color.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_FillSurfaceRects">here</see> for more details.
	/// </remarks>
	/// <param name="dst"> The <see cref="SDL_Surface"/> structure that is the drawing target. </param>
	/// <param name="rects"> An array of <see cref="SDL_Rect"/>s representing the rectangles to fill. </param>
	/// <param name="color"> The color to fill with. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int FillSurfaceRects(SDL_Surface* dst, SDL_Rect[] rects, uint color)
	{
		fixed (SDL_Rect* r = rects)
		{
			return _PInvoke(dst, r, color);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_FillSurfaceRects", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* dst, SDL_Rect* rects, uint color);
	}

	/// <summary>
	/// Performs a fast blit from the source surface to the destination surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurface">here</see> for more details.
	/// </remarks>
	/// <param name="src"> The <see cref="SDL_Surface"/> structure to be copied from. </param>
	/// <param name="srcRect"> The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or null to copy the entire surface. </param>
	/// <param name="dst"> The <see cref="SDL_Surface"/> structure that is the blit target. </param>
	/// <param name="dstRect"> The <see cref="SDL_Rect"/> structure representing the x and y position in the destination surface. On input the width and height are ignored (taken from <paramref name="srcRect"/>), and on output this is filled in with the actual rectangle used after clipping. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int BlitSurface(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect)
	{
		return _PInvoke(src, srcRect, dst, dstRect);

		[DllImport(LibraryName, EntryPoint = "SDL_BlitSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect);
	}

	/// <summary>
	/// Perform low-level surface blitting only.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceUnchecked">here</see> for more details.
	/// </remarks>
	/// <param name="src"> The <see cref="SDL_Surface"/> structure to be copied from. </param>
	/// <param name="srcRect"> The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or null to copy the entire surface. </param>
	/// <param name="dst"> The <see cref="SDL_Surface"/> structure that is the blit target. </param>
	/// <param name="dstRect"> The <see cref="SDL_Rect"/> structure representing the x and y position in the destination surface. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int BlitSurfaceUnchecked(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect)
	{
		return _PInvoke(src, srcRect, dst, dstRect);

		[DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceUnchecked", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect);
	}

	/// <summary>
	/// Perform stretch blit between two surfaces of the same format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SoftStretch">here</see> for more details.
	/// </remarks>
	/// <param name="src"> The <see cref="SDL_Surface"/> structure to be copied from. </param>
	/// <param name="srcRect"> The <see cref="SDL_Rect"/> structure representing the rectangle to be copied. </param>
	/// <param name="dst"> The <see cref="SDL_Surface"/> structure that is the blit target. </param>
	/// <param name="dstRect"> The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface. </param>
	/// <param name="scaleMode"> Scale algorithm to be used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SoftStretch(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode)
	{
		return _PInvoke(src, srcRect, dst, dstRect, scaleMode);

		[DllImport(LibraryName, EntryPoint = "SDL_SoftStretch", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode);
	}

	/// <summary>
	/// Perform a scaled blit to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceScaled">here</see> for more details.
	/// </remarks>
	/// <param name="src"> The <see cref="SDL_Surface"/> structure to be copied from. </param>
	/// <param name="srcRect"> The <see cref="SDL_Rect"/> structure representing the rectangle to be copied. </param>
	/// <param name="dst"> The <see cref="SDL_Surface"/> structure that is the blit target. </param>
	/// <param name="dstRect"> The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, filled with the actual rectangle used after clipping. </param>
	/// <param name="scaleMode"> the <see cref="SDL_ScaleMode"/> to be used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int BlitSurfaceScaled(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode)
	{
		return _PInvoke(src, srcRect, dst, dstRect, scaleMode);

		[DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceScaled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode);
	}

	/// <summary>
	/// Perform low-level surface scaled blitting only.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceUncheckedScaled">here</see> for more details.
	/// </remarks>
	/// <param name="src"> The <see cref="SDL_Surface"/> structure to be copied from. </param>
	/// <param name="srcRect"> The <see cref="SDL_Rect"/> structure representing the rectangle to be copied. </param>
	/// <param name="dst"> The <see cref="SDL_Surface"/> structure that is the blit target. </param>
	/// <param name="dstRect"> The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface. </param>
	/// <param name="scaleMode"> Scale algorithm to be used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int BlitSurfaceUncheckedScaled(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode)
	{
		return _PInvoke(src, srcRect, dst, dstRect, scaleMode);

		[DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceUncheckedScaled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode);
	}

	/// <summary>
	/// Retrieves a single pixel from a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_ReadSurfacePixel">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The surface to read. </param>
	/// <param name="x"> The horizontal coordinate, 0 &lt;= x &lt; width. </param>
	/// <param name="y"> The vertical coordinate, 0 &lt;= y &lt; height. </param>
	/// <param name="r"> Returns the red channel, 0-255. </param>
	/// <param name="g"> Returns the green channel, 0-255. </param>
	/// <param name="b"> Returns the blue channel, 0-255. </param>
	/// <param name="a"> Returns the alpha channel, 0-255. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ReadSurfacePixel(SDL_Surface* surface, int x, int y, out byte r, out byte g, out byte b, out byte a)
	{
		fixed (byte* rr = &r, gg = &g, bb = &b, aa = &a)
		{
			return _PInvoke(surface, x, y, rr, gg, bb, aa);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_ReadSurfacePixel", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Surface* surface, int x, int y, byte* r, byte* g, byte* b, byte* a);
	}
}