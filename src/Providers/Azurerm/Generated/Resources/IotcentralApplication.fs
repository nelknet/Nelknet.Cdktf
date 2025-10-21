namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain> = { assignments: ResizeArray<azurerm.IotcentralApplication.IotcentralApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application">azurerm_iotcentral_application</a>.
    /// </summary>
    type IotcentralApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : IotcentralApplicationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotcentralApplicationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IotcentralApplicationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IotcentralApplicationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#location-1">IotcentralApplication#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: IotcentralApplicationState<Missing, 'Name, 'ResourceGroupName, 'SubDomain>, value: string) : IotcentralApplicationState<Present, 'Name, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : IotcentralApplicationState<Present, 'Name, 'ResourceGroupName, 'SubDomain>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#name-1">IotcentralApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IotcentralApplicationState<'Location, Missing, 'ResourceGroupName, 'SubDomain>, value: string) : IotcentralApplicationState<'Location, Present, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IotcentralApplicationState<'Location, Present, 'ResourceGroupName, 'SubDomain>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#resource_group_name-1">IotcentralApplication#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IotcentralApplicationState<'Location, 'Name, Missing, 'SubDomain>, value: string) : IotcentralApplicationState<'Location, 'Name, Present, 'SubDomain> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IotcentralApplicationState<'Location, 'Name, Present, 'SubDomain>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#sub_domain-1">IotcentralApplication#sub_domain</a>.
        /// </summary>
        [<CustomOperation "sub_domain">]
        member _.SubDomain(state: IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SubDomain <- value)
            ({ assignments = state.assignments } : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#display_name-1">IotcentralApplication#display_name</a>.
        /// </summary>
        [<CustomOperation "display_name">]
        member _.DisplayName(state: IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>, value: string) : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.DisplayName <- value)
            state : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#id-1">IotcentralApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>, value: string) : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#identity-1">IotcentralApplication#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>, value: azurerm.IotcentralApplication.IotcentralApplicationIdentity) : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#public_network_access_enabled-1">IotcentralApplication#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>, value: bool) : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#public_network_access_enabled-1">IotcentralApplication#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>, value: HashiCorp.Cdktf.IResolvable) : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#sku-1">IotcentralApplication#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>, value: string) : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.Sku <- value)
            state : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#tags-1">IotcentralApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>, value: seq<string * string>) : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#template-1">IotcentralApplication#template</a>.
        /// </summary>
        [<CustomOperation "template">]
        member _.Template(state: IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>, value: string) : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.Template <- value)
            state : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iotcentral_application#timeouts-1">IotcentralApplication#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>, value: azurerm.IotcentralApplication.IotcentralApplicationTimeouts) : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IotcentralApplicationState<'Location, 'Name, 'ResourceGroupName, 'SubDomain>

        member _.Run(state: IotcentralApplicationState<Present, Present, Present, Present>) : azurerm.IotcentralApplication.IotcentralApplication =
            let config = azurerm.IotcentralApplication.IotcentralApplicationConfig()
            for setter in state.assignments do
                setter config
            azurerm.IotcentralApplication.IotcentralApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iotcentralApplication: missing required arguments. Must call: location, name, resource_group_name, sub_domain.", 9999, IsError = true)>]
        member _.Run(_: IotcentralApplicationState<_, _, _, _>) : azurerm.IotcentralApplication.IotcentralApplication =
            Unchecked.defaultof<azurerm.IotcentralApplication.IotcentralApplication>
