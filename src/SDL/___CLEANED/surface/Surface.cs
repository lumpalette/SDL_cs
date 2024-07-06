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
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MUSTLOCK">here</see>
	/// </remarks>
	/// <param name="s">The <see cref="SDL_Surface"/> structure to evaluate.</param>
	/// <returns>True if <paramref name="s"/> needs to be locked, otherwise false.</returns>
	[Macro]
	public static bool MustLock(SDL_Surface* s)
	{
		return (s->Flags & SDL_SurfaceFlags.RleAccel) != 0;
	}

	/// <summary>
	/// Allocate a new RGB surface with a specific pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="width">The width of the surface.</param>
	/// <param name="height">The height of the surface.</param>
	/// <param name="format">The <see cref="SDL_PixelFormatEnum"/> for the new surface's pixel format.</param>
	/// <returns>The new <see cref="SDL_Surface"/> structure that is created or <see langword="null"/> if it fails; call <see cref="GetError"/> for more information.</returns>
	public static SDL_Surface* CreateSurface(int width, int height, SDL_PixelFormatEnum format)
	{
		return PInvoke.SDL_CreateSurface(width, height, format);
	}

	/// <summary>
	/// Allocate a new RGB surface with a specific pixel format and existing pixel data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSurfaceFrom">documentation</see> for more details.
	/// </remarks>
	/// <param name="pixels">A pointer to existing pixel data.</param>
	/// <param name="width">The width of the surface.</param>
	/// <param name="height">The height of the surface.</param>
	/// <param name="pitch">The number of bytes between each row, including padding.</param>
	/// <param name="format">The <see cref="SDL_PixelFormatEnum"/> for the new surface's pixel format.</param>
	/// <returns>The new <see cref="SDL_Surface"/> structure that is created or <see langword="null"/> if it fails; call <see cref="GetError"/> for more information.</returns>
	public static SDL_Surface* CreateSurface(void* pixels, int width, int height, int pitch, SDL_PixelFormatEnum format)
	{
		return PInvoke.SDL_CreateSurfaceFrom(pixels, width, height, pitch, format);
	}

	/// <summary>
	/// Free an RGB surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroySurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> to free.</param>
	public static void DestroySurface(SDL_Surface* surface)
	{
		PInvoke.SDL_DestroySurface(surface);
	}

	/// <summary>
	/// Get the properties associated with a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	public static SDL_PropertiesId GetSurfaceProperties(SDL_Surface* surface)
	{
		return PInvoke.SDL_GetSurfaceProperties(surface);
	}

	/// <summary>
	/// Set the colorspace used by a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceColorspace">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="colorspace">An <see cref="SDL_Colorspace"/> value describing the surface colorspace.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace colorspace)
	{
		return PInvoke.SDL_SetSurfaceColorspace(surface, colorspace);
	}

	/// <summary>
	/// Get the colorspace used by a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorspace">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="colorspace">An <see cref="SDL_Colorspace"/> value describing the surface colorspace.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GetSurfaceColorspace(SDL_Surface* surface, out SDL_Colorspace colorspace)
	{
		fixed (SDL_Colorspace* colorspacePtr = &colorspace)
		{
			return PInvoke.SDL_GetSurfaceColorspace(surface, colorspacePtr);
		}
	}

	/// <summary>
	/// Set the palette used by a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfacePalette">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="palette">The <see cref="SDL_Palette"/> structure to use.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette)
	{
		return PInvoke.SDL_SetSurfacePalette(surface, palette);
	}

	/// <summary>
	/// Set up a surface for directly accessing the pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to be locked.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int LockSurface(SDL_Surface* surface)
	{
		return PInvoke.SDL_LockSurface(surface);
	}

	/// <summary>
	/// Release a surface after directly accessing the pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to be unlocked.</param>
	public static void UnlockSurface(SDL_Surface* surface)
	{
		PInvoke.SDL_UnlockSurface(surface);
	}

	// FIXME: implement SDL_LoadBMP_IO()

	/// <summary>
	/// Load a BMP image from a file.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LoadBMP">documentation</see> for more details.
	/// </remarks>
	/// <param name="file">The BMP file to load.</param>
	/// <returns>A pointer to a new <see cref="SDL_Surface"/> structure or <see langword="null"/> if there was an error; call <see cref="GetError"/> for more information.</returns>
	public static SDL_Surface* LoadBMP(string file)
	{
		fixed (byte* filePtr = Encoding.UTF8.GetBytes(file))
		{
			return PInvoke.SDL_LoadBMP(filePtr);
		}
	}

	// FIXME: implement SDL_SaveBMP_IO()

	/// <summary>
	/// Save a surface to a file.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SaveBMP">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure containing the image to be saved.</param>
	/// <param name="file">A file to save to.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SaveBMP(SDL_Surface* surface, string file)
	{
		fixed (byte* filePtr = Encoding.UTF8.GetBytes(file))
		{
			return PInvoke.SDL_SaveBMP(surface, filePtr);
		}
	}

	/// <summary>
	/// Set the RLE acceleration hint for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceRLE">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to optimize.</param>
	/// <param name="enable">True to enable RLE acceleration, false to disable.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetSurfaceRLE(SDL_Surface* surface, bool enable)
	{
		return PInvoke.SDL_SetSurfaceRLE(surface, enable ? 1 : 0);
	}

	/// <summary>
	/// Returns whether the surface is RLE enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasRLE">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <returns>True if the surface has RLE enabled, false otherwise.</returns>
	public static bool SurfaceHasRLE(SDL_Surface* surface)
	{
		return PInvoke.SDL_SurfaceHasRLE(surface) == 1;
	}

	/// <summary>
	/// Set the color key (transparent pixel) in a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasRLE">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="enable">True to enable color key, false to disable color key.</param>
	/// <param name="key">The transparent pixel.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetSurfaceColorKey(SDL_Surface* surface, bool enable, uint key)
	{
		return PInvoke.SDL_SetSurfaceColorKey(surface, enable ? 1 : 0, key);
	}

	/// <summary>
	/// Returns whether the surface has a color key.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasColorKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <returns>True if the surface has a color key, false otherwise.</returns>
	public static bool SurfaceHasColorKey(SDL_Surface* surface)
	{
		return PInvoke.SDL_SurfaceHasColorKey(surface) == 1;
	}

	/// <summary>
	/// Get the color key (transparent pixel) for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="key">The transparent pixel.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GetSurfaceColorKey(SDL_Surface* surface, out uint key)
	{
		fixed (uint* keyPtr = &key)
		{
			return PInvoke.SDL_GetSurfaceColorKey(surface, keyPtr);
		}
	}

	/// <summary>
	/// Set an additional color value multiplied into blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceColorMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="r">The red color value multiplied into blit operations.</param>
	/// <param name="g">The green color value multiplied into blit operations.</param>
	/// <param name="b">The blue color value multiplied into blit operations.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetSurfaceColorMod(SDL_Surface* surface, byte r, byte g, byte b)
	{
		return PInvoke.SDL_SetSurfaceColorMod(surface, r, g, b);
	}

	/// <summary>
	/// Get the additional color value multiplied into blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="r">The current red color value.</param>
	/// <param name="g">The current green color value.</param>
	/// <param name="b">The current blue color value.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GetSurfaceColorMod(SDL_Surface* surface, out byte r, out byte g, out byte b)
	{
		fixed (byte* rPtr = &r, gPtr = &g, bPtr = &b)
		{
			return PInvoke.SDL_GetSurfaceColorMod(surface, rPtr, gPtr, bPtr);
		}
	}

	/// <summary>
	/// Set an additional alpha value used in blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceAlphaMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="alpha">The alpha value multiplied into blit operations.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetSurfaceAlphaMod(SDL_Surface* surface, byte alpha)
	{
		return PInvoke.SDL_SetSurfaceAlphaMod(surface, alpha);
	}

	/// <summary>
	/// Get the additional alpha value used in blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceAlphaMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="alpha">The current alpha value.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GetSurfaceAlphaMod(SDL_Surface* surface, out byte alpha)
	{
		fixed (byte* alphaPtr = &alpha)
		{
			return PInvoke.SDL_GetSurfaceAlphaMod(surface, alphaPtr);
		}
	}

	/// <summary>
	/// Set the blend mode used for blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="blendMode">The <see cref="SDL_BlendMode"/> to use for blit blending.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode blendMode)
	{
		return PInvoke.SDL_SetSurfaceBlendMode(surface, blendMode);
	}

	/// <summary>
	/// Get the blend mode used for blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="blendMode">The current <see cref="SDL_BlendMode"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GetSurfaceBlendMode(SDL_Surface* surface, out SDL_BlendMode blendMode)
	{
		fixed (SDL_BlendMode* blendModePtr = &blendMode)
		{
			return PInvoke.SDL_GetSurfaceBlendMode(surface, blendModePtr);
		}
	}

	/// <summary>
	/// Set the clipping rectangle for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceClipRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to be clipped.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure representing the clipping rectangle, or <see langword="null"/> to disable clipping.</param>
	/// <returns>True if the rectangle intersects the surface, otherwise false and blits will be completely clipped.</returns>
	public static bool SetSurfaceClipRect(SDL_Surface* surface, ref SDL_Rect rect)
	{
		fixed (SDL_Rect* rectPtr = &rect)
		{
			return PInvoke.SDL_SetSurfaceClipRect(surface, rectPtr) == 1;
		}
	}

	/// <summary>
	/// Set the clipping rectangle for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceClipRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to be clipped.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure representing the clipping rectangle, or <see langword="null"/> to disable clipping.</param>
	/// <returns>True if the rectangle intersects the surface, otherwise false and blits will be completely clipped.</returns>
	public static bool SetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect)
	{
		return PInvoke.SDL_SetSurfaceClipRect(surface, rect) == 1;
	}

	/// <summary>
	/// Get the clipping rectangle for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceClipRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure representing the surface to be clipped.</param>
	/// <param name="rect">An <see cref="SDL_Rect"/> structure representing the clipping rectangle for the surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GetSurfaceClipRect(SDL_Surface* surface, out SDL_Rect rect)
	{
		fixed (SDL_Rect* rectPtr = &rect)
		{
			return PInvoke.SDL_GetSurfaceClipRect(surface, rectPtr);
		}
	}

	/// <summary>
	/// Flip a surface vertically or horizontally.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlipSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to flip.</param>
	/// <param name="flip">The direction to flip.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int FlipSurface(SDL_Surface* surface, SDL_FlipMode flip)
	{
		return PInvoke.SDL_FlipSurface(surface, flip);
	}

	/// <summary>
	/// Creates a new surface identical to the existing surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DuplicateSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to duplicate.</param>
	/// <returns>A copy of the surface, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	public static SDL_Surface* DuplicateSurface(SDL_Surface* surface)
	{
		return PInvoke.SDL_DuplicateSurface(surface);
	}

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The existing <see cref="SDL_Surface"/> structure to convert.</param>
	/// <param name="format">The <see cref="SDL_PixelFormat"/> structure that the new surface is optimized for.</param>
	/// <returns>The new <see cref="SDL_Surface"/> structure that is created or <see langword="null"/> if it fails; call <see cref="GetError"/> for more information.</returns>
	public static SDL_Surface* ConvertSurface(SDL_Surface* surface, SDL_PixelFormat* format)
	{
		return PInvoke.SDL_ConvertSurface(surface, format);
	}

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurfaceFormat">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The existing <see cref="SDL_Surface"/> structure to convert.</param>
	/// <param name="format">The new pixel format.</param>
	/// <returns>The new <see cref="SDL_Surface"/> structure that is created or <see langword="null"/> if it fails; call <see cref="GetError"/> for more information.</returns>
	public static SDL_Surface* ConvertSurface(SDL_Surface* surface, SDL_PixelFormatEnum format)
	{
		return PInvoke.SDL_ConvertSurfaceFormat(surface, format);
	}

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format and colorspace.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurfaceFormatAndColorspace">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The existing <see cref="SDL_Surface"/> structure to convert.</param>
	/// <param name="format">The new pixel format.</param>
	/// <param name="colorspace">The new colorspace.</param>
	/// <param name="props">An <see cref="SDL_PropertiesId"/> with additional color properties, or <see cref="SDL_PropertiesId.Invalid"/>.</param>
	/// <returns>The new <see cref="SDL_Surface"/> structure that is created or <see langword="null"/> if it fails; call <see cref="GetError"/> for more information.</returns>
	public static SDL_Surface* ConvertSurface(SDL_Surface* surface, SDL_PixelFormatEnum format, SDL_Colorspace colorspace, SDL_PropertiesId props)
	{
		return PInvoke.SDL_ConvertSurfaceFormatAndColorspace(surface, format, colorspace, props);
	}

	/// <summary>
	/// Copy a block of pixels of one format to another format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertPixels">documentation</see> for more details.
	/// </remarks>
	/// <param name="width">The width of the block to copy, in pixels.</param>
	/// <param name="height">The height of the block to copy, in pixels.</param>
	/// <param name="srcFormat">An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="src"/> pixels format.</param>
	/// <param name="src">A pointer to the source pixels.</param>
	/// <param name="srcPitch">The pitch of the source pixels, in bytes.</param>
	/// <param name="dstFormat">An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="dst"/> pixels format.</param>
	/// <param name="dst">A pointer to be filled in with new pixel data.</param>
	/// <param name="srcPitch">The pitch of the destination pixels, in bytes.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ConvertPixels(int width, int height, SDL_PixelFormatEnum srcFormat, void* src, int srcPitch, SDL_PixelFormatEnum dstFormat, void* dst, int dstPitch)
	{
		return PInvoke.SDL_ConvertPixels(width, height, srcFormat, src, srcPitch, dstFormat, dst, dstPitch);
	}

	/// <summary>
	/// Copy a block of pixels of one format and colorspace to another format and colorspace.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertPixelsAndColorspace">documentation</see> for more details.
	/// </remarks>
	/// <param name="width">The width of the block to copy, in pixels.</param>
	/// <param name="height">The height of the block to copy, in pixels.</param>
	/// <param name="srcFormat">An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="src"/> pixels format.</param>
	/// <param name="srcColorspace">An <see cref="SDL_Colorspace"/> value describing the colorspace of the <paramref name="src"/> pixels.</param>
	/// <param name="srcProps">An <see cref="SDL_PropertiesId"/> with additional source color properties, or <see cref="SDL_PropertiesId.Invalid"/>.</param>
	/// <param name="src">A pointer to the source pixels.</param>
	/// <param name="srcPitch">The pitch of the source pixels, in bytes.</param>
	/// <param name="dstFormat">An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="dst"/> pixels format.</param>
	/// <param name="dstColorspace">An <see cref="SDL_Colorspace"/> value describing the colorspace of the <paramref name="dst"/> pixels.</param>
	/// <param name="dstProps">An <see cref="SDL_PropertiesId"/> with additional destination color properties, or <see cref="SDL_PropertiesId.Invalid"/>.</param>
	/// <param name="dst">A pointer to be filled in with new pixel data.</param>
	/// <param name="srcPitch">The pitch of the destination pixels, in bytes.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ConvertPixels(int width, int height, SDL_PixelFormatEnum srcFormat, SDL_Colorspace srcColorspace, SDL_PropertiesId srcProps, void* src, int srcPitch, SDL_PixelFormatEnum dstFormat, SDL_Colorspace dstColorspace, SDL_PropertiesId dstProps, void* dst, int dstPitch)
	{
		return PInvoke.SDL_ConvertPixelsAndColorspace(width, height, srcFormat, srcColorspace, srcProps, src, srcPitch, dstFormat, dstColorspace, dstProps, dst, dstPitch);
	}

	/// <summary>
	/// Premultiply the alpha on a block of pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PremultiplyAlpha">documentation</see> for more details.
	/// </remarks>
	/// <param name="width">The width of the block to convert, in pixels.</param>
	/// <param name="height">The height of the block to convert, in pixels.</param>
	/// <param name="srcFormat">An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="src"/> pixels format.</param>
	/// <param name="src">A pointer to the source pixels.</param>
	/// <param name="srcPitch">The pitch of the source pixels, in bytes.</param>
	/// <param name="dstFormat">An <see cref="SDL_PixelFormatEnum"/> value of the <paramref name="dst"/> pixels format.</param>
	/// <param name="dst">A pointer to be filled in with premultiplied pixel data.</param>
	/// <param name="dstPitch">The pitch of the destination pixels, in bytes.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int PremultiplyAlpha(int width, int height, SDL_PixelFormatEnum srcFormat, void* src, int srcPitch, SDL_PixelFormatEnum dstFormat, void* dst, int dstPitch)
	{
		return PInvoke.SDL_PremultiplyAlpha(width, height, srcFormat, src, srcPitch, dstFormat, dst, dstPitch);
	}

	/// <summary>
	/// Perform a fast fill of a rectangle with a specific color.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FillSurfaceRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the drawing target.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure representing the rectangle to fill, or <see langword="null"/> to fill the entire surface.</param>
	/// <param name="color">The color to fill with.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int FillSurfaceRect(SDL_Surface* dst, ref SDL_Rect rect, uint color)
	{
		fixed (SDL_Rect* rectPtr = &rect)
		{
			return PInvoke.SDL_FillSurfaceRect(dst, rectPtr, color);
		}
	}

	/// <summary>
	/// Perform a fast fill of a rectangle with a specific color.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FillSurfaceRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the drawing target.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure representing the rectangle to fill, or <see langword="null"/> to fill the entire surface.</param>
	/// <param name="color">The color to fill with.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int FillSurfaceRect(SDL_Surface* dst, SDL_Rect* rect, uint color)
	{
		return PInvoke.SDL_FillSurfaceRect(dst, rect, color);
	}

	/// <summary>
	/// Perform a fast fill of a set of rectangles with a specific color.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FillSurfaceRects">documentation</see> for more details.
	/// </remarks>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the drawing target.</param>
	/// <param name="rects">An array of <see cref="SDL_Rect"/>s representing the rectangles to fill.</param>
	/// <param name="color">The color to fill with.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int FillSurfaceRects(SDL_Surface* dst, SDL_Rect[] rects, uint color)
	{
		fixed (SDL_Rect* rectsPtr = rects)
		{
			return PInvoke.SDL_FillSurfaceRects(dst, rectsPtr, rects.Length, color);
		}
	}

	/// <summary>
	/// Performs a fast blit from the source surface to the destination surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the x and y position in the destination surface. On input the width and height are ignored (taken from <paramref name="srcRect"/>), and on output this is filled in with the actual rectangle used after clipping.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int BlitSurface(SDL_Surface* src, ref SDL_Rect srcRect, SDL_Surface* dst, ref SDL_Rect dstRect)
	{
		fixed (SDL_Rect* srcRectPtr = &srcRect, dstRectPtr = &dstRect)
		{
			return PInvoke.SDL_BlitSurface(src, srcRectPtr, dst, dstRectPtr);
		}
	}

	/// <summary>
	/// Performs a fast blit from the source surface to the destination surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the x and y position in the destination surface. On input the width and height are ignored (taken from <paramref name="srcRect"/>), and on output this is filled in with the actual rectangle used after clipping.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int BlitSurface(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect)
	{
		return PInvoke.SDL_BlitSurface(src, srcRect, dst, dstRect);
	}

	/// <summary>
	/// Perform low-level surface blitting only.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceUnchecked">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the x and y position in the destination surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int BlitSurfaceUnchecked(SDL_Surface* src, ref SDL_Rect srcRect, SDL_Surface* dst, ref SDL_Rect dstRect)
	{
		fixed (SDL_Rect* srcRectPtr = &srcRect, dstRectPtr = &dstRect)
		{
			return PInvoke.SDL_BlitSurfaceUnchecked(src, srcRectPtr, dst, dstRectPtr);
		}
	}

	/// <summary>
	/// Perform low-level surface blitting only.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceUnchecked">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the x and y position in the destination surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int BlitSurfaceUnchecked(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect)
	{
		return PInvoke.SDL_BlitSurfaceUnchecked(src, srcRect, dst, dstRect);
	}

	/// <summary>
	/// Perform stretch blit between two surfaces of the same format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SoftStretch">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface.</param>
	/// <param name="scaleMode">Scale algorithm to be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SoftStretch(SDL_Surface* src, ref SDL_Rect srcRect, SDL_Surface* dst, ref SDL_Rect dstRect, SDL_ScaleMode scaleMode)
	{
		fixed (SDL_Rect* srcRectPtr = &srcRect, dstRectPtr = &dstRect)
		{
			return PInvoke.SDL_SoftStretch(src, srcRectPtr, dst, dstRectPtr, scaleMode);
		}
	}

	/// <summary>
	/// Perform stretch blit between two surfaces of the same format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SoftStretch">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface.</param>
	/// <param name="scaleMode">Scale algorithm to be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int SoftStretch(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode)
	{
		return PInvoke.SDL_SoftStretch(src, srcRect, dst, dstRect, scaleMode);
	}

	/// <summary>
	/// Perform a scaled blit to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceScaled">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, filled with the actual rectangle used after clipping.</param>
	/// <param name="scaleMode">The <see cref="SDL_ScaleMode"/> to be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int BlitSurfaceScaled(SDL_Surface* src, ref SDL_Rect srcRect, SDL_Surface* dst, ref SDL_Rect dstRect, SDL_ScaleMode scaleMode)
	{
		fixed (SDL_Rect* srcRectPtr = &srcRect, dstRectPtr = &dstRect)
		{
			return PInvoke.SDL_BlitSurfaceScaled(src, srcRectPtr, dst, dstRectPtr, scaleMode);
		}
	}

	/// <summary>
	/// Perform a scaled blit to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceScaled">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, filled with the actual rectangle used after clipping.</param>
	/// <param name="scaleMode">The <see cref="SDL_ScaleMode"/> to be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int BlitSurfaceScaled(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode)
	{
		return PInvoke.SDL_BlitSurfaceScaled(src, srcRect, dst, dstRect, scaleMode);
	}

	/// <summary>
	/// Perform low-level surface scaled blitting only.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceUncheckedScaled">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface.</param>
	/// <param name="scaleMode">Scale algorithm to be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int BlitSurfaceUncheckedScaled(SDL_Surface* src, ref SDL_Rect srcRect, SDL_Surface* dst, ref SDL_Rect dstRect, SDL_ScaleMode scaleMode)
	{
		fixed (SDL_Rect* srcRectPtr = &srcRect, dstRectPtr = &dstRect)
		{
			return PInvoke.SDL_BlitSurfaceUncheckedScaled(src, srcRectPtr, dst, dstRectPtr, scaleMode);
		}
	}

	/// <summary>
	/// Perform low-level surface scaled blitting only.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceUncheckedScaled">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface.</param>
	/// <param name="scaleMode">Scale algorithm to be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int BlitSurfaceUncheckedScaled(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode)
	{
		return PInvoke.SDL_BlitSurfaceUncheckedScaled(src, srcRect, dst, dstRect, scaleMode);
	}

	/// <summary>
	/// Retrieves a single pixel from a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ReadSurfacePixel">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to read.</param>
	/// <param name="x">The horizontal coordinate, 0 &lt;= x &lt; width.</param>
	/// <param name="y">The vertical coordinate, 0 &lt;= y &lt; height.</param>
	/// <param name="r">The red channel, 0-255.</param>
	/// <param name="g">The green channel, 0-255.</param>
	/// <param name="b">The blue channel, 0-255.</param>
	/// <param name="a">The alpha channel, 0-255.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ReadSurfacePixel(SDL_Surface* surface, int x, int y, out byte r, out byte g, out byte b, out byte a)
	{
		fixed (byte* rPtr = &r, gPtr = &g, bPtr = &b, aPtr = &a)
		{
			return PInvoke.SDL_ReadSurfacePixel(surface, x, y, rPtr, gPtr, bPtr, aPtr);
		}
	}

	/// <summary>
	/// Retrieves a single pixel from a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ReadSurfacePixel">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to read.</param>
	/// <param name="x">The horizontal coordinate, 0 &lt;= x &lt; width.</param>
	/// <param name="y">The vertical coordinate, 0 &lt;= y &lt; height.</param>
	/// <param name="color">The pixel color.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int ReadSurfacePixel(SDL_Surface* surface, int x, int y, out SDL_Color color)
	{
		byte r;
		byte g;
		byte b;
		byte a;
		int result = PInvoke.SDL_ReadSurfacePixel(surface, x, y, &r, &g, &b, &a);
		color = new(r, g, b, a);
		return result;
	}
}