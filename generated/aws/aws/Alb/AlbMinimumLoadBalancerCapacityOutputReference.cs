using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Alb
{
    [JsiiClass(nativeType: typeof(aws.Alb.AlbMinimumLoadBalancerCapacityOutputReference), fullyQualifiedName: "aws.alb.AlbMinimumLoadBalancerCapacityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbMinimumLoadBalancerCapacityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbMinimumLoadBalancerCapacityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbMinimumLoadBalancerCapacityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbMinimumLoadBalancerCapacityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "capacityUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CapacityUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "capacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CapacityUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.alb.AlbMinimumLoadBalancerCapacity\"}", isOptional: true)]
        public virtual aws.Alb.IAlbMinimumLoadBalancerCapacity? InternalValue
        {
            get => GetInstanceProperty<aws.Alb.IAlbMinimumLoadBalancerCapacity?>();
            set => SetInstanceProperty(value);
        }
    }
}
