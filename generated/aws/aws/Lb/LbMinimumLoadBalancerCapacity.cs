using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lb.LbMinimumLoadBalancerCapacity")]
    public class LbMinimumLoadBalancerCapacity : aws.Lb.ILbMinimumLoadBalancerCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#capacity_units Lb#capacity_units}.</summary>
        [JsiiProperty(name: "capacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        public double CapacityUnits
        {
            get;
            set;
        }
    }
}
