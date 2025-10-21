namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName> = { assignments: ResizeArray<azurerm.DedicatedHost.DedicatedHostConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host">azurerm_dedicated_host</a>.
    /// </summary>
    type DedicatedHostBuilder(logicalId: string) =
        member _.Yield(_: unit) : DedicatedHostState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DedicatedHostState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DedicatedHostState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DedicatedHostState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#dedicated_host_group_id-1">DedicatedHost#dedicated_host_group_id</a>.
        /// </summary>
        [<CustomOperation "dedicated_host_group_id">]
        member _.DedicatedHostGroupId(state: DedicatedHostState<Missing, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>, value: string) : DedicatedHostState<Present, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName> =
            state.assignments.Add(fun config -> config.DedicatedHostGroupId <- value)
            ({ assignments = state.assignments } : DedicatedHostState<Present, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#location-1">DedicatedHost#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DedicatedHostState<'DedicatedHostGroupId, Missing, 'Name, 'PlatformFaultDomain, 'SkuName>, value: string) : DedicatedHostState<'DedicatedHostGroupId, Present, 'Name, 'PlatformFaultDomain, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DedicatedHostState<'DedicatedHostGroupId, Present, 'Name, 'PlatformFaultDomain, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#name-1">DedicatedHost#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DedicatedHostState<'DedicatedHostGroupId, 'Location, Missing, 'PlatformFaultDomain, 'SkuName>, value: string) : DedicatedHostState<'DedicatedHostGroupId, 'Location, Present, 'PlatformFaultDomain, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DedicatedHostState<'DedicatedHostGroupId, 'Location, Present, 'PlatformFaultDomain, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#platform_fault_domain-1">DedicatedHost#platform_fault_domain</a>.
        /// </summary>
        [<CustomOperation "platform_fault_domain">]
        member _.PlatformFaultDomain(state: DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, Missing, 'SkuName>, value: double) : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.PlatformFaultDomain <- value)
            ({ assignments = state.assignments } : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#sku_name-1">DedicatedHost#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, Missing>, value: string) : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#auto_replace_on_failure-1">DedicatedHost#auto_replace_on_failure</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_replace_on_failure">]
        member _.AutoReplaceOnFailure(state: DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>, value: bool) : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName> =
            state.assignments.Add(fun config -> config.AutoReplaceOnFailure <- value)
            state : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#auto_replace_on_failure-1">DedicatedHost#auto_replace_on_failure</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_replace_on_failure">]
        member _.AutoReplaceOnFailure(state: DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName> =
            state.assignments.Add(fun config -> config.AutoReplaceOnFailure <- value)
            state : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#id-1">DedicatedHost#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>, value: string) : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#license_type-1">DedicatedHost#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>, value: string) : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#tags-1">DedicatedHost#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>, value: seq<string * string>) : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dedicated_host#timeouts-1">DedicatedHost#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>, value: azurerm.DedicatedHost.DedicatedHostTimeouts) : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DedicatedHostState<'DedicatedHostGroupId, 'Location, 'Name, 'PlatformFaultDomain, 'SkuName>

        member _.Run(state: DedicatedHostState<Present, Present, Present, Present, Present>) : azurerm.DedicatedHost.DedicatedHost =
            let config = azurerm.DedicatedHost.DedicatedHostConfig()
            for setter in state.assignments do
                setter config
            azurerm.DedicatedHost.DedicatedHost(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dedicatedHost: missing required arguments. Must call: dedicated_host_group_id, location, name, platform_fault_domain, sku_name.", 9999, IsError = true)>]
        member _.Run(_: DedicatedHostState<_, _, _, _, _>) : azurerm.DedicatedHost.DedicatedHost =
            Unchecked.defaultof<azurerm.DedicatedHost.DedicatedHost>
