using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

// SDL_render.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_render.h
public static unsafe partial class SDL
{
	/// <summary>
	/// Get the number of 2D rendering drivers available for the current display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumRenderDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns>The number of built in render drivers.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumRenderDrivers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetNumRenderDrivers();

	/// <summary>
	/// Use this function to get the name of a built in 2D rendering driver.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDriver">documentation</see> for more details.
	/// </remarks>
	/// <param name="index">The index of the rendering driver; the value ranges from 0 to <see cref="GetNumRenderDrivers"/> - 1.</param>
	/// <returns>The name of the rendering driver at the requested index, or <see langword="null"/> if an invalid index was specified.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDriver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetRenderDriver(int index);

	/// <summary>
	/// Create a window and default renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindowAndRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="title">The title of the window.</param>
	/// <param name="width">The width of the window.</param>
	/// <param name="height">The height of the window.</param>
	/// <param name="windowFlags">The flags used to create the window (see <see cref="CreateWindow(string, int, int, SDL_WindowFlags)"/> for details).</param>
	/// <param name="window">A pointer filled with the window, or <see langword="null"/> on error.</param>
	/// <param name="renderer">A pointer filled with the renderer, or <see langword="null"/> on error.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindowAndRenderer", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool CreateWindowAndRenderer(string title, int width, int height, SDL_WindowFlags windowFlags, SDL_Window** window, SDL_Renderer** renderer);

	/// <summary>
	/// Create a 2D rendering context for a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window where rendering is displayed.</param>
	/// <param name="name">The name of the rendering driver to initialize, or <see langword="null"/> to initialize the first one supporting the requested flags.</param>
	/// <returns>A valid rendering context or <see langword="null"/> if there was an error; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateRenderer", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Renderer* CreateRenderer(SDL_Window* window, string? name);

	/// <summary>
	/// Create a 2D rendering context for a window, with the specified properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateRendererWithProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to use.</param>
	/// <returns>A valid rendering context or <see langword="null"/> if there was an error; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateRendererWithProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Renderer* CreateRendererWithProperties(SDL_PropertiesId props);

	/// <summary>
	/// Create a 2D software rendering context for a surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSoftwareRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure representing the surface where rendering is done.</param>
	/// <returns>A valid rendering context or <see langword="null"/> if there was an error; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateSoftwareRenderer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Renderer* CreateSoftwareRenderer(SDL_Surface* surface);

	/// <summary>
	/// Get the renderer associated with a window.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/GetRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="window">The window to query.</param>
	/// <returns>The rendering context on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Renderer* GetRenderer(SDL_Window* window);

	/// <summary>
	/// Get the window associated with a renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/GetRenderWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer to query.</param>
	/// <returns>The window on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Window* GetRenderWindow(SDL_Renderer* renderer);

	/// <summary>
	/// Get the name of a renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererName">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <returns>The name of the selected renderer, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRendererName")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string? GetRendererName(SDL_Renderer* renderer);

	/// <summary>
	/// Get the properties associated with a renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRendererProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetRendererProperties(SDL_Renderer* renderer);

	/// <summary>
	/// Get the output size in pixels of a rendering context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderOutputSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="width">A pointer filled in with the width in pixels.</param>
	/// <param name="height">A pointer filled in with the height in pixels.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderOutputSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderOutputSize(SDL_Renderer* renderer, int* width, int* height);

	/// <summary>
	/// Get the current output size in pixels of a rendering context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentRenderOutputSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="width">A pointer filled in with the current width.</param>
	/// <param name="height">A pointer filled in with the current height.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentRenderOutputSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetCurrentRenderOutputSize(SDL_Renderer* renderer, int* width, int* height);

	/// <summary>
	/// Create a texture for a rendering context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="format">One of the enumerated values in <see cref="SDL_PixelFormat"/>.</param>
	/// <param name="access">One of the enumerated values in <see cref="SDL_TextureAccess"/>.</param>
	/// <param name="width">The width of the texture in pixels.</param>
	/// <param name="height">The height of the texture in pixels.</param>
	/// <returns>A pointer to the created texture or <see langword="null"/> if no rendering context was active, the format was unsupported, or the width or height were out of range; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Texture* CreateTexture(SDL_Renderer* renderer, SDL_PixelFormat format, SDL_TextureAccess access, int width, int height);

	/// <summary>
	/// Create a texture from an existing surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTextureFromSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="surface">The <see cref="SDL_Surface"/> structure containing pixel data used to fill the texture.</param>
	/// <returns>The created texture or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateTextureFromSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Texture* CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);

	/// <summary>
	/// Create a texture for a rendering context with the specified properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTextureWithProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="props">The properties to use.</param>
	/// <returns>A pointer to the created texture or <see langword="null"/> if no rendering context was active, the format was unsupported, or the width or height were out of range; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateTextureWithProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Texture* CreateTextureWithProperties(SDL_Renderer* renderer, SDL_PropertiesId props);

	/// <summary>
	/// Get the properties associated with a texture.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to query.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetTextureProperties(SDL_Texture* texture);

	/// <summary>
	/// Get the renderer that created an <see cref="SDL_Texture"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererFromTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to query.</param>
	/// <returns>A pointer to the <see cref="SDL_Renderer"/> that created the texture, or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRendererFromTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Renderer* GetRendererFromTexture(SDL_Texture* texture);

	/// <summary>
	/// Get the size of a texture, as floating point values.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to query.</param>
	/// <param name="width">A pointer filled in with the width of the texture in pixels. This argument can be <see langword="null"/> if you don't need this information.</param>
	/// <param name="height">A pointer filled in with the height of the texture in pixels. This argument can be <see langword="null"/> if you don't need this information.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetTextureSize(SDL_Texture* texture, float* width, float* height);

	/// <summary>
	/// Set an additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to update.</param>
	/// <param name="r">The red color value multiplied into copy operations.</param>
	/// <param name="g">The green color value multiplied into copy operations.</param>
	/// <param name="b">The blue color value multiplied into copy operations.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureColorMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetTextureColorMod(SDL_Texture* texture, byte r, byte g, byte b);

	/// <summary>
	/// Set an additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorModFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to update.</param>
	/// <param name="r">The red color value multiplied into copy operations.</param>
	/// <param name="g">The green color value multiplied into copy operations.</param>
	/// <param name="b">The blue color value multiplied into copy operations.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureColorModFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetTextureColorModFloat(SDL_Texture* texture, float r, float g, float b);

	/// <summary>
	/// Get the additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureColorMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to query.</param>
	/// <param name="r">A pointer filled in with the current red color value.</param>
	/// <param name="g">A pointer filled in with the current green color value.</param>
	/// <param name="b">A pointer filled in with the current blue color value.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureColorMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetTextureColorMod(SDL_Texture* texture, byte* r, byte* g, byte* b);

	/// <summary>
	/// Get the additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureColorModFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to query.</param>
	/// <param name="r">A pointer filled in with the current red color value.</param>
	/// <param name="g">A pointer filled in with the current green color value.</param>
	/// <param name="b">A pointer filled in with the current blue color value.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureColorModFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetTextureColorModFloat(SDL_Texture* texture, float* r, float* g, float* b);

	/// <summary>
	/// Set an additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureAlphaMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to update.</param>
	/// <param name="alpha">The source alpha value multiplied into copy operations.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetTextureAlphaMod(SDL_Texture* texture, byte alpha);

	/// <summary>
	/// Set an additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureAlphaModFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to update.</param>
	/// <param name="alpha">The source alpha value multiplied into copy operations.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaModFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetTextureAlphaModFloat(SDL_Texture* texture, float alpha);

	/// <summary>
	/// Get the additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureAlphaMod">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to query.</param>
	/// <param name="alpha">A pointer filled in with the current alpha value.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetTextureAlphaMod(SDL_Texture* texture, byte* alpha);

	/// <summary>
	/// Get the additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureAlphaModFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to query.</param>
	/// <param name="alpha">A pointer filled in with the current alpha value.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaModFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetTextureAlphaModFloat(SDL_Texture* texture, float* alpha);

	/// <summary>
	/// Set the blend mode for a texture, used by <see cref="RenderTexture(SDL_Renderer*, SDL_Texture*, SDL_FRect*, SDL_FRect*)"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to update.</param>
	/// <param name="blendMode">The <see cref="SDL_BlendMode"/> to use for texture blending.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode blendMode);

	/// <summary>
	/// Get the blend mode used for texture copy operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to update.</param>
	/// <param name="blendMode">A pointer filled in with the current <see cref="SDL_BlendMode"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode* blendMode);

	/// <summary>
	/// Set the scale mode used for texture scale operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureScaleMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to update.</param>
	/// <param name="scaleMode">The <see cref="SDL_ScaleMode"/> to use for texture scaling.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureScaleMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode);

	/// <summary>
	/// Get the scale mode used for texture scale operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureScaleMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to query.</param>
	/// <param name="scaleMode">A pointer filled in with the current scale mode.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureScaleMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode);

	/// <summary>
	/// Update the given texture rectangle with new pixel data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to update.</param>
	/// <param name="rect">An <see cref="SDL_Rect"/> structure representing the area to update, or <see langword="null"/> to update the entire texture.</param>
	/// <param name="pixels">The raw pixel data in the format of the texture.</param>
	/// <param name="pitch">The number of bytes in a row of pixel data, including padding between lines.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool UpdateTexture(SDL_Texture* texture, [Const] SDL_Rect* rect, [Const] nint pixels, int pitch);

	/// <summary>
	/// Update a rectangle within a planar YV12 or IYUV texture with new pixel data.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateYUVTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to update.</param>
	/// <param name="rect">A pointer to the rectangle of pixels to update, or <see langword="null"/> to update the entire texture.</param>
	/// <param name="yplane">The raw pixel data for the Y plane.</param>
	/// <param name="ypitch">The number of bytes between rows of pixel data for the Y plane.</param>
	/// <param name="uplane">The raw pixel data for the U plane.</param>
	/// <param name="upitch">The number of bytes between rows of pixel data for the U plane.</param>
	/// <param name="vplane">The raw pixel data for the V plane.</param>
	/// <param name="vpitch">The number of bytes between rows of pixel data for the V plane.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateYUVTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool UpdateYUVTexture(SDL_Texture* texture, [Const] SDL_Rect* rect, [Const] byte* yplane, int ypitch, [Const] byte* uplane, int upitch, [Const] byte* vplane, int vpitch);

	/// <summary>
	/// Update a rectangle within a planar NV12 or NV21 texture with new pixels.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateNVTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture"></param>
	/// <param name="rect">A pointer to the rectangle of pixels to update, or <see langword="null"/> to update the entire texture.</param>
	/// <param name="yplane">The raw pixel data for the Y plane.</param>
	/// <param name="ypitch">The number of bytes between rows of pixel data for the Y plane.</param>
	/// <param name="uvplane">The raw pixel data for the UV plane.</param>
	/// <param name="uvpitch">The number of bytes between rows of pixel data for the UV plane.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateNVTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool UpdateNVTexture(SDL_Texture* texture, [Const] SDL_Rect* rect, [Const] byte* yplane, int ypitch, [Const] byte* uvplane, int uvpitch);

	/// <summary>
	/// Lock a portion of the texture for <b>write-only</b> pixel access.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to lock for access, which was created with <see cref="SDL_TextureAccess.Streaming"/>.</param>
	/// <param name="rect">An <see cref="SDL_Rect"/> structure representing the area to lock for access; <see langword="null"/> to lock the entire texture.</param>
	/// <param name="pixels">This is filled in with a pointer to the locked pixels, appropriately offset by the locked area.</param>
	/// <param name="pitch">This is filled in with the pitch of the locked pixels; the pitch is the length of one row in bytes.</param>
	/// <returns>True on success or false if the texture is not valid or was not created with <see cref="SDL_TextureAccess.Streaming"/>; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_LockTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool LockTexture(SDL_Texture* texture, [Const] SDL_Rect* rect, nint** pixels, int* pitch);

	/// <summary>
	/// Lock a portion of the texture for <b>write-only</b> pixel access, and expose it as a SDL surface.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_LockTextureToSurface">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to lock for access, which was created with <see cref="SDL_TextureAccess.Streaming"/>.</param>
	/// <param name="rect">A pointer to the rectangle to lock for access. If the rect is <see langword="null"/>, the entire texture will be locked.</param>
	/// <param name="surface">This is filled in with an SDL surface representing the locked area.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_LockTextureToSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool LockTextureToSurface(SDL_Texture* texture, [Const] SDL_Rect* rect, SDL_Surface* surface);

	/// <summary>
	/// Unlock a texture, uploading the changes to video memory, if needed.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">A texture locked by <see cref="LockTexture(SDL_Texture*, SDL_Rect*, nint**, int*)"/>.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_UnlockTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void UnlockTexture(SDL_Texture* texture);

	/// <summary>
	/// Set a texture as the current rendering target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderTarget">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="texture">The targeted texture, which must be created with the <see cref="SDL_TextureAccess.Target"/> flag, or <see langword="null"/> to render to the window instead of a texture.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderTarget")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

	/// <summary>
	/// Get the current render target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderTarget">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <returns>The current render target or <see langword="null"/> for the default render target.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderTarget")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Texture* GetRenderTarget(SDL_Renderer* renderer);

	/// <summary>
	/// Set a device independent resolution and presentation mode for rendering.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderLogicalPresentation">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="width">The width of the logical resolution.</param>
	/// <param name="height">The height of the logical resolution.></param>
	/// <param name="mode">The presentation mode used.</param>
	/// <param name="scaleMode">The scale mode used.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderLogicalPresentation")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetRenderLogicalPresentation(SDL_Renderer* renderer, int width, int height, SDL_RendererLogicalPresentation mode, SDL_ScaleMode scaleMode);

	/// <summary>
	/// Get device independent resolution and presentation mode for rendering.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderLogicalPresentation">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="width">An int to be filled with the width.</param>
	/// <param name="height">An int to be filled with the height.</param>
	/// <param name="mode">A pointer filled in with the presentation mode.</param>
	/// <param name="scaleMode">A pointer filled in with the scale mode.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderLogicalPresentation")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderLogicalPresentation(SDL_Renderer* renderer, int* width, int* height, SDL_RendererLogicalPresentation* mode, SDL_ScaleMode* scaleMode);

	/// <summary>
	/// Get the final presentation rectangle for rendering.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderLogicalPresentationRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="rect">A pointer filled in with the final presentation rectangle.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderLogicalPresentationRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderLogicalPresentationRect(SDL_Renderer* renderer, SDL_FRect* rect);

	/// <summary>
	/// Get a point in render coordinates when given a point in window coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderCoordinatesFromWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="windowX">The x coordinate in window coordinates.</param>
	/// <param name="windowY">The y coordinate in window coordinates.</param>
	/// <param name="x">A pointer filled with the x coordinate in render coordinates.</param>
	/// <param name="y">A pointer filled with the x coordinate in render coordinates.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesFromWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderCoordinatesFromWindow(SDL_Renderer* renderer, float windowX, float windowY, float* x, float* y);

	/// <summary>
	/// Get a point in window coordinates when given a point in render coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderCoordinatesToWindow">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="x">The x coordinate in render coordinates.</param>
	/// <param name="y">The y coordinate in render coordinates.</param>
	/// <param name="windowX">A pointer filled with the x coordinate in window coordinates.</param>
	/// <param name="windowY">A pointer filled with the y coordinate in window coordinates.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesToWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderCoordinatesToWindow(SDL_Renderer* renderer, float x, float y, float* windowX, float* windowY);

	/// <summary>
	/// Convert the coordinates in an event to render coordinates.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ConvertEventToRenderCoordinates">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="e">The event to modify.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ConvertEventToRenderCoordinates")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool ConvertEventToRenderCoordinates(SDL_Renderer* renderer, SDL_Event* e);

	/// <summary>
	/// Set the drawing area for rendering on the current target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderViewport">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="rect">The <see cref="SDL_Rect"/> structure representing the drawing area, or <see langword="null"/> to set the viewport to the entire target.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderViewport")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetRenderViewport(SDL_Renderer* renderer, [Const] SDL_Rect* rect);

	/// <summary>
	/// Get the drawing area for the current target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderViewport">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="rect">An <see cref="SDL_Rect"/> structure filled in with the current drawing area.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderViewport")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderViewport(SDL_Renderer* renderer, SDL_Rect* rect);

	/// <summary>
	/// Return whether an explicit rectangle was set as the viewport.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderViewportSet">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <returns>True if the viewport was set to a specific rectangle, or false if it was set to <see langword="null"/> (the entire target).</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderViewportSet")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderViewportSet(SDL_Renderer* renderer);

	/// <summary>
	/// Get the safe area for rendering within the current viewport.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderSafeArea">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="rect">A pointer filled in with the area that is safe for interactive content.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderSafeArea")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderSafeArea(SDL_Renderer* renderer, SDL_Rect* rect);

	/// <summary>
	/// Set the clip rectangle for rendering on the specified target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderClipRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer"></param>
	/// <param name="rect">An <see cref="SDL_Rect"/> structure representing the clip area, relative to the viewport, or <see langword="null"/> to disable clipping.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderClipRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetRenderClipRect(SDL_Renderer* renderer, [Const] SDL_Rect* rect);

	/// <summary>
	/// Get the clip rectangle for the current target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderClipRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="rect">An <see cref="SDL_Rect"/> structure filled in with the current clipping area or an empty rectangle if clipping is disabled.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderClipRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

	/// <summary>
	/// Get whether clipping is enabled on the given renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderClipEnabled">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <returns>True if clipping is enabled or false if not; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderClipEnabled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderClipEnabled(SDL_Renderer* renderer);

	/// <summary>
	/// Set the drawing scale for rendering on the current target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="scaleX">The horizontal scaling factor.</param>
	/// <param name="scaleY">The vertical scaling factor.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderScale")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetRenderScale(SDL_Renderer* renderer, float scaleX, float scaleY);

	/// <summary>
	/// Get the drawing scale for the current target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="scaleX">A pointer filled in with the horizontal scaling factor.</param>
	/// <param name="scaleY">A pointer filled in with the vertical scaling factor.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderScale")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

	/// <summary>
	/// Set the color used for drawing operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderDrawColor">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="r">The red value used to draw on the rendering target.</param>
	/// <param name="g">The green value used to draw on the rendering target.</param>
	/// <param name="b">The blue value used to draw on the rendering target.</param>
	/// <param name="a">The alpha value used to draw on the rendering target; usually <see cref="AlphaOpaque"/> (255). Use <see cref="SetRenderDrawBlendMode(SDL_Renderer*, SDL_BlendMode)"/> to specify how the alpha channel is used.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderDrawColor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetRenderDrawColor(SDL_Renderer* renderer, byte r, byte g, byte b, byte a);

	/// <summary>
	/// Set the color used for drawing operations (Rect, Line and Clear).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderDrawColorFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="r">The red value used to draw on the rendering target.</param>
	/// <param name="g">The green value used to draw on the rendering target.</param>
	/// <param name="b">The blue value used to draw on the rendering target.</param>
	/// <param name="a">The alpha value used to draw on the rendering target. Use <see cref="SetRenderDrawBlendMode(SDL_Renderer*, SDL_BlendMode)"/> to specify how the alpha channel is used.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderDrawColorFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetRenderDrawColorFloat(SDL_Renderer* renderer, float r, float g, float b, float a);

	/// <summary>
	/// Get the color used for drawing operations (Rect, Line and Clear).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDrawColor">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="r">A pointer filled in with the red value used to draw on the rendering target.</param>
	/// <param name="g">A pointer filled in with the green value used to draw on the rendering target.</param>
	/// <param name="b">A pointer filled in with the blue value used to draw on the rendering target.</param>
	/// <param name="a">A pointer filled in with the alpha value used to draw on the rendering target; usually <see cref="AlphaOpaque"/> (255).</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDrawColor")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderDrawColor(SDL_Renderer* renderer, byte* r, byte* g, byte* b, byte* a);

	/// <summary>
	/// Get the color used for drawing operations (Rect, Line and Clear).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDrawColorFloat">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="r">A pointer filled in with the red value used to draw on the rendering target.</param>
	/// <param name="g">A pointer filled in with the green value used to draw on the rendering target.</param>
	/// <param name="b">A pointer filled in with the blue value used to draw on the rendering target.</param>
	/// <param name="a">A pointer filled in with the alpha value used to draw on the rendering target.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDrawColorFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderDrawColorFloat(SDL_Renderer* renderer, float* r, float* g, float* b, float* a);

	/// <summary>
	/// Set the color scale used for render operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderColorScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="scale">The color scale value.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderColorScale")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetRenderColorScale(SDL_Renderer* renderer, float scale);

	/// <summary>
	/// Get the color scale used for render operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderColorScale">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="scale">A pointer filled in with the current color scale value.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderColorScale")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderColorScale(SDL_Renderer* renderer, float* scale);

	/// <summary>
	/// Set the blend mode used for drawing operations (Fill and Line).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderDrawBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="blendMode">The <see cref="SDL_BlendMode"/> to use for blending.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderDrawBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode blendMode);

	/// <summary>
	/// Get the blend mode used for drawing operations.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDrawBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="blendMode">A pointer filled in with the current <see cref="SDL_BlendMode"/>.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDrawBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode* blendMode);

	/// <summary>
	/// Clear the current rendering target with the drawing color.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderClear">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderClear")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderClear(SDL_Renderer* renderer);

	/// <summary>
	/// Draw a point on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderPoint">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should draw a point.</param>
	/// <param name="x">The x coordinate of the point.</param>
	/// <param name="y">The y coordinate of the point.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderPoint")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderPoint(SDL_Renderer* renderer, float x, float y);

	/// <summary>
	/// Draw multiple points on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderPoints">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should draw multiple points.</param>
	/// <param name="points">The points to draw.</param>
	/// <param name="count">The number of points to draw.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderPoints")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderPoints(SDL_Renderer* renderer, [Const] SDL_FPoint* points, int count);

	/// <summary>
	/// Draw a line on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderLine">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should draw a line.</param>
	/// <param name="x1">The x coordinate of the start point.</param>
	/// <param name="y1">The y coordinate of the start point.</param>
	/// <param name="x2">The x coordinate of the end point.</param>
	/// <param name="y2">The y coordinate of the end point.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderLine")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderLine(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);

	/// <summary>
	/// Draw a series of connected lines on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderLines">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should draw multiple lines.</param>
	/// <param name="points">The points along the lines.</param>
	/// <param name="count">The number of points, drawing count-1 lines.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderLines")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderLines(SDL_Renderer* renderer, [Const] SDL_FPoint* points, int count);

	/// <summary>
	/// Draw a rectangle on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should draw a rectangle.</param>
	/// <param name="rect">A pointer to the destination rectangle, or <see langword="null"/> to outline the entire rendering target.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderRect(SDL_Renderer* renderer, [Const] SDL_FRect* rect);

	/// <summary>
	/// Draw some number of rectangles on the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderRects">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should draw multiple rectangles.</param>
	/// <param name="rects">A pointer to an array of destination rectangles.</param>
	/// <param name="count">The number of rectangles.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderRects")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderRects(SDL_Renderer* renderer, [Const] SDL_FRect* rects, int count);

	/// <summary>
	/// Fill a rectangle on the current rendering target with the drawing color at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderFillRect">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should fill a rectangle.</param>
	/// <param name="rect">A pointer to the destination rectangle, or <see langword="null"/> for the entire rendering target.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderFillRect")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderFillRect(SDL_Renderer* renderer, [Const] SDL_FRect* rect);

	/// <summary>
	/// Fill some number of rectangles on the current rendering target with the drawing color at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderFillRects">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should fill multiple rectangles.</param>
	/// <param name="rects">A pointer to an array of destination rectangles.</param>
	/// <param name="count">The number of rectangles.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderFillRects")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderFillRects(SDL_Renderer* renderer, [Const] SDL_FRect* rects, int count);

	/// <summary>
	/// Copy a portion of the texture to the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should copy parts of a texture.</param>
	/// <param name="texture">The source texture.</param>
	/// <param name="srcRect">A pointer to the source rectangle, or <see langword="null"/> for the entire texture.</param>
	/// <param name="dstRect">A pointer to the destination rectangle, or <see langword="null"/> for the entire rendering target.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial int RenderTexture(SDL_Renderer* renderer, SDL_Texture* texture, [Const] SDL_FRect* srcRect, [Const] SDL_FRect* dstRect);

	/// <summary>
	/// Copy a portion of the source texture to the current rendering target, with rotation and flipping, at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderTextureRotated">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should copy parts of a texture.</param>
	/// <param name="texture">The source texture.</param>
	/// <param name="srcRect">A pointer to the source rectangle, or <see langword="null"/> for the entire texture.</param>
	/// <param name="dstRect">A pointer to the destination rectangle, or <see langword="null"/> for the entire rendering target.</param>
	/// <param name="angle">An angle in degrees that indicates the rotation that will be applied to dstrect, rotating it in a clockwise direction.</param>
	/// <param name="center">A pointer to a point indicating the point around which dstrect will be rotated (if <see langword="null"/>, rotation will be done around <paramref name="dstRect"/>.Width / 2, <paramref name="dstRect"/>.Height / 2).</param>
	/// <param name="flip">An <see cref="SDL_FlipMode"/> value stating which flipping actions should be performed on the texture.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderTextureRotated")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderTextureRotated(SDL_Renderer* renderer, SDL_Texture* texture, [Const] SDL_FRect* srcRect, [Const] SDL_FRect* dstRect, [Const] double angle, [Const] SDL_FPoint* center, [Const] SDL_FlipMode flip);

	/// <summary>
	/// Tile a portion of the texture to the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderTextureTiled">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should copy parts of a texture.</param>
	/// <param name="texture">The source texture.</param>
	/// <param name="srcRect">A pointer to the source rectangle, or <see langword="null"/> for the entire texture.</param>
	/// <param name="scale">The scale used to transform srcrect into the destination rectangle, e.g. a 32x32 texture with a scale of 2 would fill 64x64 tiles.</param>
	/// <param name="dstRect">A pointer to the destination rectangle, or <see langword="null"/> for the entire rendering target.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderTextureTiled")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderTextureTiled(SDL_Renderer* renderer, SDL_Texture* texture, [Const] SDL_FRect* srcRect, float scale, [Const] SDL_FRect* dstRect);

	/// <summary>
	/// Perform a scaled copy using the 9-grid algorithm to the current rendering target at subpixel precision.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderTexture9Grid">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer which should copy parts of a texture.</param>
	/// <param name="texture">The source texture.</param>
	/// <param name="srcRect">The <see cref="SDL_Rect"/> structure representing the rectangle to be used for the 9-grid, or <see langword="null"/> to use the entire texture.</param>
	/// <param name="leftWidth">The width, in pixels, of the left corners in <paramref name="srcRect"/>.</param>
	/// <param name="rightWidth">The width, in pixels, of the right corners in <paramref name="srcRect"/>.</param>
	/// <param name="topHeight">The height, in pixels, of the top corners in <paramref name="srcRect"/>.</param>
	/// <param name="bottomHeight">The height, in pixels, of the bottom corners in <paramref name="srcRect"/>.</param>
	/// <param name="scale">The scale used to transform the corner of srcrect into the corner of dstrect, or 0.0f for an unscaled copy.</param>
	/// <param name="dstRect">A pointer to the destination rectangle, or <see langword="null"/> for the entire rendering target.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderTexture9Grid")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderTexture9Grid(SDL_Renderer* renderer, SDL_Texture* texture, [Const] SDL_FRect* srcRect, float leftWidth, float rightWidth, float topHeight, float bottomHeight, float scale, [Const] SDL_FRect* dstRect);

	/// <summary>
	/// Render a list of triangles, optionally using a texture and indices into the vertex array Color and alpha modulation
	/// is done per vertex.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderGeometry">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="texture">(optional) The SDL texture to use.</param>
	/// <param name="vertices">Vertices.</param>
	/// <param name="numVertices">Number of vertices.</param>
	/// <param name="indices">(optional) An array of integer indices into the <paramref name="vertices"/> array, if <see langword="null"/> all vertices will be rendered in sequential order.</param>
	/// <param name="numIndices">Number of indices.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderGeometry")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, [Const] SDL_Vertex* vertices, int numVertices, int* indices, int numIndices);

	/// <summary>
	/// Render a list of triangles, optionally using a texture and indices into the vertex arrays Color and alpha modulation
	/// is done per vertex (<see cref="SetTextureColorMod(SDL_Texture*, byte, byte, byte)"/> and
	/// <see cref="SetTextureAlphaMod(SDL_Texture*, byte)"/> are ignored).
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderGeometryRaw">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="texture">(optional) The SDL texture to use.</param>
	/// <param name="xy">Vertex positions.</param>
	/// <param name="xyStride">Byte size to move from one element to the next element.</param>
	/// <param name="color">Vertex colors (as SDL_FColor).</param>
	/// <param name="colorStride">Byte size to move from one element to the next element.</param>
	/// <param name="uv">Vertex normalized texture coordinates.</param>
	/// <param name="uvStride">Byte size to move from one element to the next element.</param>
	/// <param name="numVertices">Number of vertices.</param>
	/// <param name="indices">(optional) An array of indices into the 'vertices' arrays, if <see langword="null"/> all vertices will be rendered in sequential order.</param>
	/// <param name="numIndices">Number of indices.</param>
	/// <param name="sizeIndices">Index size: 1 (byte), 2 (short), 4 (int).</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderGeometryRaw")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, [Const] float* xy, int xyStride, [Const] SDL_FColor* color, int colorStride, [Const] float* uv, int uvStride, int numVertices, [Const] nint indices, int numIndices, int sizeIndices);

	/// <summary>
	/// Read pixels from the current rendering target.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderReadPixels">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="rect">An <see cref="SDL_Rect"/> structure representing the area in pixels relative to the to current viewport, or <see langword="null"/> for the entire viewport.</param>
	/// <returns>A new <see cref="SDL_Surface"/> on success or <see langword="null"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderReadPixels")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Surface* RenderReadPixels(SDL_Renderer* renderer, [Const] SDL_Rect* rect);

	/// <summary>
	/// Update the screen with any rendering performed since the previous call.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_RenderPresent">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderPresent")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool RenderPresent(SDL_Renderer* renderer);

	/// <summary>
	/// Destroy the specified texture.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyTexture">documentation</see> for more details.
	/// </remarks>
	/// <param name="texture">The texture to destroy.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroyTexture(SDL_Texture* texture);

	/// <summary>
	/// Destroy the rendering context for a window and free all associated textures.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyRenderer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroyRenderer(SDL_Renderer* renderer);

	/// <summary>
	/// Force the rendering context to flush any pending commands and state.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_FlushRenderer">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_FlushRenderer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool FlushRenderer(SDL_Renderer* renderer);

	/// <summary>
	/// Get the <c>CAMetalLayer</c> associated with the given Metal renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderMetalLayer">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer to query.</param>
	/// <returns>A <c>CAMetalLayer*</c> on success, or <see cref="nint.Zero"/> if the renderer isn't a Metal renderer.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderMetalLayer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nint GetRenderMetalLayer(SDL_Renderer* renderer);

	/// <summary>
	/// Get the Metal command encoder for the current frame.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderMetalCommandEncoder">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer to query.</param>
	/// <returns>An <c>id&lt;MTLRenderCommandEncoder&gt;</c> on success, or <see cref="nint.Zero"/> if the renderer isn't a Metal renderer or there was an error.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderMetalCommandEncoder")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nint GetRenderMetalCommandEncoder(SDL_Renderer* renderer);

	/// <summary>
	/// Add a set of synchronization semaphores for the current frame.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AddVulkanRenderSemaphores">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="waitStageMask">The <c>VkPipelineStageFlags</c> for the wait.</param>
	/// <param name="waitSemaphore">A <c>VkSempahore</c> to wait on before rendering the current frame, or 0 if not needed.</param>
	/// <param name="signalSemaphore">A <c>VkSempahore</c> that SDL will signal when rendering for the current frame is complete, or 0 if not needed.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_AddVulkanRenderSemaphores")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool AddVulkanRenderSemaphores(SDL_Renderer* renderer, uint waitStageMask, long waitSemaphore, long signalSemaphore);

	/// <summary>
	/// Toggle VSync of the given renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderVSync">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer to toggle.</param>
	/// <param name="vsync">The vertical refresh sync interval.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderVSync")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool SetRenderVSync(SDL_Renderer* renderer, int vsync);

	/// <summary>
	/// Get VSync of the given renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderVSync">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The renderer to query.</param>
	/// <param name="vsync">An int filled with the current vertical refresh sync interval. See <see cref="SetRenderVSync(SDL_Renderer*, int)"/> for the meaning of the value.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderVSync")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool GetRenderVSync(SDL_Renderer* renderer, int* vsync);

	/// <summary>
	/// The name of the software renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SOFTWARE_RENDERER">documentation</see> for more details.
	/// </remarks>
	public const string SoftwareRenderer = "software";

	/// <summary>
	/// Please refer to <see cref="SetRenderVSync(SDL_Renderer*, int)"/> for details.
	/// </summary>
	public const int RendererVSyncDisabled = 0;

	/// <summary>
	/// Please refer to <see cref="SetRenderVSync(SDL_Renderer*, int)"/> for details.
	/// </summary>
	public const int RendererVSyncAdaptive = -1;
}