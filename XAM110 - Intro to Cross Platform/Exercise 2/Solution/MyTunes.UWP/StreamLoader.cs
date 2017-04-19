using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyTunes.Shared;
using Windows.ApplicationModel;
using Windows.Storage;

namespace MyTunes.UWP
{
    class StreamLoader : IStreamLoader
    {
        public Stream GetStreamForFilename(string filename)
        {
            return Package.Current.InstalledLocation.GetFileAsync(filename)
                .AsTask().Result.OpenStreamForReadAsync().Result;
        }
    }
}
