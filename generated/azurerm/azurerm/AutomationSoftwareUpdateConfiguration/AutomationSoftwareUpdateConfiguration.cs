using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomationSoftwareUpdateConfiguration
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration azurerm_automation_software_update_configuration}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfiguration), fullyQualifiedName: "azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfiguration", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationConfig\"}}]")]
    public class AutomationSoftwareUpdateConfiguration : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration azurerm_automation_software_update_configuration} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AutomationSoftwareUpdateConfiguration(Constructs.Construct scope, string id, azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomationSoftwareUpdateConfiguration(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AutomationSoftwareUpdateConfiguration(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a AutomationSoftwareUpdateConfiguration resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the AutomationSoftwareUpdateConfiguration to import.</param>
        /// <param name="importFromId">The id of the existing AutomationSoftwareUpdateConfiguration that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the AutomationSoftwareUpdateConfiguration to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the AutomationSoftwareUpdateConfiguration to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_software_update_configuration#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing AutomationSoftwareUpdateConfiguration that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the AutomationSoftwareUpdateConfiguration to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfiguration), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putLinux", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationLinux\"}}]")]
        public virtual void PutLinux(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationLinux @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationLinux)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPostTask", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPostTask\"}}]")]
        public virtual void PutPostTask(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationPostTask @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationPostTask)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPreTask", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPreTask\"}}]")]
        public virtual void PutPreTask(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationPreTask @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationPreTask)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationSchedule\"}}]")]
        public virtual void PutSchedule(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationSchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationSchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTarget\"}}]")]
        public virtual void PutTarget(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWindows", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationWindows\"}}]")]
        public virtual void PutWindows(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationWindows @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationWindows)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDuration")]
        public virtual void ResetDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLinux")]
        public virtual void ResetLinux()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNonAzureComputerNames")]
        public virtual void ResetNonAzureComputerNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostTask")]
        public virtual void ResetPostTask()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreTask")]
        public virtual void ResetPreTask()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTarget")]
        public virtual void ResetTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualMachineIds")]
        public virtual void ResetVirtualMachineIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWindows")]
        public virtual void ResetWindows()
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
        = GetStaticProperty<string>(typeof(azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfiguration))!;

        [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "errorMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "linux", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationLinuxOutputReference\"}")]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationLinuxOutputReference Linux
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationLinuxOutputReference>()!;
        }

        [JsiiProperty(name: "postTask", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPostTaskOutputReference\"}")]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPostTaskOutputReference PostTask
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPostTaskOutputReference>()!;
        }

        [JsiiProperty(name: "preTask", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPreTaskOutputReference\"}")]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPreTaskOutputReference PreTask
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPreTaskOutputReference>()!;
        }

        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationScheduleOutputReference\"}")]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationScheduleOutputReference Schedule
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetOutputReference\"}")]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetOutputReference Target
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTargetOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTimeoutsOutputReference\"}")]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "windows", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationWindowsOutputReference\"}")]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationWindowsOutputReference Windows
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationWindowsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "automationAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutomationAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "durationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DurationInput
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
        [JsiiProperty(name: "linuxInput", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationLinux\"}", isOptional: true)]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationLinux? LinuxInput
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationLinux?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nonAzureComputerNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NonAzureComputerNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postTaskInput", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPostTask\"}", isOptional: true)]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationPostTask? PostTaskInput
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationPostTask?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preTaskInput", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationPreTask\"}", isOptional: true)]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationPreTask? PreTaskInput
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationPreTask?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scheduleInput", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationSchedule\"}", isOptional: true)]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationSchedule? ScheduleInput
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationSchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetInput", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTarget\"}", isOptional: true)]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTarget? TargetInput
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? VirtualMachineIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "windowsInput", typeJson: "{\"fqn\":\"azurerm.automationSoftwareUpdateConfiguration.AutomationSoftwareUpdateConfigurationWindows\"}", isOptional: true)]
        public virtual azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationWindows? WindowsInput
        {
            get => GetInstanceProperty<azurerm.AutomationSoftwareUpdateConfiguration.IAutomationSoftwareUpdateConfigurationWindows?>();
        }

        [JsiiProperty(name: "automationAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutomationAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Duration
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

        [JsiiProperty(name: "nonAzureComputerNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NonAzureComputerNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "virtualMachineIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] VirtualMachineIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
