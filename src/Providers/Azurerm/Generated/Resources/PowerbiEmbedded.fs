namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.PowerbiEmbedded.PowerbiEmbeddedConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/powerbi_embedded">azurerm_powerbi_embedded</a>.
    /// </summary>
    type PowerbiEmbeddedBuilder(logicalId: string) =
        member _.Yield(_: unit) : PowerbiEmbeddedState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PowerbiEmbeddedState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : PowerbiEmbeddedState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PowerbiEmbeddedState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/powerbi_embedded#administrators-1">PowerbiEmbedded#administrators</a>.
        /// </summary>
        [<CustomOperation "administrators">]
        member _.Administrators(state: PowerbiEmbeddedState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string>) : PowerbiEmbeddedState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Administrators <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : PowerbiEmbeddedState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/powerbi_embedded#location-1">PowerbiEmbedded#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: PowerbiEmbeddedState<'Administrators, Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : PowerbiEmbeddedState<'Administrators, Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : PowerbiEmbeddedState<'Administrators, Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/powerbi_embedded#name-1">PowerbiEmbedded#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: PowerbiEmbeddedState<'Administrators, 'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : PowerbiEmbeddedState<'Administrators, 'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : PowerbiEmbeddedState<'Administrators, 'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/powerbi_embedded#resource_group_name-1">PowerbiEmbedded#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: PowerbiEmbeddedState<'Administrators, 'Location, 'Name, Missing, 'SkuName>, value: string) : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/powerbi_embedded#sku_name-1">PowerbiEmbedded#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/powerbi_embedded#id-1">PowerbiEmbedded#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/powerbi_embedded#mode-1">PowerbiEmbedded#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Mode <- value)
            state : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/powerbi_embedded#tags-1">PowerbiEmbedded#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/powerbi_embedded#timeouts-1">PowerbiEmbedded#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.PowerbiEmbedded.PowerbiEmbeddedTimeouts) : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PowerbiEmbeddedState<'Administrators, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: PowerbiEmbeddedState<Present, Present, Present, Present, Present>) : azurerm.PowerbiEmbedded.PowerbiEmbedded =
            let config = azurerm.PowerbiEmbedded.PowerbiEmbeddedConfig()
            for setter in state.assignments do
                setter config
            azurerm.PowerbiEmbedded.PowerbiEmbedded(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.powerbiEmbedded: missing required arguments. Must call: administrators, location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: PowerbiEmbeddedState<_, _, _, _, _>) : azurerm.PowerbiEmbedded.PowerbiEmbedded =
            Unchecked.defaultof<azurerm.PowerbiEmbedded.PowerbiEmbedded>
