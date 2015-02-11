﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace loadify.Localization {
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
    public class Playlists {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Playlists() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("loadify.Localization.Playlists", typeof(Playlists).Assembly);
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
        ///   Looks up a localized string similar to The playlist could not be added because {0} is not a valid Spotify playlist link.
        /// </summary>
        public static string AddPlaylistInvalidLinkDialogMessage {
            get {
                return ResourceManager.GetString("AddPlaylistInvalidLinkDialogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait while Loadify is adding the playlist to your playlist collection.
        /// </summary>
        public static string AddPlaylistProcessingDialogMessage {
            get {
                return ResourceManager.GetString("AddPlaylistProcessingDialogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The track could not be added because {0} is not a valid Spotify track link.
        /// </summary>
        public static string AddTrackInvalidLinkDialogMessage {
            get {
                return ResourceManager.GetString("AddTrackInvalidLinkDialogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait while Loadify is adding the track to playlist {0}.
        /// </summary>
        public static string AddTrackProcessingDialogMessage {
            get {
                return ResourceManager.GetString("AddTrackProcessingDialogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Estimated download time.
        /// </summary>
        public static string EstimatedDownloadTimeInfo {
            get {
                return ResourceManager.GetString("EstimatedDownloadTimeInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Filter.
        /// </summary>
        public static string Filter {
            get {
                return ResourceManager.GetString("Filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait while Loadify is removing playlist {0} from your account.
        /// </summary>
        public static string RemovePlaylistProcessingDialogMessage {
            get {
                return ResourceManager.GetString("RemovePlaylistProcessingDialogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait while Loadify is retrieving playlists from your Spotify account..
        /// </summary>
        public static string RetrievingPlaylistsDialogMessage {
            get {
                return ResourceManager.GetString("RetrievingPlaylistsDialogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving Playlists....
        /// </summary>
        public static string RetrievingPlaylistsDialogTitle {
            get {
                return ResourceManager.GetString("RetrievingPlaylistsDialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tracks.
        /// </summary>
        public static string Tracks {
            get {
                return ResourceManager.GetString("Tracks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tracks selected.
        /// </summary>
        public static string TracksSelectedInfo {
            get {
                return ResourceManager.GetString("TracksSelectedInfo", resourceCulture);
            }
        }
    }
}