namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlVirtualMachineState<'VirtualMachineId> = { assignments: ResizeArray<azurerm.MssqlVirtualMachine.MssqlVirtualMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine">azurerm_mssql_virtual_machine</a>.
    /// </summary>
    type MssqlVirtualMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlVirtualMachineState<Missing> =
            ({ assignments = ResizeArray() } : MssqlVirtualMachineState<Missing>)

        member _.Zero(()) : MssqlVirtualMachineState<Missing> =
            ({ assignments = ResizeArray() } : MssqlVirtualMachineState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#virtual_machine_id-1">MssqlVirtualMachine#virtual_machine_id</a>.
        /// </summary>
        [<CustomOperation "virtual_machine_id">]
        member _.VirtualMachineId(state: MssqlVirtualMachineState<Missing>, value: string) : MssqlVirtualMachineState<Present> =
            state.assignments.Add(fun config -> config.VirtualMachineId <- value)
            ({ assignments = state.assignments } : MssqlVirtualMachineState<Present>)

        /// <summary>
        /// assessment block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#assessment-1">MssqlVirtualMachine#assessment</a>
        /// </summary>
        [<CustomOperation "assessment">]
        member _.Assessment(state: MssqlVirtualMachineState<'VirtualMachineId>, value: azurerm.MssqlVirtualMachine.MssqlVirtualMachineAssessment) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Assessment <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// auto_backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#auto_backup-1">MssqlVirtualMachine#auto_backup</a>
        /// </summary>
        [<CustomOperation "auto_backup">]
        member _.AutoBackup(state: MssqlVirtualMachineState<'VirtualMachineId>, value: azurerm.MssqlVirtualMachine.MssqlVirtualMachineAutoBackup) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.AutoBackup <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// auto_patching block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#auto_patching-1">MssqlVirtualMachine#auto_patching</a>
        /// </summary>
        [<CustomOperation "auto_patching">]
        member _.AutoPatching(state: MssqlVirtualMachineState<'VirtualMachineId>, value: azurerm.MssqlVirtualMachine.MssqlVirtualMachineAutoPatching) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.AutoPatching <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#id-1">MssqlVirtualMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlVirtualMachineState<'VirtualMachineId>, value: string) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// key_vault_credential block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#key_vault_credential-1">MssqlVirtualMachine#key_vault_credential</a>
        /// </summary>
        [<CustomOperation "key_vault_credential">]
        member _.KeyVaultCredential(state: MssqlVirtualMachineState<'VirtualMachineId>, value: azurerm.MssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredential) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.KeyVaultCredential <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#r_services_enabled-1">MssqlVirtualMachine#r_services_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "r_services_enabled">]
        member _.RServicesEnabled(state: MssqlVirtualMachineState<'VirtualMachineId>, value: bool) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.RServicesEnabled <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#r_services_enabled-1">MssqlVirtualMachine#r_services_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "r_services_enabled">]
        member _.RServicesEnabled(state: MssqlVirtualMachineState<'VirtualMachineId>, value: HashiCorp.Cdktf.IResolvable) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.RServicesEnabled <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_port-1">MssqlVirtualMachine#sql_connectivity_port</a>.
        /// </summary>
        [<CustomOperation "sql_connectivity_port">]
        member _.SqlConnectivityPort(state: MssqlVirtualMachineState<'VirtualMachineId>, value: double) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.SqlConnectivityPort <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_type-1">MssqlVirtualMachine#sql_connectivity_type</a>.
        /// </summary>
        [<CustomOperation "sql_connectivity_type">]
        member _.SqlConnectivityType(state: MssqlVirtualMachineState<'VirtualMachineId>, value: string) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.SqlConnectivityType <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_update_password-1">MssqlVirtualMachine#sql_connectivity_update_password</a>.
        /// </summary>
        [<CustomOperation "sql_connectivity_update_password">]
        member _.SqlConnectivityUpdatePassword(state: MssqlVirtualMachineState<'VirtualMachineId>, value: string) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.SqlConnectivityUpdatePassword <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_connectivity_update_username-1">MssqlVirtualMachine#sql_connectivity_update_username</a>.
        /// </summary>
        [<CustomOperation "sql_connectivity_update_username">]
        member _.SqlConnectivityUpdateUsername(state: MssqlVirtualMachineState<'VirtualMachineId>, value: string) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.SqlConnectivityUpdateUsername <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// sql_instance block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_instance-1">MssqlVirtualMachine#sql_instance</a>
        /// </summary>
        [<CustomOperation "sql_instance">]
        member _.SqlInstance(state: MssqlVirtualMachineState<'VirtualMachineId>, value: azurerm.MssqlVirtualMachine.MssqlVirtualMachineSqlInstance) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.SqlInstance <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_license_type-1">MssqlVirtualMachine#sql_license_type</a>.
        /// </summary>
        [<CustomOperation "sql_license_type">]
        member _.SqlLicenseType(state: MssqlVirtualMachineState<'VirtualMachineId>, value: string) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.SqlLicenseType <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#sql_virtual_machine_group_id-1">MssqlVirtualMachine#sql_virtual_machine_group_id</a>.
        /// </summary>
        [<CustomOperation "sql_virtual_machine_group_id">]
        member _.SqlVirtualMachineGroupId(state: MssqlVirtualMachineState<'VirtualMachineId>, value: string) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.SqlVirtualMachineGroupId <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// storage_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#storage_configuration-1">MssqlVirtualMachine#storage_configuration</a>
        /// </summary>
        [<CustomOperation "storage_configuration">]
        member _.StorageConfiguration(state: MssqlVirtualMachineState<'VirtualMachineId>, value: azurerm.MssqlVirtualMachine.MssqlVirtualMachineStorageConfiguration) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.StorageConfiguration <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#tags-1">MssqlVirtualMachine#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MssqlVirtualMachineState<'VirtualMachineId>, value: seq<string * string>) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#timeouts-1">MssqlVirtualMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlVirtualMachineState<'VirtualMachineId>, value: azurerm.MssqlVirtualMachine.MssqlVirtualMachineTimeouts) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        /// <summary>
        /// wsfc_domain_credential block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#wsfc_domain_credential-1">MssqlVirtualMachine#wsfc_domain_credential</a>
        /// </summary>
        [<CustomOperation "wsfc_domain_credential">]
        member _.WsfcDomainCredential(state: MssqlVirtualMachineState<'VirtualMachineId>, value: azurerm.MssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredential) : MssqlVirtualMachineState<'VirtualMachineId> =
            state.assignments.Add(fun config -> config.WsfcDomainCredential <- value)
            state : MssqlVirtualMachineState<'VirtualMachineId>

        member _.Run(state: MssqlVirtualMachineState<Present>) : azurerm.MssqlVirtualMachine.MssqlVirtualMachine =
            let config = azurerm.MssqlVirtualMachine.MssqlVirtualMachineConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlVirtualMachine.MssqlVirtualMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlVirtualMachine: missing required arguments. Must call: virtual_machine_id.", 9999, IsError = true)>]
        member _.Run(_: MssqlVirtualMachineState<_>) : azurerm.MssqlVirtualMachine.MssqlVirtualMachine =
            Unchecked.defaultof<azurerm.MssqlVirtualMachine.MssqlVirtualMachine>
