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
	[Register("CFTReader", true)]
	public unsafe abstract partial class CFTReader : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CFTReader");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected CFTReader () : base (NSObjectFlag.Empty)
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
		protected CFTReader (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CFTReader (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithReader:")]
		[CompilerGenerated]
		public CFTReader (global::System.nuint reader)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("initWithReader:"), reader), "initWithReader:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("initWithReader:"), reader), "initWithReader:");
			}
		}
		
		[Export ("beginEMVTransactionWithAmount:")]
		[CompilerGenerated]
		public virtual NSError BeginEMVTransactionWithAmount (NSDecimalNumber amount)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("beginEMVTransactionWithAmount:"), amount.Handle));
			} else {
				return  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("beginEMVTransactionWithAmount:"), amount.Handle));
			}
		}
		
		[Export ("beginSwipe")]
		[CompilerGenerated]
		public virtual void BeginSwipe ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("beginSwipe"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("beginSwipe"));
			}
		}
		
		[Export ("beginTransactionWithAmount:andChargeDictionary:")]
		[CompilerGenerated]
		public virtual NSError BeginTransactionWithAmount (NSDecimalNumber amount, NSDictionary chargeDictionary)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			if (chargeDictionary == null)
				throw new ArgumentNullException ("chargeDictionary");
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("beginTransactionWithAmount:andChargeDictionary:"), amount.Handle, chargeDictionary.Handle));
			} else {
				return  Runtime.GetNSObject<NSError> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("beginTransactionWithAmount:andChargeDictionary:"), amount.Handle, chargeDictionary.Handle));
			}
		}
		
		[Export ("cancelSwipeWithMessage:")]
		[CompilerGenerated]
		public virtual void CancelSwipeWithMessage (string message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsmessage = NSString.CreateNative (message);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("cancelSwipeWithMessage:"), nsmessage);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("cancelSwipeWithMessage:"), nsmessage);
			}
			NSString.ReleaseNative (nsmessage);
			
		}
		
		[Export ("cancelTransaction")]
		[CompilerGenerated]
		public virtual void CancelTransaction ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelTransaction"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelTransaction"));
			}
		}
		
		[Export ("defaultMessageForCFTEMVMessage:")]
		[CompilerGenerated]
		public abstract NSString DefaultMessageForCFTEMVMessage (CFTEMVMessage message);
		[Export ("emvProcessTransaction:")]
		[CompilerGenerated]
		public virtual void EmvProcessTransaction (bool process)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("emvProcessTransaction:"), process);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("emvProcessTransaction:"), process);
			}
		}
		
		[Export ("emvSelectApplication:")]
		[CompilerGenerated]
		public virtual void EmvSelectApplication (NSDecimalNumber amount)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("emvSelectApplication:"), amount.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("emvSelectApplication:"), amount.Handle);
			}
		}
		
		[Export ("emvTransactionAmount:")]
		[CompilerGenerated]
		public virtual void EmvTransactionAmount (NSDecimalNumber amount)
		{
			if (amount == null)
				throw new ArgumentNullException ("amount");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("emvTransactionAmount:"), amount.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("emvTransactionAmount:"), amount.Handle);
			}
		}
		
		[Export ("emvTransactionSignature:")]
		[CompilerGenerated]
		public virtual void EmvTransactionSignature (NSData signatureData)
		{
			if (signatureData == null)
				throw new ArgumentNullException ("signatureData");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("emvTransactionSignature:"), signatureData.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("emvTransactionSignature:"), signatureData.Handle);
			}
		}
		
		[Export ("readerState")]
		[CompilerGenerated]
		public virtual CFTReaderState ReaderState ()
		{
			CFTReaderState ret;
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					ret = (CFTReaderState) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("readerState"));
				} else {
					ret = (CFTReaderState) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("readerState"));
				}
			} else {
				if (IntPtr.Size == 8) {
					ret = (CFTReaderState) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readerState"));
				} else {
					ret = (CFTReaderState) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readerState"));
				}
			}
			return ret;
		}
		
		[Export ("swipeHasTimeout:")]
		[CompilerGenerated]
		public virtual void SwipeHasTimeout (bool hasTimeout)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("swipeHasTimeout:"), hasTimeout);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("swipeHasTimeout:"), hasTimeout);
			}
		}
		
		[Export ("swipeTimeoutDuration:")]
		[CompilerGenerated]
		public virtual void SwipeTimeoutDuration (global::System.nint duration)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("swipeTimeoutDuration:"), duration);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("swipeTimeoutDuration:"), duration);
			}
		}
		
		[CompilerGenerated]
		public CFTReaderDelegate Delegate {
			get {
				return WeakDelegate as /**/CFTReaderDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint ReaderType {
			[Export ("readerType")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("readerType"));
				} else {
					return global::ApiDefinition.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("readerType"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool RetrieveSerialNumber {
			[Export ("retrieveSerialNumber")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("retrieveSerialNumber"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("retrieveSerialNumber"));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class CFTReader */
}
