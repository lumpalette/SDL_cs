namespace SDL_cs;

public static partial class SDL_Prop
{
	/// <summary>
	/// Properties used in <see cref="SDL.CreateRendererWithProperties(SDL_PropertiesId)"/>.
	/// </summary>
	public static class RendererCreate
	{
		/// <summary>
		/// The name of the rendering driver to use, if a specific one is desired.
		/// </summary>
		public const string Name = "name";

		/// <summary>
		/// The window where rendering is displayed, required if this isn't a software renderer using a surface.
		/// </summary>
		public const string WindowPointer = "window";

		/// <summary>
		/// The surface where rendering is displayed, if you want a software renderer without a window.
		/// </summary>
		public const string SurfacePointer = "surface";

		/// <summary>
		/// An <see cref="SDL_Colorspace"/> value describing the colorspace for output to the display, defaults to
		/// <see cref="SDL_Colorspace.SRGB"/>.
		/// </summary>
		/// <remarks>
		/// The direct3d11, direct3d12, and metal renderers support <see cref="SDL_Colorspace.SRGBLinear"/>, which is a linear
		/// color space and supports HDR output. If you select <see cref="SDL_Colorspace.SRGBLinear"/>, drawing still uses the
		/// sRGB colorspace, but values can go beyond 1.0 and float (linear) format textures can be used for HDR content.
		/// </remarks>
		public const string OutputColorspaceNumber = "output_colorspace";

		/// <summary>
		/// Non-zero if you want present synchronized with the refresh rate.
		/// </summary>
		/// <remarks>
		/// This property can take any value that is supported by <see cref="FIXME:SDL_SetRenderVSync()"/> for the renderer.
		/// </remarks>
		public const string PresentVSyncNumber = "present_vsync";

		/// <summary>
		/// The <c>VkInstance</c> to use with the renderer, optional.
		/// </summary>
		public const string VulkanInstancePointer = "vulkan.instance";

		/// <summary>
		/// The <c>VkSurfaceKHR</c> to use with the renderer, optional.
		/// </summary>
		public const string VulkanSurfaceNumber = "vulkan.surface";

		/// <summary>
		/// The <c>VkPhysicalDevice</c> to use with the renderer, optional.
		/// </summary>
		public const string VulkanPhysicalDevicePointer = "vulkan.physical_device";

		/// <summary>
		/// The <c>VkDevice</c> to use with the renderer, optional.
		/// </summary>
		public const string VulkanDevicePointer = "vulkan.device";

		/// <summary>
		/// The queue family index used for rendering.
		/// </summary>
		public const string VulkanGraphicsQueueFamilyIndexNumber = "vulkan.graphics_queue_family_index";

		/// <summary>
		/// The queue family index used for presentation.
		/// </summary>
		public const string VulkanPresentQueueFamilyIndexNumber = "vulkan.present_queue_family_index";
	}
}