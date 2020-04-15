using Foundation;
using ObjCRuntime;

namespace BundleLocalization
{
    // @interface Localization (NSBundle)
    [Category]
    [BaseType(typeof(NSBundle))]
    interface NSBundle_Localization
    {
        [Export("load")]
        void Load();
    }

    // @interface BundleLocalization : NSObject
    [BaseType(typeof(NSObject))]
    interface BundleLocalization
    {
        // +(BundleLocalization *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        BundleLocalization SharedInstance { get; }

        // @property (nonatomic, strong) NSString * language;
        [Export("language", ArgumentSemantic.Strong)]
        string Language { get; set; }

        // @property (readonly, weak) NSBundle * localizationBundle;
        [Export("localizationBundle", ArgumentSemantic.Weak)]
        NSBundle LocalizationBundle { get; }
    }
}
