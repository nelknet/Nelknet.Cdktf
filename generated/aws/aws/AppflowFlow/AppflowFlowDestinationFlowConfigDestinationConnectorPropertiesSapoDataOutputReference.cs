using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppflowFlow
{
    [JsiiClass(nativeType: typeof(aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataOutputReference), fullyQualifiedName: "aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putErrorHandlingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig\"}}]")]
        public virtual void PutErrorHandlingConfig(aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSuccessResponseHandlingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig\"}}]")]
        public virtual void PutSuccessResponseHandlingConfig(aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetErrorHandlingConfig")]
        public virtual void ResetErrorHandlingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdFieldNames")]
        public virtual void ResetIdFieldNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccessResponseHandlingConfig")]
        public virtual void ResetSuccessResponseHandlingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWriteOperationType")]
        public virtual void ResetWriteOperationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "errorHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfigOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfigOutputReference ErrorHandlingConfig
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "successResponseHandlingConfig", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfigOutputReference\"}")]
        public virtual aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfigOutputReference SuccessResponseHandlingConfig
        {
            get => GetInstanceProperty<aws.AppflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorHandlingConfigInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig? ErrorHandlingConfigInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataErrorHandlingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idFieldNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IdFieldNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successResponseHandlingConfigInput", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig? SuccessResponseHandlingConfigInput
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoDataSuccessResponseHandlingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "writeOperationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WriteOperationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "idFieldNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdFieldNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "writeOperationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WriteOperationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appflowFlow.AppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData\"}", isOptional: true)]
        public virtual aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData? InternalValue
        {
            get => GetInstanceProperty<aws.AppflowFlow.IAppflowFlowDestinationFlowConfigDestinationConnectorPropertiesSapoData?>();
            set => SetInstanceProperty(value);
        }
    }
}
