using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.finspaceKxCluster.FinspaceKxClusterTickerplantLogConfiguration")]
    public class FinspaceKxClusterTickerplantLogConfiguration : aws.FinspaceKxCluster.IFinspaceKxClusterTickerplantLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#tickerplant_log_volumes FinspaceKxCluster#tickerplant_log_volumes}.</summary>
        [JsiiProperty(name: "tickerplantLogVolumes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] TickerplantLogVolumes
        {
            get;
            set;
        }
    }
}
