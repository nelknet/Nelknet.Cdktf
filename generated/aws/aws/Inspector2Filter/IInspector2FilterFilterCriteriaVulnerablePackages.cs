using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiInterface(nativeType: typeof(IInspector2FilterFilterCriteriaVulnerablePackages), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackages")]
    public interface IInspector2FilterFilterCriteriaVulnerablePackages
    {
        /// <summary>architecture block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#architecture Inspector2Filter#architecture}
        /// </remarks>
        [JsiiProperty(name: "architecture", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesArchitecture\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Architecture
        {
            get
            {
                return null;
            }
        }

        /// <summary>epoch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#epoch Inspector2Filter#epoch}
        /// </remarks>
        [JsiiProperty(name: "epoch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesEpoch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Epoch
        {
            get
            {
                return null;
            }
        }

        /// <summary>file_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#file_path Inspector2Filter#file_path}
        /// </remarks>
        [JsiiProperty(name: "filePath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesFilePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FilePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#name Inspector2Filter#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>release block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#release Inspector2Filter#release}
        /// </remarks>
        [JsiiProperty(name: "release", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesRelease\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Release
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_lambda_layer_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#source_lambda_layer_arn Inspector2Filter#source_lambda_layer_arn}
        /// </remarks>
        [JsiiProperty(name: "sourceLambdaLayerArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceLambdaLayerArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_layer_hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#source_layer_hash Inspector2Filter#source_layer_hash}
        /// </remarks>
        [JsiiProperty(name: "sourceLayerHash", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHash\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceLayerHash
        {
            get
            {
                return null;
            }
        }

        /// <summary>version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#version Inspector2Filter#version}
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInspector2FilterFilterCriteriaVulnerablePackages), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackages")]
        internal sealed class _Proxy : DeputyBase, aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackages
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>architecture block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#architecture Inspector2Filter#architecture}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "architecture", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesArchitecture\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Architecture
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>epoch block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#epoch Inspector2Filter#epoch}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "epoch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesEpoch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Epoch
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>file_path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#file_path Inspector2Filter#file_path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filePath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesFilePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FilePath
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>name block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#name Inspector2Filter#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Name
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>release block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#release Inspector2Filter#release}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "release", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesRelease\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Release
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source_lambda_layer_arn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#source_lambda_layer_arn Inspector2Filter#source_lambda_layer_arn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceLambdaLayerArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceLambdaLayerArn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>source_layer_hash block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#source_layer_hash Inspector2Filter#source_layer_hash}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceLayerHash", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHash\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SourceLayerHash
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>version block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#version Inspector2Filter#version}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Version
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
