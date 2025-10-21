using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncGraphqlApi
{
    [JsiiClass(nativeType: typeof(aws.AppsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderOutputReference), fullyQualifiedName: "aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppsyncGraphqlApiAdditionalAuthenticationProviderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AppsyncGraphqlApiAdditionalAuthenticationProviderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApiAdditionalAuthenticationProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApiAdditionalAuthenticationProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLambdaAuthorizerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig\"}}]")]
        public virtual void PutLambdaAuthorizerConfig(aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpenidConnectConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig\"}}]")]
        public virtual void PutOpenidConnectConfig(aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserPoolConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig\"}}]")]
        public virtual void PutUserPoolConfig(aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLambdaAuthorizerConfig")]
        public virtual void ResetLambdaAuthorizerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpenidConnectConfig")]
        public virtual void ResetOpenidConnectConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPoolConfig")]
        public virtual void ResetUserPoolConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "lambdaAuthorizerConfig", typeJson: "{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfigOutputReference\"}")]
        public virtual aws.AppsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfigOutputReference LambdaAuthorizerConfig
        {
            get => GetInstanceProperty<aws.AppsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfigOutputReference\"}")]
        public virtual aws.AppsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfigOutputReference OpenidConnectConfig
        {
            get => GetInstanceProperty<aws.AppsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfigOutputReference>()!;
        }

        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfigOutputReference\"}")]
        public virtual aws.AppsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfigOutputReference UserPoolConfig
        {
            get => GetInstanceProperty<aws.AppsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthenticationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaAuthorizerConfigInput", typeJson: "{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig\"}", isOptional: true)]
        public virtual aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig? LambdaAuthorizerConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfigInput", typeJson: "{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig\"}", isOptional: true)]
        public virtual aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolConfigInput", typeJson: "{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig\"}", isOptional: true)]
        public virtual aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfigInput
        {
            get => GetInstanceProperty<aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig?>();
        }

        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiAdditionalAuthenticationProvider\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProvider cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.AppsyncGraphqlApi.IAppsyncGraphqlApiAdditionalAuthenticationProvider).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
