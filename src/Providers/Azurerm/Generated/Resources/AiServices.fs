namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.AiServices.AiServicesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services">azurerm_ai_services</a>.
    /// </summary>
    type AiServicesBuilder(logicalId: string) =
        member _.Yield(_: unit) : AiServicesState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AiServicesState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AiServicesState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AiServicesState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#location-1">AiServices#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AiServicesState<Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : AiServicesState<Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AiServicesState<Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#name-1">AiServices#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AiServicesState<'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : AiServicesState<'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AiServicesState<'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#resource_group_name-1">AiServices#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AiServicesState<'Location, 'Name, Missing, 'SkuName>, value: string) : AiServicesState<'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AiServicesState<'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#sku_name-1">AiServices#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : AiServicesState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : AiServicesState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// customer_managed_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#customer_managed_key-1">AiServices#customer_managed_key</a>
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.AiServices.AiServicesCustomerManagedKey) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#custom_subdomain_name-1">AiServices#custom_subdomain_name</a>.
        /// </summary>
        [<CustomOperation "custom_subdomain_name">]
        member _.CustomSubdomainName(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.CustomSubdomainName <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#fqdns-1">AiServices#fqdns</a>.
        /// </summary>
        [<CustomOperation "fqdns">]
        member _.Fqdns(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string>) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Fqdns <- (value |> Seq.toArray))
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#id-1">AiServices#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#identity-1">AiServices#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.AiServices.AiServicesIdentity) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#local_authentication_enabled-1">AiServices#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#local_authentication_enabled-1">AiServices#local_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_enabled">]
        member _.LocalAuthenticationEnabled(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationEnabled <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// network_acls block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#network_acls-1">AiServices#network_acls</a>
        /// </summary>
        [<CustomOperation "network_acls">]
        member _.NetworkAcls(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.AiServices.AiServicesNetworkAcls) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.NetworkAcls <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#outbound_network_access_restricted-1">AiServices#outbound_network_access_restricted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "outbound_network_access_restricted">]
        member _.OutboundNetworkAccessRestricted(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.OutboundNetworkAccessRestricted <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#outbound_network_access_restricted-1">AiServices#outbound_network_access_restricted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "outbound_network_access_restricted">]
        member _.OutboundNetworkAccessRestricted(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.OutboundNetworkAccessRestricted <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#public_network_access-1">AiServices#public_network_access</a>.
        /// </summary>
        [<CustomOperation "public_network_access">]
        member _.PublicNetworkAccess(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccess <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// storage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#storage-1">AiServices#storage</a> Accepts: azurerm.IResolvable | azurerm.AiServices.AiServicesStorage[]
        /// </summary>
        [<CustomOperation "storage">]
        member _.Storage(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Storage <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#tags-1">AiServices#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ai_services#timeouts-1">AiServices#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.AiServices.AiServicesTimeouts) : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AiServicesState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: AiServicesState<Present, Present, Present, Present>) : azurerm.AiServices.AiServices =
            let config = azurerm.AiServices.AiServicesConfig()
            for setter in state.assignments do
                setter config
            azurerm.AiServices.AiServices(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.aiServices: missing required arguments. Must call: location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: AiServicesState<_, _, _, _>) : azurerm.AiServices.AiServices =
            Unchecked.defaultof<azurerm.AiServices.AiServices>
