using StackExchange.Redis;

namespace RedisLibrary
{
    public interface IConnectionFactory
    {
        public IConfig Configuration { get; set; }
        public IConnectionMultiplexer CreateConnection();
    }

    public class ConnectionFactory : IConnectionFactory
    {
        public IConfig Configuration { get; set; }

        public ConnectionFactory(IConfig configuration)
        {
            Configuration = configuration;
        }

        public IConnectionMultiplexer CreateConnection()
        {
            return ConnectionMultiplexer.Connect(Configuration.GetAddress());
        }
    }
}
