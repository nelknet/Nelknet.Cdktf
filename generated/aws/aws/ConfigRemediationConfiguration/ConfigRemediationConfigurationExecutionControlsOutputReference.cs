using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigRemediationConfiguration
{
    [JsiiClass(nativeType: typeof(aws.ConfigRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsOutputReference), fullyQualifiedName: "aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConfigRemediationConfigurationExecutionControlsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConfigRemediationConfigurationExecutionControlsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConfigRemediationConfigurationExecutionControlsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigRemediationConfigurationExecutionControlsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSsmControls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControls\"}}]")]
        public virtual void PutSsmControls(aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControlsSsmControls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControlsSsmControls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSsmControls")]
        public virtual void ResetSsmControls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "ssmControls", typeJson: "{\"fqn\":\"aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference\"}")]
        public virtual aws.ConfigRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference SsmControls
        {
            get => GetInstanceProperty<aws.ConfigRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssmControlsInput", typeJson: "{\"fqn\":\"aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControlsSsmControls\"}", isOptional: true)]
        public virtual aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControlsSsmControls? SsmControlsInput
        {
            get => GetInstanceProperty<aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControlsSsmControls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.configRemediationConfiguration.ConfigRemediationConfigurationExecutionControls\"}", isOptional: true)]
        public virtual aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControls? InternalValue
        {
            get => GetInstanceProperty<aws.ConfigRemediationConfiguration.IConfigRemediationConfigurationExecutionControls?>();
            set => SetInstanceProperty(value);
        }
    }
}
