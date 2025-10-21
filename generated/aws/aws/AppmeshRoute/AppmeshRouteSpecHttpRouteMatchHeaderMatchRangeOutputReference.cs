using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshRoute.AppmeshRouteSpecHttpRouteMatchHeaderMatchRangeOutputReference), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecHttpRouteMatchHeaderMatchRangeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshRouteSpecHttpRouteMatchHeaderMatchRangeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshRouteSpecHttpRouteMatchHeaderMatchRangeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshRouteSpecHttpRouteMatchHeaderMatchRangeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteMatchHeaderMatchRangeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "endInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EndInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StartInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double End
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Start
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteMatchHeaderMatchRange\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRouteMatchHeaderMatchRange?>();
            set => SetInstanceProperty(value);
        }
    }
}
