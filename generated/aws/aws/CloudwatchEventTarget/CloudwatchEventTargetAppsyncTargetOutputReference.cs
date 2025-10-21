using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventTarget
{
    [JsiiClass(nativeType: typeof(aws.CloudwatchEventTarget.CloudwatchEventTargetAppsyncTargetOutputReference), fullyQualifiedName: "aws.cloudwatchEventTarget.CloudwatchEventTargetAppsyncTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CloudwatchEventTargetAppsyncTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CloudwatchEventTargetAppsyncTargetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CloudwatchEventTargetAppsyncTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudwatchEventTargetAppsyncTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetGraphqlOperation")]
        public virtual void ResetGraphqlOperation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "graphqlOperationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GraphqlOperationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "graphqlOperation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GraphqlOperation
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudwatchEventTarget.CloudwatchEventTargetAppsyncTarget\"}", isOptional: true)]
        public virtual aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget? InternalValue
        {
            get => GetInstanceProperty<aws.CloudwatchEventTarget.ICloudwatchEventTargetAppsyncTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
