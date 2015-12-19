MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/xbuild
BINDINGIOS=../binding/iOS/
BINDINGANDROID=../binding/Android/
SAMPLEIOS=../sample/iOS/
SAMPLEANDROID=../sample/Android/

all: prepare CardFlight.dll

prepare:
	curl https://codeload.github.com/CardFlight/cardflight-ios/zip/master -o CardFlight-iOS.zip
	curl https://xamarin-components.s3.amazonaws.com/afe273b9fbc4b48bf4a282d8cd5a51ed/xamandroidsupportv4-18-22.2.0.0.zip -o AndroidSupportV4.zip
	unzip CardFlight-iOS.zip
	unzip AndroidSupportV4.zip
	mkdir DLL
	
CardFlight.dll:
	$(MONOXBUILD) /p:Configuration=Release $(BINDINGIOS)CardFlight.iOS.csproj	
	cp $(BINDINGIOS)bin/Release/CardFlight.dll DLL/CardFlight.iOS.dll

	$(MONOXBUILD) /p:Configuration=Release $(BINDINGANDROID)CardFlight.Android.csproj
	cp $(BINDINGANDROID)bin/Release/CardFlight.dll DLL/CardFlight.Android.dll

clean:
	rm -r *.zip *.dll DLL/ cardflight-ios-master/ xamandroidsupportv4-18-22.2.0.0/ $(BINDINGIOS)bin/ $(BINDINGIOS)obj/ $(SAMPLEIOS)bin/ $(SAMPLEIOS)/obj/ $(BINDINGANDROID)bin/ $(BINDINGANDROID)obj/ $(SAMPLEANDROID)bin/ $(SAMPLEANDROID)/obj/
