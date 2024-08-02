namespace SDL3;

/// <summary>
/// An enumeration of OpenGL configuration attributes.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLattr">documentation</see> for more details.
/// </remarks>
public enum SDL_GLAttr
{
	RedSize,
	GreenSize,
	BlueSize,
	AlphaSize,
	BufferSize,
	DoubleBuffer,
	DepthSize,
	StencilSize,
	AccumRedSize,
	AccumGreenSize,
	AccumBlueSize,
	AccumAlphaSize,
	Stereo,
	MultisampleBuffers,
	MultisampleSamples,
	AcceleratedVisual,
	RetainedBacking,
	ContextMajorVersion,
	ContextMinorVersion,
	GLContextFlags,
	GLContextProfileMask,
	ShareWithCurrentContext,
	FramebufferSRGBCapable,
	ContextReleaseBehaviour,
	ContextResetNotification,
	ContextNoError,
	Floatbuffers,
	EGLPlatform
}