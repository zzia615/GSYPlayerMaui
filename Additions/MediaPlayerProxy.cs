using TV.Danmaku.Ijk.Media.Player.Misc;

namespace TV.Danmaku.Ijk.Media.Player
{
    public sealed partial class IjkMediaPlayer
    {
        public override ITrackInfo[]? GetTrackInfo()
        {
            return GetTrackInfoSelf();
        }
    }
    //public partial class AndroidMediaPlayer
    //{
    //    public override ITrackInfo[]? GetTrackInfoBase()
    //    {
    //        return GetTrackInfo();
    //    }
    //}
    //public partial class MediaPlayerProxy
    //{
    //    public ITrackInfo[]? GetTrackInfoBase()
    //    {
    //        return GetTrackInfo();
    //    }
    //}
}