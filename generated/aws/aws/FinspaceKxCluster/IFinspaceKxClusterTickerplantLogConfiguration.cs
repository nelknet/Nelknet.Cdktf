using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxCluster
{
    [JsiiInterface(nativeType: typeof(IFinspaceKxClusterTickerplantLogConfiguration), fullyQualifiedName: "aws.finspaceKxCluster.FinspaceKxClusterTickerplantLogConfiguration")]
    public interface IFinspaceKxClusterTickerplantLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#tickerplant_log_volumes FinspaceKxCluster#tickerplant_log_volumes}.</summary>
        [JsiiProperty(name: "tickerplantLogVolumes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TickerplantLogVolumes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFinspaceKxClusterTickerplantLogConfiguration), fullyQualifiedName: "aws.finspaceKxCluster.FinspaceKxClusterTickerplantLogConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.FinspaceKxCluster.IFinspaceKxClusterTickerplantLogConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#tickerplant_log_volumes FinspaceKxCluster#tickerplant_log_volumes}.</summary>
            [JsiiProperty(name: "tickerplantLogVolumes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TickerplantLogVolumes
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
