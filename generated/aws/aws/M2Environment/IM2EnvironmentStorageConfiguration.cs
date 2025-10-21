using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.M2Environment
{
    [JsiiInterface(nativeType: typeof(IM2EnvironmentStorageConfiguration), fullyQualifiedName: "aws.m2Environment.M2EnvironmentStorageConfiguration")]
    public interface IM2EnvironmentStorageConfiguration
    {
        /// <summary>efs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#efs M2Environment#efs}
        /// </remarks>
        [JsiiProperty(name: "efs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.m2Environment.M2EnvironmentStorageConfigurationEfs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Efs
        {
            get
            {
                return null;
            }
        }

        /// <summary>fsx block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#fsx M2Environment#fsx}
        /// </remarks>
        [JsiiProperty(name: "fsx", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.m2Environment.M2EnvironmentStorageConfigurationFsx\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Fsx
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IM2EnvironmentStorageConfiguration), fullyQualifiedName: "aws.m2Environment.M2EnvironmentStorageConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.M2Environment.IM2EnvironmentStorageConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>efs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#efs M2Environment#efs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "efs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.m2Environment.M2EnvironmentStorageConfigurationEfs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Efs
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>fsx block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#fsx M2Environment#fsx}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fsx", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.m2Environment.M2EnvironmentStorageConfigurationFsx\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Fsx
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
