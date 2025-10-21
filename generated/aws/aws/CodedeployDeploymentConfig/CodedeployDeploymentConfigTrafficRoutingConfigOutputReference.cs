using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentConfig
{
    [JsiiClass(nativeType: typeof(aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigOutputReference), fullyQualifiedName: "aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodedeployDeploymentConfigTrafficRoutingConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodedeployDeploymentConfigTrafficRoutingConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodedeployDeploymentConfigTrafficRoutingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentConfigTrafficRoutingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeBasedCanary", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"}}]")]
        public virtual void PutTimeBasedCanary(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeBasedLinear", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"}}]")]
        public virtual void PutTimeBasedLinear(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetTimeBasedCanary")]
        public virtual void ResetTimeBasedCanary()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeBasedLinear")]
        public virtual void ResetTimeBasedLinear()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetType")]
        public virtual void ResetType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "timeBasedCanary", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanaryOutputReference\"}")]
        public virtual aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanaryOutputReference TimeBasedCanary
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanaryOutputReference>()!;
        }

        [JsiiProperty(name: "timeBasedLinear", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinearOutputReference\"}")]
        public virtual aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinearOutputReference TimeBasedLinear
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinearOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeBasedCanaryInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary? TimeBasedCanaryInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedCanary?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeBasedLinearInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear? TimeBasedLinearInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfigTimeBasedLinear?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfig\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfig? InternalValue
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
