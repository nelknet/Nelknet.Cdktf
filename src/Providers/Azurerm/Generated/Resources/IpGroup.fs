namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IpGroupState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IpGroup.IpGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group">azurerm_ip_group</a>.
    /// </summary>
    type IpGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : IpGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IpGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : IpGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IpGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group#location-1">IpGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: IpGroupState<Missing, 'Name, 'ResourceGroupName>, value: string) : IpGroupState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : IpGroupState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group#name-1">IpGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IpGroupState<'Location, Missing, 'ResourceGroupName>, value: string) : IpGroupState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IpGroupState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group#resource_group_name-1">IpGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IpGroupState<'Location, 'Name, Missing>, value: string) : IpGroupState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IpGroupState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group#cidrs-1">IpGroup#cidrs</a>.
        /// </summary>
        [<CustomOperation "cidrs">]
        member _.Cidrs(state: IpGroupState<'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : IpGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Cidrs <- (value |> Seq.toArray))
            state : IpGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group#id-1">IpGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IpGroupState<'Location, 'Name, 'ResourceGroupName>, value: string) : IpGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IpGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group#tags-1">IpGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IpGroupState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : IpGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IpGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/ip_group#timeouts-1">IpGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IpGroupState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.IpGroup.IpGroupTimeouts) : IpGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IpGroupState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: IpGroupState<Present, Present, Present>) : azurerm.IpGroup.IpGroup =
            let config = azurerm.IpGroup.IpGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.IpGroup.IpGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.ipGroup: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IpGroupState<_, _, _>) : azurerm.IpGroup.IpGroup =
            Unchecked.defaultof<azurerm.IpGroup.IpGroup>
