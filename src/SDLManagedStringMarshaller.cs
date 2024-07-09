using System.Runtime.InteropServices.Marshalling;

namespace SDL_cs;

/// <summary>
/// A marshaller for UTF-8 strings that are owned by SDL, and therefore, cannot be manually freed.
/// </summary>
[CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedOut, typeof(SDLManagedStringMarshaller))]
public static unsafe class SDLManagedStringMarshaller
{
	/// <summary>
	/// Converts an owned SDL UTF-8 native string into a managed <see cref="string"/>.
	/// </summary>
	/// <param name="unmanaged">A pointer to the SDL string.</param>
	/// <returns>A managed <see cref="string"/>.</returns>
	public static string? ConvertToManaged(byte* unmanaged)
	{
		return Utf8StringMarshaller.ConvertToManaged(unmanaged);
	}
}