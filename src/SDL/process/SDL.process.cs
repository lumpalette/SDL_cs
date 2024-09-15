using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_process.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_process.h.
unsafe partial class SDL
{
	/// <summary>
	/// Create a new process.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateProcess">documentation</see> for more details.
	/// </remarks>
	/// <param name="args">The path and arguments for the new process.</param>
	/// <param name="pipeStdio">True to create pipes to the process's standard input and from the process's standard output, false for the process to have no input and inherit the application's standard output.</param>
	/// <returns>The newly created and running process, or <see langword="null"/> if the process couldn't be created.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateProcess")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Process* CreateProcess([Const, Const] byte** args, [MarshalAs(NativeBool)] bool pipeStdio);

	/// <summary>
	/// Create a new process with the specified properties.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_CreateProcessWithProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="props">The properties to use.</param>
	/// <returns>The newly created and running process, or <see langword="null"/> if the process couldn't be created.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_CreateProcessWithProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_Process* CreateProcessWithProperties(SDL_PropertiesId props);

	/// <summary>
	/// Get the properties associated with a process.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GetProcessProperties">documentation</see> for more details.
	/// </remarks>
	/// <param name="process">The process to query.</param>
	/// <returns>A valid property ID on success or <see cref="SDL_PropertiesId.Invalid"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_GetProcessProperties")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_PropertiesId GetProcessProperties(SDL_Process* process);

	/// <summary>
	/// Read all the output from a process.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ReadProcess">documentation</see> for more details.
	/// </remarks>
	/// <param name="process">The process to read.</param>
	/// <param name="dataSize">A pointer filled in with the number of bytes read, may be <see langword="null"/>.</param>
	/// <param name="exitCode">A pointer filled in with the process exit code if the process has exited, may be <see langword="null"/>.</param>
	/// <returns>The data or <see cref="nint.Zero"/> on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ReadProcess")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial nint ReadProcess(SDL_Process* process, nuint* dataSize, int* exitCode);

	// TODO: add SDL_GetProcessInput
	// TODO: add SDL_GetProcessOutput

	/// <summary>
	/// Stop a process.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_KillProcess">documentation</see> for more details.
	/// </remarks>
	/// <param name="process">The process to stop.</param>
	/// <param name="force">True to terminate the process immediately, false to try to stop the process gracefully. In general you should try to stop the process gracefully first as terminating a process may leave it with half-written data or in some other unstable state.</param>
	/// <returns>True on success or false on failure; call <see cref="GetError"/> for more information.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_KillProcess")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool KillProcess(SDL_Process* process, [MarshalAs(NativeBool)] bool force);

	/// <summary>
	/// Wait for a process to finish.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_WaitProcess">documentation</see> for more details.
	/// </remarks>
	/// <param name="process">The process to wait for.</param>
	/// <param name="block">If true, block until the process finishes; otherwise, report on the process' status.</param>
	/// <param name="exitCode">A pointer filled in with the process exit code if the process has exited, may be <see langword="null"/>.</param>
	/// <returns>True if the process exited, false otherwise.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_WaitProcess")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	[return: MarshalAs(NativeBool)]
	public static partial bool WaitProcess(SDL_Process* process, [MarshalAs(NativeBool)] bool block, int* exitCode);

	/// <summary>
	/// Destroy a previously created process object.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_DestroyProcess">documentation</see> for more details.
	/// </remarks>
	/// <param name="process">The process object to destroy.</param>
	[LibraryImport(LibraryName, EntryPoint = "SDL_DestroyProcess")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial void DestroyProcess(SDL_Process* process);
}