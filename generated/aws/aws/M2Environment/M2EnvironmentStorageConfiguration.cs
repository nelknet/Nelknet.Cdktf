using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.M2Environment
{
    [JsiiByValue(fqn: "aws.m2Environment.M2EnvironmentStorageConfiguration")]
    public class M2EnvironmentStorageConfiguration : aws.M2Environment.IM2EnvironmentStorageConfiguration
    {
        private object? _efs;

        /// <summary>efs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#efs M2Environment#efs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "efs", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.m2Environment.M2EnvironmentStorageConfigurationEfs\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Efs
        {
            get => _efs;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.M2Environment.IM2EnvironmentStorageConfigurationEfs[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.M2Environment.IM2EnvironmentStorageConfigurationEfs).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _efs = value;
            }
        }

        private object? _fsx;

        /// <summary>fsx block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#fsx M2Environment#fsx}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsx", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.m2Environment.M2EnvironmentStorageConfigurationFsx\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Fsx
        {
            get => _fsx;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.M2Environment.IM2EnvironmentStorageConfigurationFsx[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.M2Environment.IM2EnvironmentStorageConfigurationFsx).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _fsx = value;
            }
        }
    }
}
