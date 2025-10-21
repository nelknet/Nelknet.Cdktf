using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerWorkforce
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce aws_sagemaker_workforce}.</summary>
    [JsiiClass(nativeType: typeof(aws.SagemakerWorkforce.SagemakerWorkforce), fullyQualifiedName: "aws.sagemakerWorkforce.SagemakerWorkforce", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceConfig\"}}]")]
    public class SagemakerWorkforce : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce aws_sagemaker_workforce} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SagemakerWorkforce(Constructs.Construct scope, string id, aws.SagemakerWorkforce.ISagemakerWorkforceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.SagemakerWorkforce.ISagemakerWorkforceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerWorkforce(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerWorkforce(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a SagemakerWorkforce resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the SagemakerWorkforce to import.</param>
        /// <param name="importFromId">The id of the existing SagemakerWorkforce that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the SagemakerWorkforce to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the SagemakerWorkforce to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_workforce#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing SagemakerWorkforce that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the SagemakerWorkforce to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.SagemakerWorkforce.SagemakerWorkforce), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCognitoConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceCognitoConfig\"}}]")]
        public virtual void PutCognitoConfig(aws.SagemakerWorkforce.ISagemakerWorkforceCognitoConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerWorkforce.ISagemakerWorkforceCognitoConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOidcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceOidcConfig\"}}]")]
        public virtual void PutOidcConfig(aws.SagemakerWorkforce.ISagemakerWorkforceOidcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerWorkforce.ISagemakerWorkforceOidcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceIpConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceSourceIpConfig\"}}]")]
        public virtual void PutSourceIpConfig(aws.SagemakerWorkforce.ISagemakerWorkforceSourceIpConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerWorkforce.ISagemakerWorkforceSourceIpConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWorkforceVpcConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceWorkforceVpcConfig\"}}]")]
        public virtual void PutWorkforceVpcConfig(aws.SagemakerWorkforce.ISagemakerWorkforceWorkforceVpcConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerWorkforce.ISagemakerWorkforceWorkforceVpcConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCognitoConfig")]
        public virtual void ResetCognitoConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOidcConfig")]
        public virtual void ResetOidcConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceIpConfig")]
        public virtual void ResetSourceIpConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWorkforceVpcConfig")]
        public virtual void ResetWorkforceVpcConfig()
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
        = GetStaticProperty<string>(typeof(aws.SagemakerWorkforce.SagemakerWorkforce))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "cognitoConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceCognitoConfigOutputReference\"}")]
        public virtual aws.SagemakerWorkforce.SagemakerWorkforceCognitoConfigOutputReference CognitoConfig
        {
            get => GetInstanceProperty<aws.SagemakerWorkforce.SagemakerWorkforceCognitoConfigOutputReference>()!;
        }

        [JsiiProperty(name: "oidcConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceOidcConfigOutputReference\"}")]
        public virtual aws.SagemakerWorkforce.SagemakerWorkforceOidcConfigOutputReference OidcConfig
        {
            get => GetInstanceProperty<aws.SagemakerWorkforce.SagemakerWorkforceOidcConfigOutputReference>()!;
        }

        [JsiiProperty(name: "sourceIpConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceSourceIpConfigOutputReference\"}")]
        public virtual aws.SagemakerWorkforce.SagemakerWorkforceSourceIpConfigOutputReference SourceIpConfig
        {
            get => GetInstanceProperty<aws.SagemakerWorkforce.SagemakerWorkforceSourceIpConfigOutputReference>()!;
        }

        [JsiiProperty(name: "subdomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subdomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "workforceVpcConfig", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceWorkforceVpcConfigOutputReference\"}")]
        public virtual aws.SagemakerWorkforce.SagemakerWorkforceWorkforceVpcConfigOutputReference WorkforceVpcConfig
        {
            get => GetInstanceProperty<aws.SagemakerWorkforce.SagemakerWorkforceWorkforceVpcConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cognitoConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceCognitoConfig\"}", isOptional: true)]
        public virtual aws.SagemakerWorkforce.ISagemakerWorkforceCognitoConfig? CognitoConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerWorkforce.ISagemakerWorkforceCognitoConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "oidcConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceOidcConfig\"}", isOptional: true)]
        public virtual aws.SagemakerWorkforce.ISagemakerWorkforceOidcConfig? OidcConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerWorkforce.ISagemakerWorkforceOidcConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceIpConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceSourceIpConfig\"}", isOptional: true)]
        public virtual aws.SagemakerWorkforce.ISagemakerWorkforceSourceIpConfig? SourceIpConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerWorkforce.ISagemakerWorkforceSourceIpConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workforceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkforceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workforceVpcConfigInput", typeJson: "{\"fqn\":\"aws.sagemakerWorkforce.SagemakerWorkforceWorkforceVpcConfig\"}", isOptional: true)]
        public virtual aws.SagemakerWorkforce.ISagemakerWorkforceWorkforceVpcConfig? WorkforceVpcConfigInput
        {
            get => GetInstanceProperty<aws.SagemakerWorkforce.ISagemakerWorkforceWorkforceVpcConfig?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workforceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkforceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
