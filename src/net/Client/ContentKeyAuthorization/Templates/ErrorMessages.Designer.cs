﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.MediaServices.Client.ContentKeyAuthorization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.WindowsAzure.MediaServices.Client.ContentKeyAuthorization.Templates.Err" +
                            "orMessages", typeof(ErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can only be set to null, 100, 150, or 200..
        /// </summary>
        public static string AnalogVideoOplValueError {
            get {
                return ResourceManager.GetString("AnalogVideoOplValueError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A PlayReadyLicenseResponseTemplate must have at least one PlayReadyLicenseTemplate.
        /// </summary>
        public static string AtLeastOneLicenseTemplateRequired {
            get {
                return ResourceManager.GetString("AtLeastOneLicenseTemplateRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can only be set to null, 100, 150, 200, 250, or 300..
        /// </summary>
        public static string CompressedDigitalAudioOplValueError {
            get {
                return ResourceManager.GetString("CompressedDigitalAudioOplValueError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can only be set to null, 400, or 500..
        /// </summary>
        public static string CompressedDigitalVideoOplValueError {
            get {
                return ResourceManager.GetString("CompressedDigitalVideoOplValueError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PlayReady does not allow passing to unknown outputs if the DigitalVideoOnlyContentRestriction is enabled..
        /// </summary>
        public static string DigitalVideoOnlyMutuallyExclusiveWithPassingToUnknownOutputError {
            get {
                return ResourceManager.GetString("DigitalVideoOnlyMutuallyExclusiveWithPassingToUnknownOutputError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FirstPlayExpiration cannot be set on the PlayRight of a Non Persistent license..
        /// </summary>
        public static string FirstPlayExpirationCannotBeSetOnNonPersistentLicense {
            get {
                return ResourceManager.GetString("FirstPlayExpirationCannotBeSetOnNonPersistentLicense", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to GracePeriod cannot be set on Non Persistent licenses..
        /// </summary>
        public static string GracePeriodCannotBeSetOnNonPersistentLicense {
            get {
                return ResourceManager.GetString("GracePeriodCannotBeSetOnNonPersistentLicense", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ConfigurationData must be 0, 1, 2, or 3.
        /// </summary>
        public static string InvalidTwoBitConfigurationData {
            get {
                return ResourceManager.GetString("InvalidTwoBitConfigurationData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Each PlayReadyLicenseTemplate in the PlayReadyLicenseResponseTemplate must have either a ContentEncryptionKeyFromHeader or a ContentEncryptionKeyFromKeyIdentifier.
        /// </summary>
        public static string PlayReadyContentKeyRequired {
            get {
                return ResourceManager.GetString("PlayReadyContentKeyRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Each PlayReadyLicenseTemplate in the PlayReadyLicenseResponseTemplate must have a PlayReadyPlayRight.
        /// </summary>
        public static string PlayReadyPlayRightRequired {
            get {
                return ResourceManager.GetString("PlayReadyPlayRightRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can only be set to null, 100, 150, 200, 250, or 300..
        /// </summary>
        public static string UncompressedDigitalAudioOplValueError {
            get {
                return ResourceManager.GetString("UncompressedDigitalAudioOplValueError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value can only be set to null, 100, 250, 270, or 300..
        /// </summary>
        public static string UncompressedDigitalVideoOplValueError {
            get {
                return ResourceManager.GetString("UncompressedDigitalVideoOplValueError", resourceCulture);
            }
        }
    }
}
