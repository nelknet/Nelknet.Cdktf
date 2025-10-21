using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersVirtualCluster
{
    [JsiiByValue(fqn: "aws.emrcontainersVirtualCluster.EmrcontainersVirtualClusterTimeouts")]
    public class EmrcontainersVirtualClusterTimeouts : aws.EmrcontainersVirtualCluster.IEmrcontainersVirtualClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_virtual_cluster#delete EmrcontainersVirtualCluster#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
