using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiClass(nativeType: typeof(aws.AppsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigOutputReference), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppsyncDatasourceHttpConfigAuthorizationConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppsyncDatasourceHttpConfigAuthorizationConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppsyncDatasourceHttpConfigAuthorizationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncDatasourceHttpConfigAuthorizationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAwsIamConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig\"}}]")]
        public virtual void PutAwsIamConfig(aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthorizationType")]
        public virtual void ResetAuthorizationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAwsIamConfig")]
        public virtual void ResetAwsIamConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "awsIamConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfigOutputReference\"}")]
        public virtual aws.AppsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfigOutputReference AwsIamConfig
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthorizationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsIamConfigInput", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig? AwsIamConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig?>();
        }

        [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfig\"}", isOptional: true)]
        public virtual aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig? InternalValue
        {
            get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
