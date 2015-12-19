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
	[Register("CFTPaymentView", true)]
	public unsafe partial class CFTPaymentView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("CFTPaymentView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CFTPaymentView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public CFTPaymentView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CFTPaymentView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CFTPaymentView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithFrame:enableZip:")]
		[CompilerGenerated]
		public CFTPaymentView (CGRect frame, bool zipEnabled)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_CGRect_bool (this.Handle, Selector.GetHandle ("initWithFrame:enableZip:"), frame, zipEnabled), "initWithFrame:enableZip:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_CGRect_bool (this.SuperHandle, Selector.GetHandle ("initWithFrame:enableZip:"), frame, zipEnabled), "initWithFrame:enableZip:");
			}
		}
		
		[Export ("clearInput")]
		[CompilerGenerated]
		public virtual void ClearInput ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearInput"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearInput"));
			}
		}
		
		[Export ("resignAll")]
		[CompilerGenerated]
		public virtual void ResignAll ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resignAll"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resignAll"));
			}
		}
		
		[Export ("useBorderColor:")]
		[CompilerGenerated]
		public virtual void UseBorderColor (global::UIKit.UIColor newColor)
		{
			if (newColor == null)
				throw new ArgumentNullException ("newColor");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("useBorderColor:"), newColor.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("useBorderColor:"), newColor.Handle);
			}
		}
		
		[Export ("useFont:")]
		[CompilerGenerated]
		public virtual void UseFont (global::UIKit.UIFont newFont)
		{
			if (newFont == null)
				throw new ArgumentNullException ("newFont");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("useFont:"), newFont.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("useFont:"), newFont.Handle);
			}
		}
		
		[Export ("useFontAlertColor:")]
		[CompilerGenerated]
		public virtual void UseFontAlertColor (global::UIKit.UIColor newColor)
		{
			if (newColor == null)
				throw new ArgumentNullException ("newColor");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("useFontAlertColor:"), newColor.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("useFontAlertColor:"), newColor.Handle);
			}
		}
		
		[Export ("useFontColor:")]
		[CompilerGenerated]
		public virtual void UseFontColor (global::UIKit.UIColor newColor)
		{
			if (newColor == null)
				throw new ArgumentNullException ("newColor");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("useFontColor:"), newColor.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("useFontColor:"), newColor.Handle);
			}
		}
		
		[Export ("useKeyboardAppearance:")]
		[CompilerGenerated]
		public virtual void UseKeyboardAppearance (global::UIKit.UIKeyboardAppearance keyboardAppearance)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("useKeyboardAppearance:"), (Int64)keyboardAppearance);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("useKeyboardAppearance:"), (int)keyboardAppearance);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("useKeyboardAppearance:"), (Int64)keyboardAppearance);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("useKeyboardAppearance:"), (int)keyboardAppearance);
				}
			}
		}
		
		[CompilerGenerated]
		public CFTPaymentViewDelegate Delegate {
			get {
				return WeakDelegate as /**/CFTPaymentViewDelegate;
			}
			set {
				WeakDelegate = value;
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
		public partial class CFTPaymentViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal CFTPaymentViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new CFTPaymentViewAppearance Appearance {
			get { return new CFTPaymentViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new CFTPaymentViewAppearance GetAppearance<T> () where T: CFTPaymentView {
			return new CFTPaymentViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new CFTPaymentViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new CFTPaymentViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new CFTPaymentViewAppearance GetAppearance (UITraitCollection traits) {
			return new CFTPaymentViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new CFTPaymentViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new CFTPaymentViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new CFTPaymentViewAppearance GetAppearance<T> (UITraitCollection traits) where T: CFTPaymentView {
			return new CFTPaymentViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new CFTPaymentViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: CFTPaymentView{
			return new CFTPaymentViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class CFTPaymentView */
}
