using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_surface.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_surface.h.
public static unsafe partial class SDL
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
	public static bool MustLock(SDL_Surface* s) => (s->Flags & SDL_SurfaceFlags.LockNeeded) == SDL_SurfaceFlags.LockNeeded;

	/// <summary>
	/// Allocate a new surface with a specific pixel format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="width">The width of the surface.</param>
	/// <param name="height">The height of the surface.</param>
	/// <param name="format">The <see cref="SDL_PixelFormat"/> for the new surface's pixel format.</param>
	/// <returns>The new <see cref="SDL_Surface"/> structure that is created or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface* CreateSurface(int width, int height, SDL_PixelFormat format);

	/// <summary>
	/// Allocate a new RGB surface with a specific pixel format and existing pixel data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSurfaceFrom">documentation</see> for more details.
	/// </remarks>
	/// <param name="width">The width of the surface.</param>
	/// <param name="height">The height of the surface.</param>
	/// <param name="format">The <see cref="SDL_PixelFormat"/> for the new surface's pixel format.</param>
	/// <param name="pixels">A pointer to existing pixel data.</param>
	/// <param name="pitch">The number of bytes between each row, including padding.</param>
	/// <returns>The new <see cref="SDL_Surface"/> structure that is created or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateSurfaceFrom")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface* CreateSurfaceFrom(int width, int height, SDL_PixelFormat format, nint pixels, int pitch);

	/// <summary>
	/// Free a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroySurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> to free.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroySurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroySurface(SDL_Surface* surface);

	/// <summary>
	/// Get the properties associated with a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetSurfaceProperties(SDL_Surface* surface);

	/// <summary>
	/// Set the colorspace used by a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceColorspace">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="colorspace">An <see cref="SDL_Colorspace"/> value describing the surface colorspace.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorspace")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetSurfaceColorspace(SDL_Surface* surface, SDL_Colorspace colorspace);

	/// <summary>
	/// Get the colorspace used by a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorspace">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="colorspace">A pointer filled in with an <see cref="SDL_Colorspace"/> value describing the surface colorspace.</param>
	/// <returns>The colorspace used by the surface, or <see cref="SDL_Colorspace.Unknown"/> if the surface is <see langword="null"/>.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorspace")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Colorspace GetSurfaceColorspace(SDL_Surface* surface);

	/// <summary>
	/// Create a palette and associate it with a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSurfacePalette">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <returns>A new <see cref="SDL_Palette"/> structure on success or <see langword="null"/> on failure (e.g. if the surface didn't have an index format); call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateSurfacePalette")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Palette* CreateSurfacePalette(SDL_Surface* surface);

	/// <summary>
	/// Set the palette used by a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfacePalette">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="palette">The <see cref="SDL_Palette"/> structure to use.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfacePalette")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette);

	/// <summary>
	/// Get the palette used by a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfacePalette">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <returns>A pointer to the palette used by the surface, or <see langword="null"/> if there is no palette used.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfacePalette")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Palette* GetSurfacePalette(SDL_Surface* surface);

	/// <summary>
	/// Add an alternate version of a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddSurfaceAlternateImage">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="image">A pointer to an alternate <see cref="SDL_Surface"/> to associate with this surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	// FIXME: update return, because right now the official documentation is kinda messed up.
	[LibraryImport(LibraryName, EntryPoint = "SDL_AddSurfaceAlternateImage")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int AddSurfaceAlternateImage(SDL_Surface* surface, SDL_Surface* image);

	/// <summary>
	/// Return whether a surface has alternate versions available.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasAlternateImages">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <returns>True if alternate versions are available or false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SurfaceHasAlternateImages")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SurfaceHasAlternateImages(SDL_Surface* surface);

	/// <summary>
	/// Get an array including all versions of a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceImages">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="count">A pointer filled in with the number of surface pointers returned.</param>
	/// <returns>A null-terminated array of <see cref="SDL_Surface"/> pointers or <see langword="null"/> on failure; call <see cref="GetError"/> for more information. This should be freed with <see cref="free(nint)"/> when it is no longer needed.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceImages")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface** GetSurfaceImages(SDL_Surface* surface, out int count);

	/// <summary>
	/// Remove all alternate versions of a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RemoveSurfaceAlternateImages">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RemoveSurfaceAlternateImages")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void RemoveSurfaceAlternateImages(SDL_Surface* surface);

	/// <summary>
	/// Set up a surface for directly accessing the pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to be locked.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_LockSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int LockSurface(SDL_Surface* surface);

	/// <summary>
	/// Release a surface after directly accessing the pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to be unlocked.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UnlockSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void UnlockSurface(SDL_Surface* surface);

	// TODO: implement SDL_LoadBMP_IO()

	/// <summary>
	/// Load a BMP image from a file.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LoadBMP">documentation</see> for more details.
	/// </remarks>
	/// <param name="file">The BMP file to load.</param>
	/// <returns>A pointer to a new <see cref="SDL_Surface"/> structure or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_LoadBMP", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface* LoadBmp(string file);

	// TODO: implement SDL_SaveBMP_IO()

	/// <summary>
	/// Save a surface to a file.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SaveBMP">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure containing the image to be saved.</param>
	/// <param name="file">A file to save to.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SaveBMP", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SaveBmp(SDL_Surface* surface, string file);

	/// <summary>
	/// Set the RLE acceleration hint for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceRLE">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to optimize.</param>
	/// <param name="enabled">True to enable RLE acceleration, false to disable it.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceRLE")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetSurfaceRLE(SDL_Surface* surface, [MarshalAs(NativeBool)] bool enabled);

	/// <summary>
	/// Returns whether the surface is RLE enabled.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasRLE">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <returns>True if the surface has RLE enabled, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SurfaceHasRLE")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SurfaceHasRLE(SDL_Surface* surface);

	/// <summary>
	/// Set the color key (transparent pixel) in a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceColorKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="enabled">True to enable color key, false to disable color key.</param>
	/// <param name="key">The transparent pixel.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorKey")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetSurfaceColorKey(SDL_Surface* surface, [MarshalAs(NativeBool)] bool enabled, uint key);

	/// <summary>
	/// Returns whether the surface has a color key.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasColorKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <returns>True if the surface has a color key, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SurfaceHasColorKey")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SurfaceHasColorKey(SDL_Surface* surface);

	/// <summary>
	/// Get the color key (transparent pixel) for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorKey">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="key">A pointer filled in with the transparent pixel.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorKey")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetSurfaceColorKey(SDL_Surface* surface, out uint key);

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
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetSurfaceColorMod(SDL_Surface* surface, byte r, byte g, byte b);

	/// <summary>
	/// Get the additional color value multiplied into blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="r">A pointer filled in with the current red color value.</param>
	/// <param name="g">A pointer filled in with the current green color value.</param>
	/// <param name="b">A pointer filled in with the current blue color value.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetSurfaceColorMod(SDL_Surface* surface, out byte r, out byte g, out byte b);

	/// <summary>
	/// Set an additional alpha value used in blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceAlphaMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="alpha">The alpha value multiplied into blit operations.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceAlphaMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetSurfaceAlphaMod(SDL_Surface* surface, byte alpha);

	/// <summary>
	/// Get the additional alpha value used in blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceAlphaMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="alpha">A pointer filled in with the current alpha value.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceAlphaMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetSurfaceAlphaMod(SDL_Surface* surface, out byte alpha);

	/// <summary>
	/// Set the blend mode used for blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to update.</param>
	/// <param name="blendMode">The <see cref="SDL_BlendMode"/> to use for blit blending.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int SetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode blendMode);

	/// <summary>
	/// Get the blend mode used for blit operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to query.</param>
	/// <param name="blendMode">A pointer filled in with the current <see cref="SDL_BlendMode"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetSurfaceBlendMode(SDL_Surface* surface, out SDL_BlendMode blendMode);

	/// <summary>
	/// Set the clipping rectangle for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceClipRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to be clipped.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure representing the clipping rectangle, or <see langword="null"/> to disable clipping.</param>
	/// <returns>True if the rectangle intersects the surface, otherwise false and blits will be completely clipped.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceClipRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetSurfaceClipRect(SDL_Surface* surface, in SDL_Rect rect);

	/// <summary>
	/// Set the clipping rectangle for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceClipRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure to be clipped.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure representing the clipping rectangle, or <see langword="null"/> to disable clipping.</param>
	/// <returns>True if the rectangle intersects the surface, otherwise false and blits will be completely clipped.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetSurfaceClipRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetSurfaceClipRect(SDL_Surface* surface, SDL_Rect* rect);

	/// <summary>
	/// Get the clipping rectangle for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceClipRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure representing the surface to be clipped.</param>
	/// <param name="rect">An <see cref="SDL_Rect"/> structure representing the clipping rectangle for the surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetSurfaceClipRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetSurfaceClipRect(SDL_Surface* surface, out SDL_Rect rect);

	/// <summary>
	/// Flip a surface vertically or horizontally.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlipSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to flip.</param>
	/// <param name="flip">The direction to flip.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_FlipSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int FlipSurface(SDL_Surface* surface, SDL_FlipMode flip);

	/// <summary>
	/// Creates a new surface identical to the existing surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DuplicateSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to duplicate.</param>
	/// <returns>A copy of the surface or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DuplicateSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface* DuplicateSurface(SDL_Surface* surface);

	/// <summary>
	/// Creates a new surface identical to the existing surface, scaled to the desired size.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ScaleSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to duplicate and scale.</param>
	/// <param name="width">The width of the new surface.</param>
	/// <param name="height">The height of the new surface.</param>
	/// <param name="scaleMode">The <see cref="SDL_ScaleMode"/> to be used.</param>
	/// <returns>A copy of the surface or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ScaleSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface* ScaleSurface(SDL_Surface* surface, int width, int height, SDL_ScaleMode scaleMode);

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The existing <see cref="SDL_Surface"/> structure to convert.</param>
	/// <param name="format">The new pixel format.</param>
	/// <returns>The new <see cref="SDL_Surface"/> structure that is created or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ConvertSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface* ConvertSurface(SDL_Surface* surface, SDL_PixelFormat format);

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format and colorspace.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurfaceAndColorspace">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The existing <see cref="SDL_Surface"/> structure to convert.</param>
	/// <param name="format">The new pixel format.</param>
	/// <param name="palette">An optional palette to use for indexed formats, may be <see langword="null"/>.</param>
	/// <param name="colorspace">The new colorspace.</param>
	/// <param name="props">An <see cref="SDL_PropertiesId"/> with additional color properties, or <see cref="SDL_PropertiesId.Invalid"/>.</param>
	/// <returns>The new <see cref="SDL_Surface"/> structure that is created or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ConvertSurfaceAndColorspace")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface* ConvertSurfaceAndColorspace(SDL_Surface* surface, SDL_PixelFormat format, SDL_Palette* palette, SDL_Colorspace colorspace, SDL_PropertiesId props);

	/// <summary>
	/// Copy a block of pixels of one format to another format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertPixels">documentation</see> for more details.
	/// </remarks>
	/// <param name="width">The width of the block to copy, in pixels.</param>
	/// <param name="height">The height of the block to copy, in pixels.</param>
	/// <param name="srcFormat">An <see cref="SDL_PixelFormat"/> value of the <paramref name="src"/> pixels format.</param>
	/// <param name="src">A pointer to the source pixels.</param>
	/// <param name="srcPitch">The pitch of the source pixels, in bytes.</param>
	/// <param name="dstFormat">An <see cref="SDL_PixelFormat"/> value of the <paramref name="dst"/> pixels format.</param>
	/// <param name="dst">A pointer to be filled in with new pixel data.</param>
	/// <param name="dstPitch">The pitch of the destination pixels, in bytes.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ConvertPixels")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ConvertPixels(int width, int height, SDL_PixelFormat srcFormat, nint src, int srcPitch, SDL_PixelFormat dstFormat, nint dst, int dstPitch);

	/// <summary>
	/// Copy a block of pixels of one format and colorspace to another format and colorspace.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertPixelsAndColorspace">documentation</see> for more details.
	/// </remarks>
	/// <param name="width">The width of the block to copy, in pixels.</param>
	/// <param name="height">The height of the block to copy, in pixels.</param>
	/// <param name="srcFormat">An <see cref="SDL_PixelFormat"/> value of the <paramref name="src"/> pixels format.</param>
	/// <param name="srcColorspace">An <see cref="SDL_Colorspace"/> value describing the colorspace of the <paramref name="src"/> pixels.</param>
	/// <param name="srcProps">An <see cref="SDL_PropertiesId"/> with additional source color properties, or <see cref="SDL_PropertiesId.Invalid"/>.</param>
	/// <param name="src">A pointer to the source pixels.</param>
	/// <param name="srcPitch">The pitch of the source pixels, in bytes.</param>
	/// <param name="dstFormat">An <see cref="SDL_PixelFormat"/> value of the <paramref name="dst"/> pixels format.</param>
	/// <param name="dstColorspace">An <see cref="SDL_Colorspace"/> value describing the colorspace of the <paramref name="dst"/> pixels.</param>
	/// <param name="dstProps">An <see cref="SDL_PropertiesId"/> with additional destination color properties, or <see cref="SDL_PropertiesId.Invalid"/>.</param>
	/// <param name="dst">A pointer to be filled in with new pixel data.</param>
	/// <param name="dstPitch">The pitch of the destination pixels, in bytes.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ConvertPixelsAndColorspace")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ConvertPixelsAndColorspace(int width, int height, SDL_PixelFormat srcFormat, SDL_Colorspace srcColorspace, SDL_PropertiesId srcProps, nint src, int srcPitch, SDL_PixelFormat dstFormat, SDL_Colorspace dstColorspace, SDL_PropertiesId dstProps, nint dst, int dstPitch);

	/// <summary>
	/// Premultiply the alpha on a block of pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PremultiplyAlpha">documentation</see> for more details.
	/// </remarks>
	/// <param name="width">The width of the block to convert, in pixels.</param>
	/// <param name="height">The height of the block to convert, in pixels.</param>
	/// <param name="srcFormat">An <see cref="SDL_PixelFormat"/> value of the <paramref name="src"/> pixels format.</param>
	/// <param name="src">A pointer to the source pixels.</param>
	/// <param name="srcPitch">The pitch of the source pixels, in bytes.</param>
	/// <param name="dstFormat">An <see cref="SDL_PixelFormat"/> value of the <paramref name="dst"/> pixels format.</param>
	/// <param name="dst">A pointer to be filled in with premultiplied pixel data.</param>
	/// <param name="dstPitch">The pitch of the destination pixels, in bytes.</param>
	/// <param name="linear">True to convert from sRGB to linear space for the alpha multiplication, false to do multiplication in sRGB space.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_PremultiplyAlpha")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int PremultiplyAlpha(int width, int height, SDL_PixelFormat srcFormat, nint src, int srcPitch, SDL_PixelFormat dstFormat, nint dst, int dstPitch, [MarshalAs(NativeBool)] bool linear);

	/// <summary>
	/// Premultiply the alpha in a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_PremultiplySurfaceAlpha">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to modify.</param>
	/// <param name="linear">True to convert from sRGB to linear space for the alpha multiplication, false to do multiplication in sRGB space.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_PremultiplySurfaceAlpha")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int PremultiplySurfaceAlpha(SDL_Surface* surface, [MarshalAs(NativeBool)] bool linear);

	/// <summary>
	/// Clear a surface with a specific color, with floating point precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ClearSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> to clear.</param>
	/// <param name="r">The red component of the pixel, normally in the range 0-1.</param>
	/// <param name="g">The green component of the pixel, normally in the range 0-1.</param>
	/// <param name="b">The blue component of the pixel, normally in the range 0-1.</param>
	/// <param name="a">The alpha component of the pixel, normally in the range 0-1.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ClearSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ClearSurface(SDL_Surface* surface, float r, float g, float b, float a);

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
	[LibraryImport(LibraryName, EntryPoint = "SDL_FillSurfaceRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int FillSurfaceRect(SDL_Surface* dst, in SDL_Rect rect, uint color);

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
	[LibraryImport(LibraryName, EntryPoint = "SDL_FillSurfaceRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int FillSurfaceRect(SDL_Surface* dst, SDL_Rect* rect, uint color);

	/// <summary>
	/// Perform a fast fill of a set of rectangles with a specific color.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FillSurfaceRects">documentation</see> for more details.
	/// </remarks>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the drawing target.</param>
	/// <param name="rects">An array of <see cref="SDL_Rect"/>s representing the rectangles to fill.</param>
	/// <param name="count">The number of rectangles in the array. Corresponds to <paramref name="rects"/>.Length.</param>
	/// <param name="color">The color to fill with.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_FillSurfaceRects")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int FillSurfaceRects(SDL_Surface* dst, [In] SDL_Rect[] rects, int count, uint color);

	/// <summary>
	/// Performs a fast blit from the source surface to the destination surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the x and y position in the destination surface, or <see langword="null"/> for (0,0). The width and height are ignored, and are copied from <paramref name="srcRect"/>. If you want a specific width and height, you should use <see cref="BlitSurfaceScaled(SDL_Surface*, in SDL_Rect, SDL_Surface*, ref SDL_Rect, SDL_ScaleMode)"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurface(SDL_Surface* src, in SDL_Rect srcRect, SDL_Surface* dst, in SDL_Rect dstRect);

	/// <summary>
	/// Performs a fast blit from the source surface to the destination surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the x and y position in the destination surface, or <see langword="null"/> for (0,0). The width and height are ignored, and are copied from <paramref name="srcRect"/>. If you want a specific width and height, you should use <see cref="BlitSurfaceScaled(SDL_Surface*, in SDL_Rect, SDL_Surface*, ref SDL_Rect, SDL_ScaleMode)"/>.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurface(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect);

	/// <summary>
	/// Perform low-level surface blitting only.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceUnchecked">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the x and y position in the destination surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceUnchecked")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurfaceUnchecked(SDL_Surface* src, in SDL_Rect srcRect, SDL_Surface* dst, in SDL_Rect dstRect);

	/// <summary>
	/// Perform a scaled blit to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceScaled">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface..</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, filled with the actual rectangle used after clipping.</param>
	/// <param name="scaleMode">The <see cref="SDL_ScaleMode"/> to be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceScaled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurfaceScaled(SDL_Surface* src, in SDL_Rect srcRect, SDL_Surface* dst, ref SDL_Rect dstRect, SDL_ScaleMode scaleMode);

	/// <summary>
	/// Perform a scaled blit to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceScaled">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface..</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, filled with the actual rectangle used after clipping.</param>
	/// <param name="scaleMode">The <see cref="SDL_ScaleMode"/> to be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceScaled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurfaceScaled(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect, SDL_ScaleMode scaleMode);

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
	/// <param name="scaleMode">The <see cref="SDL_ScaleMode"/> to be used.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceUncheckedScaled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurfaceUncheckedScaled(SDL_Surface* src, in SDL_Rect srcRect, SDL_Surface* dst, in SDL_Rect dstRect, SDL_ScaleMode scaleMode);

	/// <summary>
	/// Perform a tiled blit to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceTiled">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, or <see langword="null"/> to fill the entire surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceTiled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurfaceTiled(SDL_Surface* src, in SDL_Rect srcRect, SDL_Surface* dst, in SDL_Rect dstRect);

	/// <summary>
	/// Perform a tiled blit to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceTiled">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, or <see langword="null"/> to fill the entire surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceTiled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurfaceTiled(SDL_Surface* src, SDL_Rect* srcRect, SDL_Surface* dst, SDL_Rect* dstRect);

	/// <summary>
	/// Perform a scaled and tiled blit to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceTiledWithScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be copied, or <see langword="null"/> to copy the entire surface.</param>
	/// <param name="scale">The scale used to transform <paramref name="srcRect"/> into the destination rectangle, e.g. a 32x32 texture with a scale of 2 would fill 64x64 tiles.</param>
	/// <param name="scaleMode">Scale algorithm to be used.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, or <see langword="null"/> to fill the entire surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurfaceTiledWithScale")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurfaceTiledWithScale(SDL_Surface* src, in SDL_Rect srcRect, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, in SDL_Rect dstRect);

	/// <summary>
	/// Perform a scaled blit using the 9-grid algorithm to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurface9Grid">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be used for the 9-grid, or <see langword="null"/> to use the entire surface.</param>
	/// <param name="leftWidth">The width, in pixels, of the left corners in <paramref name="srcRect"/>.</param>
	/// <param name="rightWidth">The width, in pixels, of the right corners in <paramref name="srcRect"/>.</param>
	/// <param name="topHeight">The height, in pixels, of the top corners in <paramref name="srcRect"/>.</param>
	/// <param name="bottomHeight">The height, in pixels, of the bottom corners in <paramref name="srcRect"/>.</param>
	/// <param name="scale">The scale used to transform the corner of srcrect into the corner of <paramref name="dstRect"/>, or 0.0f for an unscaled blit.</param>
	/// <param name="scaleMode">Scale algorithm to be used.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, or <see langword="null"/> to fill the entire surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurface9Grid")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurface9Grid(SDL_Surface* src, in SDL_Rect srcRect, int leftWidth, int rightWidth, int topHeight, int bottomHeight, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, in SDL_FRect dstRect);

	/// <summary>
	/// Perform a scaled blit using the 9-grid algorithm to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurface9Grid">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be used for the 9-grid, or <see langword="null"/> to use the entire surface.</param>
	/// <param name="leftWidth">The width, in pixels, of the left corners in <paramref name="srcRect"/>.</param>
	/// <param name="rightWidth">The width, in pixels, of the right corners in <paramref name="srcRect"/>.</param>
	/// <param name="topHeight">The height, in pixels, of the top corners in <paramref name="srcRect"/>.</param>
	/// <param name="bottomHeight">The height, in pixels, of the bottom corners in <paramref name="srcRect"/>.</param>
	/// <param name="scale">The scale used to transform the corner of srcrect into the corner of <paramref name="dstRect"/>, or 0.0f for an unscaled blit.</param>
	/// <param name="scaleMode">Scale algorithm to be used.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, or <see langword="null"/> to fill the entire surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurface9Grid")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurface9Grid(SDL_Surface* src, SDL_Rect* srcRect, int leftWidth, int rightWidth, int topHeight, int bottomHeight, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, in SDL_FRect dstRect);

	/// <summary>
	/// Perform a scaled blit using the 9-grid algorithm to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurface9Grid">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be used for the 9-grid, or <see langword="null"/> to use the entire surface.</param>
	/// <param name="leftWidth">The width, in pixels, of the left corners in <paramref name="srcRect"/>.</param>
	/// <param name="rightWidth">The width, in pixels, of the right corners in <paramref name="srcRect"/>.</param>
	/// <param name="topHeight">The height, in pixels, of the top corners in <paramref name="srcRect"/>.</param>
	/// <param name="bottomHeight">The height, in pixels, of the bottom corners in <paramref name="srcRect"/>.</param>
	/// <param name="scale">The scale used to transform the corner of srcrect into the corner of <paramref name="dstRect"/>, or 0.0f for an unscaled blit.</param>
	/// <param name="scaleMode">Scale algorithm to be used.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, or <see langword="null"/> to fill the entire surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurface9Grid")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurface9Grid(SDL_Surface* src, in SDL_Rect srcRect, int leftWidth, int rightWidth, int topHeight, int bottomHeight, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, SDL_FRect* dstRect);

	/// <summary>
	/// Perform a scaled blit using the 9-grid algorithm to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurface9Grid">documentation</see> for more details.
	/// </remarks>
	/// <param name="src">The <see cref="SDL_Surface"/> structure to be copied from.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be used for the 9-grid, or <see langword="null"/> to use the entire surface.</param>
	/// <param name="leftWidth">The width, in pixels, of the left corners in <paramref name="srcRect"/>.</param>
	/// <param name="rightWidth">The width, in pixels, of the right corners in <paramref name="srcRect"/>.</param>
	/// <param name="topHeight">The height, in pixels, of the top corners in <paramref name="srcRect"/>.</param>
	/// <param name="bottomHeight">The height, in pixels, of the bottom corners in <paramref name="srcRect"/>.</param>
	/// <param name="scale">The scale used to transform the corner of srcrect into the corner of <paramref name="dstRect"/>, or 0.0f for an unscaled blit.</param>
	/// <param name="scaleMode">Scale algorithm to be used.</param>
	/// <param name="dst">The <see cref="SDL_Surface"/> structure that is the blit target.</param>
	/// <param name="dstRect">The <see cref="SDL_Rect"/> structure representing the target rectangle in the destination surface, or <see langword="null"/> to fill the entire surface.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_BlitSurface9Grid")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int BlitSurface9Grid(SDL_Surface* src, SDL_Rect* srcRect, int leftWidth, int rightWidth, int topHeight, int bottomHeight, float scale, SDL_ScaleMode scaleMode, SDL_Surface* dst, SDL_FRect* dstRect);

	/// <summary>
	/// Map an RGB triple to an opaque pixel value for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MapSurfaceRGB">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to use for the pixel format and palette.</param>
	/// <param name="r">The red component of the pixel in the range 0-255.</param>
	/// <param name="g">The green component of the pixel in the range 0-255.</param>
	/// <param name="b">The blue component of the pixel in the range 0-255.</param>
	/// <returns>A pixel value.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MapSurfaceRGB")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial uint MapSurfaceRGB(SDL_Surface* surface, byte r, byte g, byte b);

	/// <summary>
	/// Map an RGB quadruple to an opaque pixel value for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MapSurfaceRGBA">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to use for the pixel format and palette.</param>
	/// <param name="r">The red component of the pixel in the range 0-255.</param>
	/// <param name="g">The green component of the pixel in the range 0-255.</param>
	/// <param name="b">The blue component of the pixel in the range 0-255.</param>
	/// <param name="a">The alpha component of the pixel in the range 0-255.</param>
	/// <returns>A pixel value.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_MapSurfaceRGBA")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial uint MapSurfaceRGBA(SDL_Surface* surface, byte r, byte g, byte b, byte a);

	/// <summary>
	/// Retrieves a single pixel from a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ReadSurfacePixel">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to read.</param>
	/// <param name="x">The horizontal coordinate, 0 &lt;= x &lt; width.</param>
	/// <param name="y">The vertical coordinate, 0 &lt;= y &lt; height.</param>
	/// <param name="r">A pointer filled in with the red channel, 0-255.</param>
	/// <param name="g">A pointer filled in with the green channel, 0-255.</param>
	/// <param name="b">A pointer filled in with the blue channel, 0-255.</param>
	/// <param name="a">A pointer filled in with the alpha channel, 0-255.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ReadSurfacePixel")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ReadSurfacePixel(SDL_Surface* surface, int x, int y, out byte r, out byte g, out byte b, out byte a);

	/// <summary>
	/// Retrieves a single pixel from a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ReadSurfacePixelFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to read.</param>
	/// <param name="x">The horizontal coordinate, 0 &lt;= x &lt; width.</param>
	/// <param name="y">The vertical coordinate, 0 &lt;= y &lt; height.</param>
	/// <param name="r">A pointer filled in with the red channel, 0-255.</param>
	/// <param name="g">A pointer filled in with the green channel, 0-255.</param>
	/// <param name="b">A pointer filled in with the blue channel, 0-255.</param>
	/// <param name="a">A pointer filled in with the alpha channel, 0-255.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ReadSurfacePixelFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int ReadSurfacePixelFloat(SDL_Surface* surface, int x, int y, out float r, out float g, out float b, out float a);

	/// <summary>
	/// Writes a single pixel to a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WriteSurfacePixel">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to write.</param>
	/// <param name="x">The horizontal coordinate, 0 <= x < width.</param>
	/// <param name="y">The vertical coordinate, 0 <= y < height.</param>
	/// <param name="r">The red channel value, 0-255.</param>
	/// <param name="g">The green channel value, 0-255.</param>
	/// <param name="b">The blue channel value, 0-255.</param>
	/// <param name="a">The alpha channel value, 0-255.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WriteSurfacePixel")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int WriteSurfacePixel(SDL_Surface* surface, int x, int y, byte r, byte g, byte b, byte a);

	/// <summary>
	/// Writes a single pixel to a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WriteSurfacePixelFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The surface to write.</param>
	/// <param name="x">The horizontal coordinate, 0 <= x < width.</param>
	/// <param name="y">The vertical coordinate, 0 <= y < height.</param>
	/// <param name="r">The red channel value, normally in the range 0-1.</param>
	/// <param name="g">The green channel value, normally in the range 0-1.</param>
	/// <param name="b">The blue channel value, normally in the range 0-1.</param>
	/// <param name="a">The alpha channel value, normally in the range 0-1.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WriteSurfacePixelFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int WriteSurfacePixelFloat(SDL_Surface* surface, int x, int y, float r, float g, float b, float a);
}