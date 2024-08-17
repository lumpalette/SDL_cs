namespace SDL3;

/// <summary>
/// An enumeration of OpenGL configuration attributes.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLattr">documentation</see> for more details.
/// </remarks>
public enum SDL_GLAttr
{
	/// <summary>
	/// The minimum number of bits for the red channel of the color buffer; defaults to 3.
	/// </summary>
	RedSize,

	/// <summary>
	/// The minimum number of bits for the green channel of the color buffer; defaults to 3.
	/// </summary>
	GreenSize,

	/// <summary>
	/// The minimum number of bits for the blue channel of the color buffer; defaults to 2.
	/// </summary>
	BlueSize,

	/// <summary>
	/// The minimum number of bits for the alpha channel of the color buffer; defaults to 0.
	/// </summary>
	AlphaSize,

	/// <summary>
	/// The minimum number of bits for frame buffer size; defaults to 0.
	/// </summary>
	BufferSize,

	/// <summary>
	/// Whether the output is single or double buffered; defaults to double buffering on.
	/// </summary>
	DoubleBuffer,

	/// <summary>
	/// The minimum number of bits in the depth buffer; defaults to 16.
	/// </summary>
	DepthSize,

	/// <summary>
	/// The minimum number of bits in the stencil buffer; defaults to 0.
	/// </summary>
	StencilSize,

	/// <summary>
	/// The minimum number of bits for the red channel of the accumulation buffer; defaults to 0.
	/// </summary>
	AccumRedSize,

	/// <summary>
	/// The minimum number of bits for the green channel of the accumulation buffer; defaults to 0.
	/// </summary>
	AccumGreenSize,

	/// <summary>
	/// The minimum number of bits for the blue channel of the accumulation buffer; defaults to 0.
	/// </summary>
	AccumBlueSize,

	/// <summary>
	/// The minimum number of bits for the alpha channel of the accumulation buffer; defaults to 0.
	/// </summary>
	AccumAlphaSize,

	/// <summary>
	/// Whether the output is stereo 3D; defaults to off.
	/// </summary>
	Stereo,

	/// <summary>
	/// The number of buffers used for multisample anti-aliasing; defaults to 0.
	/// </summary>
	MultisampleBuffers,

	/// <summary>
	/// The number of samples used around the current pixel used for multisample anti-aliasing.
	/// </summary>
	MultisampleSamples,

	/// <summary>
	/// Set to 1 to require hardware acceleration, set to 0 to force software rendering; defaults to allow either.
	/// </summary>
	AcceleratedVisual,

	/// <summary>
	/// Not used (deprecated).
	/// </summary>
	RetainedBacking,

	/// <summary>
	/// OpenGL context major version.
	/// </summary>
	ContextMajorVersion,

	/// <summary>
	/// OpenGL context minor version.
	/// </summary>
	ContextMinorVersion,

	/// <summary>
	/// Some combination of 0 or more of elements of the SDL_GLcontextFlag enumeration; defaults to 0.
	/// </summary>
	GLContextFlags,

	/// <summary>
	/// Type of GL context (Core, Compatibility, ES). See SDL_GLprofile; default value depends on platform.
	/// </summary>
	GLContextProfileMask,

	/// <summary>
	/// OpenGL context sharing; defaults to 0.
	/// </summary>
	ShareWithCurrentContext,

	/// <summary>
	/// Requests sRGB capable visual; defaults to 0.
	/// </summary>
	FramebufferSRGBCapable,

	/// <summary>
	/// Sets context the release behavior. See SDL_GLcontextReleaseFlag; defaults to FLUSH.
	/// </summary>
	ContextReleaseBehaviour,

	/// <summary>
	/// Set context reset notification. See SDL_GLContextResetNotification; defaults to NO_NOTIFICATION.
	/// </summary>
	ContextResetNotification,
	ContextNoError,
	Floatbuffers,
	EGLPlatform
}