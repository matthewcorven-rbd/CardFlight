using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace CardFlight
{
	// @protocol CFTSessionProtocol <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface CFTSessionProtocol
	{
		// @optional -(void)logOutput:(NSString *)output;
		[Export ("logOutput:")]
		void LogOutput (string output);
	}

	// @interface CFTSessionManager : NSObject
	[BaseType (typeof(NSObject))]
	interface CFTSessionManager
	{
		[Wrap ("WeakDelegate")]
		CFTSessionProtocol Delegate { get; set; }

		// @property (nonatomic, readonly) BOOL isEMVMerchantAccount;
		[Export ("isEMVMerchantAccount")]
		bool IsEmvMerchantAccount { get; }

		// @property (nonatomic, weak) id<CFTSessionProtocol> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// +(CFTSessionManager *)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		CFTSessionManager SharedInstance { get; }

		// -(NSString *)SDKVersion;
		[Export ("SDKVersion")]
		string SDKVersion { get; }

		// -(NSString *)apiToken;
		[Export ("apiToken")]
		string ApiToken { get; }

		// -(NSString *)accountToken;
		[Export ("accountToken")]
		string AccountToken { get; }

		// -(void)setApiToken:(NSString *)cardFlightApiToken accountToken:(NSString *)cardFlightAccountToken;
		[Export ("setApiToken:accountToken:")]
		void SetApiToken (string cardFlightApiToken, string cardFlightAccountToken);

		// -(void)setLogging:(BOOL)logging;
		[Export ("setLogging:")]
		void SetLogging (bool logging);

		// -(NSString *)getApiToken __attribute__((deprecated("")));
		[Export ("getApiToken")]
		string GetApiToken { get; }

		// -(NSString *)getAccountToken __attribute__((deprecated("")));
		[Export ("getAccountToken")]
		string GetAccountToken { get; }
	}

	// @protocol CFTPaymentViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface CFTPaymentViewDelegate
	{
		// @required -(void)keyedCardResponse:(CFTCard *)card;
		[Abstract]
		[Export ("keyedCardResponse:")]
		void KeyedCardResponse (CFTCard card);

		// @optional (void)invalidKeyedResponse;
		[Export ("invalidKeyedResponse")]
		void InvalidKeyedResponse ();
	}

	// @interface CFTPaymentView : UIView
	[BaseType (typeof(UIView))]
	interface CFTPaymentView
	{
		[Wrap ("WeakDelegate")]
		CFTPaymentViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<CFTPaymentViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(instancetype)initWithFrame:(CGRect)frame enableZip:(BOOL)zipEnabled;
		[Export ("initWithFrame:enableZip:")]
		IntPtr Constructor (CGRect frame, bool zipEnabled);

		// -(void)resignAll;
		[Export ("resignAll")]
		void ResignAll ();

		// -(void)clearInput;
		[Export ("clearInput")]
		void ClearInput ();

		// -(void)useKeyboardAppearance:(UIKeyboardAppearance)keyboardAppearance;
		[Export ("useKeyboardAppearance:")]
		void UseKeyboardAppearance (UIKeyboardAppearance keyboardAppearance);

		// -(void)useFont:(UIFont *)newFont;
		[Export ("useFont:")]
		void UseFont (UIFont newFont);

		// -(void)useFontColor:(UIColor *)newColor;
		[Export ("useFontColor:")]
		void UseFontColor (UIColor newColor);

		// -(void)useFontAlertColor:(UIColor *)newColor;
		[Export ("useFontAlertColor:")]
		void UseFontAlertColor (UIColor newColor);

		// -(void)useBorderColor:(UIColor *)newColor;
		[Export ("useBorderColor:")]
		void UseBorderColor (UIColor newColor);
	}

	// @protocol CFTReaderDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface CFTReaderDelegate
	{
		// ****************  REQUIRED CALLBACKS FOR EMV  ****************

		// @optional -(void)emvTransactionResult:(CFTCharge *)charge requiresSignature:(BOOL)signature withError:(NSError *)error;
		[Abstract]
		[Export ("emvTransactionResult:requiresSignature:withError:")]
		void EmvTransactionResult (CFTCharge charge, bool requiresSignature, NSError error);

		// @optional -(void)emvApplicationSelection:(NSArray *)applicationArray;
		[Export ("emvApplicationSelection:")]
		void EmvApplicationSelection (NSArray applicationArray);

		// @optional -(void)emvMessage:(CFTEMVMessage)message;
		[Abstract]
		[Export ("emvMessage:")]
		void EmvMessage (CFTEMVMessage message);

		// @optional -(void)emvCardResponse:(NSDictionary *)cardDictionary;
		[Export ("emvCardResponse:")]
		void EmvCardResponse (NSDictionary cardDictionary);

		// @optional -(void)emvErrorResponse:(NSError *)error;
		[Export ("emvErrorResponse:")]
		void EmvErrorResponse (NSError error);

		// @optional -(void)emvAmountRequested;
		[Export ("emvAmountRequested")]
		void EmvAmountRequested ();

		// @optional -(void)readerBatteryLow;
		[Export ("readerBatteryLow")]
		void ReaderBatteryLow ();

		// @optional -(void)emvCardDipped;
		[Export ("emvCardDipped")]
		void EmvCardDipped ();

		// @optional -(void)emvCardRemoved;
		[Export ("emvCardRemoved")]
		void EmvCardRemoved ();

		// ****************  END OF REQUIRED CALLBACKS FOR EMV  ****************

		// @required -(void)readerCardResponse:(CFTCard *)card withError:(NSError *)error;
		[Abstract]
		[Export ("readerCardResponse:withError:")]
		void ReaderCardResponse (CFTCard card, NSError error);

		// @optional -(void)readerIsAttached;
		[Export ("readerIsAttached")]
		void ReaderIsAttached ();

		// @optional -(void)readerIsConnecting;
		[Export ("readerIsConnecting")]
		void ReaderIsConnecting ();

		// @optional -(void)readerIsConnected:(BOOL)isConnected withError:(NSError *)error;
		[Export ("readerIsConnected:withError:")]
		void ReaderIsConnected (bool isConnected, NSError error);
		
		// @optional -(void)readerSwipeDetected;
		[Export ("readerSwipeDetected")]
		void ReaderSwipeDetected ();

		// @optional -(void)readerIsDisconnected;
		[Export ("readerIsDisconnected")]
		void ReaderIsDisconnected ();

		// @optional -(void)readerSwipeDidCancel;
		[Export ("readerSwipeDidCancel")]
		void ReaderSwipeDidCancel ();
		
		// @optional -(void)readerNotDetected;
		[Export ("readerNotDetected")]
		void ReaderNotDetected ();		

		// @optional -(void)callback:(NSDictionary *)parameters;
		[Export ("callback:")]
		void Callback (NSDictionary parameters);


		// ******************** DEPRECATED ********************
		// @required -(void)transactionResult:(CFTCharge *)charge withError:(NSError *)error;
		[Abstract]
		[Export ("transactionResult:withError:")]
		void TransactionResult (CFTCharge charge, NSError error);
		// @optional -(void)readerSerialNumber:(NSString *)serialNumber __attribute__((deprecated("")));
		[Export ("readerSerialNumber:")]
		void ReaderSerialNumber (string serialNumber);
		// @optional -(void)readerGenericResponse:(NSString *)cardData __attribute__((deprecated("")));
		[Export ("readerGenericResponse:")]
		void ReaderGenericResponse (string cardData);

	}

	// @interface CFTReader : NSObject
	[BaseType (typeof(NSObject))]
	interface CFTReader
	{
		[Wrap ("WeakDelegate")]
		CFTReaderDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<CFTReaderDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(id)initWithReader:(NSUInteger)reader;
		[Export ("initWithReader:")]
		IntPtr Constructor (nuint reader);

		// -(NSUInteger)readerType;
		[Export ("readerType")]
		nuint ReaderType { get; }
		
		// -(void)beginSwipe;
		[Export ("beginSwipe")]
		void BeginSwipe ();

		// -(void)swipeHasTimeout:(BOOL)hasTimeout;
		[Export ("swipeHasTimeout:")]
		void SwipeHasTimeout (bool hasTimeout);

		// -(void)cancelTransaction;
		[Export ("cancelTransaction")]
		void CancelTransaction ();

		// - (CFTReaderState)readerState;
		[Export ("readerState")]
		CFTReaderState ReaderState ();

		// **************** EMV RELATED METHODS ****************

		// -(NSError *)beginEMVTransactionWithAmount:(NSDecimalNumber *)amount
		[Export ("beginEMVTransactionWithAmount:")]
		NSError BeginEMVTransactionWithAmount(NSDecimalNumber amount);

		// -(void)emvTransactionAmount:(NSDecimalNumber *)amount;
		[Export ("emvTransactionAmount:")]
		void EmvTransactionAmount (NSDecimalNumber amount);

		// -(void)emvSelectApplication:(NSInteger)application;
		[Export ("emvSelectApplication:")]
		void EmvSelectApplication (NSDecimalNumber amount);

		// -(void)emvProcessTransaction:(BOOL)process;
		[Export ("emvProcessTransaction:")]
		void EmvProcessTransaction (bool process);

		// -(void)emvTransactionSignature:(NSData *)signatureData;
		[Export ("emvTransactionSignature:")]
		void EmvTransactionSignature (NSData signatureData);

		// -(NSString *)defaultMessageForCFTEMVMessage:(CFTEMVMessage)message;
		[Abstract]
		[Export ("defaultMessageForCFTEMVMessage:")]
		NSString DefaultMessageForCFTEMVMessage(CFTEMVMessage message);

		// ****************  END EMV RELATED METHODS  ****************

		// ******************** DEPRECATED ********************
		// -(NSError *)beginTransactionWithAmount:(NSDecimalNumber *)amount andChargeDictionary:(NSDictionary *)chargeDictionary;
		[Export ("beginTransactionWithAmount:andChargeDictionary:")]
		NSError BeginTransactionWithAmount (NSDecimalNumber amount, NSDictionary chargeDictionary);
		// -(void)swipeTimeoutDuration:(NSInteger)duration __attribute__((deprecated("")));
		[Export ("swipeTimeoutDuration:")]
		void SwipeTimeoutDuration (nint duration);
		// -(void)cancelSwipeWithMessage:(NSString *)message __attribute__((deprecated("")));
		[Export ("cancelSwipeWithMessage:")]
		void CancelSwipeWithMessage (string message);
		// -(BOOL)retrieveSerialNumber __attribute__((deprecated("")));
		[Export ("retrieveSerialNumber")]
		bool RetrieveSerialNumber { get; }
	}

	// @interface CFTAPIResource : NSObject
	[BaseType (typeof(NSObject))]
	interface CFTAPIResource
	{
	}

	// @interface CFTCard : CFTAPIResource <NSCopying>
	[BaseType (typeof(CFTAPIResource))]
	interface CFTCard : INSCopying
	{
		// @property (readonly, nonatomic) NSString * last4;
		[Export ("last4")]
		string Last4 { get; }

		// @property (nonatomic, readonly) NSString *cardTypeString;
		[Export ("cardTypeString")]
		string CardTypeString { get; }

		// @property (readonly, nonatomic) NSString * expirationMonth;
		[Export ("expirationMonth")]
		string ExpirationMonth { get; }

		// @property (readonly, nonatomic) NSString * expirationYear;
		[Export ("expirationYear")]
		string ExpirationYear { get; }

		// @property (nonatomic) CFTCardType cardType;
		[Export ("cardType", ArgumentSemantic.Assign)]
		CFTCardType CardType { get; }

		// @property (copy, nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; }

		// @property (copy, nonatomic) NSString * cardToken;
		[Export ("cardToken")]
		string CardToken { get; }

		// @property (nonatomic, readonly) NSString *vaultID;
		[Export ("vaultID")]
		string VaultId { get; }

		// -(void)chargeCardWithParameters:(NSDictionary *)chargeDictionary success:(void (^)(CFTCharge *))success failure:(void (^)(NSError *))failure;
		[Export ("chargeCardWithParameters:success:failure:")]
		void ChargeCardWithParameters (NSDictionary chargeDictionary, Action<CFTCharge> success, Action<NSError> failure);

		// -(void)authorizeCardWithParameters:(NSDictionary *)authorizeDictionary success:(void (^)(CFTCharge *))success failure:(void (^)(NSError *))failure;
		[Export ("authorizeCardWithParameters:success:failure:")]
		void AuthorizeCardWithParameters (NSDictionary authorizeDictionary, Action<CFTCharge> success, Action<NSError> failure);

		// -(void)tokenizeCardWithSuccess:(void (^)(void))success failure:(void (^)(NSError *))failure;
		[Export ("tokenizeCardWithSuccess:failure:")]
		void TokenizeCardWithSuccess (Action success, Action<NSError> failure);

		// -(void)vaultCardWithSuccess:(void(^)(void))success failure:(void(^)(NSError *error))failure;
		[Export ("vaultCardWithSuccess:failure:")]
		void VaultCardWithSuccess (Action success, Action<NSError> failure);

		// (BOOL)isEqualToCard:(CFTCard *)card;
		[Abstract]
		[Export ("isEqualToCard:")]
		bool IsEqualToCard (CFTCard card);
		
		// -(NSDictionary *)dictionaryData:(NSData *)parameter;
		[Export ("dictionaryData:")]
		NSDictionary DictionaryData (NSData parameter);


		// ?????? SUPPORTED ??????
		// @property (copy, nonatomic) NSString * encryptedSwipedCardNumber;
		[Export ("encryptedSwipedCardNumber", ArgumentSemantic.Copy)]
		string EncryptedSwipedCardNumber { get; set; }
		// @property (copy, nonatomic) NSData * encryptedSwipeData;
		[Export ("encryptedSwipeData", ArgumentSemantic.Copy)]
		NSData EncryptedSwipeData { get; set; }

	}

	// @interface CFTCharge : CFTAPIResource
	[BaseType (typeof(CFTAPIResource))]
	interface CFTCharge
	{
		// @property (nonatomic) NSDecimalNumber * amount;
		[Export ("amount", ArgumentSemantic.Assign)]
		NSDecimalNumber Amount { get; set; }

		// @property (copy, nonatomic) NSString * token;
		[Export ("token", ArgumentSemantic.Copy)]
		string Token { get; set; }

		// @property (copy, nonatomic) NSString * referenceID;
		[Export ("referenceID", ArgumentSemantic.Copy)]
		string ReferenceID { get; set; }

		// @property (nonatomic) BOOL isRefunded;
		[Export ("isRefunded")]
		bool IsRefunded { get; set; }

		// @property (nonatomic) BOOL isVoided;
		[Export ("isVoided")]
		bool IsVoided { get; set; }

		// @property (nonatomic) NSDecimalNumber * amountRefunded;
		[Export ("amountRefunded", ArgumentSemantic.Assign)]
		NSDecimalNumber AmountRefunded { get; set; }

		// @property (nonatomic) NSDate * created;
		[Export ("created", ArgumentSemantic.Assign)]
		NSDate Created { get; set; }

		// @property (copy, nonatomic) NSDictionary * metadata;
		[Export ("metadata", ArgumentSemantic.Copy)]
		NSDictionary Metadata { get; set; }

		// + (void)cashChargeWithParameters:(NSDictionary *)chargeDictionary success:(void(^)(CFTCharge *charge))success failure:(void(^)(NSError *error))failure;
		[Static]
		[Export ("cashChargeWithParameters:success:failure:")]
		void CashChargeWithParameters (NSDictionary chargeDictionary, Action<CFTCharge> success, Action<NSError> failure);

		// +(void)refundChargeWithToken:(NSString *)token andAmount:(NSDecimalNumber *)amount success:(void (^)(CFTCharge *))success failure:(void (^)(NSError *))failure;
		[Static]
		[Export ("refundChargeWithToken:andAmount:success:failure:")]
		void RefundChargeWithToken (string token, NSDecimalNumber amount, Action<CFTCharge> success, Action<NSError> failure);

		// +(void)captureChargeWithToken:(NSString *)token andAmount:(NSDecimalNumber *)amount success:(void (^)(CFTCharge *))success failure:(void (^)(NSError *))failure;
		[Static]
		[Export ("captureChargeWithToken:andAmount:success:failure:")]
		void CaptureChargeWithToken (string token, NSDecimalNumber amount, Action<CFTCharge> success, Action<NSError> failure);

		// -(void)voidChargeWithSuccess:(void (^)())success failure:(void (^)(NSError *))failure;
		[Export ("voidChargeWithSuccess:failure:")]
		void VoidChargeWithSuccess (Action success, Action<NSError> failure);

		// +(void)attachSignatureWithToken:(NSString *)token signatureData:(NSData *)signatureData success:(void(^)(void))success success:(void(^)(void))success
		[Static]
		[Export ("attachSignatureWithToken:signatureData:success:failure:")]
		void AttachSignatureWithToken (string token, NSData signatureData, Action<CFTCharge> success, Action<NSError> failure);

	}

	// @protocol CFTAttacheReaderDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface CFTAttacheReaderDelegate
	{
		// @required -(void)readerCardResponse:(CFTCard *)card withError:(NSError *)error;
		[Abstract]
		[Export ("readerCardResponse:withError:")]
		void ReaderCardResponse (CFTCard card, NSError error);

		// @optional -(void)readerIsAttached;
		[Export ("readerIsAttached")]
		void ReaderIsAttached ();

		// @optional -(void)readerIsConnecting;
		[Export ("readerIsConnecting")]
		void ReaderIsConnecting ();

		// @optional -(void)readerIsConnected:(BOOL)isConnected withError:(NSError *)error;
		[Export ("readerIsConnected:withError:")]
		void ReaderIsConnected (bool isConnected, NSError error);

		// @optional -(void)readerGenericResponse:(NSString *)cardData;
		[Export ("readerGenericResponse:")]
		void ReaderGenericResponse (string cardData);

		// @optional -(void)readerIsDisconnected;
		[Export ("readerIsDisconnected")]
		void ReaderIsDisconnected ();

		// @optional -(void)readerSerialNumber:(NSString *)serialNumber;
		[Export ("readerSerialNumber:")]
		void ReaderSerialNumber (string serialNumber);

		// @optional -(void)readerSwipeDidCancel;
		[Export ("readerSwipeDidCancel")]
		void ReaderSwipeDidCancel ();
	}

	// @interface CFTAttacheReader : NSObject
	[BaseType (typeof(NSObject))]
	interface CFTAttacheReader
	{
		[Wrap ("WeakDelegate")]
		CFTAttacheReaderDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<CFTAttacheReaderDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @protocol customEntryDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface customEntryDelegate
	{
		// @optional -(BOOL)customTextField:(NSInteger)textFieldTag shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString *)string;
		[Export ("customTextField:shouldChangeCharactersInRange:replacementString:")]
		bool CustomTextField (nint textFieldTag, NSRange range, string @string);

		// @optional -(void)customTextFieldDidBeginEditing:(NSInteger)textFieldTag;
		[Export ("customTextFieldDidBeginEditing:")]
		void CustomTextFieldDidBeginEditing (nint textFieldTag);

		// @optional -(void)customTextFieldDidEndEditing:(NSInteger)textFieldTag;
		[Export ("customTextFieldDidEndEditing:")]
		void CustomTextFieldDidEndEditing (nint textFieldTag);

		// @optional -(BOOL)customTextFieldShouldBeginEditing:(NSInteger)textFieldTag;
		[Export ("customTextFieldShouldBeginEditing:")]
		bool CustomTextFieldShouldBeginEditing (nint textFieldTag);

		// @optional -(BOOL)customTextFieldShouldClear:(NSInteger)textFieldTag;
		[Export ("customTextFieldShouldClear:")]
		bool CustomTextFieldShouldClear (nint textFieldTag);

		// @optional -(BOOL)customTextFieldShouldReturn:(NSInteger)textFieldTag;
		[Export ("customTextFieldShouldReturn:")]
		bool CustomTextFieldShouldReturn (nint textFieldTag);
	}

	/*// @interface CFTBaseReader : NSObject
	[BaseType (typeof(NSObject))]
	interface CFTBaseReader
	{
		[Wrap ("WeakDelegate")]
		CFTReaderDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<CFTReaderDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @interface CFTCustomEntryTextField : UIView
	[BaseType (typeof(UIView))]
	interface CFTCustomEntryTextField
	{
		// -(void)customFieldFrame:(CGRect)newFrame;
		[Export ("customFieldFrame:")]
		void CustomFieldFrame (CGRect newFrame);

		// -(void)customFieldText:(NSString *)newText;
		[Export ("customFieldText:")]
		void CustomFieldText (string newText);

		// -(void)customFieldTag:(NSInteger)newTag;
		[Export ("customFieldTag:")]
		void CustomFieldTag (nint newTag);

		// -(void)customFieldBackground:(UIImage *)newBackground;
		[Export ("customFieldBackground:")]
		void CustomFieldBackground (UIImage newBackground);

		// -(void)customFieldLeftView:(UIView *)newView;
		[Export ("customFieldLeftView:")]
		void CustomFieldLeftView (UIView newView);

		// -(void)customFieldLeftViewMode:(UITextFieldViewMode)newViewMode;
		[Export ("customFieldLeftViewMode:")]
		void CustomFieldLeftViewMode (UITextFieldViewMode newViewMode);

		// -(void)customFieldRightView:(UIView *)newView;
		[Export ("customFieldRightView:")]
		void CustomFieldRightView (UIView newView);

		// -(void)customFieldRightViewMode:(UITextFieldViewMode)newViewMode;
		[Export ("customFieldRightViewMode:")]
		void CustomFieldRightViewMode (UITextFieldViewMode newViewMode);

		// -(void)customFieldFont:(UIFont *)newFont;
		[Export ("customFieldFont:")]
		void CustomFieldFont (UIFont newFont);

		// -(void)customFieldTextColor:(UIColor *)newColor;
		[Export ("customFieldTextColor:")]
		void CustomFieldTextColor (UIColor newColor);

		// -(void)customFieldPlaceholder:(NSString *)newPlaceholder;
		[Export ("customFieldPlaceholder:")]
		void CustomFieldPlaceholder (string newPlaceholder);

		// -(void)customFieldAttributedPlaceholder:(NSAttributedString *)newAttributedPlaceholder;
		[Export ("customFieldAttributedPlaceholder:")]
		void CustomFieldAttributedPlaceholder (NSAttributedString newAttributedPlaceholder);

		// -(void)customFieldTextAlignment:(NSTextAlignment)newAlignment;
		[Export ("customFieldTextAlignment:")]
		void CustomFieldTextAlignment (IntPtr newAlignment);

		// -(void)customFieldBorderStyle:(UITextBorderStyle)newBorder;
		[Export ("customFieldBorderStyle:")]
		void CustomFieldBorderStyle (UITextBorderStyle newBorder);

		// -(void)customFieldKeyboardType:(UIKeyboardType)newKeyboard;
		[Export ("customFieldKeyboardType:")]
		void CustomFieldKeyboardType (UIKeyboardType newKeyboard);

		// -(void)customFieldKeyboardAppearance:(UIKeyboardAppearance)newKeyboardAppearance;
		[Export ("customFieldKeyboardAppearance:")]
		void CustomFieldKeyboardAppearance (UIKeyboardAppearance newKeyboardAppearance);

		// -(void)customFieldReturnKeyType:(UIReturnKeyType)newReturnKeyType;
		[Export ("customFieldReturnKeyType:")]
		void CustomFieldReturnKeyType (UIReturnKeyType newReturnKeyType);

		// -(void)customFieldBecomeFirstResponder;
		[Export ("customFieldBecomeFirstResponder")]
		void CustomFieldBecomeFirstResponder ();

		// -(void)customFieldResignFirstResponder;
		[Export ("customFieldResignFirstResponder")]
		void CustomFieldResignFirstResponder ();
	}

	// @interface CFTCustomView : UIView
	[BaseType (typeof(UIView))]
	interface CFTCustomView
	{
		[Wrap ("WeakDelegate")]
		customEntryDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<customEntryDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) CFTCustomEntryTextField * cardNumber;
		[Export ("cardNumber", ArgumentSemantic.Assign)]
		CFTCustomEntryTextField CardNumber { get; set; }

		// @property (nonatomic) CFTCustomEntryTextField * expirationDate;
		[Export ("expirationDate", ArgumentSemantic.Assign)]
		CFTCustomEntryTextField ExpirationDate { get; set; }

		// @property (nonatomic) CFTCustomEntryTextField * cvvNumber;
		[Export ("cvvNumber", ArgumentSemantic.Assign)]
		CFTCustomEntryTextField CvvNumber { get; set; }

		// @property (nonatomic) CFTCustomEntryTextField * cardName;
		[Export ("cardName", ArgumentSemantic.Assign)]
		CFTCustomEntryTextField CardName { get; set; }

		// -(CFTCard *)generateCard;
		[Export ("generateCard")]
		CFTCard GenerateCard { get; }
	}*/
}