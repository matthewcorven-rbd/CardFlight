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
	[Protocol (Name = "CFTPaymentViewDelegate", WrapperType = typeof (CFTPaymentViewDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "KeyedCardResponse", Selector = "keyedCardResponse:", ParameterType = new Type [] { typeof (CardFlight.CFTCard) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InvalidKeyedResponse", Selector = "invalidKeyedResponse")]
	public interface ICFTPaymentViewDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("keyedCardResponse:")]
		[Preserve (Conditional = true)]
		void KeyedCardResponse (CFTCard card);
		
	}
	
	public static partial class CFTPaymentViewDelegate_Extensions {
		[CompilerGenerated]
		public static void InvalidKeyedResponse (this ICFTPaymentViewDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("invalidKeyedResponse"));
		}
		
	}
	
	internal sealed class CFTPaymentViewDelegateWrapper : BaseWrapper, ICFTPaymentViewDelegate {
		public CFTPaymentViewDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public CFTPaymentViewDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("keyedCardResponse:")]
		[CompilerGenerated]
		public void KeyedCardResponse (CFTCard card)
		{
			if (card == null)
				throw new ArgumentNullException ("card");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("keyedCardResponse:"), card.Handle);
		}
		
	}
}
namespace CardFlight {
	[Protocol]
	[Register("CFTPaymentViewDelegate", false)]
	[Model]
	public unsafe abstract partial class CFTPaymentViewDelegate : NSObject, ICFTPaymentViewDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CFTPaymentViewDelegate () : base (NSObjectFlag.Empty)
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
		protected CFTPaymentViewDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CFTPaymentViewDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("invalidKeyedResponse")]
		[CompilerGenerated]
		public virtual void InvalidKeyedResponse ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("keyedCardResponse:")]
		[CompilerGenerated]
		public abstract void KeyedCardResponse (CFTCard card);
	} /* class CFTPaymentViewDelegate */
}
