namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CdnProfileState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.CdnProfile.CdnProfileConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_profile">azurerm_cdn_profile</a>.
    /// </summary>
    type CdnProfileBuilder(logicalId: string) =
        member _.Yield(_: unit) : CdnProfileState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnProfileState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CdnProfileState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CdnProfileState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_profile#location-1">CdnProfile#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: CdnProfileState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : CdnProfileState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : CdnProfileState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_profile#name-1">CdnProfile#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CdnProfileState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : CdnProfileState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CdnProfileState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_profile#resource_group_name-1">CdnProfile#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CdnProfileState<'Location, 'Name, Missing, 'Sku>, value: string) : CdnProfileState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CdnProfileState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_profile#sku-1">CdnProfile#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: CdnProfileState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : CdnProfileState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : CdnProfileState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_profile#id-1">CdnProfile#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CdnProfileState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : CdnProfileState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CdnProfileState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_profile#tags-1">CdnProfile#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CdnProfileState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : CdnProfileState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CdnProfileState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_profile#timeouts-1">CdnProfile#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CdnProfileState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.CdnProfile.CdnProfileTimeouts) : CdnProfileState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CdnProfileState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: CdnProfileState<Present, Present, Present, Present>) : azurerm.CdnProfile.CdnProfile =
            let config = azurerm.CdnProfile.CdnProfileConfig()
            for setter in state.assignments do
                setter config
            azurerm.CdnProfile.CdnProfile(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cdnProfile: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: CdnProfileState<_, _, _, _>) : azurerm.CdnProfile.CdnProfile =
            Unchecked.defaultof<azurerm.CdnProfile.CdnProfile>
