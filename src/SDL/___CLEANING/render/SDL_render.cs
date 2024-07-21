using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL_cs;

// SDL_render.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_render.h
public static unsafe partial class SDL
{
	/// <summary>
	/// Get the number of 2D rendering drivers available for the current display.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumRenderDrivers">documentation</see> for more details.
	/// </remarks>
	/// <returns>A number &gt;= 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
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
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDriver", StringMarshallingCustomType = typeof(SDLManagedStringMarshaller))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetRenderDriver(int index);

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
	public static partial byte* GetRenderDriverRaw(int index);

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
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindowAndRenderer", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int CreateWindowAndRenderer(string title, int width, int height, SDL_WindowFlags windowFlags, out SDL_Window* window, out SDL_Renderer* renderer);

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
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRendererName", StringMarshallingCustomType = typeof(SDLManagedStringMarshaller))]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial string? GetRendererName(SDL_Renderer* renderer);

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
	public static partial byte* GetRendererNameRaw(SDL_Renderer* renderer);

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
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderOutputSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetRenderOutputSize(SDL_Renderer* renderer, out int width, out int height);

	/// <summary>
	/// Get the current output size in pixels of a rendering context.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentRenderOutputSize">documentation</see> for more details.
	/// </remarks>
	/// <param name="renderer">The rendering context.</param>
	/// <param name="width">A pointer filled in with the current width.</param>
	/// <param name="height">A pointer filled in with the current height.</param>
	/// <returns></returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentRenderOutputSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetCurrentRenderOutputSize(SDL_Renderer* renderer, out int width, out int height);

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
	public static partial SDL_Texture* CreateTexture(SDL_Renderer* renderer, SDL_PixelFormat format, int access, int width, int height);

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
	/// The name of the software renderer.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SOFTWARE_RENDERER">documentation</see> for more details.
	/// </remarks>
	public const string SoftwareRenderer = "software";
}