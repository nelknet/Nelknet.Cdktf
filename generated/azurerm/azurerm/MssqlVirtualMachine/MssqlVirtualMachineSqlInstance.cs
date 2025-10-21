using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiByValue(fqn: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineSqlInstance")]
    public class MssqlVirtualMachineSqlInstance : azurerm.MssqlVirtualMachine.IMssqlVirtualMachineSqlInstance
    {
        private object? _adhocWorkloadsOptimizationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#adhoc_workloads_optimization_enabled MssqlVirtualMachine#adhoc_workloads_optimization_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "adhocWorkloadsOptimizationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AdhocWorkloadsOptimizationEnabled
        {
            get => _adhocWorkloadsOptimizationEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _adhocWorkloadsOptimizationEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#collation MssqlVirtualMachine#collation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "collation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Collation
        {
            get;
            set;
        }

        private object? _instantFileInitializationEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#instant_file_initialization_enabled MssqlVirtualMachine#instant_file_initialization_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "instantFileInitializationEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InstantFileInitializationEnabled
        {
            get => _instantFileInitializationEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _instantFileInitializationEnabled = value;
            }
        }

        private object? _lockPagesInMemoryEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#lock_pages_in_memory_enabled MssqlVirtualMachine#lock_pages_in_memory_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lockPagesInMemoryEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? LockPagesInMemoryEnabled
        {
            get => _lockPagesInMemoryEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lockPagesInMemoryEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#max_dop MssqlVirtualMachine#max_dop}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxDop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxDop
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#max_server_memory_mb MssqlVirtualMachine#max_server_memory_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxServerMemoryMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxServerMemoryMb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#min_server_memory_mb MssqlVirtualMachine#min_server_memory_mb}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minServerMemoryMb", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinServerMemoryMb
        {
            get;
            set;
        }
    }
}
