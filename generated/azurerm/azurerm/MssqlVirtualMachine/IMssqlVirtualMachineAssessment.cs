using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineAssessment), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineAssessment")]
    public interface IMssqlVirtualMachineAssessment
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#enabled MssqlVirtualMachine#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#run_immediately MssqlVirtualMachine#run_immediately}.</summary>
        [JsiiProperty(name: "runImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RunImmediately
        {
            get
            {
                return null;
            }
        }

        /// <summary>schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#schedule MssqlVirtualMachine#schedule}
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAssessmentSchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessmentSchedule? Schedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineAssessment), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineAssessment")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessment
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#enabled MssqlVirtualMachine#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#run_immediately MssqlVirtualMachine#run_immediately}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runImmediately", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RunImmediately
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#schedule MssqlVirtualMachine#schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedule", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAssessmentSchedule\"}", isOptional: true)]
            public azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessmentSchedule? Schedule
            {
                get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessmentSchedule?>();
            }
        }
    }
}
