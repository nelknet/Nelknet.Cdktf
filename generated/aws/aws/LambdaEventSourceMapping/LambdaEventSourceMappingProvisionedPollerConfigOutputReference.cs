using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiClass(nativeType: typeof(aws.LambdaEventSourceMapping.LambdaEventSourceMappingProvisionedPollerConfigOutputReference), fullyQualifiedName: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingProvisionedPollerConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LambdaEventSourceMappingProvisionedPollerConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LambdaEventSourceMappingProvisionedPollerConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LambdaEventSourceMappingProvisionedPollerConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LambdaEventSourceMappingProvisionedPollerConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaximumPollers")]
        public virtual void ResetMaximumPollers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumPollers")]
        public virtual void ResetMinimumPollers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumPollersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumPollersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumPollersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinimumPollersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maximumPollers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumPollers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minimumPollers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinimumPollers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.lambdaEventSourceMapping.LambdaEventSourceMappingProvisionedPollerConfig\"}", isOptional: true)]
        public virtual aws.LambdaEventSourceMapping.ILambdaEventSourceMappingProvisionedPollerConfig? InternalValue
        {
            get => GetInstanceProperty<aws.LambdaEventSourceMapping.ILambdaEventSourceMappingProvisionedPollerConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
