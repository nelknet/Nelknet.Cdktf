using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiClass(nativeType: typeof(aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeOutputReference), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putErrorHandlingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig\"}}]")]
        public virtual void PutErrorHandlingConfig(aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetErrorHandlingConfig")]
        public virtual void ResetErrorHandlingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "errorHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfigOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfigOutputReference ErrorHandlingConfig
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorHandlingConfigInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig? ErrorHandlingConfigInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycodeErrorHandlingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "object", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Object
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycode\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycode? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesHoneycode?>();
            set => SetInstanceProperty(value);
        }
    }
}
