using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeDataLake
{
    [JsiiInterface(nativeType: typeof(ISecuritylakeDataLakeConfigurationLifecycleConfiguration), fullyQualifiedName: "aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfiguration")]
    public interface ISecuritylakeDataLakeConfigurationLifecycleConfiguration
    {
        /// <summary>expiration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#expiration SecuritylakeDataLake#expiration}
        /// </remarks>
        [JsiiProperty(name: "expiration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Expiration
        {
            get
            {
                return null;
            }
        }

        /// <summary>transition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#transition SecuritylakeDataLake#transition}
        /// </remarks>
        [JsiiProperty(name: "transition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfigurationTransition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Transition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecuritylakeDataLakeConfigurationLifecycleConfiguration), fullyQualifiedName: "aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SecuritylakeDataLake.ISecuritylakeDataLakeConfigurationLifecycleConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>expiration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#expiration SecuritylakeDataLake#expiration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expiration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfigurationExpiration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Expiration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>transition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_data_lake#transition SecuritylakeDataLake#transition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeDataLake.SecuritylakeDataLakeConfigurationLifecycleConfigurationTransition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Transition
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
