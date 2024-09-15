namespace SDL3;

unsafe partial class SDL
{
	partial class Prop
	{
		/// <summary>
		/// Properties used for <see cref="CreateRendererWithProperties(SDL_PropertiesId)"/>.
		/// </summary>
		public static class RendererCreate
		{
			/// <summary>
			/// The name of the rendering driver to use, if a specific one is desired.
			/// </summary>
			public const string NameString = "SDL.renderer.create.name";

			/// <summary>
			/// The window where rendering is displayed, required if this isn't a software renderer using a surface.
			/// </summary>
			public const string WindowPointer = "SDL.renderer.create.window";

			/// <summary>
			/// The surface where rendering is displayed, if you want a software renderer without a window.
			/// </summary>
			public const string SurfacePointer = "SDL.renderer.create.surface";

			/// <summary>
			/// An <see cref="SDL_Colorspace"/> value describing the colorspace for output to the display, defaults to
			/// <see cref="SDL_Colorspace.SRGB"/>. The direct3d11, direct3d12, and metal renderers support
			/// <see cref="SDL_Colorspace.SRGBLinear"/>, which is a linear color space and supports HDR output. If you select
			/// <see cref="SDL_Colorspace.SRGBLinear"/>, drawing still uses the sRGB colorspace, but values can go beyond 1.0 and float
			/// (linear) format textures can be used for HDR content.
			/// </summary>
			public const string OutputColorspaceNumber = "SDL.renderer.create.output_colorspace";

			/// <summary>
			/// Non-zero if you want present synchronized with the refresh rate. This property can take any value that is supported by
			/// <see cref="SDL.SetRenderVSync(SDL_Renderer*, int)"/> for the renderer.
			/// </summary>
			public const string PresentVSyncNumber = "SDL.renderer.create.present_vsync";

			/// <summary>
			/// The <c>VkInstance</c> to use with the renderer, optional.
			/// </summary>
			public const string VulkanInstancePointer = "SDL.renderer.create.vulkan.instance";

			/// <summary>
			/// The <c>VkSurfaceKHR</c> to use with the renderer, optional.
			/// </summary>
			public const string VulkanSurfaceNumber = "SDL.renderer.create.vulkan.surface";

			/// <summary>
			/// The <c>VkPhysicalDevice</c> to use with the renderer, optional.
			/// </summary>
			public const string VulkanPhysicalDevicePointer = "SDL.renderer.create.vulkan.physical_device";

			/// <summary>
			/// The <c>VkDevice</c> to use with the renderer, optional.
			/// </summary>
			public const string VulkanDevicePointer = "SDL.renderer.create.vulkan.device";

			/// <summary>
			/// The queue family index used for rendering.
			/// </summary>
			public const string VulkanGraphicsQueueFamilyIndexNumber = "SDL.renderer.create.vulkan.graphics_queue_family_index";

			/// <summary>
			/// The queue family index used for presentation.
			/// </summary>
			public const string VulkanPresentQueueFamilyIndexNumber = "SDL.renderer.create.vulkan.present_queue_family_index";
		}

		/// <summary>
		/// Properties used for <see cref="GetRendererProperties(SDL_Renderer*)"/>.
		/// </summary>
		public static class Renderer
		{
			/// <summary>
			/// The name of the rendering driver.
			/// </summary>
			public const string NameString = "SDL.renderer.name";

			/// <summary>
			/// The window where rendering is displayed, if any.
			/// </summary>
			public const string WindowPointer = "SDL.renderer.window";

			/// <summary>
			/// The surface where rendering is displayed, if this is a software renderer without a window.
			/// </summary>
			public const string SurfacePointer = "SDL.renderer.surface";

			/// <summary>
			/// The current vsync setting.
			/// </summary>
			public const string VSyncNumber = "SDL.renderer.vsync";

			/// <summary>
			/// The maximum texture width and height.
			/// </summary>
			public const string MaxTextureSizeNumber = "SDL.renderer.max_texture_size";

			/// <summary>
			/// A (const <see cref="SDL_PixelFormat"/>*) array of pixel formats, terminated with <see cref="SDL_PixelFormat.Unknown"/>,
			/// representing the available texture formats for this renderer.
			/// </summary>
			public const string TextureFormatsPointer = "SDL.renderer.texture_formats";

			/// <summary>
			/// An <see cref="SDL_Colorspace"/> value describing the colorspace for output to the display, defaults to
			/// <see cref="SDL_Colorspace.SRGB"/>.
			/// </summary>
			public const string OutputColorspaceNumber = "SDL.renderer.output_colorspace";

			/// <summary>
			/// True if the output colorspace is <see cref="SDL_Colorspace.SRGBLinear"/> and the renderer is showing on a display with
			/// HDR enabled. This property can change dynamically when <see cref="FIXME:SDL_EVENT_DISPLAY_HDR_STATE_CHANGED"/> is sent.
			/// </summary>
			public const string HdrEnabledBoolean = "SDL.renderer.HDR_enabled"; // TODO: report this error

			/// <summary>
			/// The value of SDR white in the <see cref="SDL_Colorspace.SRGBLinear"/> colorspace. When HDR is enabled, this value is
			/// automatically multiplied into the color scale. This property can change dynamically when
			/// <see cref="FIXME:SDL_EVENT_DISPLAY_HDR_STATE_CHANGED"/> is sent.
			/// </summary>
			public const string SdrWhitePointFloat = "SDL.renderer.SDR_white_point";

			/// <summary>
			/// The additional high dynamic range that can be displayed, in terms of the SDR white point.When HDR is not enabled, this
			/// will be 1.0. This property can change dynamically when <see cref="FIXME:SDL_EVENT_DISPLAY_HDR_STATE_CHANGED"/> is sent.
			/// </summary>
			public const string HdrHeadroomFloat = "SDL.renderer.HDR_headroom";

			/// <summary>
			/// The <c>IDirect3DDevice9</c> associated with the renderer.
			/// </summary>
			public const string RendererD3D9DevicePointer = "SDL.renderer.d3d9.device";

			/// <summary>
			/// The <c>ID3D11Device</c> associated with the renderer.
			/// </summary>
			public const string D3D11DevicePointer = "SDL.renderer.d3d11.device";

			/// <summary>
			/// The <c>IDXGISwapChain1</c> associated with the renderer. This may change when the window is resized.
			/// </summary>
			public const string D3D11SwapchainPointer = "SDL.renderer.d3d11.swap_chain";

			/// <summary>
			/// The <c>ID3D12Device</c> associated with the renderer.
			/// </summary>
			public const string D3D12DevicePointer = "SDL.renderer.d3d12.device";

			/// <summary>
			/// The <c>IDXGISwapChain4</c> associated with the renderer.
			/// </summary>
			public const string D3D12SwapchainPointer = "SDL.renderer.d3d12.swap_chain";

			/// <summary>
			/// The <c>ID3D12CommandQueue</c> associated with the renderer.
			/// </summary>
			public const string D3D12CommandQueuePointer = "SDL.renderer.d3d12.command_queue";

			/// <summary>
			/// The <c>VkInstance</c> associated with the renderer.
			/// </summary>
			public const string VulkanInstancePointer = "SDL.renderer.vulkan.instance";

			/// <summary>
			/// The <c>VkSurfaceKHR</c> associated with the renderer.
			/// </summary>
			public const string VulkanSurfaceNumber = "SDL.renderer.vulkan.surface";

			/// <summary>
			/// The <c>VkPhysicalDevice</c> associated with the renderer.
			/// </summary>
			public const string VulkanPhysicalDevicePointer = "SDL.renderer.vulkan.physical_device";

			/// <summary>
			/// The <c>VkDevice</c> associated with the renderer.
			/// </summary>
			public const string VulkanDevicePointer = "SDL.renderer.vulkan.device";

			/// <summary>
			/// The queue family index used for rendering.
			/// </summary>
			public const string VulkanGraphicsQueueFamilyIndexNumber = "SDL.renderer.vulkan.graphics_queue_family_index";

			/// <summary>
			/// The queue family index used for presentation.
			/// </summary>
			public const string VulkanPresentQueueFamilyIndexNumber = "SDL.renderer.vulkan.present_queue_family_index";

			/// <summary>
			/// The number of swapchain images, or potential frames in flight, used by the Vulkan renderer.
			/// </summary>
			public const string VulkanSwapchainImageCountNumber = "SDL.renderer.vulkan.swapchain_image_count";
		}

		/// <summary>
		/// Properties used for <see cref="CreateTextureWithProperties(SDL_Renderer*, SDL_PropertiesId)"/>.
		/// </summary>
		public static class TextureCreate
		{
			/// <summary>
			/// An <see cref="SDL_Colorspace"/> value describing the texture colorspace, defaults to <see cref="SDL_Colorspace.SRGBLinear"/>
			/// for floating point textures <see cref="SDL_Colorspace.Hdr10"/> for 10-bit textures, <see cref="SDL_Colorspace.SRGB"/> for
			/// other RGB textures and <see cref="SDL_Colorspace.Jpeg"/> for YUV textures
			/// </summary>
			public const string ColorspaceNumber = "colorspace";

			/// <summary>
			/// One of the enumerated values in <see cref="SDL_PixelFormat"/>, defaults to the best RGBA format for the renderer.
			/// </summary>
			public const string FormatNumber = "format";

			/// <summary>
			/// One of the enumerated values in <see cref="SDL_TextureAccess"/>, defaults to <see cref="SDL_TextureAccess.Static"/>.
			/// </summary>
			public const string AccessNumber = "access";

			/// <summary>
			/// The width of the texture in pixels, required.
			/// </summary>
			public const string WidthNumber = "width";

			/// <summary>
			/// The height of the texture in pixels, required
			/// </summary>
			public const string HeightNumber = "height";

			/// <summary>
			/// For HDR10 and floating point textures, this defines the value of 100% diffuse white, with higher values being displayed
			/// in the High Dynamic Range headroom. This defaults to 100 for HDR10 textures and 1.0 for floating point textures.
			/// </summary>
			public const string SdrWhitePointFloat = "SDR_white_point";

			/// <summary>
			/// For HDR10 and floating point textures, this defines the maximum dynamic range used by the content, in terms of the SDR
			/// white point. This would be equivalent to maxCLL / <see cref="SdrWhitePointFloat"/> for HDR10 content. If this is
			/// defined, any values outside the range supported by the display will be scaled into the available HDR headroom,
			/// otherwise they are clipped.
			/// </summary>
			public const string HdrHeadroomFloat = "HDR_headroom";

			/// <summary>
			/// The <c>ID3D11Texture2D</c> associated with the texture, if you want to wrap an existing texture.
			/// </summary>
			public const string D3D11TexturePointer = "d3d11.texture";

			/// <summary>
			/// The <c>ID3D11Texture2D</c> associated with the U plane of a YUV texture, if you want to wrap an existing texture.
			/// </summary>
			public const string D3D11TextureUPointer = "d3d11.texture_u";

			/// <summary>
			/// The <c>ID3D11Texture2D</c> associated with the V plane of a YUV texture, if you want to wrap an existing texture.
			/// </summary>
			public const string D3D11TextureVPointer = "d3d11.texture_v";

			/// <summary>
			/// The <c>ID3D12Resource</c> associated with the texture, if you want to wrap an existing texture.
			/// </summary>
			public const string D3D12TexturePointer = "d3d12.texture";

			/// <summary>
			/// The <c>ID3D12Resource</c> associated with the U plane of a YUV texture, if you want to wrap an existing texture.
			/// </summary>
			public const string D3D12TextureUPointer = "d3d12.texture_u";

			/// <summary>
			/// The <c>ID3D12Resource</c> associated with the U plane of a YUV texture, if you want to wrap an existing texture.
			/// </summary>
			public const string D3D12TextureVPointer = "d3d12.texture_v";

			/// <summary>
			/// The <c>CVPixelBufferRef</c> associated with the texture, if you want to create a texture from an existing pixel buffer.
			/// </summary>
			public const string MetalPixelBufferPointer = "metal.pixelbuffer";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the texture, if you want to wrap an existing texture.
			/// </summary>
			public const string OpenGLTextureNumber = "opengl.texture";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the UV plane of an NV12 texture, if you want to wrap an existing texture.
			/// </summary>
			public const string OpenGLTextureUVNumber = "opengl.texture_uv";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the U plane of a YUV texture, if you want to wrap an existing texture.
			/// </summary>
			public const string OpenGLTextureUNumber = "opengl.texture_u";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the V plane of a YUV texture, if you want to wrap an existing texture.
			/// </summary>
			public const string OpenGLTextureVNumber = "opengl.texture_v";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the texture, if you want to wrap an existing texture.
			/// </summary>
			public const string OpenGLES2TextureNumber = "opengles2.texture";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the UV plane of an NV12 texture, if you want to wrap an existing texture.
			/// </summary>
			public const string OpenGLES2TextureUVNumber = "opengles2.texture_uv";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the U plane of a YUV texture, if you want to wrap an existing texture.
			/// </summary>
			public const string OpenGLES2TextureUNumber = "opengles2.texture_u";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the V plane of a YUV texture, if you want to wrap an existing texture.
			/// </summary>
			public const string OpenGLES2TextureVNumber = "opengles2.texture_v";

			/// <summary>
			/// The <c>VkImage</c> with layout <c>VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL</c> associated with the texture, if you want
			/// to wrap an existing texture.
			/// </summary>
			public const string VulkanTextureNumber = "vulkan.texture";
		}

		/// <summary>
		/// Properties used for <see cref="GetTextureProperties(SDL_Texture*)"/>.
		/// </summary>
		public static class Texture
		{
			/// <summary>
			/// An <see cref="SDL_Colorspace"/> value describing the texture colorspace.
			/// </summary>
			public const string ColorspaceNumber = "SDL.texture.colorspace";

			/// <summary>
			/// One of the enumerated values in <see cref="SDL_PixelFormat"/>.
			/// </summary>
			public const string FormatNumber = "SDL.texture.format";

			/// <summary>
			/// One of the enumerated values in <see cref="SDL_TextureAccess"/>.
			/// </summary>
			public const string AccessNumber = "SDL.texture.access";

			/// <summary>
			/// The width of the texture in pixels.
			/// </summary>
			public const string WidthNumber = "SDL.texture.width";

			/// <summary>
			/// The height of the texture in pixels.
			/// </summary>
			public const string HeightNumber = "SDL.texture.height";

			/// <summary>
			/// For HDR10 and floating point textures, this defines the value of 100% diffuse white, with higher values being displayed
			/// in the High Dynamic Range headroom. 
			/// </summary>
			public const string SdrWhitePointFloat = "SDL.texture.SDR_white_point";

			/// <summary>
			/// For HDR10 and floating point textures, this defines the maximum dynamic range used by the content, in terms of the SDR
			/// white point. If this is defined, any values outside the range supported by the display will be scaled into the
			/// available HDR headroom, otherwise they are clipped. This defaults to 1.0 for SDR textures, 4.0 for HDR10 textures, and
			/// no default for floating point textures.
			/// </summary>
			public const string HdrHeadroomFloat = "SDL.texture.HDR_headroom";

			/// <summary>
			/// The <c>ID3D11Texture2D</c> associated with the texture.
			/// </summary>
			public const string D3D11TexturePointer = "SDL.texture.d3d11.texture";

			/// <summary>
			/// The <c>ID3D11Texture2D</c> associated with the U plane of a YUV texture.
			/// </summary>
			public const string D3D11TextureUPointer = "SDL.texture.d3d11.texture_u";

			/// <summary>
			/// The <c>ID3D11Texture2D</c> associated with the V plane of a YUV texture.
			/// </summary>
			public const string D3D11TextureVPointer = "SDL.texture.d3d11.texture_v";

			/// <summary>
			/// The <c>ID3D12Resource</c> associated with the texture.
			/// </summary>
			public const string D3D12TexturePointer = "SDL.texture.d3d12.texture";

			/// <summary>
			/// The <c>ID3D12Resource</c> associated with the U plane of a YUV texture.
			/// </summary>
			public const string D3D12TextureUPointer = "SDL.texture.d3d12.texture_u";

			/// <summary>
			/// The <c>ID3D12Resource</c> associated with the V plane of a YUV texture
			/// </summary>
			public const string D3D12TextureVPointer = "SDL.texture.d3d12.texture_v";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the texture.
			/// </summary>
			public const string OpenGLTextureNumber = "SDL.texture.opengl.texture";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the UV plane of an NV12 texture.
			/// </summary>
			public const string OpenGLTextureUVNumber = "SDL.texture.opengl.texture_uv";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the U plane of a YUV texture.
			/// </summary>
			public const string OpenGLTextureUNumber = "SDL.texture.opengl.texture_u";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the V plane of a YUV texture.
			/// </summary>
			public const string OpenGLTextureVNumber = "SDL.texture.opengl.texture_v";

			/// <summary>
			/// The <c>GLenum</c> for the texture target (<c>GL_TEXTURE_2D</c>, <c>GL_TEXTURE_RECTANGLE_ARB</c>, etc).
			/// </summary>
			public const string OpenGLTextureTargetNumber = "SDL.texture.opengl.target";

			/// <summary>
			/// The texture coordinate width of the texture (0.0 - 1.0).
			/// </summary>
			public const string OpenGLTexWFloat = "SDL.texture.opengl.tex_w";

			/// <summary>
			/// The texture coordinate height of the texture (0.0 - 1.0).
			/// </summary>
			public const string OpenGLTexHFloat = "SDL.texture.opengl.tex_h";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the texture.
			/// </summary>
			public const string OpenGLES2TextureNumber = "SDL.texture.opengles2.texture";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the UV plane of an NV12 texture.
			/// </summary>
			public const string OpenGLES2TextureUVNumber = "SDL.texture.opengles2.texture_uv";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the U plane of a YUV texture.
			/// </summary>
			public const string OpenGLES2TextureUNumber = "SDL.texture.opengles2.texture_u";

			/// <summary>
			/// The <c>GLuint</c> texture associated with the V plane of a YUV texture.
			/// </summary>
			public const string OpenGLES2TextureVNumber = "SDL.texture.opengles2.texture_v";

			/// <summary>
			/// The <c>GLenum</c> for the texture target (<c>GL_TEXTURE_2D</c>, <c>GL_TEXTURE_EXTERNAL_OES</c>, etc)
			/// </summary>
			public const string OpenGLES2TextureTargetNumber = "SDL.texture.opengles2.target";

			/// <summary>
			/// The <c>VkImage</c> associated with the texture.
			/// </summary>
			public const string VulkanTextureNumber = "SDL.texture.vulkan.texture";
		}
	}
}