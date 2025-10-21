namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.ContainerRegistry.ContainerRegistryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry">azurerm_container_registry</a>.
    /// </summary>
    type ContainerRegistryBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerRegistryState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerRegistryState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#location-1">ContainerRegistry#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ContainerRegistryState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ContainerRegistryState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ContainerRegistryState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#name-1">ContainerRegistry#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerRegistryState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : ContainerRegistryState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerRegistryState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#resource_group_name-1">ContainerRegistry#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ContainerRegistryState<'Location, 'Name, Missing, 'Sku>, value: string) : ContainerRegistryState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ContainerRegistryState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#sku-1">ContainerRegistry#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#admin_enabled-1">ContainerRegistry#admin_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "admin_enabled">]
        member _.AdminEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdminEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#admin_enabled-1">ContainerRegistry#admin_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "admin_enabled">]
        member _.AdminEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AdminEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#anonymous_pull_enabled-1">ContainerRegistry#anonymous_pull_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "anonymous_pull_enabled">]
        member _.AnonymousPullEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AnonymousPullEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#anonymous_pull_enabled-1">ContainerRegistry#anonymous_pull_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "anonymous_pull_enabled">]
        member _.AnonymousPullEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AnonymousPullEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#data_endpoint_enabled-1">ContainerRegistry#data_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "data_endpoint_enabled">]
        member _.DataEndpointEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DataEndpointEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#data_endpoint_enabled-1">ContainerRegistry#data_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "data_endpoint_enabled">]
        member _.DataEndpointEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DataEndpointEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#encryption-1">ContainerRegistry#encryption</a>. Accepts: azurerm.IResolvable | azurerm.ContainerRegistry.ContainerRegistryEncryption[]
        /// </summary>
        [<CustomOperation "encryption">]
        member _.Encryption(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Encryption <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#export_policy_enabled-1">ContainerRegistry#export_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "export_policy_enabled">]
        member _.ExportPolicyEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ExportPolicyEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#export_policy_enabled-1">ContainerRegistry#export_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "export_policy_enabled">]
        member _.ExportPolicyEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ExportPolicyEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// georeplications block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#georeplications-1">ContainerRegistry#georeplications</a> Accepts: azurerm.IResolvable | azurerm.ContainerRegistry.ContainerRegistryGeoreplications[]
        /// </summary>
        [<CustomOperation "georeplications">]
        member _.Georeplications(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Georeplications <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#id-1">ContainerRegistry#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#identity-1">ContainerRegistry#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ContainerRegistry.ContainerRegistryIdentity) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#network_rule_bypass_option-1">ContainerRegistry#network_rule_bypass_option</a>.
        /// </summary>
        [<CustomOperation "network_rule_bypass_option">]
        member _.NetworkRuleBypassOption(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.NetworkRuleBypassOption <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#network_rule_set-1">ContainerRegistry#network_rule_set</a>. Accepts: azurerm.IResolvable | azurerm.ContainerRegistry.ContainerRegistryNetworkRuleSet[]
        /// </summary>
        [<CustomOperation "network_rule_set">]
        member _.NetworkRuleSet(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.NetworkRuleSet <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#public_network_access_enabled-1">ContainerRegistry#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#public_network_access_enabled-1">ContainerRegistry#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#quarantine_policy_enabled-1">ContainerRegistry#quarantine_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "quarantine_policy_enabled">]
        member _.QuarantinePolicyEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.QuarantinePolicyEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#quarantine_policy_enabled-1">ContainerRegistry#quarantine_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "quarantine_policy_enabled">]
        member _.QuarantinePolicyEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.QuarantinePolicyEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#retention_policy_in_days-1">ContainerRegistry#retention_policy_in_days</a>.
        /// </summary>
        [<CustomOperation "retention_policy_in_days">]
        member _.RetentionPolicyInDays(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.RetentionPolicyInDays <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#tags-1">ContainerRegistry#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#timeouts-1">ContainerRegistry#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.ContainerRegistry.ContainerRegistryTimeouts) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#trust_policy_enabled-1">ContainerRegistry#trust_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "trust_policy_enabled">]
        member _.TrustPolicyEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TrustPolicyEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#trust_policy_enabled-1">ContainerRegistry#trust_policy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "trust_policy_enabled">]
        member _.TrustPolicyEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TrustPolicyEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#zone_redundancy_enabled-1">ContainerRegistry#zone_redundancy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundancy_enabled">]
        member _.ZoneRedundancyEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ZoneRedundancyEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry#zone_redundancy_enabled-1">ContainerRegistry#zone_redundancy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundancy_enabled">]
        member _.ZoneRedundancyEnabled(state: ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ZoneRedundancyEnabled <- value)
            state : ContainerRegistryState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: ContainerRegistryState<Present, Present, Present, Present>) : azurerm.ContainerRegistry.ContainerRegistry =
            let config = azurerm.ContainerRegistry.ContainerRegistryConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerRegistry.ContainerRegistry(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerRegistry: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: ContainerRegistryState<_, _, _, _>) : azurerm.ContainerRegistry.ContainerRegistry =
            Unchecked.defaultof<azurerm.ContainerRegistry.ContainerRegistry>
