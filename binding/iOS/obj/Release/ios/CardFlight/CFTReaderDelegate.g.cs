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
	[Protocol (Name = "CFTReaderDelegate", WrapperType = typeof (CFTReaderDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EmvTransactionResult", Selector = "emvTransactionResult:requiresSignature:withError:", ParameterType = new Type [] { typeof (CardFlight.CFTCharge), typeof (bool), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EmvApplicationSelection", Selector = "emvApplicationSelection:", ParameterType = new Type [] { typeof (NSArray) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "EmvMessage", Selector = "emvMessage:", ParameterType = new Type [] { typeof (CardFlight.CFTEMVMessage) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EmvCardResponse", Selector = "emvCardResponse:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EmvErrorResponse", Selector = "emvErrorResponse:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EmvAmountRequested", Selector = "emvAmountRequested")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderBatteryLow", Selector = "readerBatteryLow")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EmvCardDipped", Selector = "emvCardDipped")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EmvCardRemoved", Selector = "emvCardRemoved")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReaderCardResponse", Selector = "readerCardResponse:withError:", ParameterType = new Type [] { typeof (CardFlight.CFTCard), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderIsAttached", Selector = "readerIsAttached")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderIsConnecting", Selector = "readerIsConnecting")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderIsConnected", Selector = "readerIsConnected:withError:", ParameterType = new Type [] { typeof (bool), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderSwipeDetected", Selector = "readerSwipeDetected")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderIsDisconnected", Selector = "readerIsDisconnected")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderSwipeDidCancel", Selector = "readerSwipeDidCancel")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderNotDetected", Selector = "readerNotDetected")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Callback", Selector = "callback:", ParameterType = new Type [] { typeof (NSDictionary) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "TransactionResult", Selector = "transactionResult:withError:", ParameterType = new Type [] { typeof (CardFlight.CFTCharge), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderSerialNumber", Selector = "readerSerialNumber:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReaderGenericResponse", Selector = "readerGenericResponse:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface ICFTReaderDelegate : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("emvTransactionResult:requiresSignature:withError:")]
		[Preserve (Conditional = true)]
		void EmvTransactionResult (CFTCharge charge, bool requiresSignature, NSError error);
		
		[CompilerGenerated]
		[Export ("emvMessage:")]
		[Preserve (Conditional = true)]
		void EmvMessage (CFTEMVMessage message);
		
		[CompilerGenerated]
		[Export ("readerCardResponse:withError:")]
		[Preserve (Conditional = true)]
		void ReaderCardResponse (CFTCard card, NSError error);
		
		[CompilerGenerated]
		[Export ("transactionResult:withError:")]
		[Preserve (Conditional = true)]
		void TransactionResult (CFTCharge charge, NSError error);
		
	}
	
	public static partial class CFTReaderDelegate_Extensions {
		[CompilerGenerated]
		public static void EmvApplicationSelection (this ICFTReaderDelegate This, NSArray applicationArray)
		{
			if (applicationArray == null)
				throw new ArgumentNullException ("applicationArray");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("emvApplicationSelection:"), applicationArray.Handle);
		}
		
		[CompilerGenerated]
		public static void EmvCardResponse (this ICFTReaderDelegate This, NSDictionary cardDictionary)
		{
			if (cardDictionary == null)
				throw new ArgumentNullException ("cardDictionary");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("emvCardResponse:"), cardDictionary.Handle);
		}
		
		[CompilerGenerated]
		public static void EmvErrorResponse (this ICFTReaderDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("emvErrorResponse:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void EmvAmountRequested (this ICFTReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("emvAmountRequested"));
		}
		
		[CompilerGenerated]
		public static void ReaderBatteryLow (this ICFTReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerBatteryLow"));
		}
		
		[CompilerGenerated]
		public static void EmvCardDipped (this ICFTReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("emvCardDipped"));
		}
		
		[CompilerGenerated]
		public static void EmvCardRemoved (this ICFTReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("emvCardRemoved"));
		}
		
		[CompilerGenerated]
		public static void ReaderIsAttached (this ICFTReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerIsAttached"));
		}
		
		[CompilerGenerated]
		public static void ReaderIsConnecting (this ICFTReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerIsConnecting"));
		}
		
		[CompilerGenerated]
		public static void ReaderIsConnected (this ICFTReaderDelegate This, bool isConnected, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_IntPtr (This.Handle, Selector.GetHandle ("readerIsConnected:withError:"), isConnected, error.Handle);
		}
		
		[CompilerGenerated]
		public static void ReaderSwipeDetected (this ICFTReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerSwipeDetected"));
		}
		
		[CompilerGenerated]
		public static void ReaderIsDisconnected (this ICFTReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerIsDisconnected"));
		}
		
		[CompilerGenerated]
		public static void ReaderSwipeDidCancel (this ICFTReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerSwipeDidCancel"));
		}
		
		[CompilerGenerated]
		public static void ReaderNotDetected (this ICFTReaderDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("readerNotDetected"));
		}
		
		[CompilerGenerated]
		public static void Callback (this ICFTReaderDelegate This, NSDictionary parameters)
		{
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("callback:"), parameters.Handle);
		}
		
		[CompilerGenerated]
		public static void ReaderSerialNumber (this ICFTReaderDelegate This, string serialNumber)
		{
			if (serialNumber == null)
				throw new ArgumentNullException ("serialNumber");
			var nsserialNumber = NSString.CreateNative (serialNumber);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("readerSerialNumber:"), nsserialNumber);
			NSString.ReleaseNative (nsserialNumber);
			
		}
		
		[CompilerGenerated]
		public static void ReaderGenericResponse (this ICFTReaderDelegate This, string cardData)
		{
			if (cardData == null)
				throw new ArgumentNullException ("cardData");
			var nscardData = NSString.CreateNative (cardData);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("readerGenericResponse:"), nscardData);
			NSString.ReleaseNative (nscardData);
			
		}
		
	}
	
	internal sealed class CFTReaderDelegateWrapper : BaseWrapper, ICFTReaderDelegate {
		public CFTReaderDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public CFTReaderDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("emvTransactionResult:requiresSignature:withError:")]
		[CompilerGenerated]
		public void EmvTransactionResult (CFTCharge charge, bool requiresSignature, NSError error)
		{
			if (charge == null)
				throw new ArgumentNullException ("charge");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("emvTransactionResult:requiresSignature:withError:"), charge.Handle, requiresSignature, error.Handle);
		}
		
		[Export ("emvMessage:")]
		[CompilerGenerated]
		public void EmvMessage (CFTEMVMessage message)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("emvMessage:"), (UInt64)message);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("emvMessage:"), (UInt32)message);
			}
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
		
		[Export ("transactionResult:withError:")]
		[CompilerGenerated]
		public void TransactionResult (CFTCharge charge, NSError error)
		{
			if (charge == null)
				throw new ArgumentNullException ("charge");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("transactionResult:withError:"), charge.Handle, error.Handle);
		}
		
	}
}
namespace CardFlight {
	[Protocol]
	[Register("CFTReaderDelegate", false)]
	[Model]
	public unsafe abstract partial class CFTReaderDelegate : NSObject, ICFTReaderDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CFTReaderDelegate () : base (NSObjectFlag.Empty)
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
		protected CFTReaderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CFTReaderDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("callback:")]
		[CompilerGenerated]
		public virtual void Callback (NSDictionary parameters)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("emvAmountRequested")]
		[CompilerGenerated]
		public virtual void EmvAmountRequested ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("emvApplicationSelection:")]
		[CompilerGenerated]
		public virtual void EmvApplicationSelection (NSArray applicationArray)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("emvCardDipped")]
		[CompilerGenerated]
		public virtual void EmvCardDipped ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("emvCardRemoved")]
		[CompilerGenerated]
		public virtual void EmvCardRemoved ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("emvCardResponse:")]
		[CompilerGenerated]
		public virtual void EmvCardResponse (NSDictionary cardDictionary)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("emvErrorResponse:")]
		[CompilerGenerated]
		public virtual void EmvErrorResponse (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("emvMessage:")]
		[CompilerGenerated]
		public abstract void EmvMessage (CFTEMVMessage message);
		[Export ("emvTransactionResult:requiresSignature:withError:")]
		[CompilerGenerated]
		public abstract void EmvTransactionResult (CFTCharge charge, bool requiresSignature, NSError error);
		[Export ("readerBatteryLow")]
		[CompilerGenerated]
		public virtual void ReaderBatteryLow ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
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
		
		[Export ("readerNotDetected")]
		[CompilerGenerated]
		public virtual void ReaderNotDetected ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerSerialNumber:")]
		[CompilerGenerated]
		public virtual void ReaderSerialNumber (string serialNumber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerSwipeDetected")]
		[CompilerGenerated]
		public virtual void ReaderSwipeDetected ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("readerSwipeDidCancel")]
		[CompilerGenerated]
		public virtual void ReaderSwipeDidCancel ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("transactionResult:withError:")]
		[CompilerGenerated]
		public abstract void TransactionResult (CFTCharge charge, NSError error);
	} /* class CFTReaderDelegate */
}
