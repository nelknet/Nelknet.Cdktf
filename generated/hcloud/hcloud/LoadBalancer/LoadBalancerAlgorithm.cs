using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace hcloud.LoadBalancer
{
    [JsiiByValue(fqn: "hcloud.loadBalancer.LoadBalancerAlgorithm")]
    public class LoadBalancerAlgorithm : hcloud.LoadBalancer.ILoadBalancerAlgorithm
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#type LoadBalancer#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
