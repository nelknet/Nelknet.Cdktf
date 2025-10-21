using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiClass(nativeType: typeof(aws.AppflowFlow.AppflowFlowSourceFlowConfigOutputReference), fullyQualifiedName: "aws.appflowFlow.AppflowFlowSourceFlowConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowFlowSourceFlowConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowFlowSourceFlowConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowFlowSourceFlowConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowFlowSourceFlowConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIncrementalPullConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfig\"}}]")]
        public virtual void PutIncrementalPullConfig(aws.AppflowFlow.IAppflowFlowSourceFlowConfigIncrementalPullConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigIncrementalPullConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceConnectorProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorProperties\"}}]")]
        public virtual void PutSourceConnectorProperties(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApiVersion")]
        public virtual void ResetApiVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectorProfileName")]
        public virtual void ResetConnectorProfileName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncrementalPullConfig")]
        public virtual void ResetIncrementalPullConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "incrementalPullConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfigOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfigOutputReference IncrementalPullConfig
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfigOutputReference>()!;
        }

        [JsiiProperty(name: "sourceConnectorProperties", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesOutputReference SourceConnectorProperties
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowSourceFlowConfigSourceConnectorPropertiesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "apiVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApiVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectorProfileNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectorProfileNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectorTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectorTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "incrementalPullConfigInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigIncrementalPullConfig\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigIncrementalPullConfig? IncrementalPullConfigInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigIncrementalPullConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceConnectorPropertiesInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfigSourceConnectorProperties\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorProperties? SourceConnectorPropertiesInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfigSourceConnectorProperties?>();
        }

        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApiVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectorProfileName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorProfileName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectorType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectorType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowSourceFlowConfig\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowSourceFlowConfig? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowSourceFlowConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
