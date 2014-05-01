using System;
using System.Runtime.InteropServices;
using NClang.Natives;

namespace NClang
{

	public class ClangIndexImportedAstFileInfo
	{
		CXIdxImportedASTFileInfo source;

		internal ClangIndexImportedAstFileInfo (CXIdxImportedASTFileInfo source)
		{
			this.source = source;
		}

		// FIXME: these properties must be bound to source.
		public ClangFile File { get; set; }
		public ClangModule Module { get; set; }
		public ClangIndexLocation Location { get; set; }
		public bool IsImplicit { get; set; }

		internal CXIdxImportedASTFileInfo ToNative ()
		{
			return new CXIdxImportedASTFileInfo (File.Handle, Module.Handle, Location.ToNative (), IsImplicit ? 1 : 0);
		}
	}
}