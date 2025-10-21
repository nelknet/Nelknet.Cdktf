using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lb
{
    [JsiiInterface(nativeType: typeof(ILbMinimumLoadBalancerCapacity), fullyQualifiedName: "aws.lb.LbMinimumLoadBalancerCapacity")]
    public interface ILbMinimumLoadBalancerCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#capacity_units Lb#capacity_units}.</summary>
        [JsiiProperty(name: "capacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        double CapacityUnits
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbMinimumLoadBalancerCapacity), fullyQualifiedName: "aws.lb.LbMinimumLoadBalancerCapacity")]
        internal sealed class _Proxy : DeputyBase, aws.Lb.ILbMinimumLoadBalancerCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb#capacity_units Lb#capacity_units}.</summary>
            [JsiiProperty(name: "capacityUnits", typeJson: "{\"primitive\":\"number\"}")]
            public double CapacityUnits
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
