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
	[Protocol (Name = "CFTAttacheReaderDelegate", WrapperType = typeof (CFTAttacheReaderDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReaderCardResponse", Selector = "readerCardResponse:withError:", ParameterType = new Type [] { typeof (CardFlight.CFTCard), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderIsAttached", Selector = "readerIsAttached")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderIsConnecting", Selector = "readerIsConnecting")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderIsConnected", Selector = "readerIsConnected:withError:", ParameterType = new Type [] { typeof (bool), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderGenericResponse", Selector = "readerGenericResponse:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderIsDisconnected", Selector = "readerIsDisconnected")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderSerialNumber", Selector = "readerSerialNumber:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderSwipeDidCancel", Selector = "readerSwipeDidCancel")]
	public interface ICFTAttacheReaderDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("readerCardResponse:withError:")]
		[Preserve (Conditional = true)]
		void ReaderCardResponse (CFTCard card, NSError error);
		
	}
	
	public static partial class CFTAttacheReaderDelegate_Extensions {
		[CompilerGenerated]
		public static void ReaderIsAttached (this ICFTAttacheReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerIsAttached"));
		}
		
		[CompilerGenerated]
		public static void ReaderIsConnecting (this ICFTAttacheReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerIsConnecting"));
		}
		
		[CompilerGenerated]
		public static void ReaderIsConnected (this ICFTAttacheReaderDelegate This, bool isConnected, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (This.Handle, Selector.GetHandle ("readerIsConnected:withError:"), isConnected, error.Handle);
		}
		
		[CompilerGenerated]
		public static void ReaderGenericResponse (this ICFTAttacheReaderDelegate This, string cardData)
		{
			if (cardData == null)
				throw new ArgumentNullException ("cardData");
			var nscardData = NSString.CreateNative (cardData);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("readerGenericResponse:"), nscardData);
			NSString.ReleaseNative (nscardData);
			
		}
		
		[CompilerGenerated]
		public static void ReaderIsDisconnected (this ICFTAttacheReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerIsDisconnected"));
		}
		
		[CompilerGenerated]
		public static void ReaderSerialNumber (this ICFTAttacheReaderDelegate This, string serialNumber)
		{
			if (serialNumber == null)
				throw new ArgumentNullException ("serialNumber");
			var nsserialNumber = NSString.CreateNative (serialNumber);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("readerSerialNumber:"), nsserialNumber);
			NSString.ReleaseNative (nsserialNumber);
			
		}
		
		[CompilerGenerated]
		public static void ReaderSwipeDidCancel (this ICFTAttacheReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerSwipeDidCancel"));
		}
		
	}
	
	internal sealed class CFTAttacheReaderDelegateWrapper : BaseWrapper, ICFTAttacheReaderDelegate {
		public CFTAttacheReaderDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public CFTAttacheReaderDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("readerCardResponse:withError:")]
		[CompilerGenerated]
		public void ReaderCardResponse (CFTCard card, NSError error)
		{
			if (card == null)
				throw new ArgumentNullException ("card");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("readerCardResponse:withError:"), card.Handle, error.Handle);
		}
		
	}
}
namespace CardFlight {
	[Protocol]
	[Register("CFTAttacheReaderDelegate", false)]
	[Model]
	public unsafe abstract partial class CFTAttacheReaderDelegate : NSObject, ICFTAttacheReaderDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CFTAttacheReaderDelegate () : base (NSObjectFlag.Empty)
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
		protected CFTAttacheReaderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CFTAttacheReaderDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("readerCardResponse:withError:")]
		[CompilerGenerated]
		public abstract void ReaderCardResponse (CFTCard card, NSError error);
		[Export ("readerGenericResponse:")]
		[CompilerGenerated]
		public virtual void ReaderGenericResponse (string cardData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerIsAttached")]
		[CompilerGenerated]
		public virtual void ReaderIsAttached ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerIsConnected:withError:")]
		[CompilerGenerated]
		public virtual void ReaderIsConnected (bool isConnected, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerIsConnecting")]
		[CompilerGenerated]
		public virtual void ReaderIsConnecting ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerIsDisconnected")]
		[CompilerGenerated]
		public virtual void ReaderIsDisconnected ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerSerialNumber:")]
		[CompilerGenerated]
		public virtual void ReaderSerialNumber (string serialNumber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerSwipeDidCancel")]
		[CompilerGenerated]
		public virtual void ReaderSwipeDidCancel ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class CFTAttacheReaderDelegate */
}
