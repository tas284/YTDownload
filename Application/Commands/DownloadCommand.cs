namespace YTDownload.Application.Commands
{
    public record DownloadCommand(string Url, string ContainerName, string VideoCodec, string Resolution, string AudioCodec,  bool IsAudioOnly);
}