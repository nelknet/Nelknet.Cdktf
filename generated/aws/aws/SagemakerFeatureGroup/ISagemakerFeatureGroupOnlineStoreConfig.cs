using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerFeatureGroup
{
    [JsiiInterface(nativeType: typeof(ISagemakerFeatureGroupOnlineStoreConfig), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfig")]
    public interface ISagemakerFeatureGroupOnlineStoreConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#enable_online_store SagemakerFeatureGroup#enable_online_store}.</summary>
        [JsiiProperty(name: "enableOnlineStore", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableOnlineStore
        {
            get
            {
                return null;
            }
        }

        /// <summary>security_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#security_config SagemakerFeatureGroup#security_config}
        /// </remarks>
        [JsiiProperty(name: "securityConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigSecurityConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig? SecurityConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#storage_type SagemakerFeatureGroup#storage_type}.</summary>
        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageType
        {
            get
            {
                return null;
            }
        }

        /// <summary>ttl_duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#ttl_duration SagemakerFeatureGroup#ttl_duration}
        /// </remarks>
        [JsiiProperty(name: "ttlDuration", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigTtlDuration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigTtlDuration? TtlDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFeatureGroupOnlineStoreConfig), fullyQualifiedName: "aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#enable_online_store SagemakerFeatureGroup#enable_online_store}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableOnlineStore", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableOnlineStore
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>security_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#security_config SagemakerFeatureGroup#security_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securityConfig", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigSecurityConfig\"}", isOptional: true)]
            public aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig? SecurityConfig
            {
                get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigSecurityConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#storage_type SagemakerFeatureGroup#storage_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ttl_duration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_feature_group#ttl_duration SagemakerFeatureGroup#ttl_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ttlDuration", typeJson: "{\"fqn\":\"aws.sagemakerFeatureGroup.SagemakerFeatureGroupOnlineStoreConfigTtlDuration\"}", isOptional: true)]
            public aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigTtlDuration? TtlDuration
            {
                get => GetInstanceProperty<aws.SagemakerFeatureGroup.ISagemakerFeatureGroupOnlineStoreConfigTtlDuration?>();
            }
        }
    }
}
