using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiClass(nativeType: typeof(aws.SagemakerDomain.SagemakerDomainDomainSettingsOutputReference), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDomainSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerDomainDomainSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerDomainDomainSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerDomainDomainSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDomainSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDockerSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsDockerSettings\"}}]")]
        public virtual void PutDockerSettings(aws.SagemakerDomain.ISagemakerDomainDomainSettingsDockerSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDomainSettingsDockerSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRStudioServerProDomainSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettings\"}}]")]
        public virtual void PutRStudioServerProDomainSettings(aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDockerSettings")]
        public virtual void ResetDockerSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionRoleIdentityConfig")]
        public virtual void ResetExecutionRoleIdentityConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRStudioServerProDomainSettings")]
        public virtual void ResetRStudioServerProDomainSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupIds")]
        public virtual void ResetSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dockerSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsDockerSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDomainSettingsDockerSettingsOutputReference DockerSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDomainSettingsDockerSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "rStudioServerProDomainSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsOutputReference RStudioServerProDomainSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dockerSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsDockerSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDomainSettingsDockerSettings? DockerSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDomainSettingsDockerSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleIdentityConfigInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleIdentityConfigInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rStudioServerProDomainSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings? RStudioServerProDomainSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "executionRoleIdentityConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleIdentityConfig
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDomainSettings? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDomainSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
