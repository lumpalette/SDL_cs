using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// SDL_process.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_process.h.
namespace SDL3;

/// <summary>
/// An opaque handle representing a system process.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_Process">documentation</see> for more details.
/// </remarks>
[Opaque]
public unsafe struct SDL_Process;

/// <summary>
/// Description of where standard I/O should be directed when creating a process.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ProcessIO">documentation</see> for more details.
/// </remarks>
public enum SDL_ProcessIO
{
	/// <summary>
	/// The I/O stream is inherited from the application.
	/// </summary>
	StdioInherited,

	/// <summary>
	/// The I/O stream is ignored.
	/// </summary>
	StdioNull,

	/// <summary>
	/// The I/O stream is connected to a new SDL_IOStream that the application can read or write.
	/// </summary>
	StdioApp,

	/// <summary>
	/// The I/O stream is redirected to an existing <see cref="FIXME:SDL_IOStream"/>.
	/// </summary>
	StdioRedirect
}

unsafe partial class SDL
{
	partial class Prop
	{
		/// <summary>
		/// Properties used for <see cref="CreateProcessWithProperties(SDL_PropertiesId)"/>.
		/// </summary>
		public static class ProcessCreate
		{
			/// <summary>
			/// An array of strings containing the program to run, any arguments, and a <see langword="null"/> pointer. This is a
			/// required property.
			/// </summary>
			public const string ArgsPointer = "SDL.process.create.args";

			/// <summary>
			/// An <see cref="FIXME:SDL_Environment"/> pointer. If this property is set, it will be the entire environment for the
			/// process, otherwise the current environment is used.
			/// </summary>
			public const string EnvironmentPointer = "SDL.process.create.environment";

			/// <summary>
			/// An <see cref="SDL_ProcessIO"/> value describing where standard input for the process comes from, defaults to
			/// <see cref="SDL_ProcessIO.StdioNull"/>.
			/// </summary>
			public const string StdinNumber = "SDL.process.create.stdin_option";

			/// <summary>
			/// An <see cref="FIXME:SDL_IOStream"/> pointer used for standard input when <see cref="StdinNumber"/> is set to
			/// <see cref="SDL_ProcessIO.StdioRedirect"/>.
			/// </summary>
			public const string StdinPointer = "SDL.process.create.stdin_source";

			/// <summary>
			/// An <see cref="SDL_ProcessIO"/> value describing where standard output for the process goes go, defaults to
			/// <see cref="SDL_ProcessIO.StdioInherited"/>.
			/// </summary>
			public const string StdoutNumber = "SDL.process.create.stdout_option";

			/// <summary>
			/// An <see cref="FIXME:SDL_IOStream"/> pointer used for standard output when <see cref="StdoutNumber"/> is set to
			/// <see cref="SDL_ProcessIO.StdioRedirect"/>.
			/// </summary>
			public const string StdoutPointer = "SDL.process.create.stdout_source";

			/// <summary>
			/// An <see cref="SDL_ProcessIO"/> value describing where standard error for the process goes go, defaults to
			/// <see cref="SDL_ProcessIO.StdioInherited"/>.
			/// </summary>
			public const string StderrNumber = "SDL.process.create.stderr_option";

			/// <summary>
			/// An <see cref="FIXME:SDL_IOStream"/> pointer used for standard error when <see cref="StderrNumber"/> is set to
			/// <see cref="SDL_ProcessIO.StdioRedirect"/>.
			/// </summary>
			public const string StderrPointer = "SDL.process.create.stderr_source";

			/// <summary>
			/// True if the error output of the process should be redirected into the standard output of the process. This property
			/// has no effect if <see cref="StderrNumber"/> is set.
			/// </summary>
			public const string StderrToStdoutBoolean = "SDL.process.create.stderr_to_stdout";

			/// <summary>
			/// True if the process should run in the background. In this case the default input and output is
			/// <see cref="SDL_ProcessIO.StdioNull"/> and the exitcode of the process is not available, and will always be 0.
			/// </summary>
			public const string BackgroundBoolean = "SDL.process.create.background";
		}

		/// <summary>
		/// Properties used for <see cref="GetProcessProperties(SDL_Process*)"/>.
		/// </summary>
		public static class Process
		{
			/// <summary>
			/// The process ID of the process.
			/// </summary>
			public const string PidNumber = "SDL.process.pid";

			/// <summary>
			/// An <see cref="FIXME:SDL_IOStream"/> that can be used to write input to the process, if it was created with
			/// <see cref="ProcessCreate.StdinNumber"/> set to <see cref="SDL_ProcessIO.StdioApp"/>.
			/// </summary>
			public const string StdinPointer = "SDL.process.stdin";

			/// <summary>
			/// A non-blocking <see cref="FIXME:SDL_IOStream"/> that can be used to read output from the process, if it was created
			/// with <see cref="ProcessCreate.StdoutNumber"/> set to <see cref="SDL_ProcessIO.StdioApp"/>.
			/// </summary>
			public const string StdoutPointer = "SDL.process.stdout";

			/// <summary>
			/// A non-blocking <see cref="FIXME:SDL_IOStream"/> that can be used to read error output from the process, if it was
			/// created with <see cref="ProcessCreate.StderrNumber"/> set to <see cref="SDL_ProcessIO.StdioApp"/>.
			/// </summary>
			public const string StderrPointer = "SDL.process.stderr";

			/// <summary>
			/// True if the process is running in the background.
			/// </summary>
			public const string BackgroundBoolean = "SDL.process.background";
		}
	}

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
	public static partial SDL_Process* CreateProcess([Const, Const] byte** args, [MarshalAs(BoolSize)] bool pipeStdio);

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
	[return: MarshalAs(BoolSize)]
	public static partial bool KillProcess(SDL_Process* process, [MarshalAs(BoolSize)] bool force);

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
	[return: MarshalAs(BoolSize)]
	public static partial bool WaitProcess(SDL_Process* process, [MarshalAs(BoolSize)] bool block, int* exitCode);

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