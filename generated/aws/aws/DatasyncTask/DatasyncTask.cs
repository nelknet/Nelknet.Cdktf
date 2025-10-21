using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncTask
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task aws_datasync_task}.</summary>
    [JsiiClass(nativeType: typeof(aws.DatasyncTask.DatasyncTask), fullyQualifiedName: "aws.datasyncTask.DatasyncTask", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.datasyncTask.DatasyncTaskConfig\"}}]")]
    public class DatasyncTask : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task aws_datasync_task} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatasyncTask(Constructs.Construct scope, string id, aws.DatasyncTask.IDatasyncTaskConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DatasyncTask.IDatasyncTaskConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncTask(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncTask(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DatasyncTask resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DatasyncTask to import.</param>
        /// <param name="importFromId">The id of the existing DatasyncTask that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DatasyncTask to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DatasyncTask to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_task#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DatasyncTask that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DatasyncTask to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DatasyncTask.DatasyncTask), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putExcludes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncTask.DatasyncTaskExcludes\"}}]")]
        public virtual void PutExcludes(aws.DatasyncTask.IDatasyncTaskExcludes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncTask.IDatasyncTaskExcludes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIncludes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncTask.DatasyncTaskIncludes\"}}]")]
        public virtual void PutIncludes(aws.DatasyncTask.IDatasyncTaskIncludes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncTask.IDatasyncTaskIncludes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncTask.DatasyncTaskOptions\"}}]")]
        public virtual void PutOptions(aws.DatasyncTask.IDatasyncTaskOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncTask.IDatasyncTaskOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncTask.DatasyncTaskSchedule\"}}]")]
        public virtual void PutSchedule(aws.DatasyncTask.IDatasyncTaskSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncTask.IDatasyncTaskSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTaskReportConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfig\"}}]")]
        public virtual void PutTaskReportConfig(aws.DatasyncTask.IDatasyncTaskTaskReportConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncTask.IDatasyncTaskTaskReportConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasyncTask.DatasyncTaskTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.DatasyncTask.IDatasyncTaskTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DatasyncTask.IDatasyncTaskTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogGroupArn")]
        public virtual void ResetCloudwatchLogGroupArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludes")]
        public virtual void ResetExcludes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludes")]
        public virtual void ResetIncludes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOptions")]
        public virtual void ResetOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedule")]
        public virtual void ResetSchedule()
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

        [JsiiMethod(name: "resetTaskMode")]
        public virtual void ResetTaskMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskReportConfig")]
        public virtual void ResetTaskReportConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.DatasyncTask.DatasyncTask))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "excludes", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskExcludesOutputReference\"}")]
        public virtual aws.DatasyncTask.DatasyncTaskExcludesOutputReference Excludes
        {
            get => GetInstanceProperty<aws.DatasyncTask.DatasyncTaskExcludesOutputReference>()!;
        }

        [JsiiProperty(name: "includes", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskIncludesOutputReference\"}")]
        public virtual aws.DatasyncTask.DatasyncTaskIncludesOutputReference Includes
        {
            get => GetInstanceProperty<aws.DatasyncTask.DatasyncTaskIncludesOutputReference>()!;
        }

        [JsiiProperty(name: "options", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskOptionsOutputReference\"}")]
        public virtual aws.DatasyncTask.DatasyncTaskOptionsOutputReference Options
        {
            get => GetInstanceProperty<aws.DatasyncTask.DatasyncTaskOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskScheduleOutputReference\"}")]
        public virtual aws.DatasyncTask.DatasyncTaskScheduleOutputReference Schedule
        {
            get => GetInstanceProperty<aws.DatasyncTask.DatasyncTaskScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "taskReportConfig", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfigOutputReference\"}")]
        public virtual aws.DatasyncTask.DatasyncTaskTaskReportConfigOutputReference TaskReportConfig
        {
            get => GetInstanceProperty<aws.DatasyncTask.DatasyncTaskTaskReportConfigOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTimeoutsOutputReference\"}")]
        public virtual aws.DatasyncTask.DatasyncTaskTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.DatasyncTask.DatasyncTaskTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogGroupArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CloudwatchLogGroupArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationLocationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationLocationArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludesInput", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskExcludes\"}", isOptional: true)]
        public virtual aws.DatasyncTask.IDatasyncTaskExcludes? ExcludesInput
        {
            get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskExcludes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includesInput", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskIncludes\"}", isOptional: true)]
        public virtual aws.DatasyncTask.IDatasyncTaskIncludes? IncludesInput
        {
            get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskIncludes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "optionsInput", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskOptions\"}", isOptional: true)]
        public virtual aws.DatasyncTask.IDatasyncTaskOptions? OptionsInput
        {
            get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskSchedule\"}", isOptional: true)]
        public virtual aws.DatasyncTask.IDatasyncTaskSchedule? ScheduleInput
        {
            get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceLocationArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceLocationArnInput
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
        [JsiiProperty(name: "taskModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskReportConfigInput", typeJson: "{\"fqn\":\"aws.datasyncTask.DatasyncTaskTaskReportConfig\"}", isOptional: true)]
        public virtual aws.DatasyncTask.IDatasyncTaskTaskReportConfig? TaskReportConfigInput
        {
            get => GetInstanceProperty<aws.DatasyncTask.IDatasyncTaskTaskReportConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.datasyncTask.DatasyncTaskTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "cloudwatchLogGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CloudwatchLogGroupArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationLocationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationLocationArn
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceLocationArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceLocationArn
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

        [JsiiProperty(name: "taskMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
