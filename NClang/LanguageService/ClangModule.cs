using System;
using System.Runtime.InteropServices;
using NClang.Natives;

namespace NClang
{

	public class ClangModule : ClangObject
	{
		public ClangModule (IntPtr handle)
			: base (handle)
		{
		}

		public ClangFile AstFile {
			get { return new ClangFile (LibClang.clang_Module_getASTFile (Handle)); }
		}

		public ClangModule Parent {
			get { return new ClangModule (LibClang.clang_Module_getParent (Handle)); }
		}

		public string Name {
			get { return LibClang.clang_Module_getName (Handle).Unwrap (); }
		}

		public string FullName {
			get { return LibClang.clang_Module_getFullName (Handle).Unwrap (); }
		}
	}
}
