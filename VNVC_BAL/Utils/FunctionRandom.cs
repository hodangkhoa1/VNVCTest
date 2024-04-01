using System.Text;

namespace VNVC_BAL.Utils
{
    public class FunctionRandom
    {
        #region Default Avatar Array
        private static readonly string[] DefaultAvatarArray = {
            "#FF9933", "#FF9900", "#CC99FF", "#CC99CC", "#CC9999", "#CC9966", "#CC9933", "#CC9900", "#9999FF", "#9999CC",
            "#999999", "#999966", "#6699FF", "#6699CC", "#339933", "#0099FF", "#0099CC", "#009999", "#009966", "#009900",
            "#FF66FF", "#FF6699", "#FF6666", "#FF6633", "#9966FF", "#6666FF", "#6666CC", "#3366FF", "#3366CC", "#FF33FF",
            "#FF3366", "#FF3300", "#9933FF", "#993300", "#6633FF", "#3333FF", "#FF3333", "#FF0066", "#660066", "#330000"
        };
        #endregion

        #region Function Random Color Avatar
        public static string ColorAvatar()
        {
            Random random = new();
            int index = random.Next(DefaultAvatarArray.Length);
            return DefaultAvatarArray[index];
        }
        #endregion
    }
}
