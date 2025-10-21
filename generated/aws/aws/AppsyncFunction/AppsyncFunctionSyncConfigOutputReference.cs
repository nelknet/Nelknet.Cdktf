using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncFunction
{
    [JsiiClass(nativeType: typeof(aws.AppsyncFunction.AppsyncFunctionSyncConfigOutputReference), fullyQualifiedName: "aws.appsyncFunction.AppsyncFunctionSyncConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppsyncFunctionSyncConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppsyncFunctionSyncConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppsyncFunctionSyncConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncFunctionSyncConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLambdaConflictHandlerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfig\"}}]")]
        public virtual void PutLambdaConflictHandlerConfig(aws.AppsyncFunction.IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncFunction.IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConflictDetection")]
        public virtual void ResetConflictDetection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConflictHandler")]
        public virtual void ResetConflictHandler()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaConflictHandlerConfig")]
        public virtual void ResetLambdaConflictHandlerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "lambdaConflictHandlerConfig", typeJson: "{\"fqn\":\"aws.appsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfigOutputReference\"}")]
        public virtual aws.AppsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfigOutputReference LambdaConflictHandlerConfig
        {
            get => GetInstanceProperty<aws.AppsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "conflictDetectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConflictDetectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conflictHandlerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConflictHandlerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaConflictHandlerConfigInput", typeJson: "{\"fqn\":\"aws.appsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfig\"}", isOptional: true)]
        public virtual aws.AppsyncFunction.IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncFunction.IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig?>();
        }

        [JsiiProperty(name: "conflictDetection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConflictDetection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "conflictHandler", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConflictHandler
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appsyncFunction.AppsyncFunctionSyncConfig\"}", isOptional: true)]
        public virtual aws.AppsyncFunction.IAppsyncFunctionSyncConfig? InternalValue
        {
            get => GetInstanceProperty<aws.AppsyncFunction.IAppsyncFunctionSyncConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
