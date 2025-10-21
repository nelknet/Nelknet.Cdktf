using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiClass(nativeType: typeof(aws.AppsyncDatasource.AppsyncDatasourceHttpConfigOutputReference), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceHttpConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppsyncDatasourceHttpConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppsyncDatasourceHttpConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppsyncDatasourceHttpConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncDatasourceHttpConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthorizationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfig\"}}]")]
        public virtual void PutAuthorizationConfig(aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthorizationConfig")]
        public virtual void ResetAuthorizationConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigOutputReference\"}")]
        public virtual aws.AppsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigOutputReference AuthorizationConfig
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationConfigInput", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig? AuthorizationConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig? InternalValue
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
