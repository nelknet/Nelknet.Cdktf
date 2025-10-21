namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.Iothub.IothubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub">azurerm_iothub</a>.
    /// </summary>
    type IothubBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IothubState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#location-1">Iothub#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: IothubState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : IothubState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : IothubState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#name-1">Iothub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : IothubState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#resource_group_name-1">Iothub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubState<'Location, 'Name, Missing, 'Sku>, value: string) : IothubState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#sku-1">Iothub#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: IothubState<'Location, 'Name, 'ResourceGroupName, Missing>, value: azurerm.Iothub.IothubSku) : IothubState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : IothubState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// cloud_to_device block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#cloud_to_device-1">Iothub#cloud_to_device</a>
        /// </summary>
        [<CustomOperation "cloud_to_device">]
        member _.CloudToDevice(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.Iothub.IothubCloudToDevice) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CloudToDevice <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#endpoint-1">Iothub#endpoint</a>. Accepts: azurerm.IResolvable | azurerm.Iothub.IothubEndpoint[]
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#enrichment-1">Iothub#enrichment</a>. Accepts: azurerm.IResolvable | azurerm.Iothub.IothubEnrichment[]
        /// </summary>
        [<CustomOperation "enrichment">]
        member _.Enrichment(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Enrichment <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#event_hub_partition_count-1">Iothub#event_hub_partition_count</a>.
        /// </summary>
        [<CustomOperation "event_hub_partition_count">]
        member _.EventHubPartitionCount(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EventHubPartitionCount <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#event_hub_retention_in_days-1">Iothub#event_hub_retention_in_days</a>.
        /// </summary>
        [<CustomOperation "event_hub_retention_in_days">]
        member _.EventHubRetentionInDays(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.EventHubRetentionInDays <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// fallback_route block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#fallback_route-1">Iothub#fallback_route</a>
        /// </summary>
        [<CustomOperation "fallback_route">]
        member _.FallbackRoute(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.Iothub.IothubFallbackRoute) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FallbackRoute <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// file_upload block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#file_upload-1">Iothub#file_upload</a>
        /// </summary>
        [<CustomOperation "file_upload">]
        member _.FileUpload(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.Iothub.IothubFileUpload) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FileUpload <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#id-1">Iothub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#identity-1">Iothub#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.Iothub.IothubIdentity) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#local_authentication_enabled-1">Iothub#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#local_authentication_enabled-1">Iothub#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#min_tls_version-1">Iothub#min_tls_version</a>.
        /// </summary>
        [<CustomOperation "min_tls_version">]
        member _.MinTlsVersion(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MinTlsVersion <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// network_rule_set block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#network_rule_set-1">Iothub#network_rule_set</a> Accepts: azurerm.IResolvable | azurerm.Iothub.IothubNetworkRuleSet[]
        /// </summary>
        [<CustomOperation "network_rule_set">]
        member _.NetworkRuleSet(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.NetworkRuleSet <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#public_network_access_enabled-1">Iothub#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#public_network_access_enabled-1">Iothub#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#route-1">Iothub#route</a>. Accepts: azurerm.IResolvable | azurerm.Iothub.IothubRoute[]
        /// </summary>
        [<CustomOperation "route">]
        member _.Route(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Route <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#tags-1">Iothub#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#timeouts-1">Iothub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.Iothub.IothubTimeouts) : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: IothubState<Present, Present, Present, Present>) : azurerm.Iothub.Iothub =
            let config = azurerm.Iothub.IothubConfig()
            for setter in state.assignments do
                setter config
            azurerm.Iothub.Iothub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothub: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: IothubState<_, _, _, _>) : azurerm.Iothub.Iothub =
            Unchecked.defaultof<azurerm.Iothub.Iothub>
