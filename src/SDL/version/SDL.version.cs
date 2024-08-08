using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

// SDL_version.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_version.h.
public static unsafe partial class SDL
{
	/// <summary>
	/// This macro turns the version numbers into a numeric value.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_VERSIONNUM">documentation</see> for more details.
	/// </remarks>
	/// <param name="major">The major version number.</param>
	/// <param name="minor">The minor version number.</param>
	/// <param name="patch">The patch version number.</param>
	/// <returns>The version number as a 32-bit signed integer.</returns>
	[Macro]
	public static int VersionNum(int major, int minor, int patch) => (major * 1000000) + (minor * 1000) + patch;

	/// <summary>
	/// This macro extracts the major version from a version number.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_VERSIONNUM_MAJOR">documentation</see> for more details.
	/// </remarks>
	/// <param name="version">The version number.</param>
	/// <returns>The major version value in <paramref name="version"/>.</returns>
	[Macro]
	public static int VersionNumMajor(int version) => version / 1000000;

	/// <summary>
	/// This macro extracts the minor version from a version number.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_VERSIONNUM_MINOR">documentation</see> for more details.
	/// </remarks>
	/// <param name="version">The version number.</param>
	/// <returns>The minor version value in <paramref name="version"/>.</returns>
	[Macro]
	public static int VersionNumMinor(int version) => version / 1000 % 1000;

	/// <summary>
	/// This macro extracts the micro version from a version number
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_VERSIONNUM_MICRO">documentation</see> for more details.
	/// </remarks>
	/// <param name="version">The version number.</param>
	/// <returns>The micro version value in <paramref name="version"/>.</returns>
	[Macro]
	public static int VersionNumMicro(int version) => version % 1000;

	/// <summary>
	/// This macro will evaluate to true if compiled with SDL at least <paramref name="x"/>.<paramref name="y"/>.<paramref name="z"/>.
	/// </summary>
	/// <param name="x">The major version.</param>
	/// <param name="y">The minor version.</param>
	/// <param name="z">The patch version.</param>
	/// <returns>True if SDL version is at least <paramref name="x"/>.<paramref name="y"/>.<paramref name="z"/>, otherwise false.</returns>
	[Macro]
	public static bool VersionAtLeast(int x, int y, int z) => Version >= VersionNum(x, y, z);

	/// <summary>
	/// Get the version of SDL that is linked against your program.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetVersion">documentation</see> for more details.
	/// </remarks>
	/// <returns>The version of the linked library.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetVersion")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial int GetVersion();

	/// <summary>
	/// Get the code revision of SDL that is linked against your program.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetRevision">documentation</see> for more details.
	/// </remarks>
	/// <returns>An arbitrary string, uniquely identifying the exact revision of the SDL library in use.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetRevision")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string GetRevision();

	/// <summary>
	/// This is the version number macro for the current SDL version.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_VERSION">documentation</see> for more details.
	/// </remarks>
	public static int Version => VersionNum(MajorVersion, MinorVersion, MicroVersion);

	/// <summary>
	/// The current major version of SDL headers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MAJOR_VERSION">documentation</see> for more details.
	/// </remarks>
	public const int MajorVersion = 3;

	/// <summary>
	/// The current minor version of the SDL headers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MINOR_VERSION">documentation</see> for more details.
	/// </remarks>
	public const int MinorVersion = 1;

	/// <summary>
	/// The current micro (or patchlevel) version of the SDL headers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_MICRO_VERSION">documentation</see> for more details.
	/// </remarks>
	public const int MicroVersion = 2;
}