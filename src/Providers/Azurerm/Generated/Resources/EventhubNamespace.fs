namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.EventhubNamespace.EventhubNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace">azurerm_eventhub_namespace</a>.
    /// </summary>
    type EventhubNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventhubNamespaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubNamespaceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EventhubNamespaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubNamespaceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#location-1">EventhubNamespace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: EventhubNamespaceState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : EventhubNamespaceState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : EventhubNamespaceState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#name-1">EventhubNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventhubNamespaceState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : EventhubNamespaceState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventhubNamespaceState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#resource_group_name-1">EventhubNamespace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventhubNamespaceState<'Location, 'Name, Missing, 'Sku>, value: string) : EventhubNamespaceState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventhubNamespaceState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#sku-1">EventhubNamespace#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#auto_inflate_enabled-1">EventhubNamespace#auto_inflate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_inflate_enabled">]
        member _.AutoInflateEnabled(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutoInflateEnabled <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#auto_inflate_enabled-1">EventhubNamespace#auto_inflate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_inflate_enabled">]
        member _.AutoInflateEnabled(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutoInflateEnabled <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#capacity-1">EventhubNamespace#capacity</a>.
        /// </summary>
        [<CustomOperation "capacity">]
        member _.Capacity(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Capacity <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#dedicated_cluster_id-1">EventhubNamespace#dedicated_cluster_id</a>.
        /// </summary>
        [<CustomOperation "dedicated_cluster_id">]
        member _.DedicatedClusterId(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DedicatedClusterId <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#id-1">EventhubNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#identity-1">EventhubNamespace#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.EventhubNamespace.EventhubNamespaceIdentity) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#local_authentication_enabled-1">EventhubNamespace#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#local_authentication_enabled-1">EventhubNamespace#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#maximum_throughput_units-1">EventhubNamespace#maximum_throughput_units</a>.
        /// </summary>
        [<CustomOperation "maximum_throughput_units">]
        member _.MaximumThroughputUnits(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MaximumThroughputUnits <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#minimum_tls_version-1">EventhubNamespace#minimum_tls_version</a>.
        /// </summary>
        [<CustomOperation "minimum_tls_version">]
        member _.MinimumTlsVersion(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MinimumTlsVersion <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#network_rulesets-1">EventhubNamespace#network_rulesets</a>. Accepts: azurerm.IResolvable | azurerm.EventhubNamespace.EventhubNamespaceNetworkRulesets[]
        /// </summary>
        [<CustomOperation "network_rulesets">]
        member _.NetworkRulesets(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.NetworkRulesets <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#public_network_access_enabled-1">EventhubNamespace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#public_network_access_enabled-1">EventhubNamespace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#tags-1">EventhubNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace#timeouts-1">EventhubNamespace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.EventhubNamespace.EventhubNamespaceTimeouts) : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventhubNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: EventhubNamespaceState<Present, Present, Present, Present>) : azurerm.EventhubNamespace.EventhubNamespace =
            let config = azurerm.EventhubNamespace.EventhubNamespaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventhubNamespace.EventhubNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventhubNamespace: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: EventhubNamespaceState<_, _, _, _>) : azurerm.EventhubNamespace.EventhubNamespace =
            Unchecked.defaultof<azurerm.EventhubNamespace.EventhubNamespace>
