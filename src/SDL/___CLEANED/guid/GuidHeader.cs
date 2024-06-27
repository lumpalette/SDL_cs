using System.Runtime.InteropServices;
using System.Text;

namespace SDL_cs;

// SDL_guid.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_guid.h
unsafe partial class SDL
{
	/// <summary>
	/// Get a string representation for a given <see cref="SDL_Guid"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GUIDToString">documentation</see> for more details.
	/// </remarks>
	/// <param name="guid">The <see cref="SDL_Guid"/> you wish to convert to string.</param>
	/// <param name="pszGuid">The converted string.</param>
	/// <param name="cbGuid">The number of characters that <paramref name="pszGuid"/> should have. The minimum and default value is 33.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GuidToString(SDL_Guid guid, out string? pszGuid, int cbGuid = 33)
	{
		byte* buffer = stackalloc byte[cbGuid];
		int result = PInvoke.SDL_GUIDToString(guid, buffer, cbGuid);
		pszGuid = Marshal.PtrToStringUTF8((nint)buffer);
		return result;
	}

	/// <summary>
	/// Get an ASCII string representation for a given <see cref="SDL_Guid"/>.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GUIDToString">documentation</see> for more details.
	/// </remarks>
	/// <param name="guid">The <see cref="SDL_Guid"/> you wish to convert to string.</param>
	/// <param name="pszGuid">Buffer in which to write the ASCII string. The buffer needs to have a size of at least 33 bytes.</param>
	/// <param name="cbGuid">The size of <paramref name="pszGuid"/>. The minimum and default value is 33.</param>
	/// <returns>0 on success or a negative error code on failure; call <see cref="GetError"/> for more information.</returns>
	public static int GuidToString(SDL_Guid guid, byte* pszGuid, int cbGuid = 33)
	{
		return PInvoke.SDL_GUIDToString(guid, pszGuid, cbGuid);
	}

	/// <summary>
	/// Convert a GUID string into an <see cref="SDL_Guid"/> structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GUIDFromString">documentation</see> for more details.
	/// </remarks>
	/// <param name="pchGuid">String containing a representation of a GUID.</param>
	/// <returns>An <see cref="SDL_Guid"/> structure.</returns>
	public static SDL_Guid GuidFromString(string pchGuid)
	{
		fixed (byte* pchGuidPtr = Encoding.UTF8.GetBytes(pchGuid))
		{
			return PInvoke.SDL_GUIDFromString(pchGuidPtr);
		}
	}

	/// <summary>
	/// Convert a GUID string into an <see cref="SDL_Guid"/> structure.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GUIDFromString">documentation</see> for more details.
	/// </remarks>
	/// <param name="pchGuid">String containing an ASCII representation of a GUID.</param>
	/// <returns>An <see cref="SDL_Guid"/> structure.</returns>
	public static SDL_Guid GuidFromString(byte* pchGuid)
	{
		return PInvoke.SDL_GUIDFromString(pchGuid);
	}
}