namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermCdnProfileState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermCdnProfile.DataAzurermCdnProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_profile">azurerm_cdn_profile</a>.
    /// </summary>
    type DataAzurermCdnProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermCdnProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnProfileState<Missing, Missing>)

        member _.Zero(()) : DataAzurermCdnProfileState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermCdnProfileState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_profile#name-1">DataAzurermCdnProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermCdnProfileState<Missing, 'ResourceGroupName>, value: string) : DataAzurermCdnProfileState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermCdnProfileState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_profile#resource_group_name-1">DataAzurermCdnProfile#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermCdnProfileState<'Name, Missing>, value: string) : DataAzurermCdnProfileState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermCdnProfileState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_profile#id-1">DataAzurermCdnProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermCdnProfileState<'Name, 'ResourceGroupName>, value: string) : DataAzurermCdnProfileState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermCdnProfileState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_profile#timeouts-1">DataAzurermCdnProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermCdnProfileState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermCdnProfile.DataAzurermCdnProfileTimeouts) : DataAzurermCdnProfileState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermCdnProfileState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermCdnProfileState<Present, Present>) : azurerm.DataAzurermCdnProfile.DataAzurermCdnProfile =
            let config = azurerm.DataAzurermCdnProfile.DataAzurermCdnProfileConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermCdnProfile.DataAzurermCdnProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermCdnProfile: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermCdnProfileState<_, _>) : azurerm.DataAzurermCdnProfile.DataAzurermCdnProfile =
            Unchecked.defaultof<azurerm.DataAzurermCdnProfile.DataAzurermCdnProfile>
