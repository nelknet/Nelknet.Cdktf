using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DevopsguruServiceIntegration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_service_integration aws_devopsguru_service_integration}.</summary>
    [JsiiClass(nativeType: typeof(aws.DevopsguruServiceIntegration.DevopsguruServiceIntegration), fullyQualifiedName: "aws.devopsguruServiceIntegration.DevopsguruServiceIntegration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationConfig\"}}]")]
    public class DevopsguruServiceIntegration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_service_integration aws_devopsguru_service_integration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DevopsguruServiceIntegration(Constructs.Construct scope, string id, aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsguruServiceIntegration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevopsguruServiceIntegration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DevopsguruServiceIntegration resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DevopsguruServiceIntegration to import.</param>
        /// <param name="importFromId">The id of the existing DevopsguruServiceIntegration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DevopsguruServiceIntegration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DevopsguruServiceIntegration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_service_integration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DevopsguruServiceIntegration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DevopsguruServiceIntegration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DevopsguruServiceIntegration.DevopsguruServiceIntegration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putKmsServerSideEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationKmsServerSideEncryption\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutKmsServerSideEncryption(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationKmsServerSideEncryption[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationKmsServerSideEncryption).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationKmsServerSideEncryption).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogsAnomalyDetection", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationLogsAnomalyDetection\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogsAnomalyDetection(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationLogsAnomalyDetection[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationLogsAnomalyDetection).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationLogsAnomalyDetection).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOpsCenter", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenter\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutOpsCenter(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationOpsCenter[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationOpsCenter).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.DevopsguruServiceIntegration.IDevopsguruServiceIntegrationOpsCenter).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKmsServerSideEncryption")]
        public virtual void ResetKmsServerSideEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogsAnomalyDetection")]
        public virtual void ResetLogsAnomalyDetection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOpsCenter")]
        public virtual void ResetOpsCenter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.DevopsguruServiceIntegration.DevopsguruServiceIntegration))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsServerSideEncryption", typeJson: "{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationKmsServerSideEncryptionList\"}")]
        public virtual aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationKmsServerSideEncryptionList KmsServerSideEncryption
        {
            get => GetInstanceProperty<aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationKmsServerSideEncryptionList>()!;
        }

        [JsiiProperty(name: "logsAnomalyDetection", typeJson: "{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationLogsAnomalyDetectionList\"}")]
        public virtual aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationLogsAnomalyDetectionList LogsAnomalyDetection
        {
            get => GetInstanceProperty<aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationLogsAnomalyDetectionList>()!;
        }

        [JsiiProperty(name: "opsCenter", typeJson: "{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenterList\"}")]
        public virtual aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenterList OpsCenter
        {
            get => GetInstanceProperty<aws.DevopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsServerSideEncryptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationKmsServerSideEncryption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? KmsServerSideEncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logsAnomalyDetectionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationLogsAnomalyDetection\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LogsAnomalyDetectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "opsCenterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.devopsguruServiceIntegration.DevopsguruServiceIntegrationOpsCenter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? OpsCenterInput
        {
            get => GetInstanceProperty<object?>();
        }
    }
}
