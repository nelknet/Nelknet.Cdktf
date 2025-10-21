using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApprunnerService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service aws_apprunner_service}.</summary>
    [JsiiClass(nativeType: typeof(aws.ApprunnerService.ApprunnerService), fullyQualifiedName: "aws.apprunnerService.ApprunnerService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceConfig\"}}]")]
    public class ApprunnerService : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service aws_apprunner_service} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ApprunnerService(Constructs.Construct scope, string id, aws.ApprunnerService.IApprunnerServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.ApprunnerService.IApprunnerServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApprunnerService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ApprunnerService resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ApprunnerService to import.</param>
        /// <param name="importFromId">The id of the existing ApprunnerService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ApprunnerService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ApprunnerService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apprunner_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ApprunnerService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ApprunnerService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.ApprunnerService.ApprunnerService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putEncryptionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceEncryptionConfiguration\"}}]")]
        public virtual void PutEncryptionConfiguration(aws.ApprunnerService.IApprunnerServiceEncryptionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceEncryptionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheckConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceHealthCheckConfiguration\"}}]")]
        public virtual void PutHealthCheckConfiguration(aws.ApprunnerService.IApprunnerServiceHealthCheckConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceHealthCheckConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceInstanceConfiguration\"}}]")]
        public virtual void PutInstanceConfiguration(aws.ApprunnerService.IApprunnerServiceInstanceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceInstanceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(aws.ApprunnerService.IApprunnerServiceNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putObservabilityConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceObservabilityConfiguration\"}}]")]
        public virtual void PutObservabilityConfiguration(aws.ApprunnerService.IApprunnerServiceObservabilityConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceObservabilityConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfiguration\"}}]")]
        public virtual void PutSourceConfiguration(aws.ApprunnerService.IApprunnerServiceSourceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ApprunnerService.IApprunnerServiceSourceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoScalingConfigurationArn")]
        public virtual void ResetAutoScalingConfigurationArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEncryptionConfiguration")]
        public virtual void ResetEncryptionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheckConfiguration")]
        public virtual void ResetHealthCheckConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceConfiguration")]
        public virtual void ResetInstanceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkConfiguration")]
        public virtual void ResetNetworkConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObservabilityConfiguration")]
        public virtual void ResetObservabilityConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
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
        = GetStaticProperty<string>(typeof(aws.ApprunnerService.ApprunnerService))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceEncryptionConfigurationOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceEncryptionConfigurationOutputReference EncryptionConfiguration
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceEncryptionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheckConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceHealthCheckConfigurationOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceHealthCheckConfigurationOutputReference HealthCheckConfiguration
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceHealthCheckConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "instanceConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceInstanceConfigurationOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceInstanceConfigurationOutputReference InstanceConfiguration
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceInstanceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfigurationOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "observabilityConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceObservabilityConfigurationOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceObservabilityConfigurationOutputReference ObservabilityConfiguration
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceObservabilityConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "serviceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceConfiguration", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfigurationOutputReference\"}")]
        public virtual aws.ApprunnerService.ApprunnerServiceSourceConfigurationOutputReference SourceConfiguration
        {
            get => GetInstanceProperty<aws.ApprunnerService.ApprunnerServiceSourceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScalingConfigurationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoScalingConfigurationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceEncryptionConfiguration? EncryptionConfigurationInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceEncryptionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceHealthCheckConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceHealthCheckConfiguration? HealthCheckConfigurationInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceHealthCheckConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceInstanceConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceInstanceConfiguration? InstanceConfigurationInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceInstanceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "observabilityConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceObservabilityConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceObservabilityConfiguration? ObservabilityConfigurationInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceObservabilityConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceConfigurationInput", typeJson: "{\"fqn\":\"aws.apprunnerService.ApprunnerServiceSourceConfiguration\"}", isOptional: true)]
        public virtual aws.ApprunnerService.IApprunnerServiceSourceConfiguration? SourceConfigurationInput
        {
            get => GetInstanceProperty<aws.ApprunnerService.IApprunnerServiceSourceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "autoScalingConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoScalingConfigurationArn
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

        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
