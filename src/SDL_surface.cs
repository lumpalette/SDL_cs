using System.Runtime.InteropServices;
using System.Text;

namespace SDL3;

// SDL_surface.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_surface.h.
unsafe partial class SDL
{
	partial class PropConsts
	{
		// GetSurfaceProperties()
		public const string SurfaceFloatHdrHeadroom = "SDL.surface.HDR_headroom";
		public const string SurfaceFloatSDRWhitePoint = "SDL.surface.SDR_white_point";
		public const string SurfaceNumberColorspace = "SDL.surface.colorspace";
		public const string SurfaceStringTonemapOperator = "SDL.surface.tonemap";
	}

	/// <summary>
	/// Describes how blit operations work internally. This structure is an opaque type.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_BlitMap">here</see>.
	/// </remarks>
	[Opaque]
	public readonly struct BlitMap;

	/// <summary>
	/// A collection of pixels used in software blitting.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Surface">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public readonly struct Surface
	{
		/// <summary>
		/// Surface internal flags.
		/// </summary>
		public readonly SurfaceFlags Flags;

		/// <summary>
		/// The pixel format this surface uses.
		/// </summary>
		public readonly PixelFormat* Format;

		/// <summary>
		/// The width of the surface.
		/// </summary>
		public readonly int Width;

		/// <summary>
		/// The height of the surface.
		/// </summary>
		public readonly int Height;

		/// <summary>
		/// Length of a surface scanline, in bytes.
		/// </summary>
		public readonly int Pitch;

		/// <summary>
		/// The pixel data flattened into a 1D array.
		/// </summary>
		public readonly uint* Pixels;

		private readonly void* _reserved;

		/// <summary>
		/// The number of locks this surface has. For each time the surface is locked or unlocked, this counter goes up or down.
		/// </summary>
		public readonly int Locked;

		public readonly BlitMap* _listBlitmap;

		/// <summary>
		/// The surface's area that can be renderable.
		/// </summary>
		public readonly Rect ClipRect;

		private readonly BlitMap* _map;

		/// <summary>
		/// Reference count - used when freeing surface.
		/// </summary>
		public readonly int RefCount;
	}

	/// <summary>
	/// The flags on a <see cref="Surface"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceFlags">here</see>.
	/// </remarks>
	[Flags]
	public enum SurfaceFlags : uint
	{
		/// <summary>
		/// Surface uses preallocated memory.
		/// </summary>
		PreAlloc = 0x00000001u,

		/// <summary>
		/// Surface is RLE encoded.
		/// </summary>
		RleAccel = 0x00000002u,

		/// <summary>
		/// Surface is referenced internally.
		/// </summary>
		DontFree = 0x00000004u,

		/// <summary>
		/// Surface uses aligned memory.
		/// </summary>
		SimdAligned = 0x00000008u,

		/// <summary>
		/// Surface uses properties.
		/// </summary>
		UsesProperties = 0x00000010u
	}

	/// <summary>
	/// The scaling mode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ScaleMode">here</see>.
	/// </remarks>
	public enum ScaleMode
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

	/// <summary>
	/// The flip mode.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_FlipMode">here</see>.
	/// </remarks>
	public enum FlipMode
	{
		/// <summary>
		/// Do not flip.
		/// </summary>
		None,

		/// <summary>
		/// Flip horizontally.
		/// </summary>
		Horizontal,

		/// <summary>
		/// Flip vertically.
		/// </summary>
		Vertical
	}

	/// <summary>
	/// Evaluates to true if the surface needs to be locked before access.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_MUSTLOCK">here</see>
	/// </remarks>
	/// <param name="surface"> (Ref) The <see cref="Surface"/> structure to evaluate. </param>
	/// <returns> True if <paramref name="surface"/> needs to be locked, otherwise false. </returns>
	[Macro]
	public static bool MustLockSurface(Surface* surface)
	{
		return (surface->Flags & SurfaceFlags.RleAccel) != 0;
	}

	/// <summary>
	/// Allocate a new RGB surface with a specific pixel format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSurface">here</see>.
	/// </remarks>
	/// <param name="width"> The width of the surface. </param>
	/// <param name="height"> The height of the surface. </param>
	/// <param name="format"> The <see cref="PixelFormatValue"/> for the new surface's pixel format. </param>
	/// <returns> The new <see cref="Surface"/> structure that is created or null if it fails; call <see cref="GetError"/> for more information. </returns>
	public static Surface* CreateSurface(int width, int height, PixelFormatValue format) // CHECK:overload
	{
		return _PInvoke(width, height, format);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Surface* _PInvoke(int width, int height, PixelFormatValue format);
	}

	/// <summary>
	/// Allocate a new RGB surface with a specific pixel format and existing pixel data.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSurfaceFrom">here</see>.
	/// </remarks>
	/// <param name="pixels"> The pixel data, represented as unsigned 32-bit integer array. </param>
	/// <param name="width"> The width of the surface. </param>
	/// <param name="height"> The height of the surface. </param>
	/// <param name="pitch"> The number of bytes between each row, including padding </param>
	/// <param name="format"> The pixel format value for the new surface's pixel format. </param>
	/// <returns> The new <see cref="Surface"/> structure that is created or null if it fails; call <see cref="GetError"/> for more information. </returns>
	public static Surface* CreateSurface(uint[] pixels, int width, int height, int pitch, PixelFormatValue format) // CHECK:overload
	{
		fixed (uint* p = pixels)
		{
			// i'm not sure if the garbage collector messes up the 'pixels' managed array, because the documentation for
			// this function says that no copy of the pixel data is made. if the managed array gets destroyed from memory
			// by the gc, then it would also affect the C side, right? help
			return _PInvoke(p, width, height, pitch, format);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_CreateSurfaceFrom", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Surface* _PInvoke(uint* pixels, int width, int height, int pitch, PixelFormatValue format);
	}

	/// <summary>
	/// Free an RGB surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DestroySurface">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to free. It is safe to this be null. </param>
	public static void DestroySurface(Surface* surface)
	{
		if (surface is null)
		{
			return;
		}
		_PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_DestroySurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(Surface* surface);
	}

	/// <summary>
	/// Get the properties associated with a surface.
	/// </summary>
	/// <remarks>
	/// The properties' string values can be found in <see cref="PropConsts"/>; they have 'Surface' as a prefix.
	/// <br/><br/>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceProperties">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to query. </param>
	/// <returns> A valid property id on success or <see cref="PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static PropertiesId GetSurfaceProperties(Surface* surface)
	{
		return _PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern PropertiesId _PInvoke(Surface* surface);
	}

	/// <summary>
	/// Set the colorspace used by a surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceColorspace">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to update. </param>
	/// <param name="colorspace"> A <see cref="ColorspaceValue"/> value describing the surface colorspace. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceColorspace(Surface* surface, ColorspaceValue colorspace)
	{
		return _PInvoke(surface, colorspace);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorspace", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, ColorspaceValue colorspace);
	}

	/// <summary>
	/// Get the colorspace used by a surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorspace">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to query. </param>
	/// <param name="colorspace"> Returns the <see cref="ColorspaceValue"/> value describing the surface colorspace. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceColorspace(Surface* surface, out ColorspaceValue colorspace)
	{
		fixed (ColorspaceValue* c = &colorspace)
		{
			return _PInvoke(surface, c);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorspace", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, ColorspaceValue* colorspace);
	}

	/// <summary>
	/// Set the palette used by a surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfacePalette">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to update. </param>
	/// <param name="palette"> The <see cref="Palette"/> structure to use. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfacePalette(Surface* surface, Palette* palette)
	{
		return _PInvoke(surface, palette);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfacePalette", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, Palette* palette);
	}

	/// <summary>
	/// Set up a surface for directly accessing the pixels.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_LockSurface">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to be locked. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int LockSurface(Surface* surface)
	{
		return _PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_LockSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface);
	}

	/// <summary>
	/// Release a surface after directly accessing the pixels.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockSurface">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to be unlocked. </param>
	public static void UnlockSurface(Surface* surface)
	{
		_PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_UnlockSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(Surface* surface);
	}

	// i'll rather die than having to implement IO shit, so i'll just skip the IO stream functions LOL
	// ADDME: IO shit (probably not)

	/// <summary>
	/// Load a BMP image from a file.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_LoadBMP">here</see>.
	/// </remarks>
	/// <param name="file"> The BMP file to load. </param>
	/// <returns> A pointer to a new <see cref="Surface"/> structure or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static Surface* LoadBMP(string file)
	{
		fixed (byte* f = Encoding.UTF8.GetBytes(file))
		{
			return _PInvoke(f);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_LoadBMP", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Surface* _PInvoke(byte* file);
	}

	/// <summary>
	/// Save a surface to a file.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SaveBMP">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure containing the image to be saved. </param>
	/// <param name="file"> A file to save to. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SaveBMP(Surface* surface, string file)
	{
		fixed (byte* f = Encoding.UTF8.GetBytes(file))
		{
			return _PInvoke(surface, f);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SaveBMP", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, byte* file);
	}

	/// <summary>
	/// Set the RLE acceleration hint for a surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceRLE">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to optimize. </param>
	/// <param name="enable"> True to enable RLE acceleration, otherwise false. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceRLE(Surface* surface, bool enable)
	{
		return _PInvoke(surface, enable ? 1 : 0);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceRLE", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, int flag);
	}

	/// <summary>
	/// Returns whether the surface is RLE enabled.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasRLE">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to query. </param>
	/// <returns> True if the surface has RLE enabled, false otherwise. </returns>
	public static bool SurfaceHasRLE(Surface* surface)
	{
		return _PInvoke(surface) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_SurfaceHasRLE", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface);
	}

	/// <summary>
	/// Set the color key (transparent pixel) in a surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasRLE">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to update. </param>
	/// <param name="enable"> True to enable color key, false to disable color key. </param>
	/// <param name="key"> The transparent pixel. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceColorKey(Surface* surface, bool enable, uint key)
	{
		return _PInvoke(surface, enable ? 1 : 0, key);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorKey", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, int enable, uint key);
	}

	/// <summary>
	/// Returns whether the surface has a color key.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceHasColorKey">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to query. </param>
	/// <returns> True if the surface has a color key, otherwise false. </returns>
	public static bool SurfaceHasColorKey(Surface* surface)
	{
		return _PInvoke(surface) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_SurfaceHasColorKey", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface);
	}

	/// <summary>
	/// Get the color key (transparent pixel) for a surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorKey">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to query. </param>
	/// <param name="key"> Returns the transparent pixel. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceColorKey(Surface* surface, out uint key)
	{
		fixed (uint* k = &key)
		{
			return _PInvoke(surface, k);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorKey", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, uint* key);
	}

	/// <summary>
	/// Set an additional color value multiplied into blit operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceColorMod">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to update. </param>
	/// <param name="r"> The red color value multiplied into blit operations. </param>
	/// <param name="g"> The green color value multiplied into blit operations. </param>
	/// <param name="b"> The blue color value multiplied into blit operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceColorMod(Surface* surface, byte r, byte g, byte b)
	{
		return _PInvoke(surface, r, g, b);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceColorMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, byte r, byte g, byte b);
	}

	/// <summary>
	/// Get the additional color value multiplied into blit operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceColorMod">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to query. </param>
	/// <param name="r"> Returns the current red color value. </param>
	/// <param name="g"> Returns the current green color value. </param>
	/// <param name="b"> Returns the the current blue color value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceColorMod(Surface* surface, out byte r, out byte g, out byte b)
	{
		fixed (byte* rr = &r, gg = &g, bb = &b)
		{
			return _PInvoke(surface, rr, gg, bb);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceColorMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, byte* r, byte* g, byte* b);
	}

	/// <summary>
	/// Set an additional alpha value used in blit operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceAlphaMod">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to update. </param>
	/// <param name="alpha"> The alpha value multiplied into blit operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceAlphaMod(Surface* surface, byte alpha)
	{
		return _PInvoke(surface, alpha);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceAlphaMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, byte alpha);
	}

	/// <summary>
	/// Get the additional alpha value used in blit operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceAlphaMod">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to query. </param>
	/// <param name="alpha"> Returns the current alpha value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceAlphaMod(Surface* surface, out byte alpha)
	{
		fixed (byte* a = &alpha)
		{
			return _PInvoke(surface, a);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceAlphaMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, byte* alpha);
	}

	/// <summary>
	/// Set the blend mode used for blit operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceBlendMode">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to update. </param>
	/// <param name="blendMode"> The <see cref="BlendMode"/> to use for blit blending. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetSurfaceBlendMode(Surface* surface, BlendMode blendMode)
	{
		return _PInvoke(surface, blendMode);

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceBlendMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, BlendMode blendMode);
	}

	/// <summary>
	/// Get the blend mode used for blit operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceBlendMode">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to query. </param>
	/// <param name="blendMode"> Returns the current <see cref="BlendMode"/>. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceBlendMode(Surface* surface, out BlendMode blendMode)
	{
		fixed (BlendMode* b = &blendMode)
		{
			return _PInvoke(surface, b);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceBlendMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, BlendMode* blendMode);
	}

	/// <summary>
	/// Set the clipping rectangle for a surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetSurfaceClipRect">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure to be clipped. </param>
	/// <param name="rect"> The <see cref="Rect"/> structure representing the clipping rectangle, or null to disable clipping. </param>
	/// <returns> True if the rectangle intersects the surface, otherwise false and blits will be completely clipped. </returns>
	public static bool SetSurfaceClipRect(Surface* surface, Rect? rect)
	{
		if (rect.HasValue)
		{
			Rect r = rect.Value;
			return _PInvoke(surface, &r) == 1;
		}
		return _PInvoke(surface, null) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_SetSurfaceClipRect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, Rect* rect);
	}

	/// <summary>
	/// Get the clipping rectangle for a surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetSurfaceClipRect">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure representing the surface to be clipped. </param>
	/// <param name="rect"> Returns a <see cref="Rect"/> structure representing the clipping rectangle for the surface. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetSurfaceClipRect(Surface* surface, out Rect rect)
	{
		fixed (Rect* r = &rect)
		{
			return _PInvoke(surface, r);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetSurfaceClipRect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, Rect* rect);
	}

	/// <summary>
	/// Flip a surface vertically or horizontally.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_FlipSurface">here</see>.
	/// </remarks>
	/// <param name="surface"> The surface to flip. </param>
	/// <param name="flip"> The direction to flip. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int FlipSurface(Surface* surface, FlipMode flip)
	{
		return _PInvoke(surface, flip);

		[DllImport(LibraryName, EntryPoint = "SDL_FlipSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, FlipMode flip);
	}

	/// <summary>
	/// Creates a new surface identical to the existing surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_DuplicateSurface">here</see>.
	/// </remarks>
	/// <param name="surface"> The surface to duplicate. </param>
	/// <returns> A copy of the surface, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Surface* DuplicateSurface(Surface* surface)
	{
		return _PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_DuplicateSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Surface* _PInvoke(Surface* surface);
	}

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurface">here</see>.
	/// </remarks>
	/// <param name="surface"> The existing <see cref="Surface"/> structure to convert. </param>
	/// <param name="format"> The <see cref="PixelFormat"/> structure that the new surface is optimized for. </param>
	/// <returns> The new <see cref="Surface"/> structure that is created or null if it fails; call <see cref="GetError"/> for more information. </returns>
	public static Surface* ConvertSurfaceFormat(Surface* surface, PixelFormat* format) // CHECK:overload
	{
		return _PInvoke(surface, format);

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Surface* _PInvoke(Surface* surface, PixelFormat* format);
	}

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurfaceFormat">here</see>.
	/// </remarks>
	/// <param name="surface"> The existing <see cref="Surface"/> structure to convert. </param>
	/// <param name="format"> The new pixel format. </param>
	/// <returns> The new <see cref="Surface"/> structure that is created or null if it fails; call <see cref="GetError"/> for more information. </returns>
	public static Surface* ConvertSurfaceFormat(Surface* surface, PixelFormatValue format) // CHECK:overload
	{
		// i think ConvertSurface and ConvertSurfaceFormat were meant to be overloadings, but since C doesn't have
		// function overloading, they just created two functions instead. also, this function name is more accurate
		// (for both cases) to what the function does haha.
		return _PInvoke(surface, format);

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertSurfaceFormat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Surface* _PInvoke(Surface* surface, PixelFormatValue format);
	}

	/// <summary>
	/// Copy an existing surface to a new surface of the specified format and colorspace.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertSurfaceFormatAndColorspace">here</see>.
	/// </remarks>
	/// <param name="surface"> The existing <see cref="Surface"/> structure to convert. </param>
	/// <param name="format"> The new pixel format. </param>
	/// <param name="colorspace"> The new colorspace. </param>
	/// <param name="props"> An <see cref="PropertiesId"/> with additional color properties, or <see cref="PropertiesId.Invalid"/>. </param>
	/// <returns> The new <see cref="Surface"/> structure that is created or null if it fails; call <see cref="GetError"/> for more information. </returns>
	public static Surface* ConvertSurfaceFormatAndColorspace(Surface* surface, PixelFormatValue format, ColorspaceValue colorspace, PropertiesId props)
	{
		return _PInvoke(surface, format, colorspace, props);

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertSurfaceFormatAndColorspace", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern Surface* _PInvoke(Surface* surface, PixelFormatValue format, ColorspaceValue colorspace, PropertiesId props);
	}

	/// <summary>
	/// Copy a block of pixels of one format to another format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertPixels">here</see>.
	/// </remarks>
	/// <param name="width"> The width of the block to copy, in pixels. </param>
	/// <param name="height"> The height of the block to copy, in pixels. </param>
	/// <param name="srcFormat"> A <see cref="PixelFormatValue"/> value of the <paramref name="src"/> pixels format. </param>
	/// <param name="src"> The source pixels, as an unsigned 32-bit integers array. </param>
	/// <param name="srcPitch"> The pitch of the source pixels, in bytes. </param>
	/// <param name="dstFormat"> A <see cref="PixelFormatValue"/> value of the <paramref name="dst"/> pixels format. </param>
	/// <param name="dst"> Returns the new pixel data, as an unsigned 32-bit integer array. </param>
	/// <param name="srcPitch"> The pitch of the destination pixels, in bytes. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ConvertPixels(int width, int height, PixelFormatValue srcFormat, uint[] src, int srcPitch, PixelFormatValue dstFormat, out uint[] dst, int dstPitch)
	{
		// somehow this shit works.
		dst = new uint[src.Length];
		fixed (uint* s = src, d = dst)
		{
			return _PInvoke(width, height, srcFormat, s, srcPitch, dstFormat, d, dstPitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertPixels", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(int width, int height, PixelFormatValue srcFormat, uint* src, int srcPitch, PixelFormatValue dstFormat, uint* dst, int dstPitch);
	}

	/// <summary>
	/// Copy a block of pixels of one format and colorspace to another format and colorspace.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertPixelsAndColorspace">here</see>.
	/// </remarks>
	/// <param name="width"> The width of the block to copy, in pixels. </param>
	/// <param name="height"> The height of the block to copy, in pixels. </param>
	/// <param name="srcFormat"> A <see cref="PixelFormatValue"/> value of the <paramref name="src"/> pixels format. </param>
	/// <param name="srcColorspace"> A <see cref="ColorspaceValue"/> value describing the colorspace of the <paramref name="src"/> pixels. </param>
	/// <param name="srcProps"> A <see cref="PropertiesId"/> with additional source color properties, or <see cref="PropertiesId.Invalid"/>. </param>
	/// <param name="src"> The source pixels, as an unsigned 32-bit integers array. </param>
	/// <param name="srcPitch"> The pitch of the source pixels, in bytes. </param>
	/// <param name="dstFormat"> A <see cref="PixelFormatValue"/> value of the <paramref name="dst"/> pixels format. </param>
	/// <param name="dstColorspace"> A <see cref="ColorspaceValue"/> value describing the colorspace of the <paramref name="dst"/> pixels. </param>
	/// <param name="dstProps"> A <see cref="PropertiesId"/> with additional destination color properties, or <see cref="PropertiesId.Invalid"/>. </param>
	/// <param name="dst"> Returns the new pixel data, as an unsigned 32-bit integer array. </param>
	/// <param name="srcPitch"> The pitch of the destination pixels, in bytes. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ConvertPixelsAndColorspace(int width, int height, PixelFormatValue srcFormat, ColorspaceValue srcColorspace, PropertiesId srcProps, uint[] src, int srcPitch, PixelFormatValue dstFormat, ColorspaceValue dstColorspace, PropertiesId dstProps, out uint[] dst, int dstPitch)
	{
		dst = new uint[src.Length];
		fixed (uint* s = src, d = dst)
		{
			return _PInvoke(width, height, srcFormat, srcColorspace, srcProps, s, srcPitch, dstFormat, dstColorspace, dstProps, d, dstPitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertPixelsAndColorspace", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(int width, int height, PixelFormatValue srcFormat, ColorspaceValue srcColorspace, PropertiesId srcProps, uint* src, int srcPitch, PixelFormatValue dstFormat, ColorspaceValue dstColorspace, PropertiesId dstProps, uint* dst, int dstPitch); // wtf with this function.
	}

	/// <summary>
	/// Premultiply the alpha on a block of pixels.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_PremultiplyAlpha">here</see>.
	/// </remarks>
	/// <param name="width"> The width of the block to convert, in pixels. </param>
	/// <param name="height"> The height of the block to convert, in pixels. </param>
	/// <param name="srcFormat"> A <see cref="PixelFormatValue"/> value of the <paramref name="src"/> pixels format. </param>
	/// <param name="src"> The source pixels, as an unsigned 32-bit integers array. </param>
	/// <param name="srcPitch"> The pitch of the source pixels, in bytes. </param>
	/// <param name="srcFormat"> A <see cref="PixelFormatValue"/> value of the <paramref name="dst"/> pixels format. </param>
	/// <param name="dst"> Returns the premultiplied pixel data, as an unsigned 32-bit integer array. </param>
	/// <param name="srcPitch"> The pitch of the destination pixels, in bytes. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int PremultiplyAlpha(int width, int height, PixelFormatValue srcFormat, uint[] src, int srcPitch, PixelFormatValue dstFormat, out uint[] dst, int dstPitch)
	{
		dst = new uint[src.Length];
		fixed (uint* s = src, d = dst)
		{
			return _PInvoke(width, height, srcFormat, s, srcPitch, dstFormat, d, dstPitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_PremultiplyAlpha", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(int width, int height, PixelFormatValue srcFormat, uint* src, int srcPitch, PixelFormatValue dstFormat, uint* dst, int dstPitch);
	}

	/// <summary>
	/// Perform a fast fill of a rectangle with a specific color.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_FillSurfaceRect">here</see>.
	/// </remarks>
	/// <param name="dst"> The <see cref="Surface"/> structure that is the drawing target. </param>
	/// <param name="rect"> The <see cref="Rect"/> structure representing the rectangle to fill, or null to fill the entire surface. </param>
	/// <param name="color"> The color to fill with. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int FillSurfaceRect(Surface* dst, Rect? rect, uint color)
	{
		if (rect.HasValue)
		{
			Rect r = rect.Value;
			return _PInvoke(dst, &r, color);
		}
		return _PInvoke(dst, null, color);

		[DllImport(LibraryName, EntryPoint = "SDL_FillSurfaceRect", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* dst, Rect* rect, uint color);
	}

	/// <summary>
	/// Perform a fast fill of a set of rectangles with a specific color.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_FillSurfaceRects">here</see>.
	/// </remarks>
	/// <param name="dst"> The <see cref="Surface"/> structure that is the drawing target. </param>
	/// <param name="rects"> An array of <see cref="Rect"/>s representing the rectangles to fill. </param>
	/// <param name="color"> The color to fill with. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int FillSurfaceRects(Surface* dst, Rect[] rects, uint color)
	{
		fixed (Rect* r = rects)
		{
			return _PInvoke(dst, r, color);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_FillSurfaceRects", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* dst, Rect* rects, uint color);
	}

	/// <summary>
	/// Performs a fast blit from the source surface to the destination surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurface">here</see>.
	/// </remarks>
	/// <param name="src"> The <see cref="Surface"/> structure to be copied from. </param>
	/// <param name="srcRect"> The <see cref="Rect"/> structure representing the rectangle to be copied, or null to copy the entire surface. </param>
	/// <param name="dst"> The <see cref="Surface"/> structure that is the blit target. </param>
	/// <param name="dstRect"> The <see cref="Rect"/> structure representing the x and y position in the destination surface. On input the width and height are ignored (taken from <paramref name="srcRect"/>), and on output this is filled in with the actual rectangle used after clipping. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int BlitSurface(Surface* src, Rect? srcRect, Surface* dst, Rect dstRect)
	{
		if (srcRect.HasValue)
		{
			Rect s = srcRect.Value;
			return _PInvoke(src, &s, dst, &dstRect);
		}
		return _PInvoke(src, null, dst, &dstRect);

		[DllImport(LibraryName, EntryPoint = "SDL_BlitSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* src, Rect* srcRect, Surface* dst, Rect* dstRect);
	}

	/// <summary>
	/// Perform low-level surface blitting only.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceUnchecked">here</see>.
	/// </remarks>
	/// <param name="src"> The <see cref="Surface"/> structure to be copied from. </param>
	/// <param name="srcRect"> The <see cref="Rect"/> structure representing the rectangle to be copied, or null to copy the entire surface. </param>
	/// <param name="dst"> The <see cref="Surface"/> structure that is the blit target. </param>
	/// <param name="dstRect"> The <see cref="Rect"/> structure representing the x and y position in the destination surface. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int BlitSurfaceUnchecked(Surface* src, Rect? srcRect, Surface* dst, Rect dstRect)
	{
		if (srcRect.HasValue)
		{
			Rect s = srcRect.Value;
			return _PInvoke(src, &s, dst, &dstRect);
		}
		return _PInvoke(src, null, dst, &dstRect);

		[DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceUnchecked", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* src, Rect* srcRect, Surface* dst, Rect* dstRect);
	}

	/// <summary>
	/// Perform stretch blit between two surfaces of the same format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SoftStretch">here</see>.
	/// </remarks>
	/// <param name="src"> The <see cref="Surface"/> structure to be copied from. </param>
	/// <param name="srcRect"> The <see cref="Rect"/> structure representing the rectangle to be copied. </param>
	/// <param name="dst"> The <see cref="Surface"/> structure that is the blit target. </param>
	/// <param name="dstRect"> The <see cref="Rect"/> structure representing the target rectangle in the destination surface. </param>
	/// <param name="scaleMode"> Scale algorithm to be used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SoftStretch(Surface* src, Rect srcRect, Surface* dst, Rect dstRect, ScaleMode scaleMode)
	{
		return _PInvoke(src, &srcRect, dst, &dstRect, scaleMode);

		[DllImport(LibraryName, EntryPoint = "SDL_SoftStretch", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* src, Rect* srcRect, Surface* dst, Rect* dstRect, ScaleMode scaleMode);
	}

	/// <summary>
	/// Perform a scaled blit to a destination surface, which may be of a different format.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceScaled">here</see>.
	/// </remarks>
	/// <param name="src"> The <see cref="Surface"/> structure to be copied from. </param>
	/// <param name="srcRect"> The <see cref="Rect"/> structure representing the rectangle to be copied. </param>
	/// <param name="dst"> The <see cref="Surface"/> structure that is the blit target. </param>
	/// <param name="dstRect"> The <see cref="Rect"/> structure representing the target rectangle in the destination surface, filled with the actual rectangle used after clipping. </param>
	/// <param name="scaleMode"> the <see cref="ScaleMode"/> to be used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int BlitSurfaceScaled(Surface* src, Rect srcRect, Surface* dst, Rect dstRect, ScaleMode scaleMode)
	{
		return _PInvoke(src, &srcRect, dst, &dstRect, scaleMode);

		[DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceScaled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* src, Rect* srcRect, Surface* dst, Rect* dstRect, ScaleMode scaleMode);
	}

	/// <summary>
	/// Perform low-level surface scaled blitting only.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_BlitSurfaceUncheckedScaled">here</see>.
	/// </remarks>
	/// <param name="src"> The <see cref="Surface"/> structure to be copied from. </param>
	/// <param name="srcRect"> The <see cref="Rect"/> structure representing the rectangle to be copied. </param>
	/// <param name="dst"> The <see cref="Surface"/> structure that is the blit target. </param>
	/// <param name="dstRect"> The <see cref="Rect"/> structure representing the target rectangle in the destination surface. </param>
	/// <param name="scaleMode"> Scale algorithm to be used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int BlitSurfaceUncheckedScaled(Surface* src, Rect srcRect, Surface* dst, Rect dstRect, ScaleMode scaleMode)
	{
		return _PInvoke(src, &srcRect, dst, &dstRect, scaleMode);

		[DllImport(LibraryName, EntryPoint = "SDL_BlitSurfaceUncheckedScaled", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* src, Rect* srcRect, Surface* dst, Rect* dstRect, ScaleMode scaleMode);
	}

	/// <summary>
	/// Retrieves a single pixel from a surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ReadSurfacePixel">here</see>.
	/// </remarks>
	/// <param name="surface"> The surface to read. </param>
	/// <param name="x"> The horizontal coordinate, 0 &lt;= x &lt; width. </param>
	/// <param name="y"> The vertical coordinate, 0 &lt;= y &lt; height. </param>
	/// <param name="r"> Returns the red channel, 0-255. </param>
	/// <param name="g"> Returns the green channel, 0-255. </param>
	/// <param name="b"> Returns the blue channel, 0-255. </param>
	/// <param name="a"> Returns the alpha channel, 0-255. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ReadSurfacePixel(Surface* surface, int x, int y, out byte r, out byte g, out byte b, out byte a)
	{
		fixed (byte* rr = &r, gg = &g, bb = &b, aa = &a)
		{
			return _PInvoke(surface, x, y, rr, gg, bb, aa);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_ReadSurfacePixel", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(Surface* surface, int x, int y, byte* r, byte* g, byte* b, byte* a);
	}
}