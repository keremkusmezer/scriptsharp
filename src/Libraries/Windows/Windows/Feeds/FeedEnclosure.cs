// FeedEnclosure.cs
// Script#/Libraries/Windows
// Copyright (c) Nikhil Kothari.
// Copyright (c) Microsoft Corporation.
// This source code is subject to terms and conditions of the Microsoft 
// Public License. A copy of the license can be found in License.txt.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Windows.Feeds {

    [IgnoreNamespace]
    [Imported]
    public sealed class FeedEnclosure {

        private FeedEnclosure() {
        }

        [IntrinsicProperty]
        [PreserveCase]
        public string DownloadMimeType {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        [PreserveCase]
        public DownloadStatus DownloadStatus {
            get {
                return DownloadStatus.None;
            }
        }

        [IntrinsicProperty]
        [PreserveCase]
        public string DownloadUrl {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        [PreserveCase]
        public DownloadError LastDownloadError {
            get {
                return DownloadError.None;
            }
        }

        [IntrinsicProperty]
        [PreserveCase]
        public int Length {
            get {
                return 0;
            }
        }

        [IntrinsicProperty]
        [PreserveCase]
        public string LocalPath {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        [PreserveCase]
        public FeedItem Parent {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        [PreserveCase]
        public string Type {
            get {
                return null;
            }
        }

        [IntrinsicProperty]
        [PreserveCase]
        public string Url {
            get {
                return null;
            }
        }

        [PreserveCase]
        public void AsyncDownload() {
        }

        [PreserveCase]
        public void CancelAsyncDownload() {
        }

        [PreserveCase]
        public void RemoveFile() {
        }
    }
}
