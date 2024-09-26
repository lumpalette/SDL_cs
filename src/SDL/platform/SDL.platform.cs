using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

// SDL_platform.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_platform.h.
static partial class SDL
{
	/// <summary>
	/// Get the name of the platform.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetPlatform">documentation</see> for more details.
	/// </remarks>
	/// <returns>The name of the platform. If the correct platform name is not available, returns a string beginning with the text "Unknown".</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetPlatform")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial string GetPlatform();
}