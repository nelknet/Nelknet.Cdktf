using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Alb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.alb.AlbMinimumLoadBalancerCapacity")]
    public class AlbMinimumLoadBalancerCapacity : aws.Alb.IAlbMinimumLoadBalancerCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#capacity_units Alb#capacity_units}.</summary>
        [JsiiProperty(name: "capacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        public double CapacityUnits
        {
            get;
            set;
        }
    }
}
