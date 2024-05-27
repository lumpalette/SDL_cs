using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SDL3;

// SDL_render.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_render.h
unsafe partial class SDL
{
	partial class PropNames
	{
		// CreateRendererWithProperties()
		public const string RENDERER_CREATE_NAME_STRING = "name";
		public const string RENDERER_CREATE_WINDOW_POINTER = "window";
		public const string RENDERER_CREATE_SURFACE_POINTER = "surface";
		public const string RENDERER_CREATE_OUTPUT_COLORSPACE_NUMBER = "output_colorspace";
		public const string RENDERER_CREATE_PRESENT_VSYNC_NUMBER = "present_vsync";
		public const string RENDERER_CREATE_VULKAN_INSTANCE_POINTER = "vulkan.instance";
		public const string RENDERER_CREATE_VULKAN_SURFACE_NUMBER = "vulkan.surface";
		public const string RENDERER_CREATE_VULKAN_PHYSICAL_DEVICE_POINTER = "vulkan.physical_device";
		public const string RENDERER_CREATE_VULKAN_DEVICE_POINTER = "vulkan.device";
		public const string RENDERER_CREATE_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER = "vulkan.graphics_queue_family_index";
		public const string RENDERER_CREATE_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER = "vulkan.present_queue_family_index";

		// GetRendererProperties()
		public const string RENDERER_NAME_STRING = "SDL.renderer.name";
		public const string RENDERER_WINDOW_POINTER = "SDL.renderer.window";
		public const string RENDERER_SURFACE_POINTER = "SDL.renderer.surface";
		public const string RENDERER_VSYNC_NUMBER = "SDL.renderer.vsync";
		public const string RENDERER_MAX_TEXTURE_SIZE_NUMBER = "SDL.renderer.max_texture_size";
		public const string RENDERER_OUTPUT_COLORSPACE_NUMBER = "SDL.renderer.output_colorspace";
		public const string RENDERER_HDR_ENABLED_BOOLEAN = "SDL.renderer.HDR_enabled";
		public const string RENDERER_SDR_WHITE_POINT_FLOAT = "SDL.renderer.SDR_white_point";
		public const string RENDERER_HDR_HEADROOM_FLOAT = "SDL.renderer.HDR_headroom";
		public const string RENDERER_D3D9_DEVICE_POINTER = "SDL.renderer.d3d9.device";
		public const string RENDERER_D3D11_DEVICE_POINTER = "SDL.renderer.d3d11.device";
		public const string RENDERER_D3D11_SWAPCHAIN_POINTER = "SDL.renderer.d3d11.swap_chain";
		public const string RENDERER_D3D12_DEVICE_POINTER = "SDL.renderer.d3d12.device";
		public const string RENDERER_D3D12_SWAPCHAIN_POINTER = "SDL.renderer.d3d12.swap_chain";
		public const string RENDERER_D3D12_COMMAND_QUEUE_POINTER = "SDL.renderer.d3d12.command_queue";
		public const string RENDERER_VULKAN_INSTANCE_POINTER = "SDL.renderer.vulkan.instance";
		public const string RENDERER_VULKAN_SURFACE_NUMBER = "SDL.renderer.vulkan.surface";
		public const string RENDERER_VULKAN_PHYSICAL_DEVICE_POINTER = "SDL.renderer.vulkan.physical_device";
		public const string RENDERER_VULKAN_DEVICE_POINTER = "SDL.renderer.vulkan.device";
		public const string RENDERER_VULKAN_GRAPHICS_QUEUE_FAMILY_INDEX_NUMBER= "SDL.renderer.vulkan.graphics_queue_family_index";
		public const string RENDERER_VULKAN_PRESENT_QUEUE_FAMILY_INDEX_NUMBER = "SDL.renderer.vulkan.present_queue_family_index";
		public const string RENDERER_VULKAN_SWAPCHAIN_IMAGE_COUNT_NUMBER = "SDL.renderer.vulkan.swapchain_image_count";

		// CreateTextureWithProperties()
		public const string TEXTURE_CREATE_COLORSPACE_NUMBER = "colorspace";
		public const string TEXTURE_CREATE_FORMAT_NUMBER = "format";
		public const string TEXTURE_CREATE_ACCESS_NUMBER = "access";
		public const string TEXTURE_CREATE_WIDTH_NUMBER = "width";
		public const string TEXTURE_CREATE_HEIGHT_NUMBER = "height";
		public const string TEXTURE_CREATE_SDR_WHITE_POINT_FLOAT = "SDR_white_point";
		public const string TEXTURE_CREATE_HDR_HEADROOM_FLOAT = "HDR_headroom";
		public const string TEXTURE_CREATE_D3D11_TEXTURE_POINTER = "d3d11.texture";
		public const string TEXTURE_CREATE_D3D11_TEXTURE_U_POINTER = "d3d11.texture_u";
		public const string TEXTURE_CREATE_D3D11_TEXTURE_V_POINTER = "d3d11.texture_v";
		public const string TEXTURE_CREATE_D3D12_TEXTURE_POINTER = "d3d12.texture";
		public const string TEXTURE_CREATE_D3D12_TEXTURE_U_POINTER = "d3d12.texture_u";
		public const string TEXTURE_CREATE_D3D12_TEXTURE_V_POINTER = "d3d12.texture_v";
		public const string TEXTURE_CREATE_METAL_PIXELBUFFER_POINTER = "metal.pixelbuffer";
		public const string TEXTURE_CREATE_OPENGL_TEXTURE_NUMBER = "opengl.texture";
		public const string TEXTURE_CREATE_OPENGL_TEXTURE_UV_NUMBER = "opengl.texture_uv";
		public const string TEXTURE_CREATE_OPENGL_TEXTURE_U_NUMBER = "opengl.texture_u";
		public const string TEXTURE_CREATE_OPENGL_TEXTURE_V_NUMBER = "opengl.texture_v";
		public const string TEXTURE_CREATE_OPENGLES2_TEXTURE_NUMBER = "opengles2.texture";
		public const string TEXTURE_CREATE_OPENGLES2_TEXTURE_UV_NUMBER = "opengles2.texture_uv";
		public const string TEXTURE_CREATE_OPENGLES2_TEXTURE_U_NUMBER = "opengles2.texture_u";
		public const string SDL_PROP_TEXTURE_CREATE_OPENGLES2_TEXTURE_V_NUMBER = "opengles2.texture_v";
		public const string SDL_PROP_TEXTURE_CREATE_VULKAN_TEXTURE_NUMBER = "vulkan.texture";

		// GetTextureProperties()
		public const string TEXTURE_COLORSPACE_NUMBER = "SDL.texture.colorspace";
		public const string TEXTURE_SDR_WHITE_POINT_FLOAT = "SDL.texture.SDR_white_point";
		public const string TEXTURE_HDR_HEADROOM_FLOAT = "SDL.texture.HDR_headroom";
		public const string TEXTURE_D3D11_TEXTURE_POINTER = "SDL.texture.d3d11.texture";
		public const string TEXTURE_D3D11_TEXTURE_U_POINTER = "SDL.texture.d3d11.texture_u";
		public const string TEXTURE_D3D11_TEXTURE_V_POINTER = "SDL.texture.d3d11.texture_v";
		public const string TEXTURE_D3D12_TEXTURE_POINTER = "SDL.texture.d3d12.texture";
		public const string TEXTURE_D3D12_TEXTURE_U_POINTER = "SDL.texture.d3d12.texture_u";
		public const string TEXTURE_D3D12_TEXTURE_V_POINTER = "SDL.texture.d3d12.texture_v";
		public const string TEXTURE_OPENGL_TEXTURE_NUMBER = "SDL.texture.opengl.texture";
		public const string TEXTURE_OPENGL_TEXTURE_UV_NUMBER = "SDL.texture.opengl.texture_uv";
		public const string TEXTURE_OPENGL_TEXTURE_U_NUMBER = "SDL.texture.opengl.texture_u";
		public const string TEXTURE_OPENGL_TEXTURE_V_NUMBER = "SDL.texture.opengl.texture_v";
		public const string TEXTURE_OPENGL_TEXTURE_TARGET_NUMBER = "SDL.texture.opengl.target";
		public const string TEXTURE_OPENGL_TEX_W_FLOAT = "SDL.texture.opengl.tex_w";
		public const string TEXTURE_OPENGL_TEX_H_FLOAT = "SDL.texture.opengl.tex_h";
		public const string TEXTURE_OPENGLES2_TEXTURE_NUMBER = "SDL.texture.opengles2.texture";
		public const string TEXTURE_OPENGLES2_TEXTURE_UV_NUMBER = "SDL.texture.opengles2.texture_uv";
		public const string TEXTURE_OPENGLES2_TEXTURE_U_NUMBER = "SDL.texture.opengles2.texture_u";
		public const string TEXTURE_OPENGLES2_TEXTURE_V_NUMBER = "SDL.texture.opengles2.texture_v";
		public const string TEXTURE_OPENGLES2_TEXTURE_TARGET_NUMBER = "SDL.texture.opengles2.target";
		public const string TEXTURE_VULKAN_TEXTURE_NUMBER = "SDL.texture.vulkan.texture";
	}

	/// <summary>
	/// A structure representing rendering state. This structure is an opaque type.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Renderer">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public readonly struct Renderer;

	/// <summary>
	/// An efficient driver-specific representation of pixel data. This structure is an opaque type.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Texture">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public readonly struct Texture;

	/// <summary>
	/// Information on the capabilities of a render driver or context.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_RendererInfo">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public readonly struct RendererInfo
	{
		/// <summary>
		/// The name of the renderer.
		/// </summary>
		public readonly string Name => Marshal.PtrToStringUTF8((nint)_name)!;

		private readonly byte* _name;
		
		/// <summary>
		/// The number of available texture formats.
		/// </summary>
		public readonly int NumTextureFormats;

		/// <summary>
		/// The available texture formats.
		/// </summary>
		public readonly PixelFormatValue[] TextureFormats
		{
			get
			{
				var formats = new PixelFormatValue[NumTextureFormats];
				for (var i = 0; i < NumTextureFormats; i++)
				{
					formats[i] = _textureFormats[i];
				}
				return formats;
			}
		}

		private readonly PixelFormatValue* _textureFormats;
	}

	/// <summary>
	/// Vertex structure.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_Vertex">here</see>.
	/// </remarks>
	[StructLayout(LayoutKind.Sequential)]
	public struct Vertex
	{
		/// <summary>
		/// Vertex position, in <see cref="Renderer"/> coordinates.
		/// </summary>
		public FPoint Position;

		/// <summary>
		/// Vertex color.
		/// </summary>
		public FColor Color;

		/// <summary>
		/// Normalized texture coordinates, if needed.
		/// </summary>
		public FPoint TexCoord;
	}

	/// <summary>
	/// The access pattern allowed for a texture.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_TextureAccess">here</see>.
	/// </remarks>
	public enum TextureAccess
	{
		/// <summary>
		/// Changes rarely, not lockable.
		/// </summary>
		Static,

		/// <summary>
		/// Changes frequently, lockable.
		/// </summary>
		Streaming,

		/// <summary>
		/// Texture can be used as a render target.
		/// </summary>
		Target
	}

	/// <summary>
	/// How the logical size is mapped to the output.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_RendererLogicalPresentation">here</see>.
	/// </remarks>
	public enum RendererLogicalPresentation
	{
		/// <summary>
		/// There is no logical size in effect.
		/// </summary>
		Disabled,

		/// <summary>
		/// The rendered content is stretched to the output resolution.
		/// </summary>
		Stretch,

		/// <summary>
		/// The rendered content is fit to the largest dimension and the other dimension is letterboxed with black bars.
		/// </summary>
		Letterbox,

		/// <summary>
		/// The rendered content is fit to the smallest dimension and the other dimension extends beyond the output bounds.
		/// </summary>
		Overscan,

		/// <summary>
		/// The rendered content is scaled up by integer multiples to fit the output resolution.
		/// </summary>
		IntegerScale
	}

	/// <summary>
	/// Get the number of 2D rendering drivers available for the current display.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetNumRenderDrivers">here</see>.
	/// </remarks>
	/// <returns> A number >= 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetNumRenderDrivers()
	{
		return _PInvokeGetNumRenderDrivers();
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetNumRenderDrivers")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetNumRenderDrivers();

	/// <summary>
	/// Use this function to get the name of a built in 2D rendering driver.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderDriver">here</see>.
	/// </remarks>
	/// <param name="index"> The index of the rendering driver; the value ranges from 0 to <see cref="GetNumRenderDrivers"/> - 1 </param>
	/// <returns> The name of the rendering driver at the requested index, or null if an invalid index was specified. </returns>
	public static string? GetRenderDriver(int index)
	{
		return Marshal.PtrToStringUTF8((nint)_PInvokeGetRenderDriver(index));
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderDriver")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial byte* _PInvokeGetRenderDriver(int index);

	/// <summary>
	/// Create a window and default renderer.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateWindowAndRenderer">here</see>.
	/// </remarks>
	/// <param name="title"> The title of the window. </param>
	/// <param name="width"> The width of the window. </param>
	/// <param name="height"> The height of the window. </param>
	/// <param name="windowFlags"> The flags used to create the window (see <see cref="CreateWindow"/>). </param>
	/// <param name="window"> Returns the window, or null on error. </param>
	/// <param name="renderer"> Returns the renderer, or null on error. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int CreateWindowAndRenderer(string title, int width, int height, WindowFlags windowFlags, out Window* window, out Renderer* renderer)
	{
		fixed (byte* t = Encoding.UTF8.GetBytes(title))
		{
			fixed (Window** w = &window)
			{
				fixed (Renderer** r = &renderer)
				{
					return _PInvokeCreateWindowAndRenderer(t, width, height, windowFlags, w, r);
				}
			}
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateWindowAndRenderer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeCreateWindowAndRenderer(byte* title, int width, int height, WindowFlags windowFlags, Window** window, Renderer** renderer);

	/// <summary>
	/// Create a 2D rendering context for a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateRenderer">here</see>.
	/// </remarks>
	/// <param name="window"> The window where rendering is displayed. </param>
	/// <param name="name"> The name of the rendering driver to initialize, or null if it is not important. Defaults to null. </param>
	/// <returns> A valid rendering context or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static Renderer* CreateRenderer(Window* window, string? name = null)
	{
		if (!string.IsNullOrWhiteSpace(name))
		{
			fixed (byte* n = Encoding.UTF8.GetBytes(name))
			{
				return _PInvokeCreateRenderer(window, n);
			}
		}
		return _PInvokeCreateRenderer(window, null);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateRenderer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Renderer* _PInvokeCreateRenderer(Window* window, byte* name);

	/// <summary>
	/// Create a 2D rendering context for a window, with the specified properties.
	/// </summary>
	/// <remarks>
	/// The properties' string values can be found in <see cref="PropNames"/>; they have 'RENDERER_CREATE_' as a prefix.
	/// <br/><br/>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateRendererWithProperties">here</see>.
	/// </remarks>
	/// <param name="props"> The properties to use. </param>
	/// <returns> A valid rendering context or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static Renderer* CreateRendererWithProperties(PropertiesId props)
	{
		return _PInvokeCreateRendererWithProperties(props);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateRendererWithProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Renderer* _PInvokeCreateRendererWithProperties(PropertiesId props);

	/// <summary>
	/// Create a 2D software rendering context for a surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateSoftwareRenderer">here</see>.
	/// </remarks>
	/// <param name="surface"> The <see cref="Surface"/> structure representing the surface where rendering is done. </param>
	/// <returns> A valid rendering context or null if there was an error; call <see cref="GetError"/> for more information. </returns>
	public static Renderer* CreateSoftwareRenderer(Surface* surface)
	{
		return _PInvokeCreateSoftwareRenderer(surface);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateSoftwareRenderer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Renderer* _PInvokeCreateSoftwareRenderer(Surface* surface);

	/// <summary>
	/// Get the renderer associated with a window.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderer">here</see>.
	/// </remarks>
	/// <param name="window"> The window to query. </param>
	/// <returns> The rendering context on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Renderer* GetRenderer(Window* window)
	{
		return _PInvokeGetRenderer(window);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderer")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Renderer* _PInvokeGetRenderer(Window* window);

	/// <summary>
	/// Get the window associated with a renderer.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderWindow">here</see>.
	/// </remarks>
	/// <param name="renderer"> The renderer to query. </param>
	/// <returns> The window on success or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Window* GetRenderWindow(Renderer* renderer)
	{
		return _PInvokeGetRenderWindow(renderer);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Window* _PInvokeGetRenderWindow(Renderer* renderer);

	/// <summary>
	/// Get information about a rendering context.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererInfo">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="info"> Returns a <see cref="RendererInfo"/> structure filled with information about the current renderer. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRendererInfo(Renderer* renderer, out RendererInfo info)
	{
		fixed (RendererInfo* i = &info)
		{
			return _PInvokeGetRendererInfo(renderer, i);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRendererInfo")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetRendererInfo(Renderer* renderer, RendererInfo* info);

	/// <summary>
	/// Get the properties associated with a renderer.
	/// </summary>
	/// <remarks>
	/// The properties' string values can be found in <see cref="PropNames"/>; they have 'RENDERER_' as a prefix.
	/// <br/><br/>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererProperties">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> A valid property id on success or <see cref="PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information. </returns>
	public static PropertiesId GetRendererProperties(Renderer* renderer)
	{
		return _PInvokeGetRendererProperties(renderer);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRendererProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial PropertiesId _PInvokeGetRendererProperties(Renderer* renderer);

	/// <summary>
	/// Get the output size in pixels of a rendering context.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderOutputSize">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> Returns the width in pixels. </param>
	/// <param name="height"> Returns the height in pixels. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderOutputSize(Renderer* renderer, out int width, out int height)
	{
		fixed (int* w = &width, h = &height)
		{
			return _PInvokeGetRenderOutputSize(renderer, w, h);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderOutputSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetRenderOutputSize(Renderer* renderer, int* width, int* height);

	/// <summary>
	/// Get the current output size in pixels of a rendering context.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetCurrentRenderOutputSize">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> Returns the current width. </param>
	/// <param name="height"> Returns the current height. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetCurrentRenderOutputSize(Renderer* renderer, out int width, out int height)
	{
		fixed (int* w = &width, h = &height)
		{
			return _PInvokeGetCurrentRenderOutputSize(renderer, w, h);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetCurrentRenderOutputSize")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetCurrentRenderOutputSize(Renderer* renderer, int* width, int* height);

	/// <summary>
	/// Create a texture for a rendering context.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTexture">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="format"> One of the <see cref="PixelFormatValue"/> values from the <see cref="PixelFormatEnum"/> class. </param>
	/// <param name="access"> One of the enumerated values in <see cref="TextureAccess"/>. </param>
	/// <param name="width"> The width of the texture in pixels. </param>
	/// <param name="height"> The height of the texture in pixels. </param>
	/// <returns> A pointer to the created texture or null if no rendering context was active, the format was unsupported, or the width or height were out of range; call <see cref="GetError"/> for more information. </returns>
	public static Texture* CreateTexture(Renderer* renderer, PixelFormatValue format, TextureAccess access, int width, int height)
	{
		return _PInvokeCreateTexture(renderer, format, access, width, height);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Texture* _PInvokeCreateTexture(Renderer* renderer, PixelFormatValue format, TextureAccess access, int width, int height);

	/// <summary>
	/// Create a texture from an existing surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTextureFromSurface">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="surface"> the <see cref="Surface"/> structure containing pixel data used to fill the texture. </param>
	/// <returns> The created texture or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Texture* CreateTextureFromSurface(Renderer* renderer, Surface* surface)
	{
		return _PInvokeCreateTextureFromSurface(renderer, surface);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateTextureFromSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Texture* _PInvokeCreateTextureFromSurface(Renderer* renderer, Surface* surface);

	/// <summary>
	/// Create a texture for a rendering context with the specified properties.
	/// </summary>
	/// <remarks>
	/// The properties' string values can be found in <see cref="PropNames"/>; they have 'TEXTURE_CREATE_' as a prefix.
	/// <br/><br/>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_CreateTextureWithProperties">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="props"> The properties to use. </param>
	/// <returns> a pointer to the created texture or null if no rendering context was active, the format was unsupported, or the width or height were out of range; call <see cref="GetError"/> for more information. </returns>
	public static Texture* CreateTextureWithProperties(Renderer* renderer, PropertiesId props)
	{
		return _PInvokeCreateTextureWithProperties(renderer, props);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateTextureWithProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Texture* _PInvokeCreateTextureWithProperties(Renderer* renderer, PropertiesId props);

	/// <summary>
	/// Get the properties associated with a texture.
	/// </summary>
	/// <remarks>
	/// The properties' string values can be found in <see cref="PropNames"/>; they have 'TEXTURE_' as a prefix.
	/// <br/><br/>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureProperties">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <returns> A valid property id on success or 0 on failure; call <see cref="GetError"/> for more information. </returns>
	public static PropertiesId GetTextureProperties(Texture* texture)
	{
		return _PInvokeGetTextureProperties(texture);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial PropertiesId _PInvokeGetTextureProperties(Texture* texture);

	/// <summary>
	/// Get the renderer that created a <see cref="Texture"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRendererFromTexture">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <returns> A pointer to the SDL_Renderer that created the texture, or null on failure; call <see cref="GetError"/> for more information. </returns>
	public static Renderer* GetRendererFromTexture(Texture* texture)
	{
		return _PInvokeGetRendererFromTexture(texture);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRendererFromTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Renderer* _PInvokeGetRendererFromTexture(Texture* texture);

	/// <summary>
	/// Query the attributes of a texture.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_QueryTexture">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="format"> Returns the raw format of the texture; the actual format may differ, but pixel transfers will use this format (a value from the <see cref="PixelFormatEnum"/> class). </param>
	/// <param name="access"> Returns the actual access to the texture (one of the <see cref="TextureAccess"/> values). </param>
	/// <param name="width"> Returns the width of the texture in pixels. </param>
	/// <param name="height"> Returns the height of the texture in pixels. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int QueryTexture(Texture* texture, out PixelFormatValue format, out TextureAccess access, out int width, out int height)
	{
		fixed (PixelFormatValue* f = &format)
		{
			fixed (TextureAccess* a = &access)
			{
				fixed (int* w = &width, h = &height)
				{
					return _PInvokeQueryTexture(texture, f, a, w, h);
				}
			}
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_QueryTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeQueryTexture(Texture* texture, PixelFormatValue* format, TextureAccess* access, int* width, int* height);

	/// <summary>
	/// Set an additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorMod">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="r"> The red color value multiplied into copy operations. </param>
	/// <param name="g"> The green color value multiplied into copy operations. </param>
	/// <param name="b"> The blue color value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureColorMod(Texture* texture, byte r, byte g, byte b)
	{
		return _PInvokeSetTextureColorMod(texture, r, g, b);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureColorMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetTextureColorMod(Texture* texture, byte r, byte g, byte b);

	/// <summary>
	/// Set an additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorMod">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="r"> The red color value multiplied into copy operations. </param>
	/// <param name="g"> The green color value multiplied into copy operations. </param>
	/// <param name="b"> The blue color value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureColorMod(Texture* texture, float r, float g, float b)
	{
		return _PInvokeSetTextureColorModFloat(texture, r, g, b);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureColorModFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetTextureColorModFloat(Texture* texture, float r, float g, float b);

	/// <summary>
	/// Get the additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorMod">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="r"> Returns the current red color value. </param>
	/// <param name="g"> Returns the current green color value. </param>
	/// <param name="b"> Returns the current blue color value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureColorMod(Texture* texture, out byte r, out byte g, out byte b)
	{
		fixed (byte* rr = &r, gg = &g, bb = &b)
		{
			return _PInvokeGetTextureColorMod(texture, rr, gg, bb);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureColorMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetTextureColorMod(Texture* texture, byte* r, byte* g, byte* b);

	/// <summary>
	/// Get the additional color value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureColorMod">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="r"> Returns the current red color value. </param>
	/// <param name="g"> Returns the current green color value. </param>
	/// <param name="b"> Returns the current blue color value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureColorMod(Texture* texture, out float r, out float g, out float b)
	{
		fixed (float* rr = &r, gg = &g, bb = &b)
		{
			return _PInvokeGetTextureColorModFloat(texture, rr, gg, bb);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureColorModFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetTextureColorModFloat(Texture* texture, float* r, float* g, float* b);

	/// <summary>
	/// Set an additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureAlphaMod">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="alpha"> The source alpha value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureAlphaMod(Texture* texture, byte alpha)
	{
		return _PInvokeSetTextureAlphaMod(texture, alpha);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetTextureAlphaMod(Texture* texture, byte alpha);

	/// <summary>
	/// Set an additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureAlphaMod">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="alpha"> The source alpha value multiplied into copy operations. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureAlphaMod(Texture* texture, float alpha)
	{
		return _PInvokeSetTextureAlphaModFloat(texture, alpha);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureAlphaModFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetTextureAlphaModFloat(Texture* texture, float alpha);

	/// <summary>
	/// Get the additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureAlphaMod">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="alpha"> Returns the current alpha value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureAlphaMod(Texture* texture, out byte alpha)
	{
		fixed (byte* a = &alpha)
		{
			return _PInvokeGetTextureAlphaMod(texture, a);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaMod")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetTextureAlphaMod(Texture* texture, byte* alpha);

	/// <summary>
	/// Get the additional alpha value multiplied into render copy operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureAlphaMod">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="alpha"> Returns the current alpha value. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureAlphaMod(Texture* texture, out float alpha)
	{
		fixed (float* a = &alpha)
		{
			return _PInvokeGetTextureAlphaModFloat(texture, a);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureAlphaModFloat")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetTextureAlphaModFloat(Texture* texture, float* alpha);

	/// <summary>
	/// Set the blend mode for a texture, used by <see cref="FIXME:SDL_RenderTexture"/>.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureBlendMode">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="blendMode"> The <see cref="BlendMode"/> to use for texture blending. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureBlendMode(Texture* texture, BlendMode blendMode)
	{
		return _PInvokeSetTextureBlendMode(texture, blendMode);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetTextureBlendMode(Texture* texture, BlendMode blendMode);

	/// <summary>
	/// Get the blend mode used for texture copy operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureBlendMode">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="blendMode"> Returns the current <see cref="BlendMode"/> </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureBlendMode(Texture* texture, out BlendMode blendMode)
	{
		fixed (BlendMode* b = &blendMode)
		{
			return _PInvokeGetTextureBlendMode(texture, b);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetTextureBlendMode(Texture* texture, BlendMode* blendMode);

	/// <summary>
	/// Set the scale mode used for texture scale operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetTextureScaleMode">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="scaleMode"> The <see cref="ScaleMode"/> to use for texture scaling. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetTextureScaleMode(Texture* texture, ScaleMode scaleMode)
	{
		return _PInvokeSetTextureScaleMode(texture, scaleMode);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetTextureScaleMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetTextureScaleMode(Texture* texture, ScaleMode scaleMode);

	/// <summary>
	/// Get the scale mode used for texture scale operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetTextureScaleMode">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to query. </param>
	/// <param name="scaleMode"> Returns the current scale mode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetTextureScaleMode(Texture* texture, out ScaleMode scaleMode)
	{
		fixed (ScaleMode* s = &scaleMode)
		{
			return _PInvokeGetTextureScaleMode(texture, s);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetTextureScaleMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetTextureScaleMode(Texture* texture, ScaleMode* scaleMode);

	/// <summary>
	/// Update the given texture rectangle with new pixel data.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateTexture">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="rect"> A <see cref="Rect"/> structure representing the area to update, or null to update the entire texture. </param>
	/// <param name="pixels"> The raw pixel data in the format of the texture. </param>
	/// <param name="pitch"> The number of bytes in a row of pixel data, including padding between lines. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int UpdateTexture(Texture* texture, Rect? rect, uint[] pixels, int pitch)
	{
		fixed (uint* p = pixels)
		{
			if (rect.HasValue)
			{
				Rect r = rect.Value;
				return _PInvokeUpdateTexture(texture, &r, p, pitch);
			}
			return _PInvokeUpdateTexture(texture, null, p, pitch);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeUpdateTexture(Texture* texture, Rect* rect, uint* pixels, int pitch);

	/// <summary>
	/// Update a rectangle within a planar YV12 or IYUV texture with new pixel data.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateYUVTexture">here</see>.
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
	public static int UpdateYUVTexture(Texture* texture, Rect? rect, byte[] yPlane, int yPitch, byte[] uPlane, int uPitch, byte[] vPlane, int vPitch)
	{
		fixed (byte* y = yPlane, u = uPlane, v = vPlane)
		{
			if (rect.HasValue)
			{
				Rect r = rect.Value;
				return _PInvokeUpdateYUVTexture(texture, &r, y, yPitch, u, uPitch, v, vPitch);
			}
			return _PInvokeUpdateYUVTexture(texture, null, y, yPitch, u, uPitch, v, vPitch);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateYUVTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeUpdateYUVTexture(Texture* texture, Rect* rect, byte* yPlane, int yPitch, byte* uPlane, int uPitch, byte* vPlane, int vPitch);

	/// <summary>
	/// Update a rectangle within a planar NV12 or NV21 texture with new pixels.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_UpdateNVTexture">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to update. </param>
	/// <param name="rect"> The rectangle of pixels to update, or null to update the entire texture. </param>
	/// <param name="yPlane"> The raw pixel data for the Y plane. </param>
	/// <param name="yPitch"> The number of bytes between rows of pixel data for the Y plane. </param>
	/// <param name="uvPlane"> The raw pixel data for the UV plane. </param>
	/// <param name="uvPitch"> The number of bytes between rows of pixel data for the UV plane. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int UpdateUpdateNVTexture(Texture* texture, Rect? rect, byte[] yPlane, int yPitch, byte[] uvPlane, int uvPitch)
	{
		fixed (byte* y = yPlane, uv = uvPlane)
		{
			if (rect.HasValue)
			{
				Rect r = rect.Value;
				return _PInvokeUpdateNVTexture(texture, &r, y, yPitch, uv, uvPitch);
			}
			return _PInvokeUpdateNVTexture(texture, null, y, yPitch, uv, uvPitch);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_UpdateNVTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeUpdateNVTexture(Texture* texture, Rect* rect, byte* yPlane, int yPitch, byte* uvPlane, int uvPitch);

	/// <summary>
	/// Lock a portion of the texture for <b>write-only</b> pixel access.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_LockTexture">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to lock for access, which was created with <see cref="TextureAccess.Streaming"/>. </param>
	/// <param name="rect"> A <see cref="Rect"/> structure representing the area to lock for access; null to lock the entire texture. </param>
	/// <param name="pixels"> Returns an array representing the locked pixels, appropriately offset by the locked area. </param>
	/// <param name="pitch"> Returns the pitch of the locked pixels; the pitch is the length of one row in bytes. </param>
	/// <returns> 0 on success or a negative error code if the texture is not valid or was not created with <see cref="TextureAccess.Streaming"/>; call <see cref="GetError"/> for more information. </returns>
	public static int LockTexture(Texture* texture, Rect? rect, out uint* pixels, out int pitch)
	{
		fixed (uint** p = &pixels)
		{
			fixed (int* i = &pitch)
			{
				if (rect.HasValue)
				{
					Rect r = rect.Value;
					return _PInvokeLockTexture(texture, &r, p, i);
				}
				return _PInvokeLockTexture(texture, null, p, i);
			}
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_LockTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeLockTexture(Texture* texture, Rect* rect, uint** pixels, int* pitch);

	/// <summary>
	/// Lock a portion of the texture for <b>write-only</b> pixel access, and expose it as a SDL surface.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_LockTextureToSurface">here</see>.
	/// </remarks>
	/// <param name="texture"> The texture to lock for access, which was created with <see cref="TextureAccess.Streaming"/>. </param>
	/// <param name="rect"> The rectangle to lock for access. If the rect is null, the entire texture will be locked. </param>
	/// <param name="surface"> Returns the SDL surface representing the locked area. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int LockTextureToSurface(Texture* texture, Rect? rect, out Surface* surface)
	{
		fixed (Surface** s = &surface)
		{
			if (rect.HasValue)
			{
				Rect r = rect.Value;
				return _PInvokeLockTextureToSurface(texture, &r, s);
			}
			return _PInvokeLockTextureToSurface(texture, null, s);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_LockTextureToSurface")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeLockTextureToSurface(Texture* texture, Rect* rect, Surface** surface);

	/// <summary>
	/// Unlock a texture, uploading the changes to video memory, if needed.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_UnlockTexture">here</see>.
	/// </remarks>
	/// <param name="texture"> A texture locked by <see cref="LockTexture"/> </param>
	public static void UnlockTexture(Texture* texture)
	{
		_PInvokeUnlockTexture(texture);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_UnlockTexture")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial void _PInvokeUnlockTexture(Texture* texture);

	/// <summary>
	/// Set a texture as the current rendering target.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderTarget">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="texture"> The targeted texture, which must be created with the <see cref="TextureAccess.Target"/> flag, or null to render to the window instead of a texture. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderTarget(Renderer* renderer, Texture* texture)
	{
		return _PInvokeSetRenderTarget(renderer, texture);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderTarget")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetRenderTarget(Renderer* renderer, Texture* texture);

	/// <summary>
	/// Get the current render target.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderTarget">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <returns> The current render target or null for the default render target. </returns>
	public static Texture* GetRenderTarget(Renderer* renderer)
	{
		return _PInvokeGetRenderTarget(renderer);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderTarget")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial Texture* _PInvokeGetRenderTarget(Renderer* renderer);

	/// <summary>
	/// Set a device independent resolution and presentation mode for rendering.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SetRenderLogicalPresentation">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> The width of the logical resolution. </param>
	/// <param name="height"> The height of the logical resolution. </param>
	/// <param name="mode"> The presentation mode used. </param>
	/// <param name="scaleMode"> The scale mode used. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int SetRenderLogicalPresentation(Renderer* renderer, int width, int height, RendererLogicalPresentation mode, ScaleMode scaleMode)
	{
		return _PInvokeSetRenderLogicalPresentation(renderer, width, height, mode, scaleMode);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_SetRenderLogicalPresentation")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeSetRenderLogicalPresentation(Renderer* renderer, int width, int height, RendererLogicalPresentation mode, ScaleMode scaleMode);

	/// <summary>
	/// Get device independent resolution and presentation mode for rendering.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_GetRenderLogicalPresentation">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="width"> Returns the width. </param>
	/// <param name="height"> Returns the height </param>
	/// <param name="mode"> Returns the presentation mode. </param>
	/// <param name="scaleMode"> Returns the scale mode. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int GetRenderLogicalPresentation(Renderer* renderer, out int width, out int height, out RendererLogicalPresentation mode, out ScaleMode scaleMode)
	{
		fixed (int* w = &width, h = &height)
		{
			fixed (RendererLogicalPresentation* m = &mode)
			{
				fixed (ScaleMode* s = &scaleMode)
				{
					return _PInvokeGetRenderLogicalPresentation(renderer, w, h, m, s);
				}
			}
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRenderLogicalPresentation")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeGetRenderLogicalPresentation(Renderer* renderer, int* width, int* height, RendererLogicalPresentation* mode, ScaleMode* scaleMode);

	/// <summary>
	/// Get a point in render coordinates when given a point in window coordinates.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_RenderCoordinatesFromWindow">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="windowX"> The x coordinate in window coordinates. </param>
	/// <param name="windowY"> The y coordinate in window coordinates. </param>
	/// <param name="x"> Returns the x coordinate in render coordinates. </param>
	/// <param name="y"> Returns the y coordinate in render coordinates. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderCoordinatesFromWindow(Renderer* renderer, float windowX, float windowY, out float x, out float y)
	{
		fixed (float* xx = &x, yy = &y)
		{
			return _PInvokeRenderCoordinatesFromWindow(renderer, windowX, windowY, xx, yy);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesFromWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeRenderCoordinatesFromWindow(Renderer* renderer, float windowX, float windowY, float* x, float* y);

	/// <summary>
	/// Get a point in window coordinates when given a point in render coordinates.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_RenderCoordinatesToWindow">here</see>.
	/// </remarks>
	/// <param name="renderer"> The rendering context. </param>
	/// <param name="x"> The x coordinate in render coordinates. </param>
	/// <param name="y"> The y coordinate in render coordinates. </param>
	/// <param name="windowX"> Returns the x coordinate in window coordinates. </param>
	/// <param name="windowY"> Returns the y coordinate in window coordinates. </param>
	/// <returns> 0 on success or a negative error code on failure; call <see cref="GetError"/> for more information. </returns>
	public static int RenderCoordinatesToWindow(Renderer* renderer, float x, float y, out float windowX, out float windowY)
	{
		fixed (float* wx = &windowX, wy = &windowY)
		{
			return _PInvokeRenderCoordinatesToWindow(renderer, x, y, wx, wy);
		}
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_RenderCoordinatesToWindow")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial int _PInvokeRenderCoordinatesToWindow(Renderer* renderer, float x, float y, float* windowX, float* windowY);

	// this function below is the bane of my existence (because of it i have to implement SDL_event.h
	// [that uses literally like >90% of the SDL library {i have to write bindings for all of that ;_;}]).

	/// <summary>
	/// The name of the software renderer.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_SOFTWARE_RENDERER">here</see>.
	/// </remarks>
	public const string SOFTWARE_RENDERER = "software";
}