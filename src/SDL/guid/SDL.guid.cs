using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace SDL3;

// SDL_guid.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_guid.h
public static unsafe partial class SDL
{
	/// <summary>
	/// Get an ASCII string representation for a given <see cref="SDL_Guid"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GUIDToString">documentation</see> for more details.
	/// </remarks>
	/// <param name="guid">The <see cref="SDL_Guid"/> you wish to convert to string.</param>
	/// <param name="pszGuid">Buffer in which to write the ASCII string.</param>
	/// <param name="cbGuid">The size of <paramref name="pszGuid"/>, should be at least 33 bytes.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GUIDToString")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalUsing(typeof(SDL_StringMarshaller))]
	public static partial void GuidToString(SDL_Guid guid, byte* pszGuid, int cbGuid);

	/// <summary>
	/// Convert a GUID string into an <see cref="SDL_Guid"/> structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_StringToGUID">documentation</see> for more details.
	/// </remarks>
	/// <param name="pchGuid">String containing a representation of a GUID.</param>
	/// <returns>An <see cref="SDL_Guid"/> structure.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_StringToGUID", StringMarshalling = StringMarshalling.Utf8)]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Guid StringToGuid(string pchGuid);
}