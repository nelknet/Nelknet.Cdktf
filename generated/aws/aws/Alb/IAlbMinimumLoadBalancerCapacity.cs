using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Alb
{
    [JsiiInterface(nativeType: typeof(IAlbMinimumLoadBalancerCapacity), fullyQualifiedName: "aws.alb.AlbMinimumLoadBalancerCapacity")]
    public interface IAlbMinimumLoadBalancerCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#capacity_units Alb#capacity_units}.</summary>
        [JsiiProperty(name: "capacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        double CapacityUnits
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbMinimumLoadBalancerCapacity), fullyQualifiedName: "aws.alb.AlbMinimumLoadBalancerCapacity")]
        internal sealed class _Proxy : DeputyBase, aws.Alb.IAlbMinimumLoadBalancerCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb#capacity_units Alb#capacity_units}.</summary>
            [JsiiProperty(name: "capacityUnits", typeJson: "{\"primitive\":\"number\"}")]
            public double CapacityUnits
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
