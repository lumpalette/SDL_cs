using System;
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
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumRenderDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns> A number >= 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetNumRenderDrivers()
	{
		return _PInvoke();

		[DllImport(LibraryName, EntryPoint = "SDL_GetNumRenderDrivers", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke();
	}

	/// <summary>
	/// Use this function to get the name of a built in 2D rendering driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDriver">documentation</see> for more details.
	/// </remarks>
	/// <param name="index"> The index of the rendering driver; the value ranges from 0 to <see cref="GetNumRenderDrivers"/> - 1 </param>
	/// <returns> The name of the rendering driver at the requested index, or null if an invalid index was specified. </returns>
	public static string? GetRenderDriver(int index)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(index));

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderDriver", CallingConvention = CallingConvention.Cdecl)]
		static extern byte* _PInvoke(int index);
	}

	/// <summary>
	/// Create a window and default renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindowAndRenderer">documentation</see> for more details.
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
		fixed (byte* titlePtr = Encoding.UTF8.GetBytes(title))
		{
			fixed (SDL_Window** windowPtr = &window)
			{
				fixed (SDL_Renderer** rendererPtr = &renderer)
				{
					return _PInvoke(titlePtr, width, height, windowFlags, windowPtr, rendererPtr);
				}
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_CreateWindowAndRenderer", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(byte* title, int width, int height, SDL_WindowFlags windowFlags, SDL_Window** window, SDL_Renderer** renderer);
	}

	/// <summary>
	/// Create a 2D rendering context for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window where rendering is displayed. </param>
	/// <param name="name"> The name of the rendering driver to initialize, or null if it is not important. Defaults to null. </param>
	/// <returns> A valid rendering context or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Renderer* CreateRenderer(SDL_Window* window, string? name = null)
	{
		if (!string.IsNullOrWhiteSpace(name))
		{
			fixed (byte* namePtr = Encoding.UTF8.GetBytes(name))
			{
				return _PInvoke(window, namePtr);
			}
		}
		return _PInvoke(window, null);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateRenderer", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Renderer* _PInvoke(SDL_Window* window, byte* name);
	}

	/// <summary>
	/// Create a 2D rendering context for a window, with the specified properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateRendererWithProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props"> The properties to use. </param>
	/// <returns> A valid rendering context or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Renderer* CreateRendererWithProperties(SDL_PropertiesId props)
	{
		return _PInvoke(props);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateRendererWithProperties", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Renderer* _PInvoke(SDL_PropertiesId props);
	}

	/// <summary>
	/// Create a 2D software rendering context for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSoftwareRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface"> The <see cref="SDL_Surface"/> structure representing the surface where rendering is done. </param>
	/// <returns> A valid rendering context or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Renderer* CreateSoftwareRenderer(SDL_Surface* surface)
	{
		return _PInvoke(surface);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateSoftwareRenderer", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Renderer* _PInvoke(SDL_Surface* surface);
	}

	/// <summary>
	/// Get the renderer associated with a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The rendering context on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Renderer* GetRenderer(SDL_Window* window)
	{
		return _PInvoke(window);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderer", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Renderer* _PInvoke(SDL_Window* window);
	}

	/// <summary>
	/// Get the window associated with a renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer to query. </param>
	/// <returns> The window on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Window* GetRenderWindow(SDL_Renderer* renderer)
	{
		return _PInvoke(renderer);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Window* _PInvoke(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Get the name of a renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererName">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> The name of the selected renderer, or null if the renderer is invalid. </returns>
	public static string? GetRendererName(SDL_Renderer* renderer)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvoke(renderer));

		[DllImport(LibraryName, EntryPoint = "SDL_GetRendererName", CallingConvention = CallingConvention.Cdecl)]
		static extern byte* _PInvoke(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Get the properties associated with a renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetRendererProperties(SDL_Renderer* renderer)
	{
		return _PInvoke(renderer);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRendererProperties", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_PropertiesId _PInvoke(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Get the output size in pixels of a rendering context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderOutputSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> Returns the width in pixels. </param>
	/// <param name="height"> Returns the height in pixels. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderOutputSize(SDL_Renderer* renderer, out int width, out int height)
	{
		fixed (int* widthPtr = &width, hPtr = &height)
		{
			return _PInvoke(renderer, widthPtr, hPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderOutputSize", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, int* width, int* height);
	}

	/// <summary>
	/// Get the current output size in pixels of a rendering context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentRenderOutputSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> Returns the current width. </param>
	/// <param name="height"> Returns the current height. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetCurrentRenderOutputSize(SDL_Renderer* renderer, out int width, out int height)
	{
		fixed (int* widthPtr = &width, heightPtr = &height)
		{
			return _PInvoke(renderer, widthPtr, heightPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetCurrentRenderOutputSize", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, int* width, int* height);
	}

	/// <summary>
	/// Create a texture for a rendering context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="format"> One of the static properties in <see cref="SDL_PixelFormat"/>. </param>
	/// <param name="access"> One of the enumerated values in <see cref="SDL_TextureAccess"/>. </param>
	/// <param name="width"> The width of the texture in pixels. </param>
	/// <param name="height"> The height of the texture in pixels. </param>
	/// <returns> A pointer to the created texture or null if no rendering context was active, the format was unsupported, or the width or height were out of range; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Texture* CreateTexture(SDL_Renderer* renderer, SDL_PixelFormat format, SDL_TextureAccess access, int width, int height)
	{
		return _PInvoke(renderer, format, access, width, height);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateTexture", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Texture* _PInvoke(SDL_Renderer* renderer, SDL_PixelFormat format, SDL_TextureAccess access, int width, int height);
	}

	/// <summary>
	/// Create a texture from an existing surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTextureFromSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="surface"> the <see cref="SDL_Surface"/> structure containing pixel data used to fill the texture. </param>
	/// <returns> The created texture or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Texture* CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface)
	{
		return _PInvoke(renderer, surface);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateTextureFromSurface", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Texture* _PInvoke(SDL_Renderer* renderer, SDL_Surface* surface);
	}

	/// <summary>
	/// Create a texture for a rendering context with the specified properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTextureWithProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="props"> The properties to use. </param>
	/// <returns> A pointer to the created texture or null if no rendering context was active, the format was unsupported, or the width or height were out of range; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Texture* CreateTextureWithProperties(SDL_Renderer* renderer, SDL_PropertiesId props)
	{
		return _PInvoke(renderer, props);

		[DllImport(LibraryName, EntryPoint = "SDL_CreateTextureWithProperties", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Texture* _PInvoke(SDL_Renderer* renderer, SDL_PropertiesId props);
	}

	/// <summary>
	/// Get the properties associated with a texture.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <returns> A valid property ID on success or 0 on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_PropertiesId GetTextureProperties(SDL_Texture* texture)
	{
		return _PInvoke(texture);

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureProperties", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_PropertiesId _PInvoke(SDL_Texture* texture);
	}

	/// <summary>
	/// Get the renderer that created An <see cref="SDL_Texture"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererFromTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <returns> A pointer to the SDL_Renderer that created the texture, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Renderer* GetRendererFromTexture(SDL_Texture* texture)
	{
		return _PInvoke(texture);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRendererFromTexture", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Renderer* _PInvoke(SDL_Texture* texture);
	}

	/// <summary>
	/// Get the size of a texture, as floating point values.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="width"> Returns the width of the texture in pixels. </param>
	/// <param name="height"> Returns the height of the texture in pixels. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureSize(SDL_Texture* texture, out float width, out float height)
	{
		fixed (float* widthPtr = &width, heightPtr = &height)
		{
			return _PInvoke(texture, widthPtr, heightPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureSize", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, float* width, float* height);
	}

	/// <summary>
	/// Set an additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="r"> The red color value multiplied into copy operations. </param>
	/// <param name="g"> The green color value multiplied into copy operations. </param>
	/// <param name="b"> The blue color value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureColorMod(SDL_Texture* texture, byte r, byte g, byte b)
	{
		return _PInvoke(texture, r, g, b);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureColorMod", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, byte r, byte g, byte b);
	}

	/// <summary>
	/// Set an additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorModFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="r"> The red color value multiplied into copy operations. </param>
	/// <param name="g"> The green color value multiplied into copy operations. </param>
	/// <param name="b"> The blue color value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureColorModFloat(SDL_Texture* texture, float r, float g, float b)
	{
		return _PInvoke(texture, r, g, b);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureColorModFloat", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, float r, float g, float b);
	}

	/// <summary>
	/// Get the additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureColorMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="r"> Returns the current red color value. </param>
	/// <param name="g"> Returns the current green color value. </param>
	/// <param name="b"> Returns the current blue color value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureColorMod(SDL_Texture* texture, out byte r, out byte g, out byte b)
	{
		fixed (byte* rPtr = &r, gPtr = &g, bPtr = &b)
		{
			return _PInvoke(texture, rPtr, gPtr, bPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureColorMod", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, byte* r, byte* g, byte* b);
	}

	/// <summary>
	/// Get the additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureColorModFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="r"> Returns the current red color value. </param>
	/// <param name="g"> Returns the current green color value. </param>
	/// <param name="b"> Returns the current blue color value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureColorMod(SDL_Texture* texture, out float r, out float g, out float b)
	{
		fixed (float* rPtr = &r, gPtr = &g, bPtr = &b)
		{
			return _PInvoke(texture, rPtr, gPtr, bPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureColorModFloat", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, float* r, float* g, float* b);
	}

	/// <summary>
	/// Set an additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureAlphaMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="alpha"> The source alpha value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureAlphaMod(SDL_Texture* texture, byte alpha)
	{
		return _PInvoke(texture, alpha);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaMod", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, byte alpha);
	}

	/// <summary>
	/// Set an additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureAlphaMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="alpha"> The source alpha value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureAlphaMod(SDL_Texture* texture, float alpha)
	{
		return _PInvoke(texture, alpha);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaModFloat", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, float alpha);
	}

	/// <summary>
	/// Get the additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureAlphaMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="alpha"> Returns the current alpha value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureAlphaMod(SDL_Texture* texture, out byte alpha)
	{
		fixed (byte* alphaPtr = &alpha)
		{
			return _PInvoke(texture, alphaPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaMod", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, byte* alpha);
	}

	/// <summary>
	/// Get the additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureAlphaMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="alpha"> Returns the current alpha value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureAlphaMod(SDL_Texture* texture, out float alpha)
	{
		fixed (float* alphaPtr = &alpha)
		{
			return _PInvoke(texture, alphaPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaModFloat", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, float* alpha);
	}

	/// <summary>
	/// Set the blend mode for a texture, used by <see cref="FIXME:SDL_RenderTexture"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="blendMode"> The <see cref="SDL_BlendMode"/> to use for texture blending. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode blendMode)
	{
		return _PInvoke(texture, blendMode);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureBlendMode", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_BlendMode blendMode);
	}

	/// <summary>
	/// Get the blend mode used for texture copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="blendMode"> Returns the current <see cref="SDL_BlendMode"/> </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureBlendMode(SDL_Texture* texture, out SDL_BlendMode blendMode)
	{
		fixed (SDL_BlendMode* blendModePtr = &blendMode)
		{
			return _PInvoke(texture, blendModePtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureBlendMode", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_BlendMode* blendMode);
	}

	/// <summary>
	/// Set the scale mode used for texture scale operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureScaleMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="scaleMode"> The <see cref="SDL_ScaleMode"/> to use for texture scaling. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode)
	{
		return _PInvoke(texture, scaleMode);

		[DllImport(LibraryName, EntryPoint = "SDL_SetTextureScaleMode", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_ScaleMode scaleMode);
	}

	/// <summary>
	/// Get the scale mode used for texture scale operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureScaleMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="scaleMode"> Returns the current scale mode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureScaleMode(SDL_Texture* texture, out SDL_ScaleMode scaleMode)
	{
		fixed (SDL_ScaleMode* scaleModePtr = &scaleMode)
		{
			return _PInvoke(texture, scaleModePtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetTextureScaleMode", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_ScaleMode* scaleMode);
	}

	/// <summary>
	/// Update the given texture rectangle with new pixel data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="rect"> An <see cref="SDL_Rect"/> structure representing the area to update, or null to update the entire texture. </param>
	/// <param name="pixels"> The raw pixel data in the format of the texture. </param>
	/// <param name="pitch"> The number of bytes in a row of pixel data, including padding between lines. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int UpdateTexture(SDL_Texture* texture, SDL_Rect* rect, void* pixels, int pitch)
	{
		return _PInvoke(texture, rect, pixels, pitch);

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateTexture", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_Rect* rect, void* pixels, int pitch);
	}

	/// <summary>
	/// Update a rectangle within a planar YV12 or IYUV texture with new pixel data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateYUVTexture">documentation</see> for more details.
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
		fixed (byte* yPlanePtr = yPlane, uPlanePtr = uPlane, vPlanePtr = vPlane)
		{
			return _PInvoke(texture, rect, yPlanePtr, yPitch, uPlanePtr, uPitch, vPlanePtr, vPitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateYUVTexture", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_Rect* rect, byte* yPlane, int yPitch, byte* uPlane, int uPitch, byte* vPlane, int vPitch);
	}

	/// <summary>
	/// Update a rectangle within a planar NV12 or NV21 texture with new pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateNVTexture">documentation</see> for more details.
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
		fixed (byte* yPlanePtr = yPlane, uvPlanePtr = uvPlane)
		{
			return _PInvoke(texture, rect, yPlanePtr, yPitch, uvPlanePtr, uvPitch);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_UpdateNVTexture", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_Rect* rect, byte* yPlane, int yPitch, byte* uvPlane, int uvPitch);
	}

	/// <summary>
	/// Lock a portion of the texture for <b>write-only</b> pixel access.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to lock for access, which was created with <see cref="SDL_TextureAccess.Streaming"/>. </param>
	/// <param name="rect"> An <see cref="SDL_Rect"/> structure representing the area to lock for access; null to lock the entire texture. </param>
	/// <param name="pixels"> Returns an array representing the locked pixels, appropriately offset by the locked area. </param>
	/// <param name="pitch"> Returns the pitch of the locked pixels; the pitch is the length of one row in bytes. </param>
	/// <returns> 0 on success or a negative error code if the texture is not valid or was not created with <see cref="SDL_TextureAccess.Streaming"/>; call <see cref="GetError"/> for more information. </returns>
	public static int LockTexture(SDL_Texture* texture, SDL_Rect* rect, out void* pixels, out int pitch)
	{
		fixed (void** pixelsPtr = &pixels)
		{
			fixed (int* pitchPtr = &pitch)
			{
				return _PInvoke(texture, rect, pixelsPtr, pitchPtr);
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_LockTexture", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_Rect* rect, void** pixels, int* pitch);
	}

	/// <summary>
	/// Lock a portion of the texture for <b>write-only</b> pixel access, and expose it as a SDL surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockTextureToSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to lock for access, which was created with <see cref="SDL_TextureAccess.Streaming"/>. </param>
	/// <param name="rect"> The rectangle to lock for access. If the rect is null, the entire texture will be locked. </param>
	/// <param name="surface"> Returns the SDL surface representing the locked area. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int LockTextureToSurface(SDL_Texture* texture, SDL_Rect* rect, out SDL_Surface* surface)
	{
		fixed (SDL_Surface** surfacePtr = &surface)
		{
			return _PInvoke(texture, rect, surfacePtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_LockTextureToSurface", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Texture* texture, SDL_Rect* rect, SDL_Surface** surface);
	}

	/// <summary>
	/// Unlock a texture, uploading the changes to video memory, if needed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> A texture locked by <see cref="LockTexture"/> </param>
	public static void UnlockTexture(SDL_Texture* texture)
	{
		_PInvoke(texture);

		[DllImport(LibraryName, EntryPoint = "SDL_UnlockTexture", CallingConvention = CallingConvention.Cdecl)]
		static extern void _PInvoke(SDL_Texture* texture);
	}

	/// <summary>
	/// Set a texture as the current rendering target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderTarget">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="texture"> The targeted texture, which must be created with the <see cref="SDL_TextureAccess.Target"/> flag, or null to render to the window instead of a texture. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture)
	{
		return _PInvoke(renderer, texture);

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderTarget", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, SDL_Texture* texture);
	}

	/// <summary>
	/// Get the current render target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderTarget">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> The current render target or null for the default render target. </returns>
	public static SDL_Texture* GetRenderTarget(SDL_Renderer* renderer)
	{
		return _PInvoke(renderer);

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderTarget", CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Texture* _PInvoke(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Set a device independent resolution and presentation mode for rendering.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderLogicalPresentation">documentation</see> for more details.
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

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderLogicalPresentation", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, int width, int height, SDL_RendererLogicalPresentation mode, SDL_ScaleMode scaleMode);
	}

	/// <summary>
	/// Get device independent resolution and presentation mode for rendering.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderLogicalPresentation">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> Returns the width. </param>
	/// <param name="height"> Returns the height </param>
	/// <param name="mode"> Returns the presentation mode. </param>
	/// <param name="scaleMode"> Returns the scale mode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderLogicalPresentation(SDL_Renderer* renderer, out int width, out int height, out SDL_RendererLogicalPresentation mode, out SDL_ScaleMode scaleMode)
	{
		fixed (int* widthPtr = &width, heightPtr = &height)
		{
			fixed (SDL_RendererLogicalPresentation* modePtr = &mode)
			{
				fixed (SDL_ScaleMode* scaleModePtr = &scaleMode)
				{
					return _PInvoke(renderer, widthPtr, heightPtr, modePtr, scaleModePtr);
				}
			}
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderLogicalPresentation", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, int* width, int* height, SDL_RendererLogicalPresentation* mode, SDL_ScaleMode* scaleMode);
	}

	/// <summary>
	/// Get a point in render coordinates when given a point in window coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderCoordinatesFromWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="windowX"> The x coordinate in window coordinates. </param>
	/// <param name="windowY"> The y coordinate in window coordinates. </param>
	/// <param name="x"> Returns the x coordinate in render coordinates. </param>
	/// <param name="y"> Returns the y coordinate in render coordinates. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderCoordinatesFromWindow(SDL_Renderer* renderer, float windowX, float windowY, out float x, out float y)
	{
		fixed (float* xPtr = &x, yPtr = &y)
		{
			return _PInvoke(renderer, windowX, windowY, xPtr, yPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesFromWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, float windowX, float windowY, float* x, float* y);
	}

	/// <summary>
	/// Get a point in window coordinates when given a point in render coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderCoordinatesToWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="x"> The x coordinate in render coordinates. </param>
	/// <param name="y"> The y coordinate in render coordinates. </param>
	/// <param name="windowX"> Returns the x coordinate in window coordinates. </param>
	/// <param name="windowY"> Returns the y coordinate in window coordinates. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, out float windowX, out float windowY)
	{
		fixed (float* windowXPtr = &windowX, windowYPtr = &windowY)
		{
			return _PInvoke(renderer, x, y, windowXPtr, windowYPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesToWindow", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, float x, float y, float* windowX, float* windowY);
	}

	// this function below is the bane of my existence (because of it i have to implement SDL_event.h
	// [that uses literally like >90% of the SDL library {i have to write bindings for all of that ;_;}]).

	/// <summary>
	/// Convert the coordinates in an event to render coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertEventToRenderCoordinates">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="e"> The event to modify. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* e)
	{
		return _PInvoke(renderer, e);

		[DllImport(LibraryName, EntryPoint = "SDL_ConvertEventToRenderCoordinates", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, SDL_Event* e);
	}

	// finally done! let's continue.

	/// <summary>
	/// Set the drawing area for rendering on the current target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderViewport">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="rect"> The <see cref="SDL_Rect"/> structure representing the drawing area, or null </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect)
	{
		return _PInvoke(renderer, rect);

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderViewport", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, SDL_Rect* rect);
	}

	/// <summary>
	/// Get the drawing area for the current target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderViewport">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="rect"> Returns an <see cref="SDL_Rect"/> with the current drawing area. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderViewport(SDL_Renderer* renderer, out SDL_Rect rect)
	{
		fixed (SDL_Rect* rectPtr = &rect)
		{
			return _PInvoke(renderer, rectPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderViewport", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, SDL_Rect* rect);
	}

	/// <summary>
	/// Return whether an explicit rectangle was set as the viewport.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderViewportSet">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> True if the viewport was set to a specific rectangle, or false if it was set to null (the entire target). </returns>
	public static bool RenderViewportSet(SDL_Renderer* renderer)
	{
		return _PInvoke(renderer) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_RenderViewportSet", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Set the clip rectangle for rendering on the specified target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderClipRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="rect"> An <see cref="SDL_Rect"/> structure representing the clip area, relative to the viewport, or null to disable clipping. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect)
	{
		return _PInvoke(renderer, rect);

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderClipRect", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, SDL_Rect* rect);
	}

	/// <summary>
	/// Get the clip rectangle for the current target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderClipRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="rect"> An <see cref="SDL_Rect"/> structure filled in with the current clipping area or an empty rectangle if clipping is disabled. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderClipRect(SDL_Renderer* renderer, out SDL_Rect rect)
	{
		fixed (SDL_Rect* rectPtr = &rect)
		{
			return _PInvoke(renderer, rectPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderClipRect", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, SDL_Rect* rect);
	}

	/// <summary>
	/// Get whether clipping is enabled on the given renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderClipEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> True if clipping is enabled or false if not. </returns>
	public static bool RenderClipEnabled(SDL_Renderer* renderer)
	{
		return _PInvoke(renderer) == 1;

		[DllImport(LibraryName, EntryPoint = "SDL_RenderClipEnabled", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Set the drawing scale for rendering on the current target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="scaleX"> The horizontal scaling factor. </param>
	/// <param name="scaleY"> The vertical scaling factor. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY)
	{
		return _PInvoke(renderer, scaleX, scaleY);

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderScale", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, float scaleX, float scaleY);
	}

	/// <summary>
	/// Get the drawing scale for the current target.
	/// </summary>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="scaleX"> Returns the horizontal scaling factor. </param>
	/// <param name="scaleY"> Returns the vertical scaling factor. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderScale(SDL_Renderer* renderer, out float scaleX, out float scaleY)
	{
		fixed (float* scaleXPtr = &scaleX, scaleYPtr = &scaleY)
		{
			return _PInvoke(renderer, scaleXPtr, scaleYPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderScale", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, float* scaleX, float* scaleY);
	}

	/// <summary>
	/// Set the color used for drawing operations (Rect, Line and Clear).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderDrawColor">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="r"> The red value used to draw on the rendering target. </param>
	/// <param name="g"> The green value used to draw on the rendering target. </param>
	/// <param name="b"> The blue value used to draw on the rendering target. </param>
	/// <param name="a"> The alpha value used to draw on the rendering target. Use <see cref="FIXME:SetRenderDrawBlendMode"/> to specify how the alpha channel is used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderDrawColor(SDL_Renderer* renderer, byte r, byte g, byte b, byte a)
	{
		return _PInvoke(renderer, r, g, b, a);

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderDrawColor", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, byte r, byte g, byte b, byte a);
	}

	/// <summary>
	/// Set the color used for drawing operations (Rect, Line and Clear).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderDrawColor">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="r"> The red value used to draw on the rendering target. </param>
	/// <param name="g"> The green value used to draw on the rendering target. </param>
	/// <param name="b"> The blue value used to draw on the rendering target. </param>
	/// <param name="a"> The alpha value used to draw on the rendering target. Use <see cref="FIXME:SetRenderDrawBlendMode"/> to specify how the alpha channel is used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderDrawColorFloat(SDL_Renderer* renderer, float r, float g, float b, float a)
	{
		return _PInvoke(renderer, r, g, b, a);

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderDrawColor", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, float r, float g, float b, float a);
	}

	/// <summary>
	/// Get the color used for drawing operations (Rect, Line and Clear).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDrawColor">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="r"> Returns the red value used to draw on the rendering target. </param>
	/// <param name="g"> Returns the green value used to draw on the rendering target. </param>
	/// <param name="b"> Returns the blue value used to draw on the rendering target. </param>
	/// <param name="a"> Returns the alpha value used to draw on the rendering target; usually <see cref="AlphaOpaque"/> (255). </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderDrawColor(SDL_Renderer* renderer, out byte r, out byte g, out byte b, out byte a)
	{
		fixed (byte* rPtr = &r, gPtr = &g, bPtr = &b, aPtr = &a)
		{
			return _PInvoke(renderer, rPtr, gPtr, bPtr, aPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderDrawColor", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, byte* r, byte* g, byte* b, byte* a);
	}

	/// <summary>
	/// Get the color used for drawing operations (Rect, Line and Clear).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDrawColor">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="r"> Returns the red value used to draw on the rendering target. </param>
	/// <param name="g"> Returns the green value used to draw on the rendering target. </param>
	/// <param name="b"> Returns the blue value used to draw on the rendering target. </param>
	/// <param name="a"> Returns the alpha value used to draw on the rendering target; usually <see cref="AlphaOpaque"/> (255). </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderDrawColorFloat(SDL_Renderer* renderer, out float r, out float g, out float b, out float a)
	{
		fixed (float* rPtr = &r, gPtr = &g, bPtr = &b, aPtr = &a)
		{
			return _PInvoke(renderer, rPtr, gPtr, bPtr, aPtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_GetRenderDrawColor", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, float* r, float* g, float* b, float* a);
	}

	/// <summary>
	/// Set the color scale used for render operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderColorScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="scale"> The color scale value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderColorScale(SDL_Renderer* renderer, float scale)
	{
		return _PInvoke(renderer, scale);

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderColorScale", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, float scale);
	}

	/// <summary>
	/// Get the color scale used for render operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderColorScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="scale"> Returns the current color scale value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderColorScale(SDL_Renderer* renderer, out float scale)
	{
		fixed (float* scalePtr = &scale)
		{
			return _PInvoke(renderer, scalePtr);
		}

		[DllImport(LibraryName, EntryPoint = "SDL_SetRenderColorScale", CallingConvention = CallingConvention.Cdecl)]
		static extern int _PInvoke(SDL_Renderer* renderer, float* scale);
	}

	/// <summary>
	/// Set the blend mode used for drawing operations (Fill and Line).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderDrawBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="blendMode"> The <see cref="SDL_BlendMode"/> to use for blending. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode blendMode)
	{
		return SDL_SetRenderDrawBlendMode(renderer, blendMode);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_SetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode blendMode);
	}

	/// <summary>
	/// Get the blend mode used for drawing operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDrawBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="blendMode"> Returns the current <see cref="SDL_BlendMode"/>. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderDrawBlendMode(SDL_Renderer* renderer, out SDL_BlendMode blendMode)
	{
		fixed (SDL_BlendMode* blendModePtr = &blendMode)
		{
			return SDL_GetRenderDrawBlendMode(renderer, blendModePtr);
		}

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_GetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode* blendMode);
	}

	/// <summary>
	/// Clear the current rendering target with the drawing color.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderClear">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderClear(SDL_Renderer* renderer)
	{
		return SDL_RenderClear(renderer);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderClear(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Draw a point on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderPoint">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer which should draw a point. </param>
	/// <param name="x"> The x coordinate of the point. </param>
	/// <param name="y"> The y coordinate of the point. </param>
	/// <returns> 0 on success, or -1 on error. </returns>
	public static int RenderPoint(SDL_Renderer* renderer, float x, float y)
	{
		return SDL_RenderPoint(renderer, x, y);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderPoint(SDL_Renderer* renderer, float x, float y);
	}

	/// <summary>
	/// Draw multiple points on the current rendering target at subpixel precision.
	/// </summary>
	/// <param name="renderer"> The renderer which should draw multiple points. </param>
	/// <param name="points"> The points to draw. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderPoints(SDL_Renderer* renderer, SDL_FPoint[] points)
	{
		fixed (SDL_FPoint* pointsPtr = points)
		{
			return SDL_RenderPoints(renderer, pointsPtr, points.Length);
		}

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderPoints(SDL_Renderer* renderer, SDL_FPoint* points, int count);
	}

	/// <summary>
	/// Draw a line on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderLine">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer which should draw a line. </param>
	/// <param name="x1"> The x coordinate of the start point. </param>
	/// <param name="y1"> The y coordinate of the start point. </param>
	/// <param name="x2"> The x coordinate of the end point. </param>
	/// <param name="y2"> The y coordinate of the end point. </param>
	/// <returns> 0 on success, or -1 on error. </returns>
	public static int RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2)
	{
		return SDL_RenderLine(renderer, x1, y1, x2, y2);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);
	}

	/// <summary>
	/// Draw a series of connected lines on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderLines">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer which should draw multiple lines. </param>
	/// <param name="points"> The points along the lines. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderLines(SDL_Renderer* renderer, SDL_FPoint[] points)
	{
		fixed (SDL_FPoint* pointsPtr = points)
		{
			return SDL_RenderLines(renderer, pointsPtr, points.Length);
		}

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderLines(SDL_Renderer* renderer, SDL_FPoint* points, int count);
	}

	/// <summary>
	/// Draw a rectangle on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer which should draw a rectangle. </param>
	/// <param name="rect"> A pointer to the destination rectangle, or null to outline the entire rendering target. </param>
	/// <returns> 0 on success, or -1 on error. </returns>
	public static int RenderRect(SDL_Renderer* renderer, SDL_FRect* rect)
	{
		return SDL_RenderRect(renderer, rect);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderRect(SDL_Renderer* renderer, SDL_FRect* rect);
	}

	/// <summary>
	/// Draw some number of rectangles on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderRects">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer which should draw multiple rectangles. </param>
	/// <param name="rects"> An array of destination rectangles. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderRects(SDL_Renderer* renderer, SDL_FRect[] rects)
	{
		fixed (SDL_FRect* rectsPtr = rects)
		{
			return SDL_RenderRects(renderer, rectsPtr, rects.Length);
		}

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderRects(SDL_Renderer* renderer, SDL_FRect* rects, int count);
	}

	/// <summary>
	/// Fill a rectangle on the current rendering target with the drawing color at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/RenderFillRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer which should fill a rectangle. </param>
	/// <param name="rect"> A pointer to the destination rectangle, or null for the entire rendering target. </param>
	/// <returns> 0 on success, or -1 on error. </returns>
	public static int RenderFillRect(SDL_Renderer* renderer, SDL_FRect* rect)
	{
		return SDL_RenderFillRect(renderer, rect);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderFillRect(SDL_Renderer* renderer, SDL_FRect* rect);
	}

	/// <summary>
	/// Fill some number of rectangles on the current rendering target with the drawing color at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderFillRects">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer which should fill multiple rectangles. </param>
	/// <param name="rects"> A pointer to an array of destination rectangles. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderFillRects(SDL_Renderer* renderer, SDL_FRect[] rects)
	{
		fixed (SDL_FRect* rectsPtr = rects)
		{
			return SDL_RenderFillRects(renderer, rectsPtr, rects.Length);
		}

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderFillRects(SDL_Renderer* renderer, SDL_FRect* rects, int count);
	}

	/// <summary>
	/// Copy a portion of the texture to the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer which should copy parts of a texture. </param>
	/// <param name="texture"> The source texture. </param>
	/// <param name="srcRect"> A pointer to the source rectangle, or null for the entire texture. </param>
	/// <param name="dstRect"> A pointer to the destination rectangle, or null for the entire rendering target. </param>
	/// <returns> 0 on success, or -1 on error. </returns>
	public static int RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcRect, SDL_FRect* dstRect)
	{
		return SDL_RenderTexture(renderer, texture, srcRect, dstRect);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcRect, SDL_FRect* dstRect);
	}

	/// <summary>
	/// Copy a portion of the source texture to the current rendering target, with rotation and flipping, at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderTextureRotated">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer which should copy parts of a texture. </param>
	/// <param name="texture"> The source texture. </param>
	/// <param name="srcRect"> A pointer to the source rectangle, or null for the entire texture. </param>
	/// <param name="dstRect"> A pointer to the destination rectangle, or null for the entire rendering target. </param>
	/// <param name="angle"> An angle in degrees that indicates the rotation that will be applied to dstrect, rotating it in a clockwise direction. </param>
	/// <param name="center"> A pointer to a point indicating the point around which dstrect will be rotated (if null, rotation will be done around the center of <paramref name="dstRect"/>). </param>
	/// <param name="flip"> An <see cref="SDL_FlipMode"/> value stating which flipping actions should be performed on the texture. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcRect, SDL_FRect* dstRect, double angle, SDL_FPoint* center, SDL_FlipMode flip)
	{
		return SDL_RenderTextureRotated(renderer, texture, srcRect, dstRect, angle, center, flip);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, SDL_FRect* srcRect, SDL_FRect* dstRect, double angle, SDL_FPoint* center, SDL_FlipMode flip);
	}

	/// <summary>
	/// Render a list of triangles, optionally using a texture and indices into the vertex array Color and alpha modulation
	/// is done per vertex (SDL.SetTextureColorMod and SDL.SetTextureAlphaMod are ignored).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderGeometry">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="texture"> The SDL texture to use. Can be null. </param>
	/// <param name="vertices"> Vertices. </param>
	/// <param name="indices"> An array of integer indices into the <paramref name="vertices"/> array, if null all vertices will be rendered in sequential order. Defaults to null. </param>
	/// <returns> 0 on success, or -1 if the operation is not supported. </returns>
	public static int RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, SDL_Vertex[] vertices, int[]? indices = null)
	{
		fixed (SDL_Vertex* verticesPtr = vertices)
		{
			if (indices is not null)
			{
				fixed (int* indicesPtr = indices)
				{
					return SDL_RenderGeometry(renderer, texture, verticesPtr, vertices.Length, indicesPtr, indices.Length);
				}
			}
			return SDL_RenderGeometry(renderer, texture, verticesPtr, vertices.Length, null, 0);
		}

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, SDL_Vertex* vertices, int numVertices, int* indices, int numIndices);
	}

	// FIXME: implement this function having 3 overloads, representing each 'indices' size.
	//public static int RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, float[] xy, int xyStride, SDL_Color[] vertexColors, int colorStride, float[] uv, int uvStride, )

	/// <summary>
	/// Read pixels from the current rendering target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderReadPixels">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="rect"> An <see cref="SDL_Rect"/> structure representing the area in pixels relative to the to current viewport, or null for the entire viewport. </param>
	/// <returns> A new <see cref="SDL_Surface"/> on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static SDL_Surface* RenderReadPixels(SDL_Renderer* renderer, SDL_Rect* rect)
	{
		return SDL_RenderReadPixels(renderer, rect);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern SDL_Surface* SDL_RenderReadPixels(SDL_Renderer* renderer, SDL_Rect* rect);
	}

	/// <summary>
	/// Update the screen with any rendering performed since the previous call.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderPresent">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderPresent(SDL_Renderer* renderer)
	{
		return SDL_RenderPresent(renderer);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_RenderPresent(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Destroy the specified texture.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"> The texture to destroy. </param>
	public static void DestroyTexture(SDL_Texture* texture)
	{
		SDL_DestroyTexture(texture);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern void SDL_DestroyTexture(SDL_Texture* texture);
	}

	/// <summary>
	/// Destroy the rendering context for a window and free associated textures.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	public static void DestroyRenderer(SDL_Renderer* renderer)
	{
		SDL_DestroyRenderer(renderer);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern void SDL_DestroyRenderer(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Force the rendering context to flush any pending commands and state.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlushRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int FlushRenderer(SDL_Renderer* renderer)
	{
		return SDL_FlushRenderer(renderer);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_FlushRenderer(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Get the CAMetalLayer associated with the given Metal renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderMetalLayer">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer to query. </param>
	/// <returns> a CAMetalLayer* on success, or null if the renderer isn't a Metal renderer. </returns>
	public static void* GetRenderMetalLayer(SDL_Renderer* renderer)
	{
		return SDL_GetRenderMetalLayer(renderer);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern void* SDL_GetRenderMetalLayer(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Get the Metal command encoder for the current frame.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderMetalCommandEncoder">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"></param>
	/// <returns> An id&lt;MTLRenderCommandEncoder&gt; on success, or null if the renderer isn't a Metal renderer or there was an error. </returns>
	public static void* GetRenderMetalCommandEncoder(SDL_Renderer* renderer)
	{
		return SDL_GetRenderMetalCommandEncoder(renderer);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern void* SDL_GetRenderMetalCommandEncoder(SDL_Renderer* renderer);
	}

	/// <summary>
	/// Add a set of synchronization semaphores for the current frame.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddVulkanRenderSemaphores">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="waitStageMask"> The VkPipelineStageFlags for the wait. </param>
	/// <param name="waitSemaphore"> A VkSempahore to wait on before rendering the current frame, or 0 if not needed. </param>
	/// <param name="signalSemaphore"> A VkSempahore that SDL will signal when rendering for the current frame is complete, or 0 if not needed. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int AddVulkanRenderSemaphores(SDL_Renderer* renderer, uint waitStageMask, long waitSemaphore, long signalSemaphore)
	{
		return SDL_AddVulkanRenderSemaphores(renderer, waitStageMask, waitSemaphore, signalSemaphore);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_AddVulkanRenderSemaphores(SDL_Renderer* renderer, uint waitStageMask, long waitSemaphore, long signalSemaphore);
	}

	/// <summary>
	/// Toggle VSync of the given renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderVSync">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer to toggle. </param>
	/// <param name="vsync"> The vertical refresh sync interval. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderVSync(SDL_Renderer* renderer, int vsync)
	{
		return SDL_SetRenderVSync(renderer, vsync);

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_SetRenderVSync(SDL_Renderer* renderer, int vsync);
	}

	/// <summary>
	/// Get VSync of the given renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderVSync">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"> The renderer to toggle. </param>
	/// <param name="vsync"> Returns the current vertical refresh sync interval. See <see cref="SetRenderVSync(SDL_Renderer*, int)"/> for the meaning of the value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderVSync(SDL_Renderer* renderer, out int vsync)
	{
		fixed (int* vsyncPtr = &vsync)
		{
			return SDL_GetRenderVSync(renderer, vsyncPtr);
		}

		[DllImport(LibraryName, CallingConvention = CallingConvention.Cdecl)]
		static extern int SDL_GetRenderVSync(SDL_Renderer* renderer, int* vsync);
	}

	/// <summary>
	/// The name of the software renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SOFTWARE_RENDERER">documentation</see> for more details.
	/// </remarks>
	public const string SoftwareRenderer = "software";

	public const int RendererVSyncDisabled = 0;

	public const int RendererVSyncAdaptive = -1;
}