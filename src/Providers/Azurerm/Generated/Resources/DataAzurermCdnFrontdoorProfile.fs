namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCdnFrontdoorProfileState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_profile">azurerm_cdn_frontdoor_profile</a>.
    /// </summary>
    type DataAzurermCdnFrontdoorProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCdnFrontdoorProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorProfileState<Missing, Missing>)

        member _.Zero(()) : DataAzurermCdnFrontdoorProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnFrontdoorProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_profile#name-1">DataAzurermCdnFrontdoorProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCdnFrontdoorProfileState<Missing, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorProfileState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorProfileState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_profile#resource_group_name-1">DataAzurermCdnFrontdoorProfile#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCdnFrontdoorProfileState<'Name, Missing>, value: string) : DataAzurermCdnFrontdoorProfileState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnFrontdoorProfileState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_profile#id-1">DataAzurermCdnFrontdoorProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCdnFrontdoorProfileState<'Name, 'ResourceGroupName>, value: string) : DataAzurermCdnFrontdoorProfileState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCdnFrontdoorProfileState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_profile#timeouts-1">DataAzurermCdnFrontdoorProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCdnFrontdoorProfileState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileTimeouts) : DataAzurermCdnFrontdoorProfileState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCdnFrontdoorProfileState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermCdnFrontdoorProfileState<Present, Present>) : azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfile =
            let config = azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfileConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCdnFrontdoorProfile: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCdnFrontdoorProfileState<_, _>) : azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfile =
            Unchecked.defaultof<azurerm.DataAzurermCdnFrontdoorProfile.DataAzurermCdnFrontdoorProfile>
