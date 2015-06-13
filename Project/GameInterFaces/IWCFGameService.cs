using System.ServiceModel;

namespace GameInterfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFGameService" in both code and config file together.
    [ServiceContract]
    public interface IWcfGameService
    {
        [OperationContract]
        string SayHello();
    }
}
