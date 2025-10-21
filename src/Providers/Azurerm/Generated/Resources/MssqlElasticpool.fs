namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> = { assignments: ResizeArray<azurerm.MssqlElasticpool.MssqlElasticpoolConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool">azurerm_mssql_elasticpool</a>.
    /// </summary>
    type MssqlElasticpoolBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlElasticpoolState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlElasticpoolState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MssqlElasticpoolState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlElasticpoolState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#location-1">MssqlElasticpool#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MssqlElasticpoolState<Missing, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: string) : MssqlElasticpoolState<Present, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MssqlElasticpoolState<Present, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#name-1">MssqlElasticpool#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlElasticpoolState<'Location, Missing, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: string) : MssqlElasticpoolState<'Location, Present, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlElasticpoolState<'Location, Present, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>)

        /// <summary>
        /// per_database_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#per_database_settings-1">MssqlElasticpool#per_database_settings</a>
        /// </summary>
        [<CustomOperation "per_database_settings">]
        member _.PerDatabaseSettings(state: MssqlElasticpoolState<'Location, 'Name, Missing, 'ResourceGroupName, 'ServerName, 'Sku>, value: azurerm.MssqlElasticpool.MssqlElasticpoolPerDatabaseSettings) : MssqlElasticpoolState<'Location, 'Name, Present, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.PerDatabaseSettings <- value)
            ({ assignments = state.assignments } : MssqlElasticpoolState<'Location, 'Name, Present, 'ResourceGroupName, 'ServerName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#resource_group_name-1">MssqlElasticpool#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, Missing, 'ServerName, 'Sku>, value: string) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, Present, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, Present, 'ServerName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#server_name-1">MssqlElasticpool#server_name</a>.
        /// </summary>
        [<CustomOperation "server_name">]
        member _.ServerName(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, Missing, 'Sku>, value: string) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ServerName <- value)
            ({ assignments = state.assignments } : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#sku-1">MssqlElasticpool#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, Missing>, value: azurerm.MssqlElasticpool.MssqlElasticpoolSku) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#enclave_type-1">MssqlElasticpool#enclave_type</a>.
        /// </summary>
        [<CustomOperation "enclave_type">]
        member _.EnclaveType(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: string) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.EnclaveType <- value)
            state : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#id-1">MssqlElasticpool#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: string) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#license_type-1">MssqlElasticpool#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: string) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#maintenance_configuration_name-1">MssqlElasticpool#maintenance_configuration_name</a>.
        /// </summary>
        [<CustomOperation "maintenance_configuration_name">]
        member _.MaintenanceConfigurationName(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: string) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.MaintenanceConfigurationName <- value)
            state : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#max_size_bytes-1">MssqlElasticpool#max_size_bytes</a>.
        /// </summary>
        [<CustomOperation "max_size_bytes">]
        member _.MaxSizeBytes(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: double) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.MaxSizeBytes <- value)
            state : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#max_size_gb-1">MssqlElasticpool#max_size_gb</a>.
        /// </summary>
        [<CustomOperation "max_size_gb">]
        member _.MaxSizeGb(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: double) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.MaxSizeGb <- value)
            state : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#tags-1">MssqlElasticpool#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: seq<string * string>) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#timeouts-1">MssqlElasticpool#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: azurerm.MssqlElasticpool.MssqlElasticpoolTimeouts) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#zone_redundant-1">MssqlElasticpool#zone_redundant</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant">]
        member _.ZoneRedundant(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: bool) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.ZoneRedundant <- value)
            state : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#zone_redundant-1">MssqlElasticpool#zone_redundant</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant">]
        member _.ZoneRedundant(state: MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku> =
            state.assignments.Add(fun config -> config.ZoneRedundant <- value)
            state : MssqlElasticpoolState<'Location, 'Name, 'PerDatabaseSettings, 'ResourceGroupName, 'ServerName, 'Sku>

        member _.Run(state: MssqlElasticpoolState<Present, Present, Present, Present, Present, Present>) : azurerm.MssqlElasticpool.MssqlElasticpool =
            let config = azurerm.MssqlElasticpool.MssqlElasticpoolConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlElasticpool.MssqlElasticpool(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlElasticpool: missing required arguments. Must call: location, name, per_database_settings, resource_group_name, server_name, sku.", 9999, IsError = true)>]
        member _.Run(_: MssqlElasticpoolState<_, _, _, _, _, _>) : azurerm.MssqlElasticpool.MssqlElasticpool =
            Unchecked.defaultof<azurerm.MssqlElasticpool.MssqlElasticpool>
