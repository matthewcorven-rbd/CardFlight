//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace CardFlight {
	[Protocol (Name = "CFTSessionProtocol", WrapperType = typeof (CFTSessionProtocolWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "LogOutput", Selector = "logOutput:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface ICFTSessionProtocol : INativeObject, IDisposable
	{
	}
	
	public static partial class CFTSessionProtocol_Extensions {
		[CompilerGenerated]
		public static void LogOutput (this ICFTSessionProtocol This, string output)
		{
			if (output == null)
				throw new ArgumentNullException ("output");
			var nsoutput = NSString.CreateNative (output);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("logOutput:"), nsoutput);
			NSString.ReleaseNative (nsoutput);
			
		}
		
	}
	
	internal sealed class CFTSessionProtocolWrapper : BaseWrapper, ICFTSessionProtocol {
		public CFTSessionProtocolWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public CFTSessionProtocolWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace CardFlight {
	[Protocol]
	[Register("CFTSessionProtocol", false)]
	[Model]
	public unsafe partial class CFTSessionProtocol : NSObject, ICFTSessionProtocol {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CFTSessionProtocol () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CFTSessionProtocol (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CFTSessionProtocol (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("logOutput:")]
		[CompilerGenerated]
		public virtual void LogOutput (string output)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class CFTSessionProtocol */
}
