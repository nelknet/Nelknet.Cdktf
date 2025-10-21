using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbTargetGroup
{
    [JsiiClass(nativeType: typeof(aws.AlbTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference), fullyQualifiedName: "aws.albTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbTargetGroupTargetGroupHealthUnhealthyStateRoutingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMinimumHealthyTargetsCount")]
        public virtual void ResetMinimumHealthyTargetsCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumHealthyTargetsPercentage")]
        public virtual void ResetMinimumHealthyTargetsPercentage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyTargetsCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumHealthyTargetsCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyTargetsPercentageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MinimumHealthyTargetsPercentageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "minimumHealthyTargetsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumHealthyTargetsCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumHealthyTargetsPercentage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinimumHealthyTargetsPercentage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.albTargetGroup.AlbTargetGroupTargetGroupHealthUnhealthyStateRouting\"}", isOptional: true)]
        public virtual aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthUnhealthyStateRouting? InternalValue
        {
            get => GetInstanceProperty<aws.AlbTargetGroup.IAlbTargetGroupTargetGroupHealthUnhealthyStateRouting?>();
            set => SetInstanceProperty(value);
        }
    }
}
