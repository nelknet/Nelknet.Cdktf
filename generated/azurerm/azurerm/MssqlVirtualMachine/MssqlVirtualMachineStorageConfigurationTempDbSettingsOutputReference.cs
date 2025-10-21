using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiClass(nativeType: typeof(azurerm.MssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationTempDbSettingsOutputReference), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationTempDbSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MssqlVirtualMachineStorageConfigurationTempDbSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MssqlVirtualMachineStorageConfigurationTempDbSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MssqlVirtualMachineStorageConfigurationTempDbSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MssqlVirtualMachineStorageConfigurationTempDbSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDataFileCount")]
        public virtual void ResetDataFileCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataFileGrowthInMb")]
        public virtual void ResetDataFileGrowthInMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataFileSizeMb")]
        public virtual void ResetDataFileSizeMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogFileGrowthMb")]
        public virtual void ResetLogFileGrowthMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogFileSizeMb")]
        public virtual void ResetLogFileSizeMb()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataFileCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataFileCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataFileGrowthInMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataFileGrowthInMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataFileSizeMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DataFileSizeMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultFilePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultFilePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logFileGrowthMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LogFileGrowthMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logFileSizeMbInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LogFileSizeMbInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lunsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual double[]? LunsInput
        {
            get => GetInstanceProperty<double[]?>();
        }

        [JsiiProperty(name: "dataFileCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataFileCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataFileGrowthInMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataFileGrowthInMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataFileSizeMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DataFileSizeMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultFilePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultFilePath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logFileGrowthMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogFileGrowthMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logFileSizeMb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogFileSizeMb
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "luns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Luns
        {
            get => GetInstanceProperty<double[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationTempDbSettings\"}", isOptional: true)]
        public virtual azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationTempDbSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfigurationTempDbSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
