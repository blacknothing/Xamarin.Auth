rmdir /s /q source\output

"c:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild" /p:Configuration=Release source\Xamarin.Auth-Library.sln

mkdir source\output
mkdir source\output\pcl
mkdir source\output\android
mkdir source\output\ios-unified
mkdir source\output\ios
mkdir source\output\uwp

copy source\Xamarin.Auth.Portable\bin\Release\Xamarin.Auth.dll source\output\pcl
copy source\Xamarin.Auth.XamarinAndroid\bin\Release\Xamarin.Auth.dll source\output\android
copy source\Xamarin.Auth.XamarinIOS\bin\Release\Xamarin.Auth.dll source\output\ios-unified
copy source\Xamarin.Auth.XamarinIOS-Classic\bin\Release\Xamarin.Auth.dll source\output\ios
copy source\Xamarin.Auth.UniversalWindowsPlatform\bin\Release\*.* source\output\uwp
