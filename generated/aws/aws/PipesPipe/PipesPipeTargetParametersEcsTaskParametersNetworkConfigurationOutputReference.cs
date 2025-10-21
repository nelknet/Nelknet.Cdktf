using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PipesPipe
{
    [JsiiClass(nativeType: typeof(aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationOutputReference), fullyQualifiedName: "aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAwsVpcConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration\"}}]")]
        public virtual void PutAwsVpcConfiguration(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAwsVpcConfiguration")]
        public virtual void ResetAwsVpcConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "awsVpcConfiguration", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfigurationOutputReference\"}")]
        public virtual aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfigurationOutputReference AwsVpcConfiguration
        {
            get => GetInstanceProperty<aws.PipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsVpcConfigurationInput", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration? AwsVpcConfigurationInput
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfigurationAwsVpcConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.pipesPipe.PipesPipeTargetParametersEcsTaskParametersNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.PipesPipe.IPipesPipeTargetParametersEcsTaskParametersNetworkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
