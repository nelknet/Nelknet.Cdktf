namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> = { assignments: ResizeArray<azurerm.MssqlManagedInstance.MssqlManagedInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance">azurerm_mssql_managed_instance</a>.
    /// </summary>
    type MssqlManagedInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlManagedInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MssqlManagedInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlManagedInstanceState<Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#administrator_login-1">MssqlManagedInstance#administrator_login</a>.
        /// </summary>
        [<CustomOperation "administrator_login">]
        member _.AdministratorLogin(state: MssqlManagedInstanceState<Missing, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<Present, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.AdministratorLogin <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceState<Present, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#administrator_login_password-1">MssqlManagedInstance#administrator_login_password</a>.
        /// </summary>
        [<CustomOperation "administrator_login_password">]
        member _.AdministratorLoginPassword(state: MssqlManagedInstanceState<'AdministratorLogin, Missing, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, Present, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.AdministratorLoginPassword <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceState<'AdministratorLogin, Present, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#license_type-1">MssqlManagedInstance#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, Missing, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#location-1">MssqlManagedInstance#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, Missing, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, Present, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, Present, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#name-1">MssqlManagedInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, Missing, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, Present, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, Present, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#resource_group_name-1">MssqlManagedInstance#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, Missing, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, Present, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, Present, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#sku_name-1">MssqlManagedInstance#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, Missing, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, Present, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, Present, 'StorageSizeInGb, 'SubnetId, 'Vcores>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#storage_size_in_gb-1">MssqlManagedInstance#storage_size_in_gb</a>.
        /// </summary>
        [<CustomOperation "storage_size_in_gb">]
        member _.StorageSizeInGb(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Missing, 'SubnetId, 'Vcores>, value: double) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Present, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.StorageSizeInGb <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Present, 'SubnetId, 'Vcores>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#subnet_id-1">MssqlManagedInstance#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, Missing, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, Present, 'Vcores> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, Present, 'Vcores>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#vcores-1">MssqlManagedInstance#vcores</a>.
        /// </summary>
        [<CustomOperation "vcores">]
        member _.Vcores(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, Missing>, value: double) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, Present> =
            state.assignments.Add(fun config -> config.Vcores <- value)
            ({ assignments = state.assignments } : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#collation-1">MssqlManagedInstance#collation</a>.
        /// </summary>
        [<CustomOperation "collation">]
        member _.Collation(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.Collation <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#dns_zone_partner_id-1">MssqlManagedInstance#dns_zone_partner_id</a>.
        /// </summary>
        [<CustomOperation "dns_zone_partner_id">]
        member _.DnsZonePartnerId(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.DnsZonePartnerId <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#id-1">MssqlManagedInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#identity-1">MssqlManagedInstance#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: azurerm.MssqlManagedInstance.MssqlManagedInstanceIdentity) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#maintenance_configuration_name-1">MssqlManagedInstance#maintenance_configuration_name</a>.
        /// </summary>
        [<CustomOperation "maintenance_configuration_name">]
        member _.MaintenanceConfigurationName(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.MaintenanceConfigurationName <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#minimum_tls_version-1">MssqlManagedInstance#minimum_tls_version</a>.
        /// </summary>
        [<CustomOperation "minimum_tls_version">]
        member _.MinimumTlsVersion(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.MinimumTlsVersion <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#proxy_override-1">MssqlManagedInstance#proxy_override</a>.
        /// </summary>
        [<CustomOperation "proxy_override">]
        member _.ProxyOverride(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.ProxyOverride <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#public_data_endpoint_enabled-1">MssqlManagedInstance#public_data_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_data_endpoint_enabled">]
        member _.PublicDataEndpointEnabled(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: bool) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.PublicDataEndpointEnabled <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#public_data_endpoint_enabled-1">MssqlManagedInstance#public_data_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_data_endpoint_enabled">]
        member _.PublicDataEndpointEnabled(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: HashiCorp.Cdktf.IResolvable) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.PublicDataEndpointEnabled <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#storage_account_type-1">MssqlManagedInstance#storage_account_type</a>.
        /// </summary>
        [<CustomOperation "storage_account_type">]
        member _.StorageAccountType(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.StorageAccountType <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#tags-1">MssqlManagedInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: seq<string * string>) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#timeouts-1">MssqlManagedInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: azurerm.MssqlManagedInstance.MssqlManagedInstanceTimeouts) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#timezone_id-1">MssqlManagedInstance#timezone_id</a>.
        /// </summary>
        [<CustomOperation "timezone_id">]
        member _.TimezoneId(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: string) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.TimezoneId <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#zone_redundant_enabled-1">MssqlManagedInstance#zone_redundant_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant_enabled">]
        member _.ZoneRedundantEnabled(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: bool) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.ZoneRedundantEnabled <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_managed_instance#zone_redundant_enabled-1">MssqlManagedInstance#zone_redundant_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant_enabled">]
        member _.ZoneRedundantEnabled(state: MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>, value: HashiCorp.Cdktf.IResolvable) : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores> =
            state.assignments.Add(fun config -> config.ZoneRedundantEnabled <- value)
            state : MssqlManagedInstanceState<'AdministratorLogin, 'AdministratorLoginPassword, 'LicenseType, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'StorageSizeInGb, 'SubnetId, 'Vcores>

        member _.Run(state: MssqlManagedInstanceState<Present, Present, Present, Present, Present, Present, Present, Present, Present, Present>) : azurerm.MssqlManagedInstance.MssqlManagedInstance =
            let config = azurerm.MssqlManagedInstance.MssqlManagedInstanceConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlManagedInstance.MssqlManagedInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlManagedInstance: missing required arguments. Must call: administrator_login, administrator_login_password, license_type, location, name, resource_group_name, sku_name, storage_size_in_gb, subnet_id, vcores.", 9999, IsError = true)>]
        member _.Run(_: MssqlManagedInstanceState<_, _, _, _, _, _, _, _, _, _>) : azurerm.MssqlManagedInstance.MssqlManagedInstance =
            Unchecked.defaultof<azurerm.MssqlManagedInstance.MssqlManagedInstance>
