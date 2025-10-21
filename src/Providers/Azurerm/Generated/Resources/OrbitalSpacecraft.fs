namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements> = { assignments: ResizeArray<azurerm.OrbitalSpacecraft.OrbitalSpacecraftConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft">azurerm_orbital_spacecraft</a>.
    /// </summary>
    type OrbitalSpacecraftBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrbitalSpacecraftState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OrbitalSpacecraftState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : OrbitalSpacecraftState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OrbitalSpacecraftState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// links block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#links-1">OrbitalSpacecraft#links</a> Accepts: azurerm.IResolvable | azurerm.OrbitalSpacecraft.OrbitalSpacecraftLinks[]
        /// </summary>
        [<CustomOperation "links">]
        member _.Links(state: OrbitalSpacecraftState<Missing, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>, value: HashiCorp.Cdktf.IResolvable) : OrbitalSpacecraftState<Present, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements> =
            state.assignments.Add(fun config -> config.Links <- value)
            ({ assignments = state.assignments } : OrbitalSpacecraftState<Present, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#location-1">OrbitalSpacecraft#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: OrbitalSpacecraftState<'Links, Missing, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>, value: string) : OrbitalSpacecraftState<'Links, Present, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : OrbitalSpacecraftState<'Links, Present, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#name-1">OrbitalSpacecraft#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OrbitalSpacecraftState<'Links, 'Location, Missing, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>, value: string) : OrbitalSpacecraftState<'Links, 'Location, Present, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OrbitalSpacecraftState<'Links, 'Location, Present, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#norad_id-1">OrbitalSpacecraft#norad_id</a>.
        /// </summary>
        [<CustomOperation "norad_id">]
        member _.NoradId(state: OrbitalSpacecraftState<'Links, 'Location, 'Name, Missing, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>, value: string) : OrbitalSpacecraftState<'Links, 'Location, 'Name, Present, 'ResourceGroupName, 'TitleLine, 'TwoLineElements> =
            state.assignments.Add(fun config -> config.NoradId <- value)
            ({ assignments = state.assignments } : OrbitalSpacecraftState<'Links, 'Location, 'Name, Present, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#resource_group_name-1">OrbitalSpacecraft#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, Missing, 'TitleLine, 'TwoLineElements>, value: string) : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, Present, 'TitleLine, 'TwoLineElements> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, Present, 'TitleLine, 'TwoLineElements>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#title_line-1">OrbitalSpacecraft#title_line</a>.
        /// </summary>
        [<CustomOperation "title_line">]
        member _.TitleLine(state: OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, Missing, 'TwoLineElements>, value: string) : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, Present, 'TwoLineElements> =
            state.assignments.Add(fun config -> config.TitleLine <- value)
            ({ assignments = state.assignments } : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, Present, 'TwoLineElements>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#two_line_elements-1">OrbitalSpacecraft#two_line_elements</a>.
        /// </summary>
        [<CustomOperation "two_line_elements">]
        member _.TwoLineElements(state: OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, Missing>, value: seq<string>) : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, Present> =
            state.assignments.Add(fun config -> config.TwoLineElements <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#id-1">OrbitalSpacecraft#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>, value: string) : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#tags-1">OrbitalSpacecraft#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>, value: seq<string * string>) : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#timeouts-1">OrbitalSpacecraft#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>, value: azurerm.OrbitalSpacecraft.OrbitalSpacecraftTimeouts) : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OrbitalSpacecraftState<'Links, 'Location, 'Name, 'NoradId, 'ResourceGroupName, 'TitleLine, 'TwoLineElements>

        member _.Run(state: OrbitalSpacecraftState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.OrbitalSpacecraft.OrbitalSpacecraft =
            let config = azurerm.OrbitalSpacecraft.OrbitalSpacecraftConfig()
            for setter in state.assignments do
                setter config
            azurerm.OrbitalSpacecraft.OrbitalSpacecraft(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.orbitalSpacecraft: missing required arguments. Must call: links, location, name, norad_id, resource_group_name, title_line, two_line_elements.", 9999, IsError = true)>]
        member _.Run(_: OrbitalSpacecraftState<_, _, _, _, _, _, _>) : azurerm.OrbitalSpacecraft.OrbitalSpacecraft =
            Unchecked.defaultof<azurerm.OrbitalSpacecraft.OrbitalSpacecraft>
