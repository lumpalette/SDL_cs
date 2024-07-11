using System;

namespace SDL_cs;

/// <summary>
/// The flags on an <see cref="SDL_Surface"/>.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_SurfaceFlags">documentation</see> for more details.
/// </remarks>
[Typedef]
[Flags]
public enum SDL_SurfaceFlags : uint
{
	/// <summary>
	/// Surface uses preallocated memory.
	/// </summary>
	Preallocated = 0x00000001u,

	/// <summary>
	/// Surface needs to be locked to access pixels.
	/// </summary>
	LockNeeded = 0x00000002u,

	/// <summary>
	/// Surface is currently locked.
	/// </summary>
	Locked = 0x00000004u,

	/// <summary>
	/// Surface uses pixel memory allocated with SDL_aligned_alloc().
	/// </summary>
	SimdAligned = 0x00000008u
}