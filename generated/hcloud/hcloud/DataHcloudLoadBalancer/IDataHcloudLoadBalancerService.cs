using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.DataHcloudLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IDataHcloudLoadBalancerService), fullyQualifiedName: "hcloud.dataHcloudLoadBalancer.DataHcloudLoadBalancerService")]
    public interface IDataHcloudLoadBalancerService
    {

        [JsiiTypeProxy(nativeType: typeof(IDataHcloudLoadBalancerService), fullyQualifiedName: "hcloud.dataHcloudLoadBalancer.DataHcloudLoadBalancerService")]
        internal sealed class _Proxy : DeputyBase, hcloud.DataHcloudLoadBalancer.IDataHcloudLoadBalancerService
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
