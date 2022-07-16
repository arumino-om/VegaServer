using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VegaServerCore
{
    public class Configuration
    {
        public static string CONFIG_FILE = Path.Combine(Environment.CurrentDirectory, "config.json");

        /// <summary>
        /// 全ての設定を取得します。
        /// </summary>
        /// <returns>全ての設定を格納した JObject</returns>
        public static JObject GetAllConfiguration() => JObject.Parse(File.ReadAllText(CONFIG_FILE));
    }
}
