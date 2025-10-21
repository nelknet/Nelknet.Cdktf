using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCognitoUserPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool aws_cognito_user_pool}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsCognitoUserPool.DataAwsCognitoUserPool), fullyQualifiedName: "aws.dataAwsCognitoUserPool.DataAwsCognitoUserPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolConfig\"}}]")]
    public class DataAwsCognitoUserPool : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool aws_cognito_user_pool} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsCognitoUserPool(Constructs.Construct scope, string id, aws.DataAwsCognitoUserPool.IDataAwsCognitoUserPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsCognitoUserPool.IDataAwsCognitoUserPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCognitoUserPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCognitoUserPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsCognitoUserPool resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsCognitoUserPool to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsCognitoUserPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsCognitoUserPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsCognitoUserPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/cognito_user_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsCognitoUserPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsCognitoUserPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsCognitoUserPool.DataAwsCognitoUserPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
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
        = GetStaticProperty<string>(typeof(aws.DataAwsCognitoUserPool.DataAwsCognitoUserPool))!;

        [JsiiProperty(name: "accountRecoverySetting", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolAccountRecoverySettingList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolAccountRecoverySettingList AccountRecoverySetting
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolAccountRecoverySettingList>()!;
        }

        [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolAdminCreateUserConfigList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolAdminCreateUserConfigList AdminCreateUserConfig
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolAdminCreateUserConfigList>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AutoVerifiedAttributes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "creationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deletionProtection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeletionProtection
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolDeviceConfigurationList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolDeviceConfigurationList DeviceConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolDeviceConfigurationList>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolEmailConfigurationList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolEmailConfigurationList EmailConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolEmailConfigurationList>()!;
        }

        [JsiiProperty(name: "estimatedNumberOfUsers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EstimatedNumberOfUsers
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigList LambdaConfig
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolLambdaConfigList>()!;
        }

        [JsiiProperty(name: "lastModifiedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MfaConfiguration
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemaAttributes", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesList SchemaAttributes
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesList>()!;
        }

        [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsAuthenticationMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "smsConfigurationFailure", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsConfigurationFailure
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsVerificationMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UsernameAttributes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolUserPoolAddOnsList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolUserPoolAddOnsList UserPoolAddOns
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolUserPoolAddOnsList>()!;
        }

        [JsiiProperty(name: "userPoolTags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap UserPoolTags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "userPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
