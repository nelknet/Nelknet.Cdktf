using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiByValue(fqn: "aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackages")]
    public class Inspector2FilterFilterCriteriaVulnerablePackages : aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackages
    {
        private object? _architecture;

        /// <summary>architecture block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#architecture Inspector2Filter#architecture}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "architecture", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesArchitecture\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Architecture
        {
            get => _architecture;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesArchitecture[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesArchitecture).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _architecture = value;
            }
        }

        private object? _epoch;

        /// <summary>epoch block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#epoch Inspector2Filter#epoch}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "epoch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesEpoch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Epoch
        {
            get => _epoch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesEpoch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesEpoch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _epoch = value;
            }
        }

        private object? _filePath;

        /// <summary>file_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#file_path Inspector2Filter#file_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filePath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesFilePath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FilePath
        {
            get => _filePath;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesFilePath[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesFilePath).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filePath = value;
            }
        }

        private object? _name;

        /// <summary>name block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#name Inspector2Filter#name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesName\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Name
        {
            get => _name;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesName[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesName).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _name = value;
            }
        }

        private object? _release;

        /// <summary>release block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#release Inspector2Filter#release}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "release", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesRelease\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Release
        {
            get => _release;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesRelease[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesRelease).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _release = value;
            }
        }

        private object? _sourceLambdaLayerArn;

        /// <summary>source_lambda_layer_arn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#source_lambda_layer_arn Inspector2Filter#source_lambda_layer_arn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceLambdaLayerArn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SourceLambdaLayerArn
        {
            get => _sourceLambdaLayerArn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesSourceLambdaLayerArn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sourceLambdaLayerArn = value;
            }
        }

        private object? _sourceLayerHash;

        /// <summary>source_layer_hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#source_layer_hash Inspector2Filter#source_layer_hash}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceLayerHash", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHash\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SourceLayerHash
        {
            get => _sourceLayerHash;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHash[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesSourceLayerHash).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sourceLayerHash = value;
            }
        }

        private object? _version;

        /// <summary>version block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector2_filter#version Inspector2Filter#version}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.inspector2Filter.Inspector2FilterFilterCriteriaVulnerablePackagesVersion\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Version
        {
            get => _version;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesVersion[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Inspector2Filter.IInspector2FilterFilterCriteriaVulnerablePackagesVersion).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _version = value;
            }
        }
    }
}
