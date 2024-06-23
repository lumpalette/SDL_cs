using System.Runtime.InteropServices;
using System.Text;

namespace SDL_cs;

// SDL_render.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_render.h
unsafe partial class SDL
{
	/// <summary>
	/// Get the number of 2D rendering drivers available for the current display.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumRenderDrivers">here</see> for more details.
	/// </remarks>
	/// <returns> A number >= 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetNumRenderDrivers()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumRenderDrivers", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Use this function to get the name of a built in 2D rendering driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDriver">here</see> for more details.
	/// </remarks>
	/// <param name="index"> The index of the rendering driver; the value ranges from 0 to <see cref="GetNumRenderDrivers"/> - 1 </param>
	/// <returns> The name of the rendering driver at the requested index, or null if an invalid index was specified. </returns>
	public static string? GetRenderDriver(int index)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(index));

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderDriver", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(int index);
	}

	/// <summary>
	/// Create a window and default renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindowAndRenderer">here</see> for more details.
	/// </remarks>
	/// <param name="title"> The title of the window. </param>
	/// <param name="width"> The width of the window. </param>
	/// <param name="height"> The height of the window. </param>
	/// <param name="windowFlags"> The flags used to create the window (see <see cref="CreateWindow"/>). </param>
	/// <param name="window"> Returns the window, or null on error. </param>
	/// <param name="renderer"> Returns the renderer, or null on error. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int CreateWindowAndRenderer(string title, int width, int height, SDL_WindowFlags windowFlags, out SDL_Window* window, out SDL_Renderer* renderer)
	{
		fixed (byte* t = Encoding.UTF8.GetBytes(title))
		{
			fixed (SDL_Window** w = &window)
			{
				fixed (SDL_Renderer** r = &renderer)
				{
					return _PInvoke(t, width, height, windowFlags, w, r);
				}
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_CreateWindowAndRenderer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(byte* title, int width, int height, SDL_WindowFlags windowFlags, SDL_Window** window, SDL_Renderer** renderer);
	}

	/// <summary>
	/// Create a 2D rendering context for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateRenderer">here</see> for more details.
	/// </remarks>
	/// <param name="window"> The window where rendering is displayed. </param>
	/// <param name="name"> The name of the rendering driver to initialize, or null if it is not important. Defaults to null. </param>
	/// <returns> A valid rendering context or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Renderer* CreateRenderer(SDL_Window* window, string? name = null)  // CHECK:overload
	{
		if (!string.IsNullOrWhiteSpace(name))
		{
			fixed (byte* n = Encoding.UTF8.GetBytes(name))
			{
				return _PInvoke(window, n);
			}
		}
		return _PInvoke(window, null);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateRenderer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Renderer* _PInvoke(SDL_Window* window, byte* name);
	}

	/// <summary>
	/// Create a 2D rendering context for a window, with the specified properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateRendererWithProperties">here</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to use. </param>
	/// <returns> A valid rendering context or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Renderer* CreateRenderer(SDL_PropertiesId props) // CHECK:overload
	{
		return _PInvoke(props);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateRendererWithProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Renderer* _PInvoke(SDL_PropertiesId props);
	}

	/// <summary>
	/// Create a 2D software rendering context for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSoftwareRenderer">here</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure representing the surface where rendering is done. </param>
	/// <returns> A valid rendering context or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Renderer* CreateSoftwareRenderer(SDL_Surface* surface)
	{
		return _PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateSoftwareRenderer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Renderer* _PInvoke(SDL_Surface* surface);
	}

	/// <summary>
	/// Get the renderer associated with a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderer">here</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The rendering context on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Renderer* GetRenderer(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderer", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Renderer* _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get the window associated with a renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderWindow">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer to query. </param>
	/// <returns> The window on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Window* GetRenderWindow(SDL_Renderer* renderer)
	{
		return _PInvoke(renderer);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Window* _PInvoke(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Get the name of a renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererName">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> The name of the selected renderer, or null if the renderer is invalid. </returns>
	public static string? GetRendererName(SDL_Renderer* renderer)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(renderer));

		[DllImport(LibraryName, EntryPoint = "SDL_GetRendererName", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern byte* _PInvoke(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Get the properties associated with a renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererProperties">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetRendererProperties(SDL_Renderer* renderer)
	{
		return _PInvoke(renderer);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRendererProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PropertiesId _PInvoke(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Get the output size in pixels of a rendering context.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderOutputSize">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> Returns the width in pixels. </param>
	/// <param name="height"> Returns the height in pixels. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderOutputSize(SDL_Renderer* renderer, out int width, out int height)
	{
		fixed (int* w = &width, h = &height)
		{
			return _PInvoke(renderer, w, h);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderOutputSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Renderer* renderer, int* width, int* height);
	}

	/// <summary>
	/// Get the current output size in pixels of a rendering context.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentRenderOutputSize">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> Returns the current width. </param>
	/// <param name="height"> Returns the current height. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetCurrentRenderOutputSize(SDL_Renderer* renderer, out int width, out int height)
	{
		fixed (int* w = &width, h = &height)
		{
			return _PInvoke(renderer, w, h);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetCurrentRenderOutputSize", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Renderer* renderer, int* width, int* height);
	}

	/// <summary>
	/// Create a texture for a rendering context.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTexture">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="format"> One of the static properties in <see cref="SDL_PixelFormatEnum"/>. </param>
	/// <param name="access"> One of the enumerated values in <see cref="SDL_TextureAccess"/>. </param>
	/// <param name="width"> The width of the texture in pixels. </param>
	/// <param name="height"> The height of the texture in pixels. </param>
	/// <returns> A pointer to the created texture or null if no rendering context was active, the format was unsupported, or the width or height were out of range; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Texture* CreateTexture(SDL_Renderer* renderer, SDL_PixelFormatEnum format, SDL_TextureAccess access, int width, int height) // CHECK:overload
	{
		return _PInvoke(renderer, format, access, width, height);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateTexture", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Texture* _PInvoke(SDL_Renderer* renderer, SDL_PixelFormatEnum format, SDL_TextureAccess access, int width, int height);
	}

	/// <summary>
	/// Create a texture from an existing surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTextureFromSurface">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="surface"> the <see cref="SDL_Surface"/> structure containing pixel data used to fill the texture. </param>
	/// <returns> The created texture or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Texture* CreateTexture(SDL_Renderer* renderer, SDL_Surface* surface) // CHECK:overload
	{
		return _PInvoke(renderer, surface);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateTextureFromSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Texture* _PInvoke(SDL_Renderer* renderer, SDL_Surface* surface);
	}

	/// <summary>
	/// Create a texture for a rendering context with the specified properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTextureWithProperties">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="props"> The properties to use. </param>
	/// <returns> A pointer to the created texture or null if no rendering context was active, the format was unsupported, or the width or height were out of range; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Texture* CreateTexture(SDL_Renderer* renderer, SDL_PropertiesId props) // CHECK:overload
	{
		return _PInvoke(renderer, props);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateTextureWithProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Texture* _PInvoke(SDL_Renderer* renderer, SDL_PropertiesId props);
	}

	/// <summary>
	/// Get the properties associated with a texture.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureProperties">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <returns> A valid property ID on success or 0 on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetTextureProperties(SDL_Texture* texture)
	{
		return _PInvoke(texture);

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureProperties", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_PropertiesId _PInvoke(SDL_Texture* texture);
	}

	/// <summary>
	/// Get the renderer that created An <see cref="SDL_Texture"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererFromTexture">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <returns> A pointer to the SDL_Renderer that created the texture, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Renderer* GetRendererFromTexture(SDL_Texture* texture)
	{
		return _PInvoke(texture);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRendererFromTexture", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Renderer* _PInvoke(SDL_Texture* texture);
	}

	/// <summary>
	/// Query the attributes of a texture.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_QueryTexture">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="format"> Returns the raw format of the texture; the actual format may differ, but pixel transfers will use this format (one of the static properties in <see cref="SDL_PixelFormatEnum"/>). </param>
	/// <param name="access"> Returns the actual access to the texture (one of the <see cref="SDL_TextureAccess"/> values). </param>
	/// <param name="width"> Returns the width of the texture in pixels. </param>
	/// <param name="height"> Returns the height of the texture in pixels. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int QueryTexture(SDL_Texture* texture, out SDL_PixelFormatEnum format, out SDL_TextureAccess access, out int width, out int height)
	{
		fixed (SDL_PixelFormatEnum* f = &format)
		{
			fixed (SDL_TextureAccess* a = &access)
			{
				fixed (int* w = &width, h = &height)
				{
					return _PInvoke(texture, f, a, w, h);
				}
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_QueryTexture", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_PixelFormatEnum* format, SDL_TextureAccess* access, int* width, int* height);
	}

	/// <summary>
	/// Set an additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorMod">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="r"> The red color value multiplied into copy operations. </param>
	/// <param name="g"> The green color value multiplied into copy operations. </param>
	/// <param name="b"> The blue color value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureColorMod(SDL_Texture* texture, byte r, byte g, byte b)
	{
		return _PInvoke(texture, r, g, b);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureColorMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, byte r, byte g, byte b);
	}

	/// <summary>
	/// Set an additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorMod">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="r"> The red color value multiplied into copy operations. </param>
	/// <param name="g"> The green color value multiplied into copy operations. </param>
	/// <param name="b"> The blue color value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureColorMod(SDL_Texture* texture, float r, float g, float b)
	{
		return _PInvoke(texture, r, g, b);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureColorModFloat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, float r, float g, float b);
	}

	/// <summary>
	/// Get the additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorMod">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="r"> Returns the current red color value. </param>
	/// <param name="g"> Returns the current green color value. </param>
	/// <param name="b"> Returns the current blue color value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureColorMod(SDL_Texture* texture, out byte r, out byte g, out byte b)
	{
		fixed (byte* rr = &r, gg = &g, bb = &b)
		{
			return _PInvoke(texture, rr, gg, bb);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureColorMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, byte* r, byte* g, byte* b);
	}

	/// <summary>
	/// Get the additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorMod">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="r"> Returns the current red color value. </param>
	/// <param name="g"> Returns the current green color value. </param>
	/// <param name="b"> Returns the current blue color value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureColorMod(SDL_Texture* texture, out float r, out float g, out float b)
	{
		fixed (float* rr = &r, gg = &g, bb = &b)
		{
			return _PInvoke(texture, rr, gg, bb);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureColorModFloat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, float* r, float* g, float* b);
	}

	/// <summary>
	/// Set an additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureAlphaMod">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="alpha"> The source alpha value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureAlphaMod(SDL_Texture* texture, byte alpha)
	{
		return _PInvoke(texture, alpha);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, byte alpha);
	}

	/// <summary>
	/// Set an additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureAlphaMod">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="alpha"> The source alpha value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureAlphaMod(SDL_Texture* texture, float alpha)
	{
		return _PInvoke(texture, alpha);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaModFloat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, float alpha);
	}

	/// <summary>
	/// Get the additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureAlphaMod">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="alpha"> Returns the current alpha value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureAlphaMod(SDL_Texture* texture, out byte alpha)
	{
		fixed (byte* a = &alpha)
		{
			return _PInvoke(texture, a);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaMod", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, byte* alpha);
	}

	/// <summary>
	/// Get the additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureAlphaMod">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="alpha"> Returns the current alpha value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureAlphaMod(SDL_Texture* texture, out float alpha)
	{
		fixed (float* a = &alpha)
		{
			return _PInvoke(texture, a);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaModFloat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, float* alpha);
	}

	/// <summary>
	/// Set the blend mode for a texture, used by <see cref="FIXME:SDL_RenderTexture"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureBlendMode">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="blendMode"> The <see cref="SDL_BlendMode"/> to use for texture blending. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode blendMode)
	{
		return _PInvoke(texture, blendMode);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureBlendMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_BlendMode blendMode);
	}

	/// <summary>
	/// Get the blend mode used for texture copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureBlendMode">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="blendMode"> Returns the current <see cref="SDL_BlendMode"/> </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureBlendMode(SDL_Texture* texture, out SDL_BlendMode blendMode)
	{
		fixed (SDL_BlendMode* b = &blendMode)
		{
			return _PInvoke(texture, b);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureBlendMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_BlendMode* blendMode);
	}

	/// <summary>
	/// Set the scale mode used for texture scale operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureScaleMode">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="scaleMode"> The <see cref="SDL_ScaleMode"/> to use for texture scaling. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode)
	{
		return _PInvoke(texture, scaleMode);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureScaleMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_ScaleMode scaleMode);
	}

	/// <summary>
	/// Get the scale mode used for texture scale operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureScaleMode">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="scaleMode"> Returns the current scale mode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureScaleMode(SDL_Texture* texture, out SDL_ScaleMode scaleMode)
	{
		fixed (SDL_ScaleMode* s = &scaleMode)
		{
			return _PInvoke(texture, s);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureScaleMode", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_ScaleMode* scaleMode);
	}

	/// <summary>
	/// Update the given texture rectangle with new pixel data.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateTexture">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="rect"> An <see cref="SDL_Rect"/> structure representing the area to update, or null to update the entire texture. </param>
	/// <param name="pixels"> The raw pixel data in the format of the texture. </param>
	/// <param name="pitch"> The number of bytes in a row of pixel data, including padding between lines. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int UpdateTexture(SDL_Texture* texture, SDL_Rect* rect, uint[] pixels, int pitch)
	{
		fixed (uint* p = pixels)
		{
			return _PInvoke(texture, rect, p, pitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateTexture", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_Rect* rect, uint* pixels, int pitch);
	}

	/// <summary>
	/// Update a rectangle within a planar YV12 or IYUV texture with new pixel data.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateYUVTexture">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="rect"> The rectangle of pixels to update, or null to update the entire texture. </param>
	/// <param name="yPlane"> The raw pixel data for the Y plane. </param>
	/// <param name="yPitch"> The number of bytes between rows of pixel data for the Y plane. </param>
	/// <param name="uPlane"> The raw pixel data for the U plane. </param>
	/// <param name="uPitch"> The number of bytes between rows of pixel data for the U plane </param>
	/// <param name="vPlane"> The raw pixel data for the V plane. </param>
	/// <param name="vPitch"> The number of bytes between rows of pixel data for the V plane. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int UpdateYUVTexture(SDL_Texture* texture, SDL_Rect* rect, byte[] yPlane, int yPitch, byte[] uPlane, int uPitch, byte[] vPlane, int vPitch)
	{
		fixed (byte* y = yPlane, u = uPlane, v = vPlane)
		{
			return _PInvoke(texture, rect, y, yPitch, u, uPitch, v, vPitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateYUVTexture", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_Rect* rect, byte* yPlane, int yPitch, byte* uPlane, int uPitch, byte* vPlane, int vPitch);
	}

	/// <summary>
	/// Update a rectangle within a planar NV12 or NV21 texture with new pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateNVTexture">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="rect"> The rectangle of pixels to update, or null to update the entire texture. </param>
	/// <param name="yPlane"> The raw pixel data for the Y plane. </param>
	/// <param name="yPitch"> The number of bytes between rows of pixel data for the Y plane. </param>
	/// <param name="uvPlane"> The raw pixel data for the UV plane. </param>
	/// <param name="uvPitch"> The number of bytes between rows of pixel data for the UV plane. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int UpdateUpdateNVTexture(SDL_Texture* texture, SDL_Rect* rect, byte[] yPlane, int yPitch, byte[] uvPlane, int uvPitch)
	{
		fixed (byte* y = yPlane, uv = uvPlane)
		{
			return _PInvoke(texture, rect, y, yPitch, uv, uvPitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateNVTexture", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_Rect* rect, byte* yPlane, int yPitch, byte* uvPlane, int uvPitch);
	}

	/// <summary>
	/// Lock a portion of the texture for <b>write-only</b> pixel access.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_LockTexture">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to lock for access, which was created with <see cref="SDL_TextureAccess.Streaming"/>. </param>
	/// <param name="rect"> An <see cref="SDL_Rect"/> structure representing the area to lock for access; null to lock the entire texture. </param>
	/// <param name="pixels"> Returns an array representing the locked pixels, appropriately offset by the locked area. </param>
	/// <param name="pitch"> Returns the pitch of the locked pixels; the pitch is the length of one row in bytes. </param>
	/// <returns> 0 on success or a negative error code if the texture is not valid or was not created with <see cref="SDL_TextureAccess.Streaming"/>; call <see cref="GetError"/> for more information. </returns>
	public static int LockTexture(SDL_Texture* texture, SDL_Rect* rect, out uint* pixels, out int pitch)
	{
		fixed (uint** p = &pixels)
		{
			fixed (int* i = &pitch)
			{
				return _PInvoke(texture, rect, p, i);
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_LockTexture", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_Rect* rect, uint** pixels, int* pitch);
	}

	/// <summary>
	/// Lock a portion of the texture for <b>write-only</b> pixel access, and expose it as a SDL surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_LockTextureToSurface">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to lock for access, which was created with <see cref="SDL_TextureAccess.Streaming"/>. </param>
	/// <param name="rect"> The rectangle to lock for access. If the rect is null, the entire texture will be locked. </param>
	/// <param name="surface"> Returns the SDL surface representing the locked area. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int LockTextureToSurface(SDL_Texture* texture, SDL_Rect* rect, out SDL_Surface* surface)
	{
		fixed (SDL_Surface** s = &surface)
		{
			return _PInvoke(texture, rect, s);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_LockTextureToSurface", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_Rect* rect, SDL_Surface** surface);
	}

	/// <summary>
	/// Unlock a texture, uploading the changes to video memory, if needed.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockTexture">here</see> for more details.
	/// </remarks>
	/// <param name="texture"> A texture locked by <see cref="LockTexture"/> </param>
	public static void UnlockTexture(SDL_Texture* texture)
	{
		_PInvoke(texture);

		[DllImport(LibraryName, EntryPoint = "SDL_UnlockTexture", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern void _PInvoke(SDL_Texture* texture);
	}

	/// <summary>
	/// Set a texture as the current rendering target.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderTarget">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="texture"> The targeted texture, which must be created with the <see cref="SDL_TextureAccess.Target"/> flag, or null to render to the window instead of a texture. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture)
	{
		return _PInvoke(renderer, texture);

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderTarget", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Renderer* renderer, SDL_Texture* texture);
	}

	/// <summary>
	/// Get the current render target.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderTarget">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> The current render target or null for the default render target. </returns>
	public static SDL_Texture* GetRenderTarget(SDL_Renderer* renderer)
	{
		return _PInvoke(renderer);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderTarget", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern SDL_Texture* _PInvoke(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Set a device independent resolution and presentation mode for rendering.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderLogicalPresentation">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> The width of the logical resolution. </param>
	/// <param name="height"> The height of the logical resolution. </param>
	/// <param name="mode"> The presentation mode used. </param>
	/// <param name="scaleMode"> The scale mode used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderLogicalPresentation(SDL_Renderer* renderer, int width, int height, SDL_RendererLogicalPresentation mode, SDL_ScaleMode scaleMode)
	{
		return _PInvoke(renderer, width, height, mode, scaleMode);

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderLogicalPresentation", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Renderer* renderer, int width, int height, SDL_RendererLogicalPresentation mode, SDL_ScaleMode scaleMode);
	}

	/// <summary>
	/// Get device independent resolution and presentation mode for rendering.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderLogicalPresentation">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> Returns the width. </param>
	/// <param name="height"> Returns the height </param>
	/// <param name="mode"> Returns the presentation mode. </param>
	/// <param name="scaleMode"> Returns the scale mode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderLogicalPresentation(SDL_Renderer* renderer, out int width, out int height, out SDL_RendererLogicalPresentation mode, out SDL_ScaleMode scaleMode)
	{
		fixed (int* w = &width, h = &height)
		{
			fixed (SDL_RendererLogicalPresentation* m = &mode)
			{
				fixed (SDL_ScaleMode* s = &scaleMode)
				{
					return _PInvoke(renderer, w, h, m, s);
				}
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderLogicalPresentation", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Renderer* renderer, int* width, int* height, SDL_RendererLogicalPresentation* mode, SDL_ScaleMode* scaleMode);
	}

	/// <summary>
	/// Get a point in render coordinates when given a point in window coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_RenderCoordinatesFromWindow">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="windowX"> The x coordinate in window coordinates. </param>
	/// <param name="windowY"> The y coordinate in window coordinates. </param>
	/// <param name="x"> Returns the x coordinate in render coordinates. </param>
	/// <param name="y"> Returns the y coordinate in render coordinates. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderCoordinatesFromWindow(SDL_Renderer* renderer, float windowX, float windowY, out float x, out float y)
	{
		fixed (float* xx = &x, yy = &y)
		{
			return _PInvoke(renderer, windowX, windowY, xx, yy);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesFromWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Renderer* renderer, float windowX, float windowY, float* x, float* y);
	}

	/// <summary>
	/// Get a point in window coordinates when given a point in render coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_RenderCoordinatesToWindow">here</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="x"> The x coordinate in render coordinates. </param>
	/// <param name="y"> The y coordinate in render coordinates. </param>
	/// <param name="windowX"> Returns the x coordinate in window coordinates. </param>
	/// <param name="windowY"> Returns the y coordinate in window coordinates. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, out float windowX, out float windowY)
	{
		fixed (float* wx = &windowX, wy = &windowY)
		{
			return _PInvoke(renderer, x, y, wx, wy);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesToWindow", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
		static extern int _PInvoke(SDL_Renderer* renderer, float x, float y, float* windowX, float* windowY);
	}

	// this function below is the bane of my existence (because of it i have to implement SDL_event.h
	// [that uses literally like >90% of the SDL library {i have to write bindings for all of that ;_;}]).

	/// <summary>
	/// The name of the software renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_SOFTWARE_RENDERER">here</see> for more details.
	/// </remarks>
	public const string SoftwareRenderer = "software";
}