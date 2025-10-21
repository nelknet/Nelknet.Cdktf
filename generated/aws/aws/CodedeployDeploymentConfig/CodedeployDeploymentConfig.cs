using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodedeployDeploymentConfig
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config aws_codedeploy_deployment_config}.</summary>
    [JsiiClass(nativeType: typeof(aws.CodedeployDeploymentConfig.CodedeployDeploymentConfig), fullyQualifiedName: "aws.codedeployDeploymentConfig.CodedeployDeploymentConfig", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigConfig\"}}]")]
    public class CodedeployDeploymentConfig : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config aws_codedeploy_deployment_config} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CodedeployDeploymentConfig(Constructs.Construct scope, string id, aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentConfig(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodedeployDeploymentConfig(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CodedeployDeploymentConfig resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CodedeployDeploymentConfig to import.</param>
        /// <param name="importFromId">The id of the existing CodedeployDeploymentConfig that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CodedeployDeploymentConfig to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CodedeployDeploymentConfig to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codedeploy_deployment_config#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CodedeployDeploymentConfig that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CodedeployDeploymentConfig to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CodedeployDeploymentConfig.CodedeployDeploymentConfig), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMinimumHealthyHosts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigMinimumHealthyHosts\"}}]")]
        public virtual void PutMinimumHealthyHosts(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigMinimumHealthyHosts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigMinimumHealthyHosts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrafficRoutingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfig\"}}]")]
        public virtual void PutTrafficRoutingConfig(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZonalConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfig\"}}]")]
        public virtual void PutZonalConfig(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetComputePlatform")]
        public virtual void ResetComputePlatform()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinimumHealthyHosts")]
        public virtual void ResetMinimumHealthyHosts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrafficRoutingConfig")]
        public virtual void ResetTrafficRoutingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZonalConfig")]
        public virtual void ResetZonalConfig()
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
        = GetStaticProperty<string>(typeof(aws.CodedeployDeploymentConfig.CodedeployDeploymentConfig))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deploymentConfigId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentConfigId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minimumHealthyHosts", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigMinimumHealthyHostsOutputReference\"}")]
        public virtual aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigMinimumHealthyHostsOutputReference MinimumHealthyHosts
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigMinimumHealthyHostsOutputReference>()!;
        }

        [JsiiProperty(name: "trafficRoutingConfig", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigOutputReference\"}")]
        public virtual aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigOutputReference TrafficRoutingConfig
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "zonalConfig", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigOutputReference\"}")]
        public virtual aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigOutputReference ZonalConfig
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "computePlatformInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ComputePlatformInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deploymentConfigNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeploymentConfigNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minimumHealthyHostsInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigMinimumHealthyHosts\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigMinimumHealthyHosts? MinimumHealthyHostsInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigMinimumHealthyHosts?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficRoutingConfigInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigTrafficRoutingConfig\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfig? TrafficRoutingConfigInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigTrafficRoutingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonalConfigInput", typeJson: "{\"fqn\":\"aws.codedeployDeploymentConfig.CodedeployDeploymentConfigZonalConfig\"}", isOptional: true)]
        public virtual aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig? ZonalConfigInput
        {
            get => GetInstanceProperty<aws.CodedeployDeploymentConfig.ICodedeployDeploymentConfigZonalConfig?>();
        }

        [JsiiProperty(name: "computePlatform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ComputePlatform
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deploymentConfigName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentConfigName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
