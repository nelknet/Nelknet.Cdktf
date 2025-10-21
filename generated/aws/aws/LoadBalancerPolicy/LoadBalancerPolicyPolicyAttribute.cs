using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LoadBalancerPolicy
{
    [JsiiByValue(fqn: "aws.loadBalancerPolicy.LoadBalancerPolicyPolicyAttribute")]
    public class LoadBalancerPolicyPolicyAttribute : aws.LoadBalancerPolicy.ILoadBalancerPolicyPolicyAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_policy#name LoadBalancerPolicy#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_policy#value LoadBalancerPolicy#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
