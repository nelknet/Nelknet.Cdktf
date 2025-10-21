using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MwaaEnvironment
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment aws_mwaa_environment}.</summary>
    [JsiiClass(nativeType: typeof(aws.MwaaEnvironment.MwaaEnvironment), fullyQualifiedName: "aws.mwaaEnvironment.MwaaEnvironment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentConfig\"}}]")]
    public class MwaaEnvironment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment aws_mwaa_environment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MwaaEnvironment(Constructs.Construct scope, string id, aws.MwaaEnvironment.IMwaaEnvironmentConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.MwaaEnvironment.IMwaaEnvironmentConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MwaaEnvironment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MwaaEnvironment(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MwaaEnvironment resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MwaaEnvironment to import.</param>
        /// <param name="importFromId">The id of the existing MwaaEnvironment that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MwaaEnvironment to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MwaaEnvironment to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MwaaEnvironment that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MwaaEnvironment to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.MwaaEnvironment.MwaaEnvironment), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLoggingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfiguration\"}}]")]
        public virtual void PutLoggingConfiguration(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentNetworkConfiguration\"}}]")]
        public virtual void PutNetworkConfiguration(aws.MwaaEnvironment.IMwaaEnvironmentNetworkConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MwaaEnvironment.IMwaaEnvironmentNetworkConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.MwaaEnvironment.IMwaaEnvironmentTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.MwaaEnvironment.IMwaaEnvironmentTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAirflowConfigurationOptions")]
        public virtual void ResetAirflowConfigurationOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAirflowVersion")]
        public virtual void ResetAirflowVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEndpointManagement")]
        public virtual void ResetEndpointManagement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironmentClass")]
        public virtual void ResetEnvironmentClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKey")]
        public virtual void ResetKmsKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingConfiguration")]
        public virtual void ResetLoggingConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxWebservers")]
        public virtual void ResetMaxWebservers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxWorkers")]
        public virtual void ResetMaxWorkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinWebservers")]
        public virtual void ResetMinWebservers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinWorkers")]
        public virtual void ResetMinWorkers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPluginsS3ObjectVersion")]
        public virtual void ResetPluginsS3ObjectVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPluginsS3Path")]
        public virtual void ResetPluginsS3Path()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequirementsS3ObjectVersion")]
        public virtual void ResetRequirementsS3ObjectVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRequirementsS3Path")]
        public virtual void ResetRequirementsS3Path()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulers")]
        public virtual void ResetSchedulers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartupScriptS3ObjectVersion")]
        public virtual void ResetStartupScriptS3ObjectVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStartupScriptS3Path")]
        public virtual void ResetStartupScriptS3Path()
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

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebserverAccessMode")]
        public virtual void ResetWebserverAccessMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeeklyMaintenanceWindowStart")]
        public virtual void ResetWeeklyMaintenanceWindowStart()
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
        = GetStaticProperty<string>(typeof(aws.MwaaEnvironment.MwaaEnvironment))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databaseVpcEndpointService", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseVpcEndpointService
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastUpdated", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLastUpdatedList\"}")]
        public virtual aws.MwaaEnvironment.MwaaEnvironmentLastUpdatedList LastUpdated
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.MwaaEnvironmentLastUpdatedList>()!;
        }

        [JsiiProperty(name: "loggingConfiguration", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfigurationOutputReference\"}")]
        public virtual aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationOutputReference LoggingConfiguration
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.MwaaEnvironmentLoggingConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "networkConfiguration", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentNetworkConfigurationOutputReference\"}")]
        public virtual aws.MwaaEnvironment.MwaaEnvironmentNetworkConfigurationOutputReference NetworkConfiguration
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.MwaaEnvironmentNetworkConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRoleArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentTimeoutsOutputReference\"}")]
        public virtual aws.MwaaEnvironment.MwaaEnvironmentTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.MwaaEnvironmentTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "webserverUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebserverUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "webserverVpcEndpointService", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebserverVpcEndpointService
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "airflowConfigurationOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AirflowConfigurationOptionsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "airflowVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AirflowVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dagS3PathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DagS3PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "endpointManagementInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EndpointManagementInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleArnInput
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
        [JsiiProperty(name: "kmsKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingConfigurationInput", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentLoggingConfiguration\"}", isOptional: true)]
        public virtual aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfiguration? LoggingConfigurationInput
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentLoggingConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWebserversInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxWebserversInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxWorkersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxWorkersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minWebserversInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinWebserversInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minWorkersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinWorkersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkConfigurationInput", typeJson: "{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentNetworkConfiguration\"}", isOptional: true)]
        public virtual aws.MwaaEnvironment.IMwaaEnvironmentNetworkConfiguration? NetworkConfigurationInput
        {
            get => GetInstanceProperty<aws.MwaaEnvironment.IMwaaEnvironmentNetworkConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluginsS3ObjectVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PluginsS3ObjectVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluginsS3PathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PluginsS3PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requirementsS3ObjectVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequirementsS3ObjectVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "requirementsS3PathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RequirementsS3PathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulersInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SchedulersInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceBucketArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceBucketArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startupScriptS3ObjectVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartupScriptS3ObjectVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startupScriptS3PathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartupScriptS3PathInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.mwaaEnvironment.MwaaEnvironmentTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webserverAccessModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebserverAccessModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeklyMaintenanceWindowStartInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WeeklyMaintenanceWindowStartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "airflowConfigurationOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AirflowConfigurationOptions
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "airflowVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AirflowVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dagS3Path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DagS3Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "endpointManagement", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndpointManagement
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environmentClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EnvironmentClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
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

        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxWebservers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxWebservers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxWorkers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minWebservers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinWebservers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minWorkers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinWorkers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pluginsS3ObjectVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PluginsS3ObjectVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pluginsS3Path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PluginsS3Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requirementsS3ObjectVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequirementsS3ObjectVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "requirementsS3Path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RequirementsS3Path
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "schedulers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Schedulers
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceBucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceBucketArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startupScriptS3ObjectVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartupScriptS3ObjectVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "startupScriptS3Path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StartupScriptS3Path
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

        [JsiiProperty(name: "webserverAccessMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebserverAccessMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weeklyMaintenanceWindowStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WeeklyMaintenanceWindowStart
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
