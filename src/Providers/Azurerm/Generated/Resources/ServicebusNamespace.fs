namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.ServicebusNamespace.ServicebusNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace">azurerm_servicebus_namespace</a>.
    /// </summary>
    type ServicebusNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicebusNamespaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusNamespaceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ServicebusNamespaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusNamespaceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#location-1">ServicebusNamespace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ServicebusNamespaceState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ServicebusNamespaceState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ServicebusNamespaceState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#name-1">ServicebusNamespace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicebusNamespaceState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : ServicebusNamespaceState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicebusNamespaceState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#resource_group_name-1">ServicebusNamespace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ServicebusNamespaceState<'Location, 'Name, Missing, 'Sku>, value: string) : ServicebusNamespaceState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ServicebusNamespaceState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#sku-1">ServicebusNamespace#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#capacity-1">ServicebusNamespace#capacity</a>.
        /// </summary>
        [<CustomOperation "capacity">]
        member _.Capacity(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Capacity <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// customer_managed_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#customer_managed_key-1">ServicebusNamespace#customer_managed_key</a>
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ServicebusNamespace.ServicebusNamespaceCustomerManagedKey) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#id-1">ServicebusNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#identity-1">ServicebusNamespace#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ServicebusNamespace.ServicebusNamespaceIdentity) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#local_auth_enabled-1">ServicebusNamespace#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#local_auth_enabled-1">ServicebusNamespace#local_auth_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_auth_enabled">]
        member _.LocalAuthEnabled(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthEnabled <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#minimum_tls_version-1">ServicebusNamespace#minimum_tls_version</a>.
        /// </summary>
        [<CustomOperation "minimum_tls_version">]
        member _.MinimumTlsVersion(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MinimumTlsVersion <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// network_rule_set block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#network_rule_set-1">ServicebusNamespace#network_rule_set</a>
        /// </summary>
        [<CustomOperation "network_rule_set">]
        member _.NetworkRuleSet(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ServicebusNamespace.ServicebusNamespaceNetworkRuleSet) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.NetworkRuleSet <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#premium_messaging_partitions-1">ServicebusNamespace#premium_messaging_partitions</a>.
        /// </summary>
        [<CustomOperation "premium_messaging_partitions">]
        member _.PremiumMessagingPartitions(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PremiumMessagingPartitions <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#public_network_access_enabled-1">ServicebusNamespace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#public_network_access_enabled-1">ServicebusNamespace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#tags-1">ServicebusNamespace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace#timeouts-1">ServicebusNamespace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ServicebusNamespace.ServicebusNamespaceTimeouts) : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicebusNamespaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: ServicebusNamespaceState<Present, Present, Present, Present>) : azurerm.ServicebusNamespace.ServicebusNamespace =
            let config = azurerm.ServicebusNamespace.ServicebusNamespaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServicebusNamespace.ServicebusNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.servicebusNamespace: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: ServicebusNamespaceState<_, _, _, _>) : azurerm.ServicebusNamespace.ServicebusNamespace =
            Unchecked.defaultof<azurerm.ServicebusNamespace.ServicebusNamespace>
