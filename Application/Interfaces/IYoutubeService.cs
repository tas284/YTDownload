﻿using YTDownload.Application.Commands;
using YTDownload.Application.ViewModel;

namespace YTDownload.Application.Interfaces
{
    public interface IYoutubeService
    {
        Task<IEnumerable<StreamManifestViewModel>> DownloadManifest(string url);
        Task<string> Download(DownloadCommand command);
        Task Converter(string file);
    }
}
